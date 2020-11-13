using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        public static FrmInventory instance = null;
        private Player player;
        public List<Item> inventory = new List<Item>();
        private Item selected;

        public FrmInventory()
        {
            InitializeComponent();
            player = Game.player;
        }

        private void FrmInventory_Deactivate(object sender, EventArgs e)
        {
            instance.Hide();
        }

        public void ShowCommands()
        {
            UpdateHealthBar();
            UpdateItemPictures();
            instance.Show();
        }

        private void UpdateHealthBar()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
        }

        private void UpdateItemPictures()
        {
            if (inventory.Count > 0)
                picItem1.Image = inventory[0].image;
            else
                picItem1.Image = null;

            if (inventory.Count > 1)
                picItem2.Image = inventory[1].image;
            else
                picItem2.Image = null;

            if (inventory.Count > 2)
                picItem3.Image = inventory[2].image;
            else
                picItem3.Image = null;

            if (inventory.Count > 3)
                picItem4.Image = inventory[3].image;
            else
                picItem4.Image = null;

            if (inventory.Count > 4)
                picItem5.Image = inventory[4].image;
            else
                picItem5.Image = null;

            if (inventory.Count > 5)
                picItem6.Image = inventory[5].image;
            else
                picItem6.Image = null;

            if (inventory.Count > 6)
                picItem7.Image = inventory[6].image;
            else
                picItem7.Image = null;

            if (inventory.Count > 7)
                picItem8.Image = inventory[7].image;
            else
                picItem8.Image = null;

            if (inventory.Count > 8)
                picItem9.Image = inventory[8].image;
            else
                picItem9.Image = null;
        }

        public static FrmInventory GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmInventory();
            }
            return instance;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            instance.Hide();
        }

        private void picItem1_Click(object sender, EventArgs e)
        {
            EnableCommands(0);
        }

        private void picItem2_Click(object sender, EventArgs e)
        {
            EnableCommands(1);
        }

        private void picItem3_Click(object sender, EventArgs e)
        {
            EnableCommands(2);
        }

        private void picItem4_Click(object sender, EventArgs e)
        {
            EnableCommands(3);
        }

        private void picItem5_Click(object sender, EventArgs e)
        {
            EnableCommands(4);
        }

        private void picItem6_Click(object sender, EventArgs e)
        {
            EnableCommands(5);
        }

        private void picItem7_Click(object sender, EventArgs e)
        {
            EnableCommands(6);
        }

        private void picItem8_Click(object sender, EventArgs e)
        {
            EnableCommands(7);
        }

        private void picItem9_Click(object sender, EventArgs e)
        {
            EnableCommands(8);
        }

        private void EnableCommands(int index)
        {
            if (inventory.Count > index)
            {
                selected = inventory[index];
                lblPower.Text = selected.power.ToString();

                switch (selected.type)
                {
                    case 'F':
                        lblType.Text = "Health restored:";
                        break;
                    case 'W':
                        lblType.Text = "Weapon strength:";
                        break;
                    case 'A':
                        lblType.Text = "Armor defense:";
                        break;
                }

                SetButtonState(true);
            }
        }

        private void SetButtonState(bool state)
        {
            btnUse.Enabled = state;
            btnDestroy.Enabled = state;
        }

        private void DisableCommands()
        {
            selected = null;
            lblPower.Text = "";
            lblType.Text = "";
            SetButtonState(false);
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            selected.Use();
            if (selected.type == 'A')
                lblDefense.Text = selected.power.ToString();
            else if (selected.type == 'W')
                lblStrength.Text = selected.power.ToString();
            inventory.Remove(selected);
            UpdateHealthBar();
            UpdateItemPictures();
            DisableCommands();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            inventory.Remove(selected);
            UpdateHealthBar();
            UpdateItemPictures();
            DisableCommands();
        }
    }
}

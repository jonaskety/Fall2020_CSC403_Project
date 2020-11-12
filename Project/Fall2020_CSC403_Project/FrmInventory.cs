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
        private List<Item> inventory = new List<Item>();
        private Item selected;

        public FrmInventory()
        {
            InitializeComponent();
            player = Game.player;

            for (int i = 0; i < 9; i++)
                inventory.Add(null);
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            UpdateHealthBar();
        }

        private void UpdateHealthBar()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
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
            if (inventory[index] != null)
            {
                selected = inventory[index];
                lblPower.Text = selected.power.ToString();
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
            lblPower.Text = "0";
            SetButtonState(false);
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {

        }
    }
}

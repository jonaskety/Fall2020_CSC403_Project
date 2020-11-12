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

        public FrmInventory()
        {
            InitializeComponent();
            player = Game.player;
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
            instance = null;
            Close();
        }

        private void picItem1_Click(object sender, EventArgs e)
        {

        }

        private void picItem2_Click(object sender, EventArgs e)
        {

        }

        private void picItem3_Click(object sender, EventArgs e)
        {

        }

        private void picItem4_Click(object sender, EventArgs e)
        {

        }

        private void picItem5_Click(object sender, EventArgs e)
        {

        }

        private void picItem6_Click(object sender, EventArgs e)
        {

        }

        private void picItem7_Click(object sender, EventArgs e)
        {

        }

        private void picItem8_Click(object sender, EventArgs e)
        {

        }

        private void picItem9_Click(object sender, EventArgs e)
        {

        }
    }
}

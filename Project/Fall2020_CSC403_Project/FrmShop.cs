using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    /// <summary>
    /// interact with a merchant NPC
    /// use items in a merchant's inventory
    /// </summary>
    public partial class FrmShop : Form
    {
        public static FrmShop instance = null;
        private Merchant merchant;
        private Player player;
        private FrmInventory frmInventory = FrmInventory.GetInstance();
        private Item mango = new Food(Resources.food_mango, 10, 5, 'F');

        public FrmShop()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this npc
            picNPCMerchant.BackgroundImage = merchant.Img;
            picNPCMerchant.Refresh();
            BackColor = merchant.Color;
            picNPCMerchant.Visible = true;

            // load the npc message
            labelMerchant.Text = merchant.Message;

            picPlayer.BackgroundImage = player.Img;
        }

        public static FrmShop GetInstance(Merchant merchant)
        {
            if (instance == null)
            {
                instance = new FrmShop();
                instance.merchant = merchant;
                instance.Setup();
            }
            return instance;
        }

        /// <summary>
        /// update the visibility of the merchant's items
        /// based on wether or not they have been used
        /// </summary>
        public void UpdateInventory()
        {
            for (int i = 0; i < merchant.inventory.Length; i++)
            {
                string picName = "picMerchantItem" + (i + 1);
                PictureBox pic = (PictureBox)this.Controls.Find(picName, true)[0];

                if (merchant.inventory[i] != null)
                {
                    pic.BackgroundImage = merchant.inventory[i].Img;
                    pic.Visible = true;
                } else
                {
                    pic.Visible = false;
                }
            }
        }

        /// <summary>
        /// When continue button is clicked change the text to
        /// display the merchant message
        /// </summary>
        private void btnContinue_Click(object sender, EventArgs e)
        {

            labelMerchant.Text = merchant.shopMessage;
            UpdateInventory();
        }

        /// <summary>
        /// First item of the merchant's is selected
        /// </summary>
        private void picMerchantItem1_Click(object sender, EventArgs e)
        {
            if (picMerchantItem1.Visible)
            {
                if (frmInventory.inventory.Count < 9)
                {
                    merchant.RemoveFood(0);
                    frmInventory.inventory.Add(mango);
                }
                else
                    MessageBox.Show("Your inventory is full. Remove some items to pick up the mango.");
            }
            UpdateInventory();
        }

        /// <summary>
        /// Second item of the merchant's is selected
        /// </summary>
        private void picMerchantItem2_Click(object sender, EventArgs e)
        {
            if (picMerchantItem2.Visible)
            {
                if (frmInventory.inventory.Count < 9)
                {
                    merchant.RemoveFood(1);
                    frmInventory.inventory.Add(mango);
                }
                else
                    MessageBox.Show("Your inventory is full. Remove some items to pick up the mango.");
            }
            UpdateInventory();
        }

        /// <summary>
        /// Third item of the merchant's is selected
        /// </summary>
        private void picMerchantItem3_Click(object sender, EventArgs e)
        {
            if (picMerchantItem3.Visible)
            {
                if (frmInventory.inventory.Count < 9)
                {
                    merchant.RemoveFood(2);
                    frmInventory.inventory.Add(mango);
                }
                else
                    MessageBox.Show("Your inventory is full. Remove some items to pick up the mango.");
            }
            UpdateInventory();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// stop and close the interaction with leave button is selected
        /// </summary>
        private void btnLeave_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }

        private void FrmShop_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    frmInventory = FrmInventory.GetInstance();
                    frmInventory.ShowCommands();
                    break;
            }
        }

        private void FrmShop_Load(object sender, EventArgs e)
        {

        }
    }
}

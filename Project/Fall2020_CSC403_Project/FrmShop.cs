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
                player.AlterHealth(merchant.inventory[0].healthRegen);
                merchant.RemoveFood(0);
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
                player.AlterHealth(merchant.inventory[1].healthRegen);
                merchant.RemoveFood(1);
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
                player.AlterHealth(merchant.inventory[2].healthRegen);
                merchant.RemoveFood(2);
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
    }
}

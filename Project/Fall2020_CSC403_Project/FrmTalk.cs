using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    /// <summary>
    /// interaction with non-player character
    /// </summary>
    public partial class FrmTalk : Form
    {
        public static FrmTalk instance = null;
        private NPC npc;
        private Player player;
        private FrmInventory frmInventory;

        public FrmTalk()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this npc
            picNPC.BackgroundImage = npc.Img;
            picNPC.Refresh();
            BackColor = npc.Color;
            picNPC.Visible = true;

            // load the npc message
            labelNPC.Text = npc.Message;

            picPlayer.BackgroundImage = player.Img;
        }

        public static FrmTalk GetInstance(NPC npc)
        {
            if (instance == null)
            {
                instance = new FrmTalk();
                instance.npc = npc;
                instance.Setup();
            }
            return instance;
        }

        /// <summary>
        /// exits the interaction
        /// </summary>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTalk_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    frmInventory = FrmInventory.GetInstance();
                    frmInventory.ShowCommands();
                    break;
            }
        }
    }
}

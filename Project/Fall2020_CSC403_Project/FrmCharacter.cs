using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
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
    public partial class FrmCharacter : Form
    {
        public static FrmCharacter instance = null;
        private Player player;
        public FrmCharacter()
        {
            player = Game.player;
            InitializeComponent();
        }

        public static FrmCharacter GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmCharacter();
            }
            return instance;
        }

        private void picMrPeanut_Click(object sender, EventArgs e)
        {
            player.Img = picMrPeanut.BackgroundImage;
            player.TempImg = picMrPeanut.BackgroundImage;
            instance.Hide();
        }

        private void picLadyPeanut_Click(object sender, EventArgs e)
        {
            player.Img = picLadyPeanut.BackgroundImage;
            player.TempImg = picLadyPeanut.BackgroundImage;
            instance.Hide();
        }

        private void picKingPeanut_Click(object sender, EventArgs e)
        {
            player.Img = picKingPeanut.BackgroundImage;
            player.TempImg = picKingPeanut.BackgroundImage;
            instance.Hide();
        }

        private void picIRLPeanut_Click(object sender, EventArgs e)
        {
            player.Img = picIRLPeanut.BackgroundImage;
            player.TempImg = picIRLPeanut.BackgroundImage;
            instance.Hide();
        }
    }
}

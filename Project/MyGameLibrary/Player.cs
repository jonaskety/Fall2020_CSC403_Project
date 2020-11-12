using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
    public class Player : BattleCharacter {
        public int Exp;
        public int ExpNeeded;
        public int Level;
        /// <summary>
        /// This is the image for the player
        /// </summary>
        public Image Img { get; set; }

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
            Exp = 0;
            Level = 1;
            ExpNeeded = 10;
        }

        public void UpdateLevel() {
            Level += 1;
            Exp -= ExpNeeded;
            ExpNeeded = (Level * 10);
        }
    }
}

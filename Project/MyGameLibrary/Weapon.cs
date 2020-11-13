using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Weapon : Item
    {
        public Weapon(Image img, int pwr, int cst, char tpe)
        {
            image = img;
            power = pwr;
            cost = cst;
            type = tpe;
            player = Game.player;
        }

        public Image image { get; set; }
        public int power { get; set; }
        public int cost { get; set; }
        public char type { get; set; }
        public Player player { get; set; }

        public void Use()
        {
            player.AlterStrength(power);
        }
    }
}

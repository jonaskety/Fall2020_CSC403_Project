using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// Food items heal the player
    /// </summary>
    public class Food
    {
        // variables
        public Image Img { get; set; }
        public int healthRegen { get; set; }
        public int price { get; set; }

        private Player player = Game.player;

        public Food()
        {
        }

        // eat a food item and alter the player's health
        public void Consume()
        {
            player.AlterHealth(healthRegen);
        }
    }
}
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    /// <summary>
    /// Merchant is an NPC that offers the player three items
    /// </summary>
    public class Merchant : NPC
    {
        public string shopMessage { get; set; }
        public Image Img { get; set; }
        public Color Color { get; set; }

        // maximum of 3 inventory slots for merchants
        public ShopFood[] inventory = new ShopFood[3];

        public Merchant(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
        }

        /// <summary>
        /// Add a food item to the merchant's inventory
        /// </summary>
        public void AddFood(ShopFood item)
        {
            for (int i=0; i<inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = item;
                    break;
                }
            }
        }

        /// <summary>
        /// delete a food item from the merchant's inventory
        /// </summary>
        /// <param name="i"></param>
        public void RemoveFood(int i)
        {
            inventory[i] = null;
        }
    }
}
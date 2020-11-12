using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    /// <summary>
    /// THis is the image for the player
    /// </summary>
    public Image Img { get; set; }

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {

    }
  }
}

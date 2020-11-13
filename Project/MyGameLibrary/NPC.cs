using System;
using System.Drawing;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// Non-Player Characters always have a single defualt message
  /// for the player to read
  /// </summary>
  public class NPC : Character {
    public string Message { get; set; }
    public Image Img { get; set; }
    public Color Color { get; set; }

    public NPC(Vector2 initPos, Collider collider) : base(initPos, collider) {
    }
  }
}

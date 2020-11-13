using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    public PictureBox playerImage;
    private Mango mango = new Mango();

    private NPC npcMike;
    private Merchant npcMerchantSteve;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmTalk frmTalk;
    private FrmShop frmShop;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      npcMike = new NPC(CreatePosition(picNPCMike), CreateCollider(picNPCMike, PADDING));
      npcMerchantSteve = new Merchant(CreatePosition(picNPCMerchantSteve), CreateCollider(picNPCMerchantSteve, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      npcMike.Img = picNPCMike.BackgroundImage;
      npcMerchantSteve.Img = picNPCMerchantSteve.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      npcMike.Color = Color.FromArgb(0, 204, 204);
      npcMerchantSteve.Color = Color.FromArgb(255, 255, 153);

      // declare messages for the NPCs
      npcMike.Message = "Good luck finishing the Kool-aid!";
      npcMerchantSteve.Message = "Hello, how are you?";
      npcMerchantSteve.shopMessage = "Check out my stuff.";
      
      // add food to the merchant's inventory
      mango.Img = picFoodMango.BackgroundImage;
      npcMerchantSteve.AddFood(mango);
      npcMerchantSteve.AddFood(mango);
      npcMerchantSteve.AddFood(mango);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerHealth_Tick(object sender, EventArgs e)
    {
      lblHealthBar.Text = "HP: " + player.Health.ToString();
    }

    private void tmrPlayerExp_Tick(object sender, EventArgs e)
    {
      lblLevelBar.Text = "LEVEL: " + player.Level.ToString();
      lblExpBar.Text = player.Exp.ToString() + " / " + player.ExpNeeded.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // check collision with npc
      if (HitAChar(player, npcMike))
      {
          Talk(npcMike);
      }
      if (HitAChar(player, npcMerchantSteve))
      {
          Shop(npcMerchantSteve);
      }

      if (player.Health <= 0) {
                Close();
      }

      // update player's image if less than 80% health to baby peanut
      if (player.Health < 0.8 * player.MaxHealth)
      {
          player.Img = babyPeanut.BackgroundImage;
          picPlayer.BackgroundImage = player.Img;
          picPlayer.Refresh();
      } else
      {
          player.Img = picPlayerTemp.BackgroundImage;
          picPlayer.BackgroundImage = player.Img;
          picPlayer.Refresh();
      }

        // update player's picture box
        picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy)
    {
        player.ResetMoveSpeed();
        player.MoveBack();
        frmBattle = FrmBattle.GetInstance(enemy);
        frmBattle.Show();

        if (enemy == bossKoolaid)
        {
            frmBattle.SetupForBossBattle();
        }
    }

    private void Talk(NPC npc)
    {
        player.ResetMoveSpeed();
        player.MoveBack();
        frmTalk = FrmTalk.GetInstance(npc);
        frmTalk.Show();
    }

    private void Shop(Merchant merchant)
    {
        player.ResetMoveSpeed();
        player.MoveBack();
        frmShop = FrmShop.GetInstance(merchant);
        frmShop.Show();
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }
    }
}

using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private bool Boss;
    private bool ready = false;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
    }

    public void Setup() {

      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;
      Boss = false;

      // update the player
      picPlayer.BackgroundImage = player.Img;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;
      player.HealEvent += PlayerHeal;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      Boss = true;
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
      btnHeal.Visible = true;
      enemy.ChallengeMode();
      UpdateHealthBars();
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void UpdateExp() {
       player.Exp += 5;
       if (player.Exp >= player.ExpNeeded) {
            player.UpdateLevel();
            player.UpdateStats();
       }
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
                if (Boss) {
                    enemy.OnAttack(-3);
                } else {
                    enemy.OnAttack(-2);
                }
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
                if (enemy.Health <= 0) {
                    UpdateExp();
                }
        instance = null;
        Close();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void PlayerHeal(int amount) {
            player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

        private void btnHeal_Click(object sender, EventArgs e) {
            player.OnHeal(4);
            if (Boss) {
                enemy.OnAttack(-3);
            } else {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
        }
    }
}

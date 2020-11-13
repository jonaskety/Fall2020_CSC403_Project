using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private FrmInventory frmInventory;
    private List<Item> lootTable = new List<Item>();
    private bool Boss;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
      AddLootToTables();
    }

    private void AddLootToTables()
        {
            lootTable.Add(new Food(Resources.Apple, 6, 4, 'F'));
            lootTable.Add(new Food(Resources.monster, 10, 8, 'F'));
            lootTable.Add(new Food(Resources.mikeslemonade, 12, 10, 'F'));
            lootTable.Add(new Food(Resources.RawPorkchopNew, 4, 3, 'F'));
            lootTable.Add(new Food(Resources.egg, 2, 1, 'F'));
            lootTable.Add(new Food(Resources.Burg, 8, 6, 'F'));
            lootTable.Add(new Armor(Resources.armor, 3, 12, 'A'));
            lootTable.Add(new Armor(Resources.Onesie, 1, 1, 'A'));
            lootTable.Add(new Armor(Resources.Mask, 2, 5, 'A'));
            lootTable.Add(new Armor(Resources.socks, 1, 2, 'A'));
            lootTable.Add(new Armor(Resources.jorts, 3, 9, 'A'));
            lootTable.Add(new Armor(Resources.yeezys, 2, 4, 'A'));
            lootTable.Add(new Weapon(Resources.sword, 2, 5, 'W'));
            lootTable.Add(new Weapon(Resources.stick, 1, 1, 'W'));
            lootTable.Add(new Weapon(Resources.gun, 2, 6, 'W'));
            lootTable.Add(new Weapon(Resources.BFG, 3, 9, 'W'));
            lootTable.Add(new Weapon(Resources.energysword, 3, 11, 'W'));
            lootTable.Add(new Weapon(Resources.plunger, 1, 3, 'W'));
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
                    enemy.OnAttack((int)(-4 + player.armorDef * 0.2));
                } else {
                    enemy.OnAttack((int)(-3 + player.armorDef * 0.2));
                }
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
                if (enemy.Health <= 0) {
                    if (Boss)
                    {
                        MessageBox.Show("Congratulations, you won!");
                        Application.Exit();
                    }
                    UpdateExp();
                    GivePlayerLoot();
                    MessageBox.Show("You got loot! Access your inventory with I to see it.");
                    instance = null;
                    Close();
                }
        instance = null;
        Close();
      }
    }

    private void GivePlayerLoot()
        {
            frmInventory = FrmInventory.GetInstance();
            Random rnd = new Random();
            if (frmInventory.inventory.Count < 9)
                frmInventory.inventory.Add(lootTable[rnd.Next(18)]);
            if (frmInventory.inventory.Count < 9)
                frmInventory.inventory.Add(lootTable[rnd.Next(18)]);
        }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

    private void FrmBattle_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    frmInventory = FrmInventory.GetInstance();
                    frmInventory.ShowCommands();
                    break;
            }
        }

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }

        private void tmrUpdateHealth_Tick(object sender, EventArgs e)
        {
            UpdateHealthBars();
        }
    }
}

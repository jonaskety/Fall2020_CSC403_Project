using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;
    private float weaponStr;
    public float armorDef;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 1.5f;
      weaponStr = 0;
      armorDef = 0;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * (strength + weaponStr * 0.2)));
    }

    public void AlterHealth(int amount) {
      Health += amount;
      if (Health >= MaxHealth) {
                Health = MaxHealth;
            }
    }

    public void ChallengeMode() {
            MaxHealth = 60;
            strength = 3;
            Health = MaxHealth;
    }

    public void UpdateStats() {
            MaxHealth += 5;
            Health = MaxHealth;
            strength += 1;
        }

        public void AlterStrength(int amount)
        {
            weaponStr = amount;
        }

        public void AlterDefense(int amount)
        {
            armorDef = amount;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Enemy : Character
    {
        public string Description { get; set; }

        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
            UIController.OnEnemyUpdate(this);
        }

        public override void Die()
        {
            Encounter.OnEnemyDie();
            Energy = MaxEnergy;
        }
    }
}

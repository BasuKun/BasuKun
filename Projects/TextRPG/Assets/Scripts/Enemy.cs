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
            Debug.Log("This also happens, but only on enemy!");
        }

        public override void Die()
        {
            Debug.Log("Character has died, was enemy.");
        }
    }
}

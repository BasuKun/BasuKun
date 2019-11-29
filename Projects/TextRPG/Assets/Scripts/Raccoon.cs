using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Raccoon : Enemy
    {
        void Start()
        {
            Energy = 10;
            Attack = 5;
            Defense = 3;
            Gold = 20;
            Inventory.Add("Bandit Mask");
        }

        void Update()
        {
        
        }
    }
}

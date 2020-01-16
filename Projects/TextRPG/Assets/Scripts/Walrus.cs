using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TextRPG
{
    public class Walrus : Enemy
    {
        void Start()
        {
            Energy = 15;
            Attack = 3;
            Defense = 5;
            Gold = 30;
            Description = "Walrus";
            Inventory.Add("Walrus Tooth");
        }

        void Update()
        {
        
        }
    }
}

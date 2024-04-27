using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    public float health;

    void Update()
    {
        if (Game.instance.isRoundOver == true)
        {
            health = 1;
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    public void Damage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        this.GetComponent<SpriteRenderer>().enabled = false;
    }
}

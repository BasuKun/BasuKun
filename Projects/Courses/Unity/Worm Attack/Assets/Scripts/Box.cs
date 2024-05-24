﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float shrinkAmount = 0.25f;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "Bullet")
        {
            Destroy(otherCollider.gameObject);

            transform.localScale = new Vector2(transform.localScale.x - shrinkAmount, transform.localScale.y - shrinkAmount);

            if (transform.localScale.x <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
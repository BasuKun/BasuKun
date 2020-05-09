using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGravityController : MonoBehaviour
{
    private float drag = 0.1f;
    private Rigidbody2D rig;
    private bool hasCollision = false;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (hasCollision && rig.velocity.x > 0)
        {
            var vel = rig.velocity;
            vel.x *= 1.0f - drag;
            rig.velocity = vel;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasCollision)
        {
            rig.gravityScale = 1;
            rig.angularDrag = 4;
            hasCollision = true;
        }
    }
}

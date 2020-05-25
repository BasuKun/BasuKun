using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGravityController : MonoBehaviour
{
    private float drag = 0.2f;
    private Rigidbody2D rig;
    private bool hasCollision = false;
    private BubbleMagnetism bubbleMagnetism;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        bubbleMagnetism = GetComponent<BubbleMagnetism>();
    }

    void FixedUpdate()
    {
        if (hasCollision && !bubbleMagnetism.isGettingAbsorbed)
        {
            VelocityController(drag);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!hasCollision)
        {
            VelocityController(0.9f);
            rig.gravityScale = 1;
            rig.angularDrag = 4;
            hasCollision = true;
        }
    }

    void VelocityController(float dragValue)
    {
        var vel = rig.velocity;
        vel.x = Mathf.Clamp(vel.x * (1.0f - dragValue), 0f, 100f); ;
        rig.velocity = vel;
    }
}

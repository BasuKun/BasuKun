using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLaunch : MonoBehaviour
{
    private float dashSpeed = 7;
    private float dashTime = 0.1f;
    private float StartDashTime = 0.1f;
    private float velocityResetSpeed = 0.6f;
    private bool isDashing = false;
    public bool dashInitiated = false;
    private bool endingDash = false;

    private Rigidbody2D rig;

    private MouseAngleFinder mouseAngleFinder;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        mouseAngleFinder = GetComponent<MouseAngleFinder>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDashing)
        {
            isDashing = true;
        }
        if (isDashing)
        {
            if (dashTime <= 0)
            {
                EndPropulse();
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (!dashInitiated)
                {
                    CharacterPropulsor(mouseAngleFinder.mouseAngle);
                }
            }
        }

    }

    private void FixedUpdate()
    {
        if (endingDash)
        {
            ResetVelocity();
        }
    }

    private void CharacterPropulsor(int angle)
    {
        dashInitiated = true;
        rig.velocity = Vector2.zero;

        switch (angle)
        {
            case 0:
                rig.velocity = Vector2.down * dashSpeed;
                break;
            case 1:
                rig.velocity = Vector2.left * dashSpeed;
                break;
            case 2:
                rig.velocity = Vector2.up * dashSpeed * 0.75f;
                break;
            case 3:
                rig.velocity = Vector2.right * dashSpeed;
                break;
        }
    }

    private void EndPropulse()
    {
        dashTime = StartDashTime;
        endingDash = true;
        isDashing = false;
        dashInitiated = false;
    }

    private void ResetVelocity()
    {
        rig.velocity = new Vector2(rig.velocity.x * velocityResetSpeed, rig.velocity.y);

        if (rig.velocity.x < 0.5f && rig.velocity.x > -0.5f)
        {
            rig.velocity = Vector2.zero;
            Debug.Log("Dash ended");
            endingDash = false;
        }
    }
}

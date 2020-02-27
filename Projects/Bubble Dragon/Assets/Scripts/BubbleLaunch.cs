using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLaunch : MonoBehaviour
{
    private float dashTime = 0.3f;
    public float DashTime
    {
        get { return dashTime; }
        private set { dashTime = DashTime; }
    }

    private float startDashTime = 0.3f;
    public float StartDashTime
    {
        get { return startDashTime; }
        private set { startDashTime = StartDashTime; }
    }

    private float dashSpeed = 4;
    private float velocityResetSpeed = 0.6f;
    private float gravityResetSpeed = 1.3f;
    private bool isDashing = false;
    public bool dashInitiated = false;
    private bool endingDash = false;
    public bool dashingUp = false;

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
            if (dashTime <= startDashTime / gravityResetSpeed)
            {
                rig.gravityScale = Mathf.Clamp(rig.gravityScale + 10f * Time.deltaTime, 0f, 1f);
            }

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
        rig.gravityScale = 0;

        switch (angle)
        {
            case 0:
                rig.velocity = Vector2.down * dashSpeed;
                break;
            case 1:
                rig.velocity = Vector2.left * dashSpeed;
                break;
            case 2:
                dashingUp = true;
                rig.velocity = Vector2.up * dashSpeed * 0.6f;
                break;
            case 3:
                rig.velocity = Vector2.right * dashSpeed;
                break;
        }
    }

    private void EndPropulse()
    {
        dashTime = startDashTime;
        endingDash = true;
        isDashing = false;
        dashInitiated = false;
    }

    private void ResetVelocity()
    {
        rig.velocity = new Vector2(rig.velocity.x * velocityResetSpeed, rig.velocity.y);

        if (rig.velocity.x < 0.5f && rig.velocity.x > -0.5f)
        {
            rig.gravityScale = 1;
            rig.velocity = Vector2.zero;
            endingDash = false;
            dashingUp = false;
        }
    }
}

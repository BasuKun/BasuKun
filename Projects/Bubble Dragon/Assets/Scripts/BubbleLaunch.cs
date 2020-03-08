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

    public float dashCharge = 0f;
    private float dashSpeed = 4f;
    private float velocityResetSpeed = 0.6f;
    private float gravityResetSpeed = 1.3f;
    private int arrowKeyDirection;
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
        if (Input.GetMouseButton(0) && !isDashing && GameManager.instance.isUsingMouse)
        {
            dashCharge = Mathf.Clamp(dashCharge + Time.deltaTime, 0f, 1f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDashing = true;
        }

        else if (!isDashing && !GameManager.instance.isUsingMouse)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                arrowKeyDirection = 0;
                isDashing = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                arrowKeyDirection = 1;
                isDashing = true;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                arrowKeyDirection = 2;
                isDashing = true;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                arrowKeyDirection = 3;
                isDashing = true;
            }
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
                    if (GameManager.instance.isUsingMouse)
                    {
                        CharacterPropulsor(mouseAngleFinder.mouseAngle, (int)(dashCharge + 1));
                        dashCharge = 0;
                    }
                    else
                    {
                        CharacterPropulsor(arrowKeyDirection, 1);
                        dashCharge = 0;
                    }
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

    private void CharacterPropulsor(int angle, int strength)
    {
        dashInitiated = true;
        rig.velocity = Vector2.zero;
        rig.gravityScale = 0;

        switch (angle)
        {
            case 0:
                rig.velocity = Vector2.down * dashSpeed * strength;
                break;
            case 1:
                rig.velocity = Vector2.left * dashSpeed * strength;
                break;
            case 2:
                dashingUp = true;
                rig.velocity = Vector2.up * dashSpeed * 0.75f * strength;
                break;
            case 3:
                rig.velocity = Vector2.right * dashSpeed * strength;
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

        if (rig.velocity.x < 0.1f && rig.velocity.x > -0.1f)
        {
            rig.gravityScale = 1;
            rig.velocity = Vector2.zero;
            endingDash = false;
            dashingUp = false;
        }
    }
}

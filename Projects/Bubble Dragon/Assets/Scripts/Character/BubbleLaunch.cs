using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLaunch : MonoBehaviour
{
    private float dashTime = 0.2f;
    public float DashTime
    {
        get { return dashTime; }
        private set { dashTime = DashTime; }
    }

    private float startDashTime = 0.2f;
    public float StartDashTime
    {
        get { return startDashTime; }
        private set { startDashTime = StartDashTime; }
    }

    public float dashCharge = 0f;
    private float chargeSpeed = 1.5f;
    private float dashSpeed = 3f;
    private float velocityResetSpeed = 0.6f;
    private float gravityResetSpeed = 2.5f; // higher = longer
    private int arrowKeyDirection;
    public bool isDashing = false;
    public bool dashInitiated = false;
    private bool endingDash = false;
    public bool dashingUp = false;
    public bool isCharging = false;
    public bool hasFlashed = false;

    public TintController tintController;
    private CharacterMovement characterMovement;
    private Rigidbody2D rig;
    public GameObject bubble;
    private MouseAngleFinder mouseAngleFinder;
    public CameraShake cameraShake;
    public Transform bubblesHolder;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        characterMovement = GetComponent<CharacterMovement>();
        mouseAngleFinder = GetComponent<MouseAngleFinder>();
    }

    private void Update()
    {
        ButtonUsedToPropulse();

        if (isDashing)
        {
            GravityController();
        }

        isCharging = dashCharge == 0 ? false : true;
    }

    private void FixedUpdate()
    {  
        if (endingDash)
        {
            ResetVelocity();
        }
    }

    private void ButtonUsedToPropulse()
    {
        if (GameManager.instance.bubbleAmount <= 0) return;
        if (characterMovement.isAbsorbing) return;
        if (isDashing) return;

        if (Input.GetMouseButton(0) && !isDashing && GameManager.instance.isUsingMouse)
        {
            dashCharge = Mathf.Clamp(dashCharge + (Time.deltaTime * chargeSpeed), 0f, 1f);
            CharacterBlinker();
        }
        if (Input.GetMouseButtonUp(0) && GameManager.instance.isUsingMouse)
        {
            isDashing = true;
        }

        if (!isDashing && !GameManager.instance.isUsingMouse)
        {
            if (!GameManager.instance.isUsingMouse && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow)))
            {
                dashCharge = Mathf.Clamp(dashCharge + (Time.deltaTime * chargeSpeed), 0f, 1f);
                CharacterBlinker();
            }

            if (Input.GetKeyUp(KeyCode.UpArrow) && !GameManager.instance.isUsingMouse)
            {
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    arrowKeyDirection = 0;
                    isDashing = true;
                }
            }
            if (Input.GetKeyUp(KeyCode.RightArrow) && !GameManager.instance.isUsingMouse)
            {
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    arrowKeyDirection = 1;
                    isDashing = true;
                }
            }
            if (Input.GetKeyUp(KeyCode.DownArrow) && !GameManager.instance.isUsingMouse)
            {
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    arrowKeyDirection = 2;
                    isDashing = true;
                }
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow) && !GameManager.instance.isUsingMouse)
            {
                if (!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow) && !Input.GetKey(KeyCode.LeftArrow))
                {
                    arrowKeyDirection = 3;
                    isDashing = true;
                }
            }
        }
    }

    private void GravityController()
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
                    ShootBubble(mouseAngleFinder.mouseAngle, (int)(dashCharge + 1));
                    dashCharge = 0;
                }
                else
                {
                    CharacterPropulsor(arrowKeyDirection, (int)(dashCharge + 1));
                    ShootBubble(arrowKeyDirection, (int)(dashCharge + 1));
                    dashCharge = 0;
                }
            }
        }
    }

    private void CharacterPropulsor(int angle, int strength)
    {
        hasFlashed = false;
        dashInitiated = true;
        rig.velocity = Vector2.zero;
        rig.gravityScale = 0;

        StartCoroutine(cameraShake.CameraShaker(0.1f * strength, 0.2f));

        switch (angle)
        {
            case 0:
                rig.velocity = Vector2.down * dashSpeed * strength;
                break;
            case 1:
                rig.velocity = Vector2.left * dashSpeed * strength;
                SpriteDirection(angle);
                break;
            case 2:
                dashingUp = true;
                rig.velocity = Vector2.up * dashSpeed * 0.75f * Mathf.Clamp(strength * 0.8f, 1f, 2f);
                break;
            case 3:
                rig.velocity = Vector2.right * dashSpeed * strength;
                SpriteDirection(angle);
                break;
        }
    }

    private void SpriteDirection(int angle)
    {
        characterMovement.sprite.flipX = angle == 1 ? false : true;
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

        if (rig.velocity.x < 0.01f && rig.velocity.x > -0.01f)
        {
            rig.gravityScale = 1;
            rig.velocity = new Vector2(0, rig.velocity.y);
            endingDash = false;
            dashingUp = false;
        }
    }

    private void ShootBubble(int angle, int strength)
    {
        GameObject bubblePrefab = Instantiate(
            GameManager.instance.hasSpecialItem ? GameManager.instance.itemInventory[0].prefab : GameManager.instance.bubblesInventory[0].prefab, 
            transform.position, 
            transform.rotation, 
            bubblesHolder);
        Rigidbody2D bubbleRig = bubblePrefab.GetComponent<Rigidbody2D>();

        switch (angle)
        {
            case 0:
                bubbleRig.velocity = Vector2.up * strength * 3;
                break;
            case 1:
                bubbleRig.velocity = Vector2.right * strength * 3;
                break;
            case 2:
                bubbleRig.velocity = Vector2.down * strength * 3;
                break;
            case 3:
                bubbleRig.velocity = Vector2.left * strength * 3;
                break;
        }

        if (GameManager.instance.hasSpecialItem)
        {
            GameManager.instance.itemInventory.RemoveAt(0);
        }
        else
        {
            GameManager.instance.bubbleAmount--;
            GameManager.instance.bubblesInventory.RemoveAt(0);
        }
        GameUI.instance.UpdateBubbleAmountUI();
    }

    private void CharacterBlinker()
    {
        if (dashCharge < 1f || (dashCharge == 1f && hasFlashed))
        {
            tintController.Blink(dashCharge);
        }
        else if (dashCharge == 1f && !hasFlashed)
        {
            tintController.BlinkCharged();
            hasFlashed = true;
        }
    }
}

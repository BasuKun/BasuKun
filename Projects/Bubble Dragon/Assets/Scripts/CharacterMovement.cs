using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public bool isJumping = false;
    public bool isGrounded = false;
    public bool isLookingRight = true;
    private float movementSpeed = 1.7f;
    private float jumpVelocity = 3.5f;
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2f;

    public SpriteRenderer sprite;
    private Rigidbody2D rig;
    private CharacterHorizontalCollider characterHorizontalCollider;
    private BubbleLaunch bubbleLaunch;

    public LayerMask groundLayer;

    private void Awake()
    {
        bubbleLaunch = GetComponent<BubbleLaunch>();
        rig = GetComponent<Rigidbody2D>();
        characterHorizontalCollider = GetComponent<CharacterHorizontalCollider>();
    }

    private void Update()
    {
        isGrounded = IsGrounded();
        isJumping = !isGrounded;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }

        if (rig.velocity.y < 0)
        {
            JumpGravityModifier(fallMultiplier);
        }
        else if (rig.velocity.y > 0 && !Input.GetButton("Jump") && !bubbleLaunch.dashInitiated)
        {
            JumpGravityModifier(lowJumpMultiplier);
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.12f;
        float offsetL = 0.08f;
        float offsetR = 0.12f;

        RaycastHit2D hitL = Physics2D.Raycast(new Vector2(position.x - offsetL, position.y), direction, distance, groundLayer);
        //Debug.DrawRay(new Vector2(position.x - offsetL, position.y), direction * distance);
        RaycastHit2D hitR = Physics2D.Raycast(new Vector2(position.x + offsetR, position.y), direction, distance, groundLayer);
        //Debug.DrawRay(new Vector2(position.x + offsetR, position.y), direction * distance);

        if (hitL || hitR)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Jump()
    {
        rig.velocity = Vector2.up * jumpVelocity;
    }

    private void JumpGravityModifier(float modifier)
    {
        rig.velocity += Vector2.up * Physics2D.gravity.y * (modifier - 1) * Time.deltaTime;
    }

    private void Movement()
    {
        if (!characterHorizontalCollider.isHittingWall)
        {
            if (!bubbleLaunch.dashInitiated || bubbleLaunch.dashInitiated && bubbleLaunch.dashingUp && bubbleLaunch.DashTime <= bubbleLaunch.StartDashTime / 1.2f)
            {
                transform.position += new Vector3(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0);
            }
        }

        if (Input.GetAxis("Horizontal") > 0 && !isLookingRight)
        {
            isLookingRight = true;
            sprite.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0 && isLookingRight)
        {
            isLookingRight = false;
            sprite.flipX = true;
        }
    }
}

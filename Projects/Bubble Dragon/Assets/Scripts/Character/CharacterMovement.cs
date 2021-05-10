using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public bool isJumping = false;
    public bool isGrounded = false;
    public bool isLookingRight = true;
    public bool isAbsorbing = false;
    private float movementSpeed = 1.5f;
    private float jumpVelocity = 2.3f;
    private float fallMultiplier = 2.5f;
    private float lowJumpMultiplier = 2f;

    public Animator animator;
    public SpriteRenderer sprite;
    public GameObject absorbArea;
    public GameObject absorbedArea;
    private BoxCollider2D absorbAreaCollider;
    private BoxCollider2D boxCollider;
    private Rigidbody2D rig;
    //private CharacterHorizontalCollider characterHorizontalCollider;
    private BubbleLaunch bubbleLaunch;
    private MouseAngleFinder mouseAngleFinder;


    public LayerMask groundLayer;

    private void Awake()
    {

        bubbleLaunch = GetComponent<BubbleLaunch>();
        rig = GetComponent<Rigidbody2D>();
        //characterHorizontalCollider = GetComponent<CharacterHorizontalCollider>();
        absorbAreaCollider = absorbArea.GetComponent<BoxCollider2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        mouseAngleFinder = GetComponent<MouseAngleFinder>();
    }

    private void Update()
    {
        isGrounded = IsGrounded();
        isJumping = !isGrounded;

        if (Input.GetButtonDown("Jump") && isGrounded && !isAbsorbing)
        {
            Jump();
        }

        if (Input.GetButton("Fire2") && !bubbleLaunch.isDashing && !bubbleLaunch.isCharging && isGrounded)
        {
            BubbleAbsorb(Input.GetButton("Fire2"));
        }
        if (Input.GetButtonUp("Fire2"))
        {
            BubbleAbsorb(Input.GetButton("Fire2"));
        }

        if (rig.velocity.y < 0)
        {
            JumpGravityModifier(fallMultiplier);
        }
        else if (rig.velocity.y > 0 && !Input.GetButton("Jump") && !bubbleLaunch.dashInitiated)
        {
            JumpGravityModifier(lowJumpMultiplier);
        }

        CharacterAnimator();

        if (rig.velocity.x < 0.001f && rig.velocity.x > -0.001f && rig.velocity.x != 0)
        {
            rig.velocity = new Vector2(0, rig.velocity.y);
        }
    }

    private void FixedUpdate()
    {
        Movement();
        LookingDirection();
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

        return hitL || hitR;
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
        if (!isAbsorbing)
        {
            if (!bubbleLaunch.dashInitiated || bubbleLaunch.dashInitiated && bubbleLaunch.dashingUp && bubbleLaunch.DashTime <= bubbleLaunch.StartDashTime / 2f)
            {
                //rig.MovePosition(rig.position + new Vector2(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0));
                rig.position = (rig.position + new Vector2(Input.GetAxis("Horizontal") * movementSpeed * Time.fixedDeltaTime, 0));
                //rig.AddForce(new Vector2(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0), ForceMode2D.Force);
            }
        }
        
    }

    private void LookingDirection()
    {
        if (!bubbleLaunch.isCharging)
        {
            if (Input.GetAxis("Horizontal") > 0 && !isLookingRight)
            {
                isLookingRight = true;
                sprite.flipX = false;
                absorbAreaCollider.offset = new Vector2(0.4f, 0);
                boxCollider.offset = new Vector2(0.02f, 0);
            }
            else if (Input.GetAxis("Horizontal") < 0 && isLookingRight)
            {
                isLookingRight = false;
                sprite.flipX = true;
                absorbAreaCollider.offset = new Vector2(-0.4f, 0);
                boxCollider.offset = new Vector2(-0.02f, 0);
            }
        }
        else
        {
            if (Input.GetAxis("Horizontal") >= 0 && sprite.flipX == mouseAngleFinder.isAimingRight)
            {
                isLookingRight = true;
                sprite.flipX = mouseAngleFinder.isAimingRight ? false : true;
                absorbAreaCollider.offset = mouseAngleFinder.isAimingRight ? new Vector2(0.4f, 0) : new Vector2(-0.4f, 0);
                boxCollider.offset = mouseAngleFinder.isAimingRight ? new Vector2(0.02f, 0) : new Vector2(-0.02f, 0);
            }
            else if (Input.GetAxis("Horizontal") < 0 && sprite.flipX == mouseAngleFinder.isAimingRight)
            {
                isLookingRight = false;
                sprite.flipX = mouseAngleFinder.isAimingRight ? false : true;
                absorbAreaCollider.offset = mouseAngleFinder.isAimingRight ? new Vector2(0.4f, 0) : new Vector2(-0.4f, 0);
                boxCollider.offset = mouseAngleFinder.isAimingRight ? new Vector2(0.02f, 0) : new Vector2(-0.02f, 0);
            }
        }
    }

    private void BubbleAbsorb(bool absorbing)
    {
        isAbsorbing = absorbing;
        absorbArea.SetActive(isAbsorbing);
        absorbedArea.SetActive(isAbsorbing);
    }

    private void CharacterAnimator()
    {
        animator.SetBool("IsGrounded", isGrounded);
        animator.SetBool("IsAbsorbing", isAbsorbing);
        animator.SetBool("IsRunning", Input.GetButton("Horizontal"));
        animator.SetBool("IsSpittingDown", bubbleLaunch.dashingUp);
        animator.SetBool("IsSpitting", bubbleLaunch.isDashing);
        animator.SetBool("IsRunningLeft", Input.GetAxis("Horizontal") > 0 ? false : true);
        animator.SetBool("IsCharging", bubbleLaunch.isCharging);
        animator.SetInteger("ChargeDirection", mouseAngleFinder.mouseAngle);
        animator.SetFloat("yVelocity", rig.velocity.y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toad : MonoBehaviour
{
    public int player;
    [SerializeField]
    private Transform[] jumpPathPoints;
    [SerializeField]
    private float jumpSpeed;
    [SerializeField]
    private Tongue tongue;
    [SerializeField]
    private Sprite[] toadSprites;
    private bool grounded, reachedTargetPoint;
    private int positionIndex;
    private Vector2 jumpDirection;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        grounded = true;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // if grounded and pressed action button, jump
        if (Input.GetButtonDown("Action" + player) && grounded)
        {
            Debug.Log("Jump!");
            jumpDirection = positionIndex == 0 ? Vector2.right : Vector2.left;
            spriteRenderer.sprite = toadSprites[1];
            grounded = false;
        }
        // If not grounded and pressed action button, attack
        else if (Input.GetButtonDown("Action" + player))
        {
            StartCoroutine(Attack());
        }
        Move();
    }

    IEnumerator Attack()
    {
        tongue.gameObject.SetActive(true);
        yield return new WaitForSeconds(.7f);
        tongue.gameObject.SetActive(false);
    }

    private void Move()
    {
        if (!grounded)
        {
            // If close enough to target point, return true
            reachedTargetPoint = Vector2.Distance(transform.position, jumpPathPoints[positionIndex].position) <= .1f;
            // What to do if jumping to the right
            if (jumpDirection == Vector2.right)
            {
                if (reachedTargetPoint)
                {
                    positionIndex++;
                }
                if (ReachedLandingPad())
                {
                    positionIndex = 2;
                }
            }
            // what to do if jumping to the left
            else
            {
                if (reachedTargetPoint)
                {
                    positionIndex--;
                }
                if (ReachedLandingPad())
                {
                    positionIndex = 0;
                }
            }
        }
        // Move towards target path point
        transform.position = Vector2.MoveTowards(transform.position, jumpPathPoints[positionIndex].position, jumpSpeed);
    }

    bool ReachedLandingPad()
    {
        if (jumpDirection == Vector2.right && positionIndex == jumpPathPoints.Length
            || jumpDirection == Vector2.left && positionIndex == -1)
        {
            grounded = true;
            transform.Rotate(Vector3.up, 180f);
            spriteRenderer.sprite = toadSprites[0];
            return true;
        }
        return false;
    }
}

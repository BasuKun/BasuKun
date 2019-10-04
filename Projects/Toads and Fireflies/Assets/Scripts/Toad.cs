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
        if (Input.GetButtonDown("Action" + player) && grounded)
        {
            jumpDirection = positionIndex == 0 ? Vector2.right : Vector2.left;
            spriteRenderer.sprite = toadSprites[1];
            grounded = false;
        }
        else if (Input.GetButtonDown("Action" + player))
        {
            StartCoroutine(Attack());
        }
        Move();
    }

    IEnumerator Attack()
    {
        // activate tongue
        yield return new WaitForSeconds(0.7f);
        // deactivate tongue
    }

    void Move()
    {
        if (!grounded)
        {
            reachedTargetPoint = Vector2.Distance(transform.position, jumpPathPoints[positionIndex].position) <= .1f;
            if (jumpDirection == Vector2.right)
            {
                if (reachedTargetPoint)
                {
                    positionIndex++;
                }
                if (ReachedLandingPad())
                {
                    positionIndex = 8;
                }
            }
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
        transform.position = Vector2.MoveTowards(transform.position, jumpPathPoints[positionIndex].position, jumpSpeed);
    }

    bool ReachedLandingPad()
    {
        if (jumpDirection == Vector2.right && positionIndex == jumpPathPoints.Length || jumpDirection == Vector2.left && positionIndex == -1)
        {
            grounded = true;
            transform.Rotate(Vector3.up, 180f);
            spriteRenderer.sprite = toadSprites[0];
            return true;
        }
        return false;
    }
}

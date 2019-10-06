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

    private bool isTongueOut;

    void Awake()
    {
        grounded = true;
        isTongueOut = false;
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
        else if (Input.GetButtonDown("Action" + player) && !isTongueOut)
        {
            StartCoroutine(Attack());
        }
        Move();
    }

    IEnumerator Attack()
    {
        isTongueOut = true;
        tongue.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        isTongueOut = false;
        tongue.gameObject.SetActive(false);
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

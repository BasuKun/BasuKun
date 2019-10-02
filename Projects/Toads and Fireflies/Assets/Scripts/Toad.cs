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
    private bool grounded, reachedTargetPoint;
    private int positionIndex;
    private Vector2 jumpDirection;

    void Awake()
    {
        grounded = true;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            Debug.Log("Jump!");
            jumpDirection = positionIndex == 0 ? Vector2.right : Vector2.left;
            grounded = false;
        }
        Move();
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
            }
            else
            {
                if (reachedTargetPoint)
                {
                    positionIndex--;
                }
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, jumpPathPoints[positionIndex].position, jumpSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHorizontalCollider : MonoBehaviour
{
    public bool isHittingWall = false;

    private Rigidbody2D rig;
    private CharacterMovement characterMovement;
    private MouseAngleFinder mouseAngleFinder;
    private BubbleLaunch bubbleLaunch;

    public LayerMask groundLayer;

    private void Awake()
    {
        bubbleLaunch = GetComponent<BubbleLaunch>();
        mouseAngleFinder = GetComponent<MouseAngleFinder>();
        rig = GetComponent<Rigidbody2D>();
        characterMovement = GetComponent<CharacterMovement>();
    }

    private void Update()
    {
        if (CheckForHorizontalCollision())
        {
            isHittingWall = true;
            rig.velocity = new Vector2(0, rig.velocity.y);
        }
        else
        {
            isHittingWall = false;
        }
    }

    private bool CheckForHorizontalCollision()
    {
        Vector2 position = transform.position;
        Vector2 direction = Input.GetAxis("Horizontal") > 0 ? Vector2.right : Vector2.left;

        float distance = 0.14f;
        float offsetU = 0.10f;
        float offsetD = 0.10f;

        RaycastHit2D hitU = Physics2D.Raycast(new Vector2(position.x, position.y + offsetU), direction, distance, groundLayer);
        Debug.DrawRay(new Vector2(position.x, position.y + offsetU), direction * distance);
        RaycastHit2D hitD = Physics2D.Raycast(new Vector2(position.x, position.y - offsetD), direction, distance, groundLayer);
        Debug.DrawRay(new Vector2(position.x, position.y - offsetD), direction * distance);

        if (hitU || hitD)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

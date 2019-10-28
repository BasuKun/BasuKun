﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void PlayerHandler();
    public event PlayerHandler OnPlayerMoved;
    public event PlayerHandler OnPlayerEscaped;

    public float jumpDistance = 0.32f;

    private bool jumped;
    private Vector3 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        // Movement logic.
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        if (!jumped)
        {
            Vector2 targetPosition = Vector2.zero;
            bool tryingToMove = false;

            if (horizontalMovement != 0)
            {
                tryingToMove = true;
                targetPosition = new Vector2(transform.position.x + (horizontalMovement > 0 ? jumpDistance : -jumpDistance), transform.position.y);
            }
            else if (verticalMovement != 0)
            {
                tryingToMove = true;
                targetPosition = new Vector2(transform.position.x, transform.position.y + (verticalMovement > 0 ? jumpDistance : -jumpDistance));
            }

            Collider2D hitCollider = Physics2D.OverlapCircle(targetPosition, 0.1f);

            if (tryingToMove == true && hitCollider == null)
            {
                transform.position = targetPosition;
                jumped = true;
                if (OnPlayerMoved != null)
                {
                    OnPlayerMoved();
                }
            }
        }
        else
        {
            if (horizontalMovement == 0f && verticalMovement == 0f)
            {
                jumped = false;
            }
        }

        //Bounds logic.
        if (transform.position.y < -(Screen.height / 100f) / 2f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + jumpDistance, transform.position.z);
        }

        if (transform.position.y > (Screen.height / 100f) / 2f)
        {
            transform.position = startingPosition;
        }

        if (transform.position.x < -((Screen.width / 100f) / 2f))
        {
            transform.position = new Vector3(transform.position.x + jumpDistance, transform.position.y, transform.position.z);
        }

        if (transform.position.x > ((Screen.width / 100f) / 2f))
        {
            transform.position = new Vector3(transform.position.x - jumpDistance, transform.position.y, transform.position.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int pointValue;
    private Rigidbody2D body;
    [SerializeField]
    private float speed;
    private Vector2 movementDirection;

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        movementDirection = Vector2.right;
    }

    void Update()
    {
        Move(movementDirection);
    }

    public void Move(Vector2 direction)
    {
        movementDirection = direction;
        body.velocity = new Vector2(direction.x * speed, body.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            movementDirection *= -1f;
        }
    }
}

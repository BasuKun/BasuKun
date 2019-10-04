using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly : MonoBehaviour
{
    public int pointValue;
    public float moveSpeed;
    public float sinSpeed;
    public float sinLength;
    private Vector2 direction;

    private Vector3 newPosition;

    private void Awake()
    {
        sinSpeed = Random.Range(0.5f, 2.5f);
        sinLength = Random.Range(3, 5);
    }

    void Update()
    {
        newPosition = transform.position;
        newPosition.y += Mathf.Sin(Time.time * sinLength) * sinSpeed * Time.deltaTime;
        transform.position = newPosition;
        Move();
    }

    public void Setup(float speed, Vector2 direction)
    {
        this.pointValue = (int)speed * 3;
        this.moveSpeed = speed;
        this.direction = direction;
    }

    private void Move()
    {
        transform.Translate((direction * 1.3f) * Time.deltaTime);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firefly : MonoBehaviour
{
    public int pointValue;
    public float moveSpeed;
    private Vector2 direction;

    private Vector3 newPosition;
    private float randomTimeModifier;

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.y += Mathf.Sin(Time.time*randomTimeModifier) * 1.5f * Time.deltaTime;
        transform.position = newPosition;
        Move();
    }

    public void Setup(float speed, Vector2 direction)
    {
        this.pointValue = (int)speed * 3;
        this.moveSpeed = speed;
        this.direction = direction;
        randomTimeModifier = Random.Range(3f, 8f);
    }

    private void Move()
    {
        transform.Translate((direction * moveSpeed) * Time.deltaTime);
    }
}

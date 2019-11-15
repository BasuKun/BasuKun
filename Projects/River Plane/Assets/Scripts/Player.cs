﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void FuelHandler();
    public event FuelHandler OnFuel;

    public float horizontalSpeed = 1.5f;
    public float verticalSpeed = 1f;
    public float horizontalLimit = 2.8f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 2f;
    public float bulletOffset = 0.5f;
    private bool fired = false;

    private void Update()
    {
        // Move the player
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * horizontalSpeed, verticalSpeed);

        // Keep the player within bounds
        if (transform.position.x > horizontalLimit)
        {
            transform.position = new Vector2(horizontalLimit, transform.position.y);
        }
        else if (transform.position.x < -horizontalLimit)
        {
            transform.position = new Vector2(-horizontalLimit, transform.position.y);
        }

        if (Input.GetAxis("Fire1") == 1f)
        {
            if (fired == false)
            {
                fired = true;
                GameObject bulletInstance = Instantiate(bulletPrefab);
                bulletInstance.transform.SetParent(transform.parent);
                bulletInstance.transform.position = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletSpeed);
                Destroy(bulletInstance, 3f);
            }
        }
        else
        {
            fired = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "EnemyBullet" || otherCollider.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
        else if (otherCollider.tag == "Fuel")
        {
            Destroy(otherCollider.gameObject);
            if (OnFuel != null)
            {
                OnFuel();
            }
        }
    }
}

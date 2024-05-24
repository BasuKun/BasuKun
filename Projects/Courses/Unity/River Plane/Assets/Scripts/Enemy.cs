using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public delegate void KillHandler();
    public event KillHandler OnKill;

    public GameObject bulletPrefab;
    public float speed;
    public float shootingInterval = 6f;
    public float enemyBulletOffset;
    public float bulletSpeed;
    private float shootingTimer;

    private void Start()
    {
        shootingTimer = Random.Range(0f, shootingInterval);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    private void Update()
    {
        shootingTimer -= Time.deltaTime;
        if (shootingTimer <= 0f)
        {
            shootingTimer = shootingInterval;

            GameObject bulletInstance = Instantiate(bulletPrefab);
            bulletInstance.transform.SetParent(transform.parent);
            bulletInstance.transform.position = new Vector2(transform.position.x, transform.position.y + enemyBulletOffset);
            bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, bulletSpeed);
            Destroy(bulletInstance, 3f);
        }
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);

            if (OnKill != null)
            {
                OnKill();
            }
        }
    }
}

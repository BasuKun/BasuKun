using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float shootingInterval = 3f;
    public float shootingSpeed = 1.5f;
    public GameObject enemyMissilePrefab;

    private float shootingTimer;

    void Start()
    {
        shootingTimer = shootingInterval;
    }

    void Update()
    {
        shootingTimer -= Time.deltaTime;
        if (shootingTimer <= 0f)
        {
            shootingTimer = shootingInterval;

            Enemy[] enemies = GetComponentsInChildren<Enemy>();
            Enemy randomEnemy = enemies[Random.Range(0, enemies.Length)];

            GameObject missileInstance = Instantiate(enemyMissilePrefab);
            missileInstance.transform.SetParent(transform);
            missileInstance.transform.position = randomEnemy.transform.position;
            missileInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -shootingSpeed);

            Destroy(missileInstance, 3f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour
{
    public float baseValue = 1;
    public float fallSpeed = 8f;
    public float fallingCooldown = 1f;
    public Snowflake snowflake;
    public GameObject sfObject;
    public ParticleSystem snowBurst;
    private bool wentLeft = true;

    void Start()
    {
        snowflake = gameObject.GetComponent<Snowflake>();
        sfObject = this.gameObject;
    }

    void Update()
    {
        fallingCooldown -= Time.deltaTime * fallSpeed;

        if (fallingCooldown <= 0f)
        {
            FallingMovement();
        }

        if (transform.position.y <= -Screen.height / 80)
        {
            Destroy(gameObject);
        }
    }

    void FallingMovement()
    {
        transform.position = wentLeft ?
            new Vector2(transform.position.x + 0.2f, transform.position.y - 0.2f) :
            new Vector2(transform.position.x - 0.2f, transform.position.y - 0.2f);

        wentLeft = !wentLeft;
        fallingCooldown = 1f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MouseRadius")
        {
            ParticleSystem burst = Instantiate(snowBurst, transform.position, Quaternion.identity);
            GameManager.Instance.collectSnowflakes(baseValue);
            Destroy(gameObject);
        }
    }
}
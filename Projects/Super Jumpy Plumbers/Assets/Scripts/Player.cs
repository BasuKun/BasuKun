using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Game game;
    private Rigidbody2D body;
    private float bounceForce = 1000f;

    void Awake()
    {
        game = FindObjectOfType<Game>();
        body = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Hurt();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Enemy":
                body.AddForce(new Vector2(0f, bounceForce));
                StartCoroutine(HurtEnemy(collision.gameObject.GetComponent<Enemy>()));
                break;
            case "Gem":
                game.AddLife();
                Destroy(collision.gameObject);
                break;
            case "Coin":
                game.AddPoints(50);
                Destroy(collision.gameObject);
                break;
        }
    }

    IEnumerator HurtEnemy(Enemy enemy)
    {
        Destroy(enemy.gameObject);
        yield return new WaitForEndOfFrame();
        game.AddPoints(enemy.pointValue);
        // add points will check to see if any enemies exist, complete level?
    }

    void Hurt()
    {
        game.LoseLife();
        Destroy(this.gameObject);
    }
}

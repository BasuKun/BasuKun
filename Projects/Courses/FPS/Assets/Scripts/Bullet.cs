using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    public float lifetime;
    private float shootTime;
    public GameObject hitParticle;
    public GameObject hitParticleSmall;

    void OnEnable()
    {
        shootTime = Time.time;
    }

    void Update()
    {
        // disable the bullet after 'lifetime' seconds
        if(Time.time - shootTime >= lifetime)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        var other = collision.transform;
        var player = other.GetComponent<Player>();

        // did we hit the player?
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().TakeDamage(damage);
        }
        else if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().TakeDamage(damage);
        }

        other.GetComponent<BoxCollider>();
        var posMe = transform.position;
        var posNormal = collision.contacts[0].normal;
        var spawnPos = posMe + posNormal * 0.2f;

        // create the hit particle
        GameObject obj = Instantiate(hitParticle, spawnPos, Quaternion.identity);
        GameObject objSmall = Instantiate(hitParticleSmall, spawnPos, Quaternion.identity);
        Destroy(obj, 0.5f);
        Destroy(objSmall, 0.5f);

        // disable the bullet
        gameObject.SetActive(false);
    }
}

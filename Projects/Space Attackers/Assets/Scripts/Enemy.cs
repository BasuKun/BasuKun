using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.tag == "PlayerMissile")
        {
            GameObject explosionInstance = Instantiate(explosionPrefab);
            explosionInstance.transform.SetParent(transform.parent.parent);
            explosionInstance.transform.position = transform.position;

            Destroy(explosionInstance, 0.5f);
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }
}

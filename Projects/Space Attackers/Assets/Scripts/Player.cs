using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1.5f;
    public float horizontalLimit = 2.5f;
    public GameObject missilePrefab;
    public float firingSpeed = 3f;
    public float missileLastingTime = 2f;

    private bool fired = false;

    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);

        if (transform.position.x > horizontalLimit)
        {
            transform.position = new Vector2(horizontalLimit, transform.position.y);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (transform.position.x < -horizontalLimit)
        {
            transform.position = new Vector2(-horizontalLimit, transform.position.y);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (Input.GetAxis("Fire1") == 1f)
        {
            if (fired == false)
            {
                fired = true;

                GameObject missileInstance = Instantiate(missilePrefab);
                missileInstance.transform.SetParent(transform.parent);
                missileInstance.transform.position = transform.position;
                missileInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, firingSpeed);

                Destroy(missileInstance, missileLastingTime);
            }
        }
        else
        {
            fired = false;
        }
    }
}

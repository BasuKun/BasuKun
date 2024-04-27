using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmites : MonoBehaviour
{
    private Rigidbody2D rig;
    private bool isFalling = false;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (!isFalling)
        {
            if (DetectsPlayerUnder())
            {
                Fall();
            }
        }
    }

    private bool DetectsPlayerUnder()
    {
        Vector2 position = transform.position;

        float distance = 10f;
        Vector2 direction = Vector2.down;
        float offsetL = 0.02f;
        float offsetR = 0.10f;
        float offsetD = 0.1f;

        RaycastHit2D hitL = Physics2D.Raycast(new Vector2(position.x - offsetL, position.y - offsetD), direction, distance);
        //Debug.DrawRay(new Vector2(position.x -offsetL, position.y - offsetD), direction * distance);
        RaycastHit2D hitR = Physics2D.Raycast(new Vector2(position.x + offsetR, position.y - offsetD), direction, distance);
        //Debug.DrawRay(new Vector2(position.x + offsetR, position.y - offsetD), direction * distance);

        if (hitL.collider.tag == "Dragon" || hitR.collider.tag == "Dragon")
        {
            return true;
        }
        else if (hitL.collider.tag == "Ground" || hitR.collider.tag == "Ground")
        {
            return false;
        }
        else
        {
            return false;
        }
    }

    private void Fall()
    {
        isFalling = true;
        rig.bodyType = RigidbodyType2D.Dynamic;
        rig.freezeRotation = true;
    }

    private void Break()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Break();
        }
        else if (col.gameObject.tag == "Dragon")
        {
            col.gameObject.GetComponent<Character>().Die();
            Break();
        }
    }
}

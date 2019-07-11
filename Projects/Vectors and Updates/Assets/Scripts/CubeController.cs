using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour

{
    public float speed = 0.1f;
    public Vector3 movement;
    public float maxValue = 10;
    public float minValue = -10;

    void Start()
    {
        movement = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = transform.position + speed * movement;
        transform.position += speed * movement;

        if(transform.position.y >= maxValue && speed > 0)
        {
            speed *= -1;
        }

        else if (transform.position.y <= minValue && speed < 0)
        {
            speed *= -1;
        }
    }
}

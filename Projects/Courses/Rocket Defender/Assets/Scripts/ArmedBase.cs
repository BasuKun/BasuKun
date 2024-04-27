using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedBase : Base
{
    public float shootSpeed = 5f;

    [SerializeField]
    private Rocket rocket;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        Rocket rocketInstance = Instantiate(rocket);
        rocketInstance.Launch(Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position, shootSpeed);
    }
}

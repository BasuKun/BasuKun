using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSoulHurtAnimation : MonoBehaviour
{
    public ParticleSystem anim;

    private void Update()
    {
        if (!anim.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}

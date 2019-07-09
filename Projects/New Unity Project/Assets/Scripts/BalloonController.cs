using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    //how much it grows each time
    [Range(0, 10)]
    public float scaleFactor = 1.2f;

    //maximum scale
    public float maxScale = 3;

    void OnValidate()
    {
        if(scaleFactor <= 1)
        {
            print("Scale Factor is too small");
        }
    }
    //Method that will detect mouse press
    void OnMouseDown()
    {
        //Access the scale & increase the scale
        //transform.localScale = transform.localScale * scaleFactor
        transform.localScale *= scaleFactor;

        //check if we've passed the maxScale
        if(transform.localScale.x >= maxScale)
        {
            //if so, destroy the balloon
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public bool hasProp;
    public bool willParallax;
    public float parallaxAmount;
    private float length = 4.26f;
    private float cameraOffset = 0.49f;
    private PropsGenerator prop = null;

    private void Start()
    {
        if (hasProp) prop = gameObject.GetComponentInChildren<PropsGenerator>();
    }

    private void Update()
    {
        if (Player.Instance.isMoving)
        {
            this.transform.position -= new Vector3(0.01f * parallaxAmount, 0f, 0f) * 100f * Time.deltaTime;

            if (transform.position.x <= -length + cameraOffset && willParallax)
            {
                transform.position = new Vector3(length + cameraOffset - 0.01f, 0, 0);

                if (hasProp) prop.GenerateSprite();
            }

            else if (transform.position.x <= -length * 2 && !willParallax) gameObject.SetActive(false);
        }
    }
}

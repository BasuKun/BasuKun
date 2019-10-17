using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomGesture : MonoBehaviour
{
    public float zoomRate = 0.015f;
    public Vector2 minMaxZoom;

    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Vector3 aPrevPos = Input.touches[0].position - Input.touches[0].deltaPosition;
            Vector3 bPrevPos = Input.touches[1].position - Input.touches[1].deltaPosition;

            float prevMag = (aPrevPos - bPrevPos).magnitude;
            float curMag = (Input.touches[0].position - Input.touches[1].position).magnitude;

            float diff = curMag - prevMag;

            if (cam.orthographic)
            {
                cam.orthographicSize -= diff * zoomRate;
                cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minMaxZoom.x, minMaxZoom.y);
            }
            else
            {
                transform.position += transform.forward * (diff * zoomRate);
            }
        }
    }
}

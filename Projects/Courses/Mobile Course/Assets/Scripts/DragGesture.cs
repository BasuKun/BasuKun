using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragGesture : MonoBehaviour
{
    private Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Vector3 lastPos = Input.touches[0].position - Input.touches[0].deltaPosition;
            Vector3 curPos = Input.touches[0].position;

            Vector3 dir = cam.ScreenToWorldPoint(lastPos) - cam.ScreenToWorldPoint(curPos);

            transform.position += dir;
        }
    }
}

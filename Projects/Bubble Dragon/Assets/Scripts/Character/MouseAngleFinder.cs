using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAngleFinder : MonoBehaviour
{
    private Vector3 mousePos;
    private CharacterMovement characterMovement;
    public int mouseAngle;
    public bool isAimingRight;

    private void Awake()
    {
        characterMovement = GetComponent<CharacterMovement>();
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 dir = mousePos - transform.position;
        dir = transform.InverseTransformDirection(dir);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        mouseAngle = GetMouseAngle(angle);
    }

    private int GetMouseAngle(float angle)
    {
        if (angle >= 45 && angle < 135)
        {
            return 0;
        }
        else if (angle >= -45 && angle < 45)
        {
            isAimingRight = true;
            return 1;
        }
        else if (angle >= -135 && angle < -45)
        {
            return 2;
        }
        else
        {
            isAimingRight = false;
            return 3;
        }
    }
}

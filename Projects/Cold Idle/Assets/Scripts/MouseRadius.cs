using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRadius : MonoBehaviour
{
    private Transform sphere;
    public CircleCollider2D collider;

    void Start()
    {
        sphere = gameObject.GetComponent<Transform>();
        collider = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sphere.transform.position = new Vector2(worldPoint.x, worldPoint.y);
    }

    public void UpdateRadius()
    {
        collider.radius = GameManager.Instance.radius;
    }
}

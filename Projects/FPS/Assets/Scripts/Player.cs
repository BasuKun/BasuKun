using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float jumpForce;

    [Header("Camera")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;

    private Camera cam;
    private Rigidbody rig;

    void Awake()
    {
        // get the components
        cam = Camera.main;
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
}

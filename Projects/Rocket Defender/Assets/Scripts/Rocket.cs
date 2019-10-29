﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D body;
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] audioClips;

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioClips[0]);
        Destroy(this.gameObject, 3f);
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * 5f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Baddie"))
        {
            audioSource.PlayOneShot(audioClips[1]);
            Destroy(this.gameObject, .33f);
        }
    }

    public void Launch(Vector2 direction, float speed)
    {
        body.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
    }
}
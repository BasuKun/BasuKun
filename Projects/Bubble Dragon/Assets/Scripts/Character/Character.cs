using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject spawnPoint;
    public Transform bubblesHolder;
    private BubbleLaunch bubbleLaunch;
    private Rigidbody2D rig;
    public CameraShake cameraShake;
    public bool hasHitWall = false;
    private float currentVelX;

    public void Awake()
    {
        bubbleLaunch = GetComponent<BubbleLaunch>();
        rig = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        if (!bubbleLaunch.isDashing && hasHitWall)
        {
            hasHitWall = false;
        }

        if (rig.velocity.x != 0)
        {
            currentVelX = rig.velocity.x;
        }
    }

    public void Die()
    {
        foreach (Transform child in bubblesHolder)
        {
            Destroy(child.gameObject);
        }

        transform.position = spawnPoint.transform.position;
        GameManager.instance.bubbleAmount = 3;
        GameUI.instance.UpdateBubbleAmountUI();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Breakable")
        {
            if (bubbleLaunch.isDashing && !hasHitWall)
            {                
                BreakableWalls breakableWalls = col.gameObject.GetComponent<BreakableWalls>();
                breakableWalls.RemoveHP(1);
                StartCoroutine(cameraShake.CameraShaker(0.3f, 0.3f));
                hasHitWall = true;

                if (breakableWalls.hp == 0)
                {
                    rig.velocity = new Vector2(currentVelX, rig.velocity.y);
                }
            }
        }

        if (col.gameObject.tag == "Spikes")
        {
            Die();
        }
    }
}

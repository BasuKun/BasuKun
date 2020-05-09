using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMagnetism : MonoBehaviour
{
    private Rigidbody2D rig;
    private GameObject dragon;
    private Vector2 dragonDirection;
    private float timeStamp;
    private float buildup;
    private bool isgettingAbsorbed;

    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        dragon = GameObject.Find("Dragon");
    }

    void Update()
    {
        if (isgettingAbsorbed)
        {
            bubbleMagnet();
        }
        isgettingAbsorbed = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "AbsorbArea")
        {
            buildup = 0;
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "AbsorbArea")
        {
            timeStamp = Time.time;
            buildup += Time.deltaTime;
            bubbleMagnet();
        }

        else if (col.gameObject.tag == "Dragon")
        {
            GameManager.instance.bubbleAmount++;
            GameUI.instance.UpdateBubbleAmountUI();
            Destroy(gameObject);
        }
    }

    void bubbleMagnet()
    {
        dragonDirection = -(transform.position - dragon.transform.position).normalized;
        rig.velocity = new Vector2(dragonDirection.x, dragonDirection.y) * (buildup + 0.1f) * 2f * (Time.time / timeStamp);
    }
}

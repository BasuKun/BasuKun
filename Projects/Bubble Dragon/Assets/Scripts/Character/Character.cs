using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject spawnPoint;
    public Transform bubblesHolder;

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
        if (col.gameObject.tag == "Spikes")
        {
            Die();
        }
    }
}

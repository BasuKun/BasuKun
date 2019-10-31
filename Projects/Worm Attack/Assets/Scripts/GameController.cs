using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject boxPrefab;
    public int tileSize = 32;
    public float boxChance = 0.1f;

    void Start()
    {
        for (int y = Screen.height / 2 - tileSize; y > -Screen.height / 2 + tileSize * 2; y -= tileSize)
        {
            for (int x = Screen.width /2 - tileSize; x > -Screen.width / 2 + tileSize; x -= tileSize)
            {
                if (Random.value < boxChance)
                {
                    GameObject boxInstance = Instantiate(boxPrefab);
                    boxInstance.transform.SetParent(transform);
                    boxInstance.transform.position = new Vector2((x - tileSize / 2) / 100f, (y - tileSize / 2) / 100f);
                }
            }
        }
    }
}

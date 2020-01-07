using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour
{
    public List<GameObject> snowflakes = new List<GameObject>();
    public GameObject spawner;
    public float spawnInterval = 8.5f;

    void Update()
    {
        spawnInterval -= Time.deltaTime * GameManager.Instance.spawnSpeed;

        if (spawnInterval <= 0f)
        {
            GameObject sf = Instantiate(snowflakes[0].gameObject, new Vector2(
                Random.Range(-Screen.width / 150f, Screen.width / 150f), 
                Random.Range(Screen.height / 142f, Screen.height / 144f)), 
                transform.rotation);
            sf.transform.parent = spawner.transform;

            spawnInterval = 8.5f;
        }
    }
}

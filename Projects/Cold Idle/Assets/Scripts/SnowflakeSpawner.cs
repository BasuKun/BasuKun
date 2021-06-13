using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour
{
    public List<GameObject> snowflakesTypes = new List<GameObject>();
    public List<GameObject> currentSnowflakesList = new List<GameObject>();
    public GameObject spawner;
    public float spawnInterval = 8.5f;
    public float screenWidth = 1280;
    public float screenHeight = 720;

    public static SnowflakeSpawner Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        spawnInterval -= Time.deltaTime * GameManager.Instance.GMData.spawnSpeed;

        if (spawnInterval <= 0f)
        {
            int index = RollForGleamingSnowflake();

            GameObject sf = Instantiate(snowflakesTypes[index].gameObject, new Vector2(
                Random.Range(-screenWidth / 150f, screenWidth / 150f), 
                Random.Range(screenHeight / 142f, screenHeight / 144f)), 
                transform.rotation);
            sf.transform.parent = spawner.transform;

            currentSnowflakesList.Add(sf);

            spawnInterval = GameManager.Instance.GMData.initialSpawnInterval;
        }
    }

    int RollForGleamingSnowflake()
    {
        int doubleChance = Random.Range(1, 201);
        int index;

        if (doubleChance <= GameManager.Instance.GMData.doubleValueChance + Powerups.Instance.LuckyWinter())
        {
            index = 1; //get a gleaming snowflake
        }
        else
        {
            index = 0; //get a normal snowflake
        }

        return index;
    }
}

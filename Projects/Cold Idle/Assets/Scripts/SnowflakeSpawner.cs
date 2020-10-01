using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour
{
    public List<GameObject> snowflakesTypes = new List<GameObject>();
    public List<GameObject> currentSnowflakesList = new List<GameObject>();
    public GameObject spawner;
    public float spawnInterval = 8.5f;

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
        spawnInterval -= Time.deltaTime * GameManager.Instance.spawnSpeed;

        if (spawnInterval <= 0f)
        {
            int index = RollForGleamingSnowflake();

            GameObject sf = Instantiate(snowflakesTypes[index].gameObject, new Vector2(
                Random.Range(-Screen.width / 150f, Screen.width / 150f), 
                Random.Range(Screen.height / 142f, Screen.height / 144f)), 
                transform.rotation);
            sf.transform.parent = spawner.transform;

            currentSnowflakesList.Add(sf);

            spawnInterval = 8.5f;
        }
    }

    int RollForGleamingSnowflake()
    {
        int doubleChance = Random.Range(1, 201);
        int index;

        if (doubleChance <= GameManager.Instance.doubleValueChance + Powerups.Instance.LuckyWinter(GameManager.Instance.equippedLuckyWinter))
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

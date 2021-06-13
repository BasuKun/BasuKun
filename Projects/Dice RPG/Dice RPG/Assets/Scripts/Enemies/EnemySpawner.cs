using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform moveLocation;
    public List<Enemy> enemiesList = new List<Enemy>();
    public Dictionary<string, GameObject> enemiesDict = new Dictionary<string, GameObject>();

    public static EnemySpawner Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        PopulateDictionary();
    }

    private void PopulateDictionary()
    {
        foreach (Enemy enemy in enemiesList)
        {
            enemiesDict.Add(enemy.enemyName, enemy.gameObject);
        }
    }

    public void SpawnEnemy(string name)
    {
        GameObject enemy = Instantiate(enemiesDict[name], transform.position, Quaternion.identity);
        StartCoroutine(enemy.GetComponent<Enemy>().MoveToFightLocation());
    }
}

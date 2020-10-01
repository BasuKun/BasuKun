using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Habitats : MonoBehaviour
{
    public SnowflakeSpawner snowflakeSpawner;
    public ShovelButton ShovelButton;
    public float autoShovelInterval = 5f;
    public float autoCollectInterval = 5f;

    void Update()
    {
        if (GameManager.Instance.shovelersAmount > 0)
        {
            Shovelers();
        }
        if (GameManager.Instance.collectorsAmount > 0)
        {
            SnowCollectors();
        }
        if (PileHandler.Instance.pileDict.Count <= 0 && autoShovelInterval != 5f)
        {
            autoShovelInterval = 5f;
        }
        if (snowflakeSpawner.currentSnowflakesList.Count <= 0 && autoCollectInterval != 5f)
        {
            autoCollectInterval = 5f;
        }
    }

    public void AddOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount--;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount++;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 1000f);
                GameUI.Instance.shovelersUpdateText();
                break;
            case "collector":
                GameManager.Instance.collectorsAmount++;
                GameManager.Instance.autoCollectSpeed = (float)(GameManager.Instance.collectorsAmount / 1000f);
                GameUI.Instance.collectorsUpdateText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void RemoveOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount++;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount--;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 500f);
                GameUI.Instance.shovelersUpdateText();
                break;
            case "collector":
                GameManager.Instance.collectorsAmount--;
                GameManager.Instance.autoCollectSpeed = (float)(GameManager.Instance.collectorsAmount / 500f);
                GameUI.Instance.collectorsUpdateText();
                break;
        }

        GameUI.Instance.idlePopulationUpdateText();
    }

    public void Shovelers()
    {
        autoShovelInterval -= Time.deltaTime + GameManager.Instance.autoShovelSpeed;

        if (autoShovelInterval <= 0 && PileHandler.Instance.pileDict.Count > 0)
        {
            ShovelButton.ShovelSnow();
            autoShovelInterval = 5f;
        }
    }

    public void SnowCollectors()
    {
        autoCollectInterval -= Time.deltaTime + GameManager.Instance.autoCollectSpeed;

        if (autoCollectInterval <= 0 && snowflakeSpawner.currentSnowflakesList.Count > 0)
        {
            System.Random rand = new System.Random();
            int index = rand.Next(0, snowflakeSpawner.currentSnowflakesList.Count);

            if (snowflakeSpawner.currentSnowflakesList[index] != null)
            {
                Snowflake sf = snowflakeSpawner.currentSnowflakesList[index].GetComponent<Snowflake>();
                sf.isSelectedByCollector = true;

                GameManager.Instance.collectSnowflakes(GameManager.Instance.snowflakeValue, sf.isDouble ? true : false, sf.transform.position);
                sf.DestroySnowflake(true);
            }

            autoCollectInterval = 5f;
        }
    }
}

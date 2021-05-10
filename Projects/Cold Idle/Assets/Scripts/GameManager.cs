using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SnowflakeSpawner snowflakeSpawner;
    public GameObject currencyGainPopout;
    public Canvas popoutsCanvas;
    public Data GMData = new Data();

    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        SetData();
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("GameManager"))
        {
            GMData.spawnSpeed = 3f;
            GMData.snowflakeValue = 1;
            GMData.snowflakeExtraValue = 0;
            GMData.radius = 0.1f;
            GMData.shovelSpeed = 2f;
            GMData.snowpileHeightLimit = -4.5f;
            GMData.doubleValueChance = 0;
            GMData.maxTierAllowed = 1;
            GMData.absorbedSnowflakesAmount = 1;
            GMData.obtainedIntelligenceAmount = 1;
            GMData.snowflakesAmount = 0;
            GMData.intelligencePointsAmount = 0;
            GMData.iceBlocksAmount = 0;
            GMData.blessingPointsAmount = 0;
            GMData.absorbedSnowflakes = 0;
            GMData.habitatsAmount = 0;
            GMData.habitatsExtraAmount = 0;
            GMData.idlePopulationAmount = 0;
            GMData.shovelersAmount = 0;
            GMData.collectorsAmount = 0;
            GMData.transplantersAmount = 0;
            GMData.cryogenicsAmount = 0;
            GMData.worshippersAmount = 0;
            GMData.newPowerupUnlockChance = 1f;
            GMData.newPowerupCurrentChance = 0f;
            GMData.temperature = 0;
            GMData.tempMultiplier = 1;
            GMData.maxPowerups = 1;
            GMData.equippedPowerups = 0;
            GMData.initialSpawnInterval = 8.5f;

            string data = JsonUtility.ToJson(GMData);
            PlayerPrefs.SetString("GameManager", data);
        }
        else
        {
            string data = PlayerPrefs.GetString("GameManager");
            GMData = JsonUtility.FromJson<Data>(data);
            MouseRadius.Instance.UpdateRadius();
        }
    }

    public void collectSnowflakes(double value, bool isDouble, bool wasShoveled, Vector3 pos)
    {
        double valueToAdd;

        if (!wasShoveled)
        {
            valueToAdd = Math.Round(value * Powerups.Instance.SnowflakeBooster() *
            (isDouble ? 2 + Powerups.Instance.BlessedSnowflakes() : 1) *
            Powerups.Instance.SnowstormSeeker() *
            ConquerRewards.Instance.data.sfReward *
            GMData.tempMultiplier);
        }
        else
        {
            valueToAdd = Math.Round(value * GMData.tempMultiplier);
        }
        GMData.snowflakesAmount += valueToAdd;
        GameUI.Instance.snowflakesUpdateText();
        currencyPopout('+', pos, valueToAdd, "SF", GameUI.Instance.snowflakesColor);
    }

    public void collectIceBlocks(double value, Vector3 pos)
    {
        double valueToAdd = Math.Round(value * Powerups.Instance.SnowpileFreezer() * ConquerRewards.Instance.data.ibReward * GMData.tempMultiplier);
        GMData.iceBlocksAmount += valueToAdd;
        GameUI.Instance.iceBlocksUpdateText();
        currencyPopout('+', pos, valueToAdd, "IB", GameUI.Instance.iceBlocksColor);
    }

    public void currencyPopout(char sign, Vector3 pos, double value, string currency, Color color)
    {
        Vector3 posOffset = new Vector3(pos.x, pos.y + 0.1f, pos.z);
        GameObject popout = Instantiate(currencyGainPopout, Camera.main.WorldToScreenPoint(posOffset), Quaternion.identity, popoutsCanvas.transform);
        popout.GetComponent<CurrencyGainPopout>().UpdateText(sign, value, currency, color);
    }

    public void textPopout(Vector3 pos, string text, Color color)
    {
        Vector3 posOffset = new Vector3(pos.x, pos.y + 0.1f, pos.z);
        GameObject popout = Instantiate(currencyGainPopout, Camera.main.WorldToScreenPoint(posOffset), Quaternion.identity, popoutsCanvas.transform);
        popout.GetComponent<CurrencyGainPopout>().UpdateTextNoDigit(text, color);
    }
}

[Serializable]
public struct Data
{
    [Header("UPGRADES")]
    public float spawnSpeed;
    public double snowflakeValue;
    public double snowflakeExtraValue;
    public float radius;
    public float shovelSpeed;
    public float snowpileHeightLimit;
    public int doubleValueChance;
    public int maxTierAllowed;
    public int absorbedSnowflakesAmount;
    public int obtainedIntelligenceAmount;

    [Header("CURRENCIES")]
    public double snowflakesAmount;
    public double intelligencePointsAmount;
    public double iceBlocksAmount;
    public double blessingPointsAmount;

    [Header("OTHERS")]
    public int absorbedSnowflakes;
    public float initialSpawnInterval;

    [Header("HABITATS")]
    public double habitatsAmount;
    public double habitatsExtraAmount;
    public double idlePopulationAmount;
    public double shovelersAmount;
    public double collectorsAmount;
    public double transplantersAmount;
    public double worshippersAmount;
    public double cryogenicsAmount;
    public float autoShovelSpeed;
    public float autoCollectSpeed;
    public float autoAbsorbSpeed;
    public float newPowerupUnlockChance;
    public float newPowerupCurrentChance;
    public float temperature;
    public float tempMultiplier;

    [Header("POWERUPS")]
    public int maxPowerups;
    public int equippedPowerups;
}

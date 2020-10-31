using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UPGRADES")]
    public float spawnSpeed = 3f;
    public double snowflakeValue = 1;
    public float radius = 0.1f;
    public float shovelSpeed = 2f;
    public float snowpileHeightLimit = -4.5f;
    public int doubleValueChance = 0;
    public int maxTierAllowed = 1;
    public int absorbedSnowflakesAmount = 1;
    public int obtainedIntelligenceAmount = 1;

    [Header("CURRENCIES")]
    public double snowflakesAmount = 0;
    public double intelligencePointsAmount = 0;
    public double iceBlocksAmount = 0;
    public double blessingPointsAmount = 0;

    [Header("OTHERS")]
    public int absorbedSnowflakes = 0;

    [Header("HABITATS")]
    public double habitatsAmount = 0;
    public double idlePopulationAmount = 0;
    public double shovelersAmount = 0;
    public double collectorsAmount = 0;
    public double transplantersAmount = 0;
    public double worshippersAmount = 0;
    public float autoShovelSpeed;
    public float autoCollectSpeed;
    public float autoAbsorbSpeed;
    public float newPowerupUnlockChance = 1f;
    public float newPowerupCurrentChance = 0f;

    [Header("POWERUPS")]
    public int maxPowerups = 1;
    public int equippedPowerups = 0;

    public SnowflakeSpawner snowflakeSpawner;
    public GameObject currencyGainPopout;
    public Canvas popoutsCanvas;
    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void collectSnowflakes(double value, bool isDouble, bool wasShoveled, Vector3 pos)
    {
        double valueToAdd;

        if (!wasShoveled)
        {
            valueToAdd = Math.Round(value * Powerups.Instance.SnowflakeBooster() *
            (isDouble ? 2 + Powerups.Instance.BlessedSnowflakes() : 1) *
            Powerups.Instance.SnowstormSeeker());
        }
        else
        {
            valueToAdd = Math.Round(value);
        }
        snowflakesAmount += valueToAdd;
        GameUI.Instance.snowflakesUpdateText();
        currencyPopout(pos, valueToAdd, "SF", GameUI.Instance.snowflakesColor);
    }

    public void collectIceBlocks(double value, Vector3 pos)
    {
        double valueToAdd = Math.Round(value * Powerups.Instance.SnowpileFreezer());
        iceBlocksAmount += valueToAdd;
        GameUI.Instance.iceBlocksUpdateText();
        currencyPopout(pos, valueToAdd, "IB", GameUI.Instance.iceBlocksColor);
    }

    public void currencyPopout(Vector3 pos, double value, string currency, Color color)
    {
        Vector3 posOffset = new Vector3(pos.x, pos.y + 0.1f, pos.z);
        GameObject popout = Instantiate(currencyGainPopout, Camera.main.WorldToScreenPoint(posOffset), Quaternion.identity, popoutsCanvas.transform);
        popout.GetComponent<CurrencyGainPopout>().UpdateText(value, currency, color);
    }
}

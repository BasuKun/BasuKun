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
    public float snowpileHeightLimit = -4f;
    public int doubleValueChance = 0;

    [Header("CURRENCIES")]
    public double snowflakesAmount = 0;
    public double intelligencePointsAmount = 0;
    public double iceBlocksAmount = 0;

    [Header("OTHERS")]
    public int absorbedSnowflakes = 0;

    [Header("HABITATS")]
    public double habitatsAmount = 0;
    public double idlePopulationAmount = 0;
    public double shovelersAmount = 0;
    public double collectorsAmount = 0;
    public float autoShovelSpeed;
    public float autoCollectSpeed;

    [Header("POWERUPS")]
    public int maxPowerups = 1;
    public int equippedPowerups = 0;
    public bool boughtSnowstormSeeker = false;
    public bool boughtSnowpileEnthusiast = false;
    public bool boughtSnowflakeBooster = false;
    public bool boughtShovelMaster = false;
    public bool boughtLuckyWinter = false;
    public bool boughtMountainMaker = false;
    public bool boughtBlessedSnowflakes = false;
    public bool boughtSnowpileFreezer = false;
    public bool equippedSnowstormSeeker = false;
    public bool equippedSnowpileEnthusiast = false;
    public bool equippedSnowflakeBooster = false;
    public bool equippedShovelMaster = false;
    public bool equippedLuckyWinter = false;
    public bool equippedMountainMaker = false;
    public bool equippedBlessedSnowflakes = false;
    public bool equippedSnowpileFreezer = false;

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

    public void collectSnowflakes(double value, bool isDouble, Vector3 pos)
    {
        double valueToAdd = (int)(value * Powerups.Instance.SnowflakeBooster(equippedSnowflakeBooster) *
            (isDouble ? 2 + Powerups.Instance.BlessedSnowflakes(equippedBlessedSnowflakes) : 1) *
            Powerups.Instance.SnowstormSeeker(equippedSnowstormSeeker));
        snowflakesAmount += valueToAdd;
        GameUI.Instance.snowflakesUpdateText();
        currencyPopout(pos, valueToAdd, "SF", GameUI.Instance.snowflakesColor);
    }

    public void collectIceBlocks(double value, Vector3 pos)
    {
        double valueToAdd = (int)value * Powerups.Instance.SnowpileFreezer(equippedSnowpileFreezer);
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

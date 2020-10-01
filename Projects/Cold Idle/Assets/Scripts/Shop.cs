using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public static Shop Instance;

    [Header("UPGRADES COSTS")]
    public double moreSnowCost = 10;
    public double biggerRadiusCost = 25;
    public double fasterShovelCost = 40;
    public double betterValueCost = 15;
    public double moreHabitatCost = 10;
    public double higherSnowpileCost = 50;
    public double moreGleamingSnowflakesCost = 25;

    [Header("POWERUPS COSTS")]
    public double snowstormSeekerCost = 100;
    public double snowpileEnthusiastCost = 100;
    public double snowflakeBoosterCost = 100;
    public double shovelMasterCost = 100;
    public double luckyWinterCost = 100;
    public double mountainMakerCost = 100;
    public double blessedSnowflakesCost = 100;
    public double snowpileFreezerCost = 100;

    [Header("POWERUPS EQUIP BUTTONS")]
    public List<Button> EquipButtonsList = new List<Button>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void BuyMoreSnow()
    {
        GameManager.Instance.snowflakesAmount -= moreSnowCost;
        moreSnowCost += (int)(moreSnowCost * 0.5f);
        GameManager.Instance.spawnSpeed += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.moreSnowButtonUpdateText();
    }

    public void BuyBetterValue()
    {
        GameManager.Instance.snowflakesAmount -= betterValueCost;
        betterValueCost += (int)(betterValueCost * 1.1f);
        GameManager.Instance.snowflakeValue += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.betterValueButtonUpdateText();
    }

    public void BiggerRadius()
    {
        GameManager.Instance.snowflakesAmount -= biggerRadiusCost;
        biggerRadiusCost += (int)(biggerRadiusCost * 1.2f);
        GameManager.Instance.radius += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.biggerRadiusButtonUpdateText();
    }

    public void FasterShovel()
    {
        GameManager.Instance.snowflakesAmount -= fasterShovelCost;
        fasterShovelCost += (int)(fasterShovelCost * 0.5f);
        GameManager.Instance.shovelSpeed -= (10f / 100f * GameManager.Instance.shovelSpeed);
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.fasterShovelButtonUpdateText();
    }

    public void MoreHabitat()
    {
        GameManager.Instance.iceBlocksAmount -= moreHabitatCost;
        moreHabitatCost += (int)(moreHabitatCost * 0.3f);
        GameManager.Instance.habitatsAmount += 1;
        GameManager.Instance.idlePopulationAmount += 1;
        GameUI.Instance.iceBlocksUpdateText();
        GameUI.Instance.moreHabitatButtonUpdateText();
        GameUI.Instance.populationUpdateText();
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void HigherSnowPile()
    {
        GameManager.Instance.iceBlocksAmount -= higherSnowpileCost;
        higherSnowpileCost += (int)(higherSnowpileCost * 1f);
        GameManager.Instance.snowpileHeightLimit += 0.25f;
        GameUI.Instance.iceBlocksUpdateText();
        GameUI.Instance.higherSnowpileButtonUpdateText();
    }

    public void MoreGleamingSnowflakes()
    {
        GameManager.Instance.snowflakesAmount -= moreGleamingSnowflakesCost;
        moreGleamingSnowflakesCost += (int)(moreGleamingSnowflakesCost * 0.4f);
        GameManager.Instance.doubleValueChance += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.moreGleamingSnowflakesButtonUpdateText();
    }

    public void BuySnowstormSeeker()
    {
        GameManager.Instance.intelligencePointsAmount -= snowstormSeekerCost;
        GameManager.Instance.boughtSnowstormSeeker = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.snowstormSeekerText.gameObject.SetActive(false);
        EquipButtonsList[0].gameObject.SetActive(true);
    }

    public void BuyLuckyWinter()
    {
        GameManager.Instance.intelligencePointsAmount -= luckyWinterCost;
        GameManager.Instance.boughtLuckyWinter = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.luckyWinterText.gameObject.SetActive(false);
        EquipButtonsList[1].gameObject.SetActive(true);
    }

    public void BuyBlessedSnowflakes()
    {
        GameManager.Instance.intelligencePointsAmount -= blessedSnowflakesCost;
        GameManager.Instance.boughtBlessedSnowflakes = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.blessedSnowflakesText.gameObject.SetActive(false);
        EquipButtonsList[2].gameObject.SetActive(true);
    }

    public void BuyShovelMaster()
    {
        GameManager.Instance.intelligencePointsAmount -= shovelMasterCost;
        GameManager.Instance.boughtShovelMaster = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.shovelMasterText.gameObject.SetActive(false);
        EquipButtonsList[3].gameObject.SetActive(true);
    }

    public void BuySnowflakeBooster()
    {
        GameManager.Instance.intelligencePointsAmount -= snowflakeBoosterCost;
        GameManager.Instance.boughtSnowflakeBooster = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.snowflakeBoosterText.gameObject.SetActive(false);
        EquipButtonsList[4].gameObject.SetActive(true);
    }

    public void BuySnowpileFreezer()
    {
        GameManager.Instance.intelligencePointsAmount -= snowpileFreezerCost;
        GameManager.Instance.boughtSnowpileFreezer = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.snowpileFreezerText.gameObject.SetActive(false);
        EquipButtonsList[5].gameObject.SetActive(true);
    }
}

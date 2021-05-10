using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public MouseRadius mouseRadius;
    public static Shop Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void BuyUpgrade(string name, float defaultBonus, float bonusPerTier, int tier)
    {
        switch (name)
        {
            case "More Snow":
                MoreSnow(defaultBonus, bonusPerTier, tier);
                break;
            case "Better Value":
                BetterValue(defaultBonus, bonusPerTier, tier);
                break;
            case "Bigger Radius":
                BiggerRadius(defaultBonus, bonusPerTier, tier);
                break;
            case "Faster Shovel":
                FasterShovel(defaultBonus, bonusPerTier, tier);
                break;
            case "More Habitat":
                MoreHabitat(defaultBonus, bonusPerTier, tier);
                break;
            case "Higher Snowpile":
                HigherSnowPile(defaultBonus, bonusPerTier, tier);
                break;
            case "More Shiny Snowflakes":
                MoreShinySnowflakes(defaultBonus, bonusPerTier, tier);
                break;
            case "More Blessings Slots":
                MorePowerupSlots(defaultBonus, bonusPerTier, tier);
                break;
            case "Better Absorb Ratio":
                BetterAbsorbRatio(defaultBonus, bonusPerTier, tier);
                break;
            default:
                break;
        }
    }

    public void MoreSnow(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.spawnSpeed += defaultBonus + (bonusPerTier * (tier - 1));
    }

    public void BetterValue(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.snowflakeValue += defaultBonus + GameManager.Instance.GMData.snowflakeExtraValue + (bonusPerTier * (tier - 1));
    }

    public void BiggerRadius(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.radius += defaultBonus + (bonusPerTier * (tier - 1));
        mouseRadius.UpdateRadius();
    }

    public void FasterShovel(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.shovelSpeed -= ((defaultBonus + (bonusPerTier * (tier - 1))) / 100f * GameManager.Instance.GMData.shovelSpeed);
    }

    public void MoreHabitat(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.habitatsAmount += defaultBonus + GameManager.Instance.GMData.habitatsExtraAmount + ConquerRewards.Instance.data.habitatReward + (bonusPerTier * (tier - 1));
        GameManager.Instance.GMData.idlePopulationAmount += defaultBonus + GameManager.Instance.GMData.habitatsExtraAmount + ConquerRewards.Instance.data.habitatReward + (bonusPerTier * (tier - 1));
        GameUI.Instance.populationUpdateText();
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void HigherSnowPile(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.snowpileHeightLimit += defaultBonus + (bonusPerTier * (tier - 1));
        PileHandler.Instance.MovePileHeightLimitArrow();
    }

    public void MoreShinySnowflakes(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.doubleValueChance += (int)(defaultBonus + (bonusPerTier * (tier - 1)));
    }

    public void MorePowerupSlots(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.maxPowerups += (int)(defaultBonus + (bonusPerTier * (tier - 1)));
        GameUI.Instance.CheckForMaxEquippedPowerups();
        GameUI.Instance.equippedPowerupUpdateText();
    }

    public void BetterAbsorbRatio(float defaultBonus, float bonusPerTier, int tier)
    {
        GameManager.Instance.GMData.absorbedSnowflakesAmount++;
        GameManager.Instance.GMData.obtainedIntelligenceAmount += (int)(defaultBonus + (bonusPerTier * (tier - 1)));
    }
}

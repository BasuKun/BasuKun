using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop Instance;

    [Header("COSTS")]
    public double moreSnowCost = 10;
    public double biggerRadiusCost = 25;
    public double fasterShovelCost = 40;
    public double betterValueCost = 15;
    public double moreHabitatCost = 10;

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
        fasterShovelCost += (int)(fasterShovelCost * 0.8f);
        GameManager.Instance.shovelSpeed -= (10f / 100f * GameManager.Instance.shovelSpeed);
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.fasterShovelButtonUpdateText();
    }

    public void MoreHabitat()
    {
        GameManager.Instance.iceBlocksAmount -= moreHabitatCost;
        moreHabitatCost += (int)(moreHabitatCost * 0.5f);
        GameManager.Instance.habitatsAmount += 1;
        GameManager.Instance.idlePopulationAmount += 1;
        GameUI.Instance.iceBlocksUpdateText();
        GameUI.Instance.moreHabitatButtonUpdateText();
        GameUI.Instance.populationUpdateText();
        GameUI.Instance.idlePopulationUpdateText();
    }
}

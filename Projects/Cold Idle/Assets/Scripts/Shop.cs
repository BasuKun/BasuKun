using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop Instance;

    [Header("COSTS")]
    public int moreSnowCost = 10;
    public int biggerRadiusCost = 25;

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
        moreSnowCost += (int)(moreSnowCost * 1.1f);
        GameManager.Instance.spawnSpeed += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.moreSnowButtonUpdateText();
    }

    public void BiggerRadius()
    {
        GameManager.Instance.snowflakesAmount -= biggerRadiusCost;
        biggerRadiusCost += (int)(biggerRadiusCost * 1.3f);
        GameManager.Instance.radius += 1;
        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.biggerRadiusButtonUpdateText();
    }
}

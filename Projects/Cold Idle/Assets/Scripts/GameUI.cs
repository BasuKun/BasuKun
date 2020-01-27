using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("BUTTONS TEXTS")]
    public TextMeshProUGUI moreSnowButtonText;
    public TextMeshProUGUI biggerRadiusButtonText;
    public TextMeshProUGUI fasterShovelButtonText;

    [Header("CURRENCIES")]
    public TextMeshProUGUI snowflakesAmountText;
    public TextMeshProUGUI IntelligencePointsAmountText;

    public static GameUI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        moreSnowButtonUpdateText();
        biggerRadiusButtonUpdateText();
        fasterShovelButtonUpdateText();
    }

    public void snowflakesUpdateText()
    {
        snowflakesAmountText.text = "SF: " + CurrencyLetterFormatting(GameManager.Instance.snowflakesAmount);
    }

    public void IntelligencePointsUpdateText()
    {
        IntelligencePointsAmountText.text = "IP: " + CurrencyLetterFormatting(GameManager.Instance.intelligencePoints);
    }

    public void moreSnowButtonUpdateText()
    {
        moreSnowButtonText.text = "More Snow! " + CurrencyLetterFormatting(Shop.Instance.moreSnowCost) + " SF";
    }

    public void biggerRadiusButtonUpdateText()
    {
        biggerRadiusButtonText.text = "Bigger Radius! " + CurrencyLetterFormatting(Shop.Instance.biggerRadiusCost) + " SF";
    }

    public void fasterShovelButtonUpdateText()
    {
        fasterShovelButtonText.text = "Faster Shovel! " + CurrencyLetterFormatting(Shop.Instance.fasterShovelCost) + " SF";
    }

    public string CurrencyLetterFormatting(double value)
    {
        if (value >= 10000000000000000)
        {
            return (value / 1000000000000000D).ToString("0.#Q");
        }
        if (value >= 1000000000000000)
        {
            return (value / 1000000000000000D).ToString("0.##Q");
        }
        if (value >= 10000000000000)
        {
            return (value / 1000000000000D).ToString("0.#t");
        }
        if (value >= 1000000000000)
        {
            return (value / 1000000000000D).ToString("0.##t");
        }
        if (value >= 10000000000)
        {
            return (value / 1000000000D).ToString("0.#B");
        }
        if (value >= 1000000000)
        {
            return (value / 1000000000D).ToString("0.##B");
        }
        if (value >= 100000000)
        {
            return (value / 1000000D).ToString("0.#M");
        }
        if (value >= 1000000)
        {
            return (value / 1000000D).ToString("0.##M");
        }
        if (value >= 100000)
        {
            return (value / 1000D).ToString("0.#K");
        }
        if (value >= 1000)
        {
            return (value / 1000D).ToString("0.##K");
        }
        return value.ToString("#,0");
    }
}

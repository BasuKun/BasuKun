using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("POWERUPS")]
    public TextMeshProUGUI equippedPowerupsText;

    [Header("CURRENCIES")]
    public TextMeshProUGUI snowflakesAmountText;
    public TextMeshProUGUI IntelligencePointsAmountText;
    public TextMeshProUGUI iceBlocksAmountText;
    public TextMeshProUGUI BlessingPointsAmountText;

    [Header("HABITATS TEXTS")]
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI idlePopulationText;
    public TextMeshProUGUI shovelersText;
    public TextMeshProUGUI collectorsText;
    public TextMeshProUGUI transplantersText;
    public TextMeshProUGUI worshippersText;

    [Header("COLORS")]
    public Color snowflakesColor = new Color(0.71f, 0.94f, 0.95f, 1);
    public Color intelligencePointsColor = new Color(0.90f, 0.61f, 0.85f, 1);
    public Color iceBlocksColor = new Color(0.26f, 0.67f, 0.76f, 1);
    public Color blessingPointsColor = new Color(0.86f, 0.87f, 0.76f, 1);

    public delegate void IBObtained();
    public static event IBObtained OnIBObtained;

    public delegate void IPObtained();
    public static event IPObtained OnIPObtained;

    public delegate void BPObtained();
    public static event BPObtained OnBPObtained;

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
        equippedPowerupUpdateText();

        populationUpdateText();

        snowflakesAmountText.color = snowflakesColor;
        iceBlocksAmountText.color = iceBlocksColor;
        IntelligencePointsAmountText.color = intelligencePointsColor;
        BlessingPointsAmountText.color = blessingPointsColor;
    }

    public void snowflakesUpdateText()
    {
        snowflakesAmountText.text = "SF: " + CurrencyLetterFormatting(GameManager.Instance.snowflakesAmount);
    }

    public void iceBlocksUpdateText()
    {
        if (OnIBObtained != null) OnIBObtained();
        iceBlocksAmountText.text = "IB: " + CurrencyLetterFormatting(GameManager.Instance.iceBlocksAmount);
    }

    public void IntelligencePointsUpdateText()
    {
        if (OnIPObtained != null) OnIPObtained();
        IntelligencePointsAmountText.text = "IP: " + CurrencyLetterFormatting(GameManager.Instance.intelligencePointsAmount);
    }

    public void BlessingPointsUpdateText()
    {
        if (OnBPObtained != null) OnBPObtained();
        BlessingPointsAmountText.text = "BP: " + CurrencyLetterFormatting(GameManager.Instance.blessingPointsAmount);
    }

    public void equippedPowerupUpdateText()
    {
        equippedPowerupsText.text = "Equipped: " + GameManager.Instance.equippedPowerups + "/" + GameManager.Instance.maxPowerups;
    }

    public void populationUpdateText()
    {
        populationText.text = "Population: " + CurrencyLetterFormatting(GameManager.Instance.habitatsAmount);
    }

    public void idlePopulationUpdateText()
    {
        idlePopulationText.text = "Idle: " + CurrencyLetterFormatting(GameManager.Instance.idlePopulationAmount);
    }

    public void shovelersUpdateText()
    {
        shovelersText.text = "Shovellers: " + CurrencyLetterFormatting(GameManager.Instance.shovelersAmount);
    }

    public void collectorsUpdateText()
    {
        collectorsText.text = "Collectors: " + CurrencyLetterFormatting(GameManager.Instance.collectorsAmount);
    }

    public void transplantersUpdateText()
    {
        transplantersText.text = "Absorbers: " + CurrencyLetterFormatting(GameManager.Instance.transplantersAmount);
    }

    public void worshippersUpdateText()
    {
        worshippersText.text = "Worshippers: " + CurrencyLetterFormatting(GameManager.Instance.worshippersAmount);
    }

    public void CheckForMaxEquippedPowerups()
    {
        foreach (PowerupsButton button in Powerups.Instance.PowerupsButtonsList)
        {
            if (GameManager.Instance.equippedPowerups == GameManager.Instance.maxPowerups)
            {
                button.equipButton.interactable = button.isEquipped;
            }
            else
            {
                button.equipButton.interactable = true;
            }
        }
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

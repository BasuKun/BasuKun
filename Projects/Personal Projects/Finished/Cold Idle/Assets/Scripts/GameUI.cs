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
    public TextMeshProUGUI cryogenicsText;

    [Header("OTHERS")]
    public TextMeshProUGUI temperatureText;
    public TextMeshProUGUI unlocksRemainingText;
    public bool hasClickedBP = false;

    [Header("COLORS")]
    public Color snowflakesColor = new Color(0.71f, 0.94f, 0.95f, 1);
    public Color intelligencePointsColor = new Color(0.90f, 0.61f, 0.85f, 1);
    public Color iceBlocksColor = new Color(0.26f, 0.67f, 0.76f, 1);
    public Color blessingPointsColor = new Color(0.86f, 0.87f, 0.76f, 1);

    public delegate void SFObtained();
    public static event SFObtained OnSFObtained;

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
        unlocksRemainingUpdateText();
        if (GameManager.Instance.GMData.snowflakesAmount > 0) snowflakesUpdateText();

        snowflakesAmountText.color = snowflakesColor;
        iceBlocksAmountText.color = iceBlocksColor;
        IntelligencePointsAmountText.color = intelligencePointsColor;
        BlessingPointsAmountText.color = blessingPointsColor;
    }

    public void snowflakesUpdateText()
    {
        if (OnSFObtained != null) OnSFObtained();
        snowflakesAmountText.text = "SF: " + CurrencyLetterFormatting(GameManager.Instance.GMData.snowflakesAmount);
    }

    public void iceBlocksUpdateText()
    {
        if (OnIBObtained != null) OnIBObtained();
        iceBlocksAmountText.text = "IB: " + CurrencyLetterFormatting(GameManager.Instance.GMData.iceBlocksAmount);
    }

    public void IntelligencePointsUpdateText()
    {
        if (OnIPObtained != null) OnIPObtained();
        IntelligencePointsAmountText.text = "IP: " + CurrencyLetterFormatting(GameManager.Instance.GMData.intelligencePointsAmount);
    }

    public void BlessingPointsUpdateText()
    {
        if (OnBPObtained != null) OnBPObtained();
        BlessingPointsAmountText.text = "BP: " + CurrencyLetterFormatting(GameManager.Instance.GMData.blessingPointsAmount);
    }

    public void equippedPowerupUpdateText()
    {
        equippedPowerupsText.text = "Equipped: " + GameManager.Instance.GMData.equippedPowerups + "/" + GameManager.Instance.GMData.maxPowerups;
    }

    public void populationUpdateText()
    {
        populationText.text = "Population: " + CurrencyLetterFormatting(GameManager.Instance.GMData.habitatsAmount);
    }

    public void idlePopulationUpdateText()
    {
        idlePopulationText.text = "Idle: " + CurrencyLetterFormatting(GameManager.Instance.GMData.idlePopulationAmount);
    }

    public void shovelersUpdateText()
    {
        shovelersText.text = "Shovellers: " + CurrencyLetterFormatting(GameManager.Instance.GMData.shovelersAmount);
    }

    public void collectorsUpdateText()
    {
        collectorsText.text = "Collectors: " + CurrencyLetterFormatting(GameManager.Instance.GMData.collectorsAmount);
    }

    public void transplantersUpdateText()
    {
        transplantersText.text = "Absorbers: " + CurrencyLetterFormatting(GameManager.Instance.GMData.transplantersAmount);
    }

    public void worshippersUpdateText()
    {
        worshippersText.text = "Worshippers: " + CurrencyLetterFormatting(GameManager.Instance.GMData.worshippersAmount);
    }

    public void cryogenicsUpdateText()
    {
        cryogenicsText.text = "Cryogenics: " + CurrencyLetterFormatting(GameManager.Instance.GMData.cryogenicsAmount);
    }

    public void temperatureUpdateText()
    {
        temperatureText.text = "Temperature: " + GameManager.Instance.GMData.temperature.ToString("F1") + "°C";
    }

    public void conquerSFRewardUpdateText()
    {
        ConquerRewards.Instance.sfRewardText.text = "* x" + ConquerRewards.Instance.data.sfReward.ToString("F1") + " SF";
    }

    public void conquerIBRewardUpdateText()
    {
        ConquerRewards.Instance.ibRewardText.text = "* x" + ConquerRewards.Instance.data.ibReward.ToString("F1") + " IB";
    }

    public void conquerIPRewardUpdateText()
    {
        ConquerRewards.Instance.ipRewardText.text = "* x" + ConquerRewards.Instance.data.ipReward + " IP";
    }

    public void conquerBPRewardUpdateText()
    {
        ConquerRewards.Instance.bpRewardText.text = "* x" + ConquerRewards.Instance.data.bpReward + " BP";
    }

    public void conquerHabitatRewardUpdateText()
    {
        ConquerRewards.Instance.habitatRewardText.text = "* +" + ConquerRewards.Instance.data.habitatReward + " Habitat";
    }

    public void completedPercentageUpdateText()
    {
        LocationSelection.Instance.completedPercentageText.text = "Completed: " + LocationSelection.Instance.data.completionPercentage + "%";
    }

    public void currentUniverseUpdateText()
    {
        LocationSelection.Instance.currentUniverseText.text = "Universe: " + Player.Instance.data.currentUniverse;
    }

    public void unlocksRemainingUpdateText()
    {
        unlocksRemainingText.text = "Unlocks remaining: " + UnlocksListHandler.Instance.UnlocksButtonsList.Count;
    }

    public void CheckForMaxEquippedPowerups()
    {
        foreach (PowerupsButton button in Powerups.Instance.PowerupsButtonsList)
        {
            if (GameManager.Instance.GMData.equippedPowerups == GameManager.Instance.GMData.maxPowerups)
            {
                button.equipButton.interactable = button.data.isEquipped;
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

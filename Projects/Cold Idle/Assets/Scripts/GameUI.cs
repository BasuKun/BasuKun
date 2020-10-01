using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("UPGRADES TEXTS")]
    public TextMeshProUGUI moreSnowButtonText;
    public TextMeshProUGUI betterValueButtonText;
    public TextMeshProUGUI biggerRadiusButtonText;
    public TextMeshProUGUI fasterShovelButtonText;
    public TextMeshProUGUI moreHabitatButtonText;
    public TextMeshProUGUI higherSnowpileButtonText;
    public TextMeshProUGUI moreGleamingSnowflakesButtonText;

    [Header("POWERUPS")]
    public TextMeshProUGUI equippedPowerupsText;
    public TextMeshProUGUI snowstormSeekerText;
    public TextMeshProUGUI luckyWinterText;
    public TextMeshProUGUI blessedSnowflakesText;
    public TextMeshProUGUI shovelMasterText;
    public TextMeshProUGUI snowflakeBoosterText;
    public TextMeshProUGUI snowpileFreezerText;

    [Header("CURRENCIES")]
    public TextMeshProUGUI snowflakesAmountText;
    public TextMeshProUGUI IntelligencePointsAmountText;
    public TextMeshProUGUI iceBlocksAmountText;

    [Header("HABITATS TEXTS")]
    public TextMeshProUGUI populationText;
    public TextMeshProUGUI idlePopulationText;
    public TextMeshProUGUI shovelersText;
    public TextMeshProUGUI collectorsText;

    [Header("COLORS")]
    public Color snowflakesColor = new Color(0.71f, 0.94f, 0.95f, 1);
    public Color intelligencePointsColor = new Color(0.90f, 0.61f, 0.85f, 1);
    public Color iceBlocksColor = new Color(0.26f, 0.67f, 0.76f, 1);

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
        betterValueButtonUpdateText();
        biggerRadiusButtonUpdateText();
        fasterShovelButtonUpdateText();
        moreHabitatButtonUpdateText();
        higherSnowpileButtonUpdateText();
        moreGleamingSnowflakesButtonUpdateText();

        equippedPowerupUpdateText();
        snowstormSeekerUpdateText();
        luckyWinterUpdateText();
        blessedSnowflakesUpdateText();
        shovelMasterUpdateText();
        snowflakeBoosterUpdateText();
        snowpileFreezerUpdateText();

        populationUpdateText();

        snowflakesAmountText.color = snowflakesColor;
        iceBlocksAmountText.color = iceBlocksColor;
        IntelligencePointsAmountText.color = intelligencePointsColor;
    }

    public void snowflakesUpdateText()
    {
        snowflakesAmountText.text = "SF: " + CurrencyLetterFormatting(GameManager.Instance.snowflakesAmount);
    }

    public void iceBlocksUpdateText()
    {
        iceBlocksAmountText.text = "IB: " + CurrencyLetterFormatting(GameManager.Instance.iceBlocksAmount);
    }

    public void IntelligencePointsUpdateText()
    {
        IntelligencePointsAmountText.text = "IP: " + CurrencyLetterFormatting(GameManager.Instance.intelligencePointsAmount);
    }

    public void moreSnowButtonUpdateText()
    {
        moreSnowButtonText.text = "<color=#B5F0F2>" + CurrencyLetterFormatting(Shop.Instance.moreSnowCost) + " SF</color>";
    }

    public void betterValueButtonUpdateText()
    {
        betterValueButtonText.text = "<color=#B5F0F2>" + CurrencyLetterFormatting(Shop.Instance.betterValueCost) + " SF</color>";
    }

    public void biggerRadiusButtonUpdateText()
    {
        biggerRadiusButtonText.text = "<color=#B5F0F2>" + CurrencyLetterFormatting(Shop.Instance.biggerRadiusCost) + " SF</color>";
    }

    public void fasterShovelButtonUpdateText()
    {
        fasterShovelButtonText.text = "<color=#B5F0F2>" + CurrencyLetterFormatting(Shop.Instance.fasterShovelCost) + " SF</color>";
    }

    public void moreHabitatButtonUpdateText()
    {
        moreHabitatButtonText.text = "<color=#42ABC2>" + CurrencyLetterFormatting(Shop.Instance.moreHabitatCost) + " IB</color>";
    }

    public void higherSnowpileButtonUpdateText()
    {
        higherSnowpileButtonText.text = "<color=#42ABC2>" + CurrencyLetterFormatting(Shop.Instance.higherSnowpileCost) + " IB</color>";
    }

    public void moreGleamingSnowflakesButtonUpdateText()
    {
        moreGleamingSnowflakesButtonText.text = "<color=#B5F0F2>" + CurrencyLetterFormatting(Shop.Instance.moreGleamingSnowflakesCost) + " SF</color>";
    }

    public void snowstormSeekerUpdateText()
    {
        snowstormSeekerText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.snowstormSeekerCost) + " IP</color>";
    }

    public void luckyWinterUpdateText()
    {
        luckyWinterText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.luckyWinterCost) + " IP</color>";
    }

    public void blessedSnowflakesUpdateText()
    {
        blessedSnowflakesText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.blessedSnowflakesCost) + " IP</color>";
    }

    public void shovelMasterUpdateText()
    {
        shovelMasterText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.shovelMasterCost) + " IP</color>";
    }

    public void snowflakeBoosterUpdateText()
    {
        snowflakeBoosterText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.snowflakeBoosterCost) + " IP</color>";
    }

    public void snowpileFreezerUpdateText()
    {
        snowpileFreezerText.text = "<color=#E69CD9>" + CurrencyLetterFormatting(Shop.Instance.snowpileFreezerCost) + " IP</color>";
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
        shovelersText.text = "Shovelers: " + CurrencyLetterFormatting(GameManager.Instance.shovelersAmount);
    }

    public void collectorsUpdateText()
    {
        collectorsText.text = "Collectors: " + CurrencyLetterFormatting(GameManager.Instance.collectorsAmount);
    }

    public void CheckForMaxEquippedPowerups()
    {
        foreach (Button button in Shop.Instance.EquipButtonsList)
        {
            if (GameManager.Instance.equippedPowerups == GameManager.Instance.maxPowerups)
            {
                TextMeshProUGUI equipText = button.GetComponentInChildren<TextMeshProUGUI>();
                button.interactable = equipText.text == "Unequip" ? true : false;
            }
            else
            {
                button.interactable = true;
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

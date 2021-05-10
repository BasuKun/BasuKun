using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnMouseOverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [TextArea] public string description;

    private string textToSend;

    public bool isUpgradeButton;
    public bool isUnlock;
    public bool isPowerupButton;
    public bool isHabitat;
    public bool isSimpleText;
    public bool isBeingChecked;

    void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        if (isUpgradeButton)
        {
            textToSend = UpgradeText();
        }
        if (isPowerupButton)
        {
            textToSend = PowerupText();
        }
        if (isHabitat)
        {
            textToSend = HabitatText();
        }
        if (isSimpleText)
        {
            textToSend = description;
        }
        if (isUnlock)
        {
            textToSend = description;
        }
    }

    string UpgradeText()
    {
        bool isRatio = false;
        UpgradesButton upgradesButton = GetComponent<UpgradesButton>();
        string text;
        double currentBonus = 0;
        double nextBonus = 0;
        double secondCurrentBonus = 0;
        double secondNextBonus = 0;
        string currentRatio = "";
        string nextRatio = "";

        switch (upgradesButton.name)
        {
            case "More Snow":
                currentBonus = Mathf.Round((GameManager.Instance.GMData.initialSpawnInterval / GameManager.Instance.GMData.spawnSpeed) * 1000.00f) / 1000.00f;
                nextBonus = Mathf.Round((GameManager.Instance.GMData.initialSpawnInterval / 
                    (GameManager.Instance.GMData.spawnSpeed + upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1)))) * 1000.00f) / 1000.00f;
                break;
            case "Better Value":
                currentBonus = GameManager.Instance.GMData.snowflakeValue;
                nextBonus = GameManager.Instance.GMData.snowflakeValue + GameManager.Instance.GMData.snowflakeExtraValue + upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1));
                break;
            case "Bigger Radius":
                currentBonus = Mathf.Round(GameManager.Instance.GMData.radius * 1000.0f) / 1000.0f;
                nextBonus = Mathf.Round((GameManager.Instance.GMData.radius + upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1))) * 1000.0f) / 1000.0f;
                break;
            case "Faster Shovel":
                currentBonus = Mathf.Round(GameManager.Instance.GMData.shovelSpeed * 1000.00f) / 1000.00f;
                nextBonus = Mathf.Round((GameManager.Instance.GMData.shovelSpeed - 
                    ((upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1))) / 100f * GameManager.Instance.GMData.shovelSpeed)) * 1000.00f) / 1000.00f;
                break;
            case "More Habitat":
                currentBonus = GameManager.Instance.GMData.habitatsAmount;
                nextBonus = GameManager.Instance.GMData.habitatsAmount + GameManager.Instance.GMData.habitatsExtraAmount + upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1));
                break;
            case "Higher Snowpile":
                currentBonus = 2 + upgradesButton.data.level;
                nextBonus = 2 + upgradesButton.data.level + 1;
                break;
            case "More Shiny Snowflakes":
                currentBonus = GameManager.Instance.GMData.doubleValueChance * 0.5f;
                nextBonus = (GameManager.Instance.GMData.doubleValueChance + (int)(upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1)))) * 0.5f;
                break;
            case "More Blessings Slots":
                currentBonus = GameManager.Instance.GMData.maxPowerups;
                nextBonus = GameManager.Instance.GMData.maxPowerups + (int)(upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1)));
                break;
            case "Better Absorb Ratio":
                isRatio = true;
                currentBonus = GameManager.Instance.GMData.absorbedSnowflakesAmount * 10;
                secondCurrentBonus = GameManager.Instance.GMData.obtainedIntelligenceAmount;
                nextBonus = (GameManager.Instance.GMData.absorbedSnowflakesAmount + 1) * 10;
                secondNextBonus = GameManager.Instance.GMData.obtainedIntelligenceAmount + (int)(upgradesButton.defaultBonus + (upgradesButton.bonusPerTier * (upgradesButton.data.tier - 1)));
                currentRatio = currentBonus + " SF => " + secondCurrentBonus + " IP";
                nextRatio = nextBonus + " SF => " + secondNextBonus + " IP";
                break;
            default:
                break;
        }

        if (!upgradesButton.data.isMaxLevel)
        {
            if (!isRatio)
            {
                text = description + "\n" +
                    "Current: " + currentBonus.ToString() + " " + upgradesButton.infoPopupSuffix + "\n" +
                    "Next: " + nextBonus.ToString() + " " + upgradesButton.infoPopupSuffix;
            }
            else
            {
                text = description + "\n" +
                    "Current: " + currentRatio + "\n" +
                    "Next: " + nextRatio;
            }
        }
        else
        {
            if (!isRatio)
            {
                text = description + "\n" +
                    "Current: " + currentBonus.ToString() + " " + upgradesButton.infoPopupSuffix + "\n" +
                    "Next: REACHED MAX LEVEL FOR THIS TIER";
            }
            else
            {
                text = description + "\n" +
                    "Current: " + currentRatio + "\n" +
                    "Next: REACHED MAX LEVEL FOR THIS TIER";
            }

        }

        return text;
    }

    string PowerupText()
    {
        PowerupsButton powerupsButton = GetComponent<PowerupsButton>();
        string text;
        double currentBonus = 0;
        double nextBonus = 0;

        switch (powerupsButton.name)
        {
            case "Snowstorm Seeker":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.000f) / 1000.000f;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.000f) / 1000.000f;
                break;
            case "Lucky Winter":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 0.5f * 1000.0f) / 1000.0f;
                nextBonus = Mathf.Round((powerupsButton.bonus * 0.5f + powerupsButton.bonusPerLevel * 0.5f * (powerupsButton.data.level + 1)) * 1000.0f) / 1000.0f;
                break;
            case "Blessed Snowflakes":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.0f) / 1000.0f + 1;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.0f) / 1000.0f + 1;
                break;
            case "Shovel Master":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.0f) / 1000.0f + 1;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.0f) / 1000.0f + 1;
                break;
            case "Snowflake Booster":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.0f) / 1000.0f;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.0f) / 1000.0f;
                break;
            case "Snowpile Freezer":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.0f) / 1000.0f;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.0f) / 1000.0f;
                break;
            case "Absorbant Body":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.00f) / 1000.00f + 1;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.00f) / 1000.00f + 1;
                break;
            case "Fate Conqueror":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 1000.00000f) / 1000.00000f;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 1000.00000f) / 1000.00000f;
                break;
            case "Resources Recovery":
                currentBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * powerupsButton.data.level) * 100f *  1000.00f) / 1000.00f;
                nextBonus = Mathf.Round((powerupsButton.bonus + powerupsButton.bonusPerLevel * (powerupsButton.data.level + 1)) * 100f * 1000.00f) / 1000.00f;
                break;
            default:
                break;
        }

        if (powerupsButton.data.level < 5)
        {
            text = description + "\n" +
                "Current: " + currentBonus.ToString() + "" + powerupsButton.infoPopupSuffix + "\n" +
                "Next: " + nextBonus.ToString() + "" + powerupsButton.infoPopupSuffix;

            return text;
        }
        else
        {
            text = description + "\n" +
                "Current: " + currentBonus.ToString() + "" + powerupsButton.infoPopupSuffix + "\n" +
                "MAX LEVEL";

            return text;
        }        
    }

    string HabitatText()
    {
        string text;
        string prefix = "Current speed: ";
        string suffix = "s / action";
        double currentBonus = 0;
        double populationAmount = 0;

        switch (this.gameObject.name)
        {
            case "Collectors":
                currentBonus = Mathf.Round(3 / (1 + GameManager.Instance.GMData.autoCollectSpeed) * 1000.00f) / 1000.00f;
                populationAmount = GameManager.Instance.GMData.collectorsAmount;
                break;
            case "Shovelers":
                currentBonus = Mathf.Round(3 / (1 + GameManager.Instance.GMData.autoShovelSpeed) * 1000.00f) / 1000.00f;
                populationAmount = GameManager.Instance.GMData.shovelersAmount;
                break;
            case "Transplanters":
                currentBonus = Mathf.Round(3 / (1 + GameManager.Instance.GMData.autoAbsorbSpeed) * 1000.00f) / 1000.00f;
                populationAmount = GameManager.Instance.GMData.transplantersAmount;
                break;
            case "Worshippers":
                prefix = "Current chance: ";
                suffix = "% / s";
                currentBonus = Mathf.Round(((GameManager.Instance.GMData.newPowerupCurrentChance + Powerups.Instance.FateConqueror()) / GameManager.Instance.GMData.newPowerupUnlockChance * 100f) * 1000.00f) / 1000.00f;
                populationAmount = GameManager.Instance.GMData.worshippersAmount;
                break;
            case "Cryogenics":
                prefix = "Current speed: -";
                suffix = "°C / s";
                currentBonus = Mathf.Round((float)(GameManager.Instance.GMData.cryogenicsAmount / 1000f / (GameManager.Instance.GMData.tempMultiplier * 2)) * 1000.000f) / 1000.000f;
                populationAmount = GameManager.Instance.GMData.cryogenicsAmount;
                break;
            default:
                break;
        }

        if (populationAmount == 0)
        {
            text = description + "\n" + 
                prefix + "N/A";
        }
        else
        {
            text = description + "\n" +
                prefix + currentBonus.ToString() + suffix;
        }

        return text;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        UpdateText();
        this.isBeingChecked = true;
        StartCoroutine(InfoPopupHandler.Instance.SpawnInfoPopup(this.transform, textToSend));
    }

    public void RefreshText()
    {
        UpdateText();
        InfoPopupHandler.Instance.RefreshText(textToSend);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        DespawnPopup();
    }

    public void DespawnPopup()
    {
        this.isBeingChecked = false;
        InfoPopupHandler.Instance.DespawnInfoPopup();
    }

}

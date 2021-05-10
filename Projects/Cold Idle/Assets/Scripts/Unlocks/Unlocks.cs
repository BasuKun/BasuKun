using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlocks : MonoBehaviour
{
    public bool hasHabitatXHighlight = false;
    public bool hasShopXHighlight = false;
    public bool hasUpgradeTabHighlight = false;
    public bool hasBlessingsTabHighlight = false;
    public bool hasLogsHighlight = false;

    [Header("TABS")]
    public GameObject upgradesTab;
    public GameObject unlocksTab;
    public GameObject blessingsTab;
    public GameObject LogsTab;
    public GameObject SettingsTab;
    public GameObject blessingsLevelsButton;
    public UpgradeDropdownHandler habitatsContainer;
    public UpgradeDropdownHandler shopContainer;
    public UpgradeDropdownHandler logsContainer;
    public GameObject habitatsTabX;
    public GameObject shopTabX;
    public GameObject logsTabX;

    [Header("UPGRADES")]
    public GameObject betterValueButton;
    public GameObject moreSnowButton;
    public GameObject biggerRadiusButton;
    public GameObject betterAbsorbRatioButton;
    public GameObject moreShinySnowflakesButton;
    public GameObject fasterShovelButton;
    public GameObject moreHabitatButton;
    public GameObject higherSnowpileButton;
    public GameObject morePowerupSlotsButton;

    [Header("HABITATS")]
    public GameObject habitatsMenu;
    public GameObject shovelers;
    public GameObject collectors;
    public GameObject absorbers;
    public GameObject worshippers;
    public GameObject cryogenics;

    [Header("ACTIONS")]
    public GameObject absorbSnowflakesButton;
    public GameObject shovelSnowButton;
    public GameObject snowPileHeightArrow;
    public GameObject temperature;
    public GameObject conquestButton;

    [Header("CURRENCIES")]
    public GameObject currenciesContainer;
    public GameObject iceBlocksAmount;
    public GameObject intelligencePointsAmount;
    public GameObject blessingPointsAmount;

    [Header("Others")]
    public GameObject highlight;
    public GameObject highlightCanvas;
    public GameObject snowflakeSpawner;
    public static Unlocks Instance;
    public UIData data = new UIData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        Instance = this;
        SetData();
        if(!data.hasIceBlocks) GameUI.OnIBObtained += IceBlockAmountUnlock;
        if (!data.hasIntelligencePoints) GameUI.OnIPObtained += IntelligencePointsAmountUnlock;
        if (!data.hasBlessingsPoints) GameUI.OnBPObtained += BlessingPointsAmountUnlock;
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("UI"))
        {
            data.hasHabitats = false;
            data.hasCollectors = false;
            data.hasAbsorbers = false;
            data.hasWorshippers = false;
            data.hasCryogenics = false;
            data.hasSnowpiles = false;
            data.hasIceBlocks = false;
            data.hasIntelligencePoints = false;
            data.hasBlessingsPoints = false;
            data.hasBlessingsLevels = false;
            data.hasConquest = false;
            data.hasBetterHealing = false;
        }
        else
        {
            string jData = PlayerPrefs.GetString("UI");
            data = JsonUtility.FromJson<UIData>(jData);
        }

        habitatsMenu.SetActive(data.hasHabitats);
        shovelers.SetActive(data.hasHabitats);
        collectors.SetActive(data.hasCollectors);
        absorbers.SetActive(data.hasAbsorbers);
        worshippers.SetActive(data.hasWorshippers);
        cryogenics.SetActive(data.hasCryogenics);
        temperature.SetActive(data.hasCryogenics);
        blessingsLevelsButton.SetActive(data.hasBlessingsLevels);

        shovelSnowButton.SetActive(data.hasSnowpiles);
        conquestButton.SetActive(data.hasConquest);
        snowPileHeightArrow.SetActive(data.hasSnowpiles);
        if (data.hasSnowpiles) PileHandler.Instance.MovePileHeightLimitArrow();

        iceBlocksAmount.SetActive(data.hasIceBlocks);
        intelligencePointsAmount.SetActive(data.hasIntelligencePoints);
        blessingPointsAmount.SetActive(data.hasBlessingsPoints);

        GameUI.Instance.snowflakesUpdateText();
        GameUI.Instance.iceBlocksUpdateText();
        GameUI.Instance.IntelligencePointsUpdateText();
        GameUI.Instance.BlessingPointsUpdateText();
        GameUI.Instance.populationUpdateText();
        GameUI.Instance.idlePopulationUpdateText();
        GameUI.Instance.shovelersUpdateText();
        GameUI.Instance.collectorsUpdateText();
        GameUI.Instance.transplantersUpdateText();
        GameUI.Instance.worshippersUpdateText();
        GameUI.Instance.cryogenicsUpdateText();
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("UI", jData);
    }

    public void SpawnHighlight(GameObject button, bool isHabitatX, bool isShopX, bool isUpgradeTab, bool isBlessingTab, bool isLogsTab)
    {
        GameObject highlightPrefab = Instantiate(highlight, button.transform.position, Quaternion.identity, button.transform);
        RectTransform rect = button.gameObject.GetComponent<RectTransform>();
        highlightPrefab.GetComponent<ButtonHighlight>().Reshape(rect.rect.width, rect.rect.height, isHabitatX, isShopX, isUpgradeTab, isBlessingTab, isLogsTab);

        if (isHabitatX) hasHabitatXHighlight = true;
        if (isShopX) hasShopXHighlight = true;
        if (isUpgradeTab) hasUpgradeTabHighlight = true;
        if (isBlessingTab) hasBlessingsTabHighlight = true;
        if (isLogsTab) hasLogsHighlight = true;
    }

    public void BuyUnlock(int ID, double bonus)
    {
        switch (ID)
        {
            case 0:
                MoreSnowUnlock();
                break;
            case 1:
                SnowPilesUnlock();
                break;
            case 2:
                FasterShovelUnlock();
                break;
            case 3:
                HabitatsUnlock();
                break;
            case 4:
                MoreHabitatsUnlock();
                break;
            case 5:
                BiggerRadiusUnlock();
                break;
            case 6:
                HigherSnowPilesUnlock();
                break;
            case 7:
                CollectorsUnlock();
                break;
            case 8:
                ShinySnowflakesUnlock();
                break;
            case 9:
                BetterAbsorbRatioUnlock();
                break;
            case 10:
                AbsorbersUnlock();
                break;
            case 11:
                WorshippersUnlock();
                break;
            case 12:
                MorePowerupsSlotsUnlock();
                break;
            case 13:
                TierUnlock();
                break;
            case 14:
                BetterValueBoost(bonus);
                break;
            case 15:
                MoreHabitatsBoost(bonus);
                break;
            case 16:
                SongUnlock(bonus);
                break;
            case 17:
                CryogenicsUnlock();
                break;
            case 18:
                BlessingsLevelsUnlock();
                break;
            case 19:
                ConquestUnlock();
                break;
            case 20:
                BetterHealingUnlock();
                break;
            default:
                break;
        }
    }

    public void MoreSnowUnlock()
    {
        moreSnowButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(moreSnowButton, false, false, false, false, false);
    }

    public void SnowPilesUnlock()
    {
        GameManager.Instance.GMData.snowpileHeightLimit = -4f;
        shovelSnowButton.SetActive(true);
        snowPileHeightArrow.SetActive(true);
        data.hasSnowpiles = true;
        PileHandler.Instance.MovePileHeightLimitArrow();
        SpawnHighlight(shovelSnowButton, false, false, false, false, false);
    }

    public void FasterShovelUnlock()
    {
        fasterShovelButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(fasterShovelButton, false, false, false, false, false);
    }

    public void HabitatsUnlock()
    {
        habitatsMenu.SetActive(true);
        shovelers.SetActive(true);
        data.hasHabitats = true;
        GameManager.Instance.GMData.habitatsAmount += 1;
        GameManager.Instance.GMData.idlePopulationAmount += 1;
        GameUI.Instance.populationUpdateText();
        GameUI.Instance.idlePopulationUpdateText();
        SpawnHighlight(shovelers, false, false, false, false, false);
    }

    public void MoreHabitatsUnlock()
    {
        moreHabitatButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(moreHabitatButton, false, false, false, false, false);
    }

    public void BiggerRadiusUnlock()
    {
        biggerRadiusButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(biggerRadiusButton, false, false, false, false, false);
    }

    public void HigherSnowPilesUnlock()
    {
        higherSnowpileButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(higherSnowpileButton, false, false, false, false, false);
    }

    public void CollectorsUnlock()
    {
        collectors.SetActive(true);
        data.hasCollectors = true;
        SpawnHighlight(collectors, false, false, false, false, false);

        if (!habitatsContainer.isOpened && !hasHabitatXHighlight)
        {
            SpawnHighlight(habitatsTabX, true, false, false, false, false);
        }
    }

    public void ShinySnowflakesUnlock()
    {
        moreShinySnowflakesButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(moreShinySnowflakesButton, false, false, false, false, false);
    }

    public void BetterAbsorbRatioUnlock()
    {
        betterAbsorbRatioButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(betterAbsorbRatioButton, false, false, false, false, false);
    }

    public void AbsorbersUnlock()
    {
        absorbers.SetActive(true);
        data.hasAbsorbers = true;
        SpawnHighlight(absorbers, false, false, false, false, false);

        if (!habitatsContainer.isOpened && !hasHabitatXHighlight)
        {
            SpawnHighlight(habitatsTabX, true, false, false, false, false);
        }
    }

    public void WorshippersUnlock()
    {
        worshippers.SetActive(true);
        data.hasWorshippers = true;
        SpawnHighlight(worshippers, false, false, false, false, false);

        if (!habitatsContainer.isOpened && !hasHabitatXHighlight)
        {
            SpawnHighlight(habitatsTabX, true, false, false, false, false);
        }
    }

    public void MorePowerupsSlotsUnlock()
    {
        morePowerupSlotsButton.SetActive(true);
        if (!hasUpgradeTabHighlight) SpawnHighlight(upgradesTab, false, false, true, false, false);
        SpawnHighlight(morePowerupSlotsButton, false, false, false, false, false);
    }

    public void BlessingsTabUnlock()
    {
        blessingsTab.SetActive(true);
    }

    public void IceBlockAmountUnlock()
    {
        iceBlocksAmount.SetActive(true);
        data.hasIceBlocks = true;
        GameUI.OnIBObtained -= IceBlockAmountUnlock;
        Logs.Instance.AddLog("Seems like snow freezes when piling up on the ground. Shovelling piles returns around half their value in Snowflakes as well as half their value in Ice Blocks.", Color.white);
    }

    public void IntelligencePointsAmountUnlock()
    {
        intelligencePointsAmount.SetActive(true);
        data.hasIntelligencePoints = true;

        if (!unlocksTab.gameObject.activeSelf)
        {
            unlocksTab.SetActive(true);

            if (!shopContainer.isOpened && !hasShopXHighlight)
            {
                SpawnHighlight(shopTabX, false, true, false, false, false);
            }
            SpawnHighlight(unlocksTab, false, false, false, false, false);
            Logs.Instance.AddLog("Your body has absorbed your collected snowflakes like it was a natural thing for you. Doing so has shaken up your lost memories a bit, granting you Intelligence Points.", Color.white);
        }

        GameUI.OnIPObtained -= IntelligencePointsAmountUnlock;
    }

    public void BlessingPointsAmountUnlock()
    {
        blessingPointsAmount.SetActive(true);
        data.hasBlessingsPoints = true;
        GameUI.OnBPObtained -= BlessingPointsAmountUnlock;
    }

    public void TierUnlock()
    {
        GameManager.Instance.GMData.maxTierAllowed++;
    }

    public void BetterValueBoost(double bonus)
    {
        GameManager.Instance.GMData.snowflakeExtraValue += bonus;
        UpgradesButton button = betterValueButton.gameObject.GetComponent<UpgradesButton>();
        GameManager.Instance.GMData.snowflakeValue += bonus * button.data.level;
    }

    public void MoreHabitatsBoost(double bonus)
    {
        GameManager.Instance.GMData.habitatsExtraAmount += bonus;
        UpgradesButton button = moreHabitatButton.gameObject.GetComponent<UpgradesButton>();
        GameManager.Instance.GMData.habitatsAmount += bonus * button.data.level;
        GameManager.Instance.GMData.idlePopulationAmount += bonus * button.data.level;
        GameUI.Instance.idlePopulationUpdateText();
        GameUI.Instance.populationUpdateText();
    }

    public void SongUnlock(double bonus)
    {
        MusicManager.Instance.musicButtons[(int)bonus].interactable = true;
        MusicManager.Instance.unlockedMusics[(int)bonus].SetActive(true);
        MusicManager.Instance.data.unlockedAmount++;
    }

    public void CryogenicsUnlock()
    {
        cryogenics.SetActive(true);
        temperature.SetActive(true);
        data.hasCryogenics = true;
        SpawnHighlight(cryogenics, false, false, false, false, false);
        SpawnHighlight(temperature, false, false, false, false, false);

        if (!habitatsContainer.isOpened && !hasHabitatXHighlight)
        {
            SpawnHighlight(habitatsTabX, true, false, false, false, false);
        }
    }

    public void BlessingsLevelsUnlock()
    {
        blessingsLevelsButton.SetActive(true);
        data.hasBlessingsLevels = true;
        SpawnHighlight(blessingsLevelsButton, false, false, false, false, false);

        if (!shopContainer.isOpened && !hasShopXHighlight)
        {
            SpawnHighlight(shopTabX, false, true, false, false, false);
        }
        if (blessingsTab.GetComponent<Button>().interactable && !hasBlessingsTabHighlight)
        {
            SpawnHighlight(blessingsTab, false, false, false, true, false);
        }
    }

    public void ConquestUnlock()
    {
        conquestButton.SetActive(true);
        SpawnHighlight(conquestButton, false, false, false, false, false);
        data.hasConquest = true;
    }

    public void BetterHealingUnlock()
    {
        data.hasBetterHealing = true;
    }

    private void OnDestroy()
    {
        GameUI.OnIBObtained -= IceBlockAmountUnlock;
        GameUI.OnIPObtained -= IntelligencePointsAmountUnlock;
        GameUI.OnBPObtained -= BlessingPointsAmountUnlock;
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct UIData
{
    public bool hasHabitats;
    public bool hasCollectors;
    public bool hasAbsorbers;
    public bool hasWorshippers;
    public bool hasCryogenics;
    public bool hasSnowpiles;
    public bool hasIceBlocks;
    public bool hasIntelligencePoints;
    public bool hasBlessingsPoints;
    public bool hasBlessingsLevels;
    public bool hasConquest;
    public bool hasBetterHealing;
}

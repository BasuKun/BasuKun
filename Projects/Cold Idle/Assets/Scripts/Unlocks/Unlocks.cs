using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    [Header("ACTIONS")]
    public GameObject shovelSnowButton;
    public GameObject snowPileHeightArrow;

    [Header("CURRENCIES")]
    public GameObject iceBlocksAmount;
    public GameObject intelligencePointsAmount;
    public GameObject blessingPointsAmount;

    [Header("Others")]
    public GameObject highlight;
    public GameObject highlightCanvas;
    public static Unlocks Instance;

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
        GameUI.OnIBObtained += IceBlockAmountUnlock;
        GameUI.OnIPObtained += IntelligencePointsAmountUnlock;
        GameUI.OnBPObtained += BlessingPointsAmountUnlock;
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
        GameManager.Instance.snowpileHeightLimit = -4f;
        shovelSnowButton.SetActive(true);
        snowPileHeightArrow.SetActive(true);
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
        GameManager.Instance.habitatsAmount += 1;
        GameManager.Instance.idlePopulationAmount += 1;
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
        SpawnHighlight(absorbers, false, false, false, false, false);

        if (!habitatsContainer.isOpened && !hasHabitatXHighlight)
        {
            SpawnHighlight(habitatsTabX, true, false, false, false, false);
        }
    }

    public void WorshippersUnlock()
    {
        worshippers.SetActive(true);
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
        GameUI.OnIBObtained -= IceBlockAmountUnlock;
        Logs.Instance.AddLog("Seems like snow freezes when piling up on the ground. Shovelling piles returns around half their value in Snowflakes as well as half their value in Ice Blocks.", Color.white);
    }

    public void IntelligencePointsAmountUnlock()
    {
        intelligencePointsAmount.SetActive(true);
        unlocksTab.SetActive(true);
        GameUI.OnIPObtained -= IntelligencePointsAmountUnlock;

        if (!shopContainer.isOpened && !hasShopXHighlight)
        {
            SpawnHighlight(shopTabX, false, true, false, false, false);
        }
        SpawnHighlight(unlocksTab, false, false, false, false, false);
        Logs.Instance.AddLog("Your body has absorbed your collected snowflakes like it was a natural thing for you. Doing so has shaken up your lost memories a bit, granting you Intelligence Points.", Color.white);
    }

    public void BlessingPointsAmountUnlock()
    {
        blessingPointsAmount.SetActive(true);
        GameUI.OnBPObtained -= BlessingPointsAmountUnlock;
    }

    public void TierUnlock()
    {
        GameManager.Instance.maxTierAllowed++;
    }

    public void BetterValueBoost(double bonus)
    {
        GameManager.Instance.snowflakeExtraValue += bonus;
        UpgradesButton button = betterValueButton.gameObject.GetComponent<UpgradesButton>();
        GameManager.Instance.snowflakeValue += GameManager.Instance.snowflakeExtraValue * button.level;
    }
}

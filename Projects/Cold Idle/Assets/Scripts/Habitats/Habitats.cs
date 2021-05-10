using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Habitats : MonoBehaviour
{
    public ShovelButton shovelButton;
    public AbsorbSnowButton absorbSnowButton;
    public GameObject character;
    public float originalInterval = 3f;
    public float originalWorshippersInterval = 1f;
    public float originalCryogenicsInterval = 1f;
    public float autoShovelInterval = 3f;
    public float autoCollectInterval = 3f;
    public float autoAbsorbInterval = 3f;
    public float worshippersInterval = 1f;
    public float cryogenicsInterval = 1f;
    public float newPowerupCooldown;
    public float newPowerupMaxChance;
    public float amountOfTimesFailed = 0;

    public OnMouseOverHandler shovelerOMOH;
    public OnMouseOverHandler collectorOMOH;
    public OnMouseOverHandler transplanterOMOH;
    public OnMouseOverHandler worshipperOMOH;
    public OnMouseOverHandler cryogenicsOMOH;

    public delegate void BPObtained();
    public static event BPObtained OnBPObtained;

    public static Habitats Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        newPowerupCooldown = GameManager.Instance.GMData.newPowerupUnlockChance / 4;
        newPowerupMaxChance = GameManager.Instance.GMData.newPowerupUnlockChance;
    }

    void Update()
    {
        if (GameManager.Instance.GMData.shovelersAmount > 0)
        {
            Shovelers();
        }
        if (GameManager.Instance.GMData.collectorsAmount > 0)
        {
            SnowCollectors();
        }
        if (GameManager.Instance.GMData.transplantersAmount > 0)
        {
            Transplanters();
        }
        if (GameManager.Instance.GMData.worshippersAmount > 0)
        {
            Worshippers();
        }
        if (GameManager.Instance.GMData.cryogenicsAmount > 0)
        {
            Cryogenics();
        }
        if (PileHandler.Instance.pileDict.Count <= 0 && autoShovelInterval != originalInterval)
        {
            autoShovelInterval = originalInterval;
        }
        if (SnowflakeSpawner.Instance.currentSnowflakesList.Count <= 0 && autoCollectInterval != originalInterval)
        {
            autoCollectInterval = originalInterval;
        }
        if (GameManager.Instance.GMData.snowflakesAmount < GameManager.Instance.GMData.absorbedSnowflakesAmount && autoAbsorbInterval != originalInterval)
        {
            autoAbsorbInterval = originalInterval;
        }
    }

    public void AddOccupation(string occupation)
    {
        GameManager.Instance.GMData.idlePopulationAmount--;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.GMData.shovelersAmount++;
                GameManager.Instance.GMData.autoShovelSpeed = (float)(GameManager.Instance.GMData.shovelersAmount / 10f);
                GameUI.Instance.shovelersUpdateText();
                shovelerOMOH.RefreshText();
                break;
            case "collector":
                GameManager.Instance.GMData.collectorsAmount++;
                GameManager.Instance.GMData.autoCollectSpeed = (float)(GameManager.Instance.GMData.collectorsAmount / 10f);
                GameUI.Instance.collectorsUpdateText();
                collectorOMOH.RefreshText();
                break;
            case "transplanter":
                GameManager.Instance.GMData.transplantersAmount++;
                GameManager.Instance.GMData.autoAbsorbSpeed = (float)(GameManager.Instance.GMData.transplantersAmount / 10f);
                GameUI.Instance.transplantersUpdateText();
                transplanterOMOH.RefreshText();
                break;
            case "worshipper":
                GameManager.Instance.GMData.worshippersAmount++;
                GameManager.Instance.GMData.newPowerupCurrentChance = (float)(GameManager.Instance.GMData.worshippersAmount / 1000f);
                GameUI.Instance.worshippersUpdateText();
                worshipperOMOH.RefreshText();
                break;
            case "cryogenic":
                GameManager.Instance.GMData.cryogenicsAmount++;
                GameUI.Instance.cryogenicsUpdateText();
                cryogenicsOMOH.RefreshText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void RemoveOccupation(string occupation)
    {
        GameManager.Instance.GMData.idlePopulationAmount++;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.GMData.shovelersAmount--;
                GameManager.Instance.GMData.autoShovelSpeed = (float)(GameManager.Instance.GMData.shovelersAmount / 10f);
                GameUI.Instance.shovelersUpdateText();
                shovelerOMOH.RefreshText();
                break;
            case "collector":
                GameManager.Instance.GMData.collectorsAmount--;
                GameManager.Instance.GMData.autoCollectSpeed = (float)(GameManager.Instance.GMData.collectorsAmount / 10f);
                GameUI.Instance.collectorsUpdateText();
                collectorOMOH.RefreshText();
                break;
            case "transplanter":
                GameManager.Instance.GMData.transplantersAmount--;
                GameManager.Instance.GMData.autoAbsorbSpeed = (float)(GameManager.Instance.GMData.transplantersAmount / 10f);
                GameUI.Instance.transplantersUpdateText();
                transplanterOMOH.RefreshText();
                break;
            case "worshipper":
                GameManager.Instance.GMData.worshippersAmount--;
                GameManager.Instance.GMData.newPowerupCurrentChance = (float)(GameManager.Instance.GMData.worshippersAmount / 1000f);
                GameUI.Instance.worshippersUpdateText();
                worshipperOMOH.RefreshText();
                break;
            case "cryogenic":
                GameManager.Instance.GMData.cryogenicsAmount--;
                GameUI.Instance.cryogenicsUpdateText();
                cryogenicsOMOH.RefreshText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void Shovelers()
    {
        autoShovelInterval -= Time.deltaTime * (1 + GameManager.Instance.GMData.autoShovelSpeed);

        if (autoShovelInterval <= 0 && PileHandler.Instance.pileDict.Count > 0)
        {
            shovelButton.ShovelSnow(false);
            autoShovelInterval = originalInterval;
        }
    }

    public void SnowCollectors()
    {
        autoCollectInterval -= Time.deltaTime * (1 + GameManager.Instance.GMData.autoCollectSpeed);

        if (autoCollectInterval <= 0 && SnowflakeSpawner.Instance.currentSnowflakesList.Count > 0)
        {
            System.Random rand = new System.Random();
            int index = rand.Next(0, SnowflakeSpawner.Instance.currentSnowflakesList.Count);

            if (SnowflakeSpawner.Instance.currentSnowflakesList[index] != null)
            {
                Snowflake sf = SnowflakeSpawner.Instance.currentSnowflakesList[index].GetComponent<Snowflake>();
                sf.isSelectedByCollector = true;

                GameManager.Instance.collectSnowflakes(GameManager.Instance.GMData.snowflakeValue, sf.isDouble ? true : false, false, sf.transform.position);

                sf.DestroySnowflake(true);
            }

            autoCollectInterval = originalInterval;
        }
    }

    public void Transplanters()
    {
        autoAbsorbInterval -= Time.deltaTime * (1 + GameManager.Instance.GMData.autoAbsorbSpeed);

        if (autoAbsorbInterval <= 0 && GameManager.Instance.GMData.snowflakesAmount >= (GameManager.Instance.GMData.absorbedSnowflakesAmount * 10))
        {
            GameManager.Instance.GMData.snowflakesAmount -= (GameManager.Instance.GMData.absorbedSnowflakesAmount * 10);
            GameUI.Instance.snowflakesUpdateText();

            double valueToAdd = Mathf.Round(GameManager.Instance.GMData.obtainedIntelligenceAmount * ConquerRewards.Instance.data.ipReward * GameManager.Instance.GMData.tempMultiplier);
            GameManager.Instance.GMData.intelligencePointsAmount += valueToAdd;
            GameManager.Instance.currencyPopout('+', Camera.main.ScreenToWorldPoint(absorbSnowButton.transform.position), valueToAdd, "IP", GameUI.Instance.intelligencePointsColor);
            GameUI.Instance.IntelligencePointsUpdateText();
            UnlocksListHandler.Instance.CheckForUnlocks();

            autoAbsorbInterval = originalInterval;
        }
    }

    public void Worshippers()
    {
        worshippersInterval -= Time.deltaTime;

        if (worshippersInterval <= 0)
        {
            float unlockAttempt = Random.Range(newPowerupCooldown, newPowerupMaxChance);

            if (unlockAttempt < (GameManager.Instance.GMData.newPowerupCurrentChance + Powerups.Instance.FateConqueror()))
            {
                if (Powerups.Instance.PowerupsToUnlockList.Count > 0)
                {
                    if (!Unlocks.Instance.blessingsTab.activeSelf)
                    {
                        Unlocks.Instance.BlessingsTabUnlock();
                    }

                    AudioManager.Instance.PlayNoPitchSound(AudioManager.Instance.blessingUnlockSFX);

                    GameObject powerup = Powerups.Instance.PowerupsToUnlockList[0].gameObject;
                    powerup.SetActive(true);
                    powerup.GetComponent<PowerupsButton>().data.isUnlocked = true;
                    GameUI.Instance.CheckForMaxEquippedPowerups();
                    Logs.Instance.AddLog(powerup.GetComponent<PowerupsButton>().logsText,
                        powerup.GetComponent<PowerupsButton>().logsColor);

                    Unlocks.Instance.SpawnHighlight(powerup, false, false, false, false, false);

                    if (!Unlocks.Instance.shopContainer.isOpened && !Unlocks.Instance.hasShopXHighlight)
                    {
                        Unlocks.Instance.SpawnHighlight(Unlocks.Instance.shopTabX, false, true, false, false, false);
                    }
                    if (Unlocks.Instance.blessingsTab.GetComponent<Button>().interactable && !Unlocks.Instance.hasBlessingsTabHighlight)
                    {
                        Unlocks.Instance.SpawnHighlight(Unlocks.Instance.blessingsTab, false, false, false, true, false);
                    }

                    Powerups.Instance.PowerupsToUnlockList.RemoveAt(0);
                    GameManager.Instance.GMData.newPowerupUnlockChance *= 1.8f;
                }
                else
                {
                    double valueToAdd = Mathf.Round(1 * ConquerRewards.Instance.data.bpReward);
                    GameManager.Instance.GMData.blessingPointsAmount += valueToAdd;
                    GameManager.Instance.currencyPopout('+', character.transform.position, valueToAdd, "BP", GameUI.Instance.blessingPointsColor);
                    GameUI.Instance.BlessingPointsUpdateText();

                    if (OnBPObtained != null)
                    {
                        OnBPObtained();
                    }
                }

                newPowerupMaxChance = GameManager.Instance.GMData.newPowerupUnlockChance;
                amountOfTimesFailed = 0;
                newPowerupCooldown = GameManager.Instance.GMData.newPowerupUnlockChance / 4;
            }

            if (newPowerupCooldown > 0)
            {
                newPowerupCooldown = Mathf.Clamp(newPowerupCooldown - (float)((GameManager.Instance.GMData.newPowerupCurrentChance + Powerups.Instance.FateConqueror()) * 2), 0, GameManager.Instance.GMData.newPowerupUnlockChance);
            }
            else
            {
                newPowerupMaxChance = Mathf.Clamp(newPowerupMaxChance - (float)((GameManager.Instance.GMData.newPowerupCurrentChance + Powerups.Instance.FateConqueror()) / 2), 0.001f, GameManager.Instance.GMData.newPowerupUnlockChance);
            }
            amountOfTimesFailed++;

            if (worshipperOMOH.isBeingChecked)
            {
                worshipperOMOH.RefreshText();
            }
            worshippersInterval = originalWorshippersInterval;
        }
    }

    public void Cryogenics()
    {
        cryogenicsInterval -= Time.deltaTime;

        if (cryogenicsInterval <= 0)
        {
            GameManager.Instance.GMData.temperature -= (float)(GameManager.Instance.GMData.cryogenicsAmount / 1000f / (GameManager.Instance.GMData.tempMultiplier * 3));
            GameManager.Instance.GMData.tempMultiplier = 1 + Mathf.Abs(GameManager.Instance.GMData.temperature / 10);

            GameUI.Instance.temperatureUpdateText();

            cryogenicsInterval = originalCryogenicsInterval;
        }
    }
}

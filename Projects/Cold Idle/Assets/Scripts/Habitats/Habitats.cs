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
    public float autoShovelInterval = 3f;
    public float autoCollectInterval = 3f;
    public float autoAbsorbInterval = 3f;
    public float worshippersInterval = 1f;
    public float newPowerupCooldown;
    public float newPowerupMaxChance;
    public int autoAbsorbAmount = 0;
    public float amountOfTimesFailed = 0;

    public OnMouseOverHandler shovelerOMOH;
    public OnMouseOverHandler collectorOMOH;
    public OnMouseOverHandler transplanterOMOH;
    public OnMouseOverHandler worshipperOMOH;

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
        newPowerupCooldown = GameManager.Instance.newPowerupUnlockChance / 2;
        newPowerupMaxChance = GameManager.Instance.newPowerupUnlockChance;
    }

    void Update()
    {
        if (GameManager.Instance.shovelersAmount > 0)
        {
            Shovelers();
        }
        if (GameManager.Instance.collectorsAmount > 0)
        {
            SnowCollectors();
        }
        if (GameManager.Instance.transplantersAmount > 0)
        {
            Transplanters();
        }
        if (GameManager.Instance.worshippersAmount > 0)
        {
            Worshippers();
        }
        if (PileHandler.Instance.pileDict.Count <= 0 && autoShovelInterval != originalInterval)
        {
            autoShovelInterval = originalInterval;
        }
        if (SnowflakeSpawner.Instance.currentSnowflakesList.Count <= 0 && autoCollectInterval != originalInterval)
        {
            autoCollectInterval = originalInterval;
        }
        if (GameManager.Instance.snowflakesAmount < GameManager.Instance.absorbedSnowflakesAmount && autoAbsorbInterval != originalInterval)
        {
            autoAbsorbInterval = originalInterval;
        }
    }

    public void AddOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount--;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount++;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 10f);
                GameUI.Instance.shovelersUpdateText();
                shovelerOMOH.RefreshText();
                break;
            case "collector":
                GameManager.Instance.collectorsAmount++;
                GameManager.Instance.autoCollectSpeed = (float)(GameManager.Instance.collectorsAmount / 10f);
                GameUI.Instance.collectorsUpdateText();
                collectorOMOH.RefreshText();
                break;
            case "transplanter":
                GameManager.Instance.transplantersAmount++;
                GameManager.Instance.autoAbsorbSpeed = (float)(GameManager.Instance.transplantersAmount / 10f);
                GameUI.Instance.transplantersUpdateText();
                transplanterOMOH.RefreshText();
                break;
            case "worshipper":
                GameManager.Instance.worshippersAmount++;
                GameManager.Instance.newPowerupCurrentChance = (float)(GameManager.Instance.worshippersAmount / 1000f);
                GameUI.Instance.worshippersUpdateText();
                worshipperOMOH.RefreshText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void RemoveOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount++;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount--;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 10f);
                GameUI.Instance.shovelersUpdateText();
                shovelerOMOH.RefreshText();
                break;
            case "collector":
                GameManager.Instance.collectorsAmount--;
                GameManager.Instance.autoCollectSpeed = (float)(GameManager.Instance.collectorsAmount / 10f);
                GameUI.Instance.collectorsUpdateText();
                collectorOMOH.RefreshText();
                break;
            case "transplanter":
                GameManager.Instance.transplantersAmount--;
                GameManager.Instance.autoAbsorbSpeed = (float)(GameManager.Instance.transplantersAmount / 10f);
                GameUI.Instance.transplantersUpdateText();
                transplanterOMOH.RefreshText();
                break;
            case "worshipper":
                GameManager.Instance.worshippersAmount--;
                GameManager.Instance.newPowerupCurrentChance = (float)(GameManager.Instance.worshippersAmount / 1000f);
                GameUI.Instance.worshippersUpdateText();
                worshipperOMOH.RefreshText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void Shovelers()
    {
        autoShovelInterval -= Time.deltaTime * (1 + GameManager.Instance.autoShovelSpeed);

        if (autoShovelInterval <= 0 && PileHandler.Instance.pileDict.Count > 0)
        {
            shovelButton.ShovelSnow();
            autoShovelInterval = originalInterval;
        }
    }

    public void SnowCollectors()
    {
        autoCollectInterval -= Time.deltaTime * (1 + GameManager.Instance.autoCollectSpeed);

        if (autoCollectInterval <= 0 && SnowflakeSpawner.Instance.currentSnowflakesList.Count > 0)
        {
            System.Random rand = new System.Random();
            int index = rand.Next(0, SnowflakeSpawner.Instance.currentSnowflakesList.Count);

            if (SnowflakeSpawner.Instance.currentSnowflakesList[index] != null)
            {
                Snowflake sf = SnowflakeSpawner.Instance.currentSnowflakesList[index].GetComponent<Snowflake>();
                sf.isSelectedByCollector = true;

                GameManager.Instance.collectSnowflakes(GameManager.Instance.snowflakeValue, sf.isDouble ? true : false, false, sf.transform.position);
                sf.DestroySnowflake(true);
            }

            autoCollectInterval = originalInterval;
        }
    }

    public void Transplanters()
    {
        autoAbsorbInterval -= Time.deltaTime * (1 + GameManager.Instance.autoAbsorbSpeed);

        if (autoAbsorbInterval <= 0 && GameManager.Instance.snowflakesAmount >= GameManager.Instance.absorbedSnowflakesAmount)
        {
            GameManager.Instance.snowflakesAmount -= GameManager.Instance.absorbedSnowflakesAmount;
            GameUI.Instance.snowflakesUpdateText();
            autoAbsorbAmount++;

            if (autoAbsorbAmount == 10)
            {
                GameManager.Instance.intelligencePointsAmount += GameManager.Instance.obtainedIntelligenceAmount;
                GameManager.Instance.currencyPopout(Camera.main.ScreenToWorldPoint(absorbSnowButton.transform.position), GameManager.Instance.obtainedIntelligenceAmount, "IP", GameUI.Instance.intelligencePointsColor);
                GameUI.Instance.IntelligencePointsUpdateText();
                UnlocksListHandler.Instance.CheckForUnlocks();
                autoAbsorbAmount = 0;
            }

            autoAbsorbInterval = originalInterval;
        }
    }

    public void Worshippers()
    {
        worshippersInterval -= Time.deltaTime;

        if (worshippersInterval <= 0)
        {
            float unlockAttempt = Random.Range(newPowerupCooldown, newPowerupMaxChance);

            if (unlockAttempt < (GameManager.Instance.newPowerupCurrentChance + Powerups.Instance.FateConqueror()))
            {
                if (Powerups.Instance.PowerupsToUnlockList.Count > 0)
                {
                    if (!Unlocks.Instance.blessingsTab.activeSelf)
                    {
                        Unlocks.Instance.BlessingsTabUnlock();
                    }

                    GameObject powerup = Powerups.Instance.PowerupsToUnlockList[0].gameObject;
                    powerup.SetActive(true);
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
                }
                else
                {
                    GameManager.Instance.blessingPointsAmount++;
                    GameManager.Instance.currencyPopout(character.transform.position, 1, "BP", GameUI.Instance.blessingPointsColor);
                    GameUI.Instance.BlessingPointsUpdateText();

                    if (OnBPObtained != null)
                    {
                        OnBPObtained();
                    }
                }

                GameManager.Instance.newPowerupUnlockChance *= 2f;
                newPowerupMaxChance = GameManager.Instance.newPowerupUnlockChance;
                amountOfTimesFailed = 0;
                newPowerupCooldown = GameManager.Instance.newPowerupUnlockChance / 2;
            }

            if (newPowerupCooldown > 0)
            {
                newPowerupCooldown = Mathf.Clamp(newPowerupCooldown - (float)(GameManager.Instance.newPowerupCurrentChance * 2), 0, GameManager.Instance.newPowerupUnlockChance);
            }
            else
            {
                newPowerupMaxChance = Mathf.Clamp(newPowerupMaxChance - (float)(GameManager.Instance.newPowerupCurrentChance / 2), 0.001f, GameManager.Instance.newPowerupUnlockChance);
            }
            amountOfTimesFailed++;

            if (worshipperOMOH.isBeingChecked)
            {
                worshipperOMOH.RefreshText();
            }
            worshippersInterval = originalWorshippersInterval;
        }
    }
}

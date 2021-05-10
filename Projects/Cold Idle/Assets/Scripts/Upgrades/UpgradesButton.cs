using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradesButton : MonoBehaviour
{
    public new string name;
    public string infoPopupSuffix;
    public double cost;
    public CurrencyTypes.currencies currency;
    public float multiplier;
    public int levelsPerTier;
    public float defaultBonus;
    public float bonusPerTier;
    public bool isUnlocked;
    [TextArea] public string logsText;
    public UpgData data = new UpgData();

    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI tierText;
    public TextMeshProUGUI levelText;
    public Image tierImage;
    public Image levelImage;
    public Color logsColor;

    void Start()
    {
        buttonText.text = name;
        SetData();
        UpdateText();
        SetButtonToUninteractable();
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey(name))
        {
            data.curCost = cost;
            data.tier = 1;
            data.level = 1;
            data.isMaxLevel = false;
            data.isUnlocked = this.isUnlocked;
            this.gameObject.SetActive(data.isUnlocked);
        }
        else
        {
            string jData = PlayerPrefs.GetString(name);
            data = JsonUtility.FromJson<UpgData>(jData);
            cost = data.curCost;

            this.gameObject.SetActive(data.isUnlocked);
            this.isUnlocked = data.isUnlocked;
        }
    }

    public void Save()
    {
        data.curCost = cost;
        data.isUnlocked = this.gameObject.activeSelf;
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(name, jData);
    }

    void Update()
    {
        if ((currency == CurrencyTypes.currencies.SF ? GameManager.Instance.GMData.snowflakesAmount : GameManager.Instance.GMData.iceBlocksAmount) >= cost && !button.interactable && !data.isMaxLevel)
        {
            SetButtonToInteractable();
        }
        else if ((currency == CurrencyTypes.currencies.SF ? GameManager.Instance.GMData.snowflakesAmount : GameManager.Instance.GMData.iceBlocksAmount) < cost && button.interactable || data.isMaxLevel)
        {
            SetButtonToUninteractable();
        }

        if (data.isMaxLevel && data.tier < GameManager.Instance.GMData.maxTierAllowed)
        {
            data.isMaxLevel = false;
            CheckIfReachedNewTier();
            UpdateText();
        }
    }

    private void UpdateText()
    {
        tierText.text = data.tier.ToString();
        levelText.text = data.level.ToString();

        if (data.isMaxLevel) costText.text = "T" + data.tier + " MAXED";
        else
        {
            switch (currency)
            {
                case CurrencyTypes.currencies.SF:
                    costText.text = "<color=#B5F0F2>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " SF</color>";
                    break;
                case CurrencyTypes.currencies.IB:
                    costText.text = "<color=#42ABC2>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " IB</color>";
                    break;
                case CurrencyTypes.currencies.IP:
                    costText.text = "<color=#E69CD9>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " IP</color>";
                    break;
                default:
                    break;
            }
        }
    }

    public void OnBuyButtonClick()
    {
        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                GameManager.Instance.GMData.snowflakesAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.snowflakesUpdateText();
                break;
            case CurrencyTypes.currencies.IB:
                GameManager.Instance.GMData.iceBlocksAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.iceBlocksUpdateText();
                break;
            case CurrencyTypes.currencies.IP:
                GameManager.Instance.GMData.intelligencePointsAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.IntelligencePointsUpdateText();
                break;
            default:
                break;
        }
        data.level++;
        cost += Math.Round(cost * multiplier + (data.level * 10));
        data.isMaxLevel = CheckIfMaxLevel();
        CheckIfReachedNewTier();
        UpdateText();
        Shop.Instance.BuyUpgrade(name, defaultBonus, bonusPerTier, data.tier);
        GetComponent<OnMouseOverHandler>().RefreshText();

        if (data.level == 2) Logs.Instance.AddLog(logsText, logsColor);
    }

    private bool CheckIfMaxLevel()
    {
        if (data.level == GameManager.Instance.GMData.maxTierAllowed * levelsPerTier)
        {
            ReachNewTierUnlock();
            return true;
        }
        else return false;
    }

    private void ReachNewTierUnlock()
    {
        if (!Tiers.Instance.tiers[data.tier - 1].activeSelf)
        {
            Tiers.Instance.tiers[data.tier - 1].SetActive(true);
            UnlocksListHandler.Instance.CheckForUnlocks();
        }
    }

    private void CheckIfReachedNewTier()
    {
        if (data.level == data.tier * levelsPerTier && data.tier < GameManager.Instance.GMData.maxTierAllowed) data.tier++;
    }

    private void SetButtonToUninteractable()
    {
        button.interactable = false;
        levelImage.color = new Color(1, 1, 1, 0.14f);
        tierImage.color = new Color(1, 1, 1, 0.14f);
    }

    private void SetButtonToInteractable()
    {
        button.interactable = true;
        levelImage.color = new Color(1, 1, 1, 0.5f);
        tierImage.color = new Color(1, 1, 1, 0.5f);
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct UpgData
{
    public double curCost;
    public int tier;
    public int level;
    public bool isMaxLevel;
    public bool isUnlocked;
}


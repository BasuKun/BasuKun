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
    public int tier;
    public int level;
    public int levelsPerTier;
    public float defaultBonus;
    public float bonusPerTier;
    [TextArea] public string logsText;
    public bool isMaxLevel;

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
        UpdateText();
        SetButtonToUninteractable();
    }

    void Update()
    {
        if ((currency == CurrencyTypes.currencies.SF ? GameManager.Instance.snowflakesAmount : GameManager.Instance.iceBlocksAmount) >= cost && !button.interactable && !isMaxLevel)
        {
            SetButtonToInteractable();
        }
        else if ((currency == CurrencyTypes.currencies.SF ? GameManager.Instance.snowflakesAmount : GameManager.Instance.iceBlocksAmount) < cost && button.interactable || isMaxLevel)
        {
            SetButtonToUninteractable();
        }

        if (isMaxLevel && tier < GameManager.Instance.maxTierAllowed)
        {
            isMaxLevel = false;
            CheckIfReachedNewTier();
            UpdateText();
        }
    }

    private void UpdateText()
    {
        tierText.text = tier.ToString();
        levelText.text = level.ToString();

        if (isMaxLevel) costText.text = "T" + tier + " MAXED";
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
                GameManager.Instance.snowflakesAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.snowflakesUpdateText();
                break;
            case CurrencyTypes.currencies.IB:
                GameManager.Instance.iceBlocksAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.iceBlocksUpdateText();
                break;
            case CurrencyTypes.currencies.IP:
                GameManager.Instance.intelligencePointsAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
                GameUI.Instance.IntelligencePointsUpdateText();
                break;
            default:
                break;
        }
        cost += Math.Round(cost * multiplier);
        level++;
        isMaxLevel = CheckIfMaxLevel();
        CheckIfReachedNewTier();
        UpdateText();
        Shop.Instance.BuyUpgrade(name, defaultBonus, bonusPerTier, tier);
        GetComponent<OnMouseOverHandler>().RefreshText();
        Logs.Instance.AddLog(logsText, logsColor);
    }

    private bool CheckIfMaxLevel()
    {
        if (level == GameManager.Instance.maxTierAllowed * levelsPerTier) return true;
        else return false;
    }

    private void CheckIfReachedNewTier()
    {
        if (level == tier * levelsPerTier && tier < GameManager.Instance.maxTierAllowed) tier++;
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
}

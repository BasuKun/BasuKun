using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsButton : MonoBehaviour
{
    public string stat;
    public double addedCost;
    public double cost;
    public float costMult;
    public CurrencyTypes.currencies currency;
    public int bonus;

    public Button button;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI valueText;
    public StatsData data = new StatsData();

    void Start()
    {
        valueText.text = stat;
        SetData();
        UpdateCost();
        UpdateStatText();
        CheckforInteractibility();

        SaveManager.OnSavedGame += Save;

        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                GameUI.OnSFObtained += CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.IB:
                GameUI.OnIBObtained += CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.IP:
                GameUI.OnIPObtained += CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.BP:
                GameUI.OnBPObtained += CheckforInteractibility;
                break;
            default:
                break;
        }
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey(stat))
        {
            data.cost = cost;
        }
        else
        {
            string jData = PlayerPrefs.GetString(stat);
            data = JsonUtility.FromJson<StatsData>(jData);
            cost = data.cost;
        }
    }

    public void Save()
    {
        data.cost = cost;
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(stat, jData);
    }

    private void UpdateStatText()
    {
        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                valueText.text = stat + ": " + GameUI.Instance.CurrencyLetterFormatting(Player.Instance.data.hitPoints);
                break;
            case CurrencyTypes.currencies.IB:
                valueText.text = stat + ": " + GameUI.Instance.CurrencyLetterFormatting(Player.Instance.data.defense);
                break;
            case CurrencyTypes.currencies.IP:
                valueText.text = stat + ": " + GameUI.Instance.CurrencyLetterFormatting(Player.Instance.data.attack);
                break;
            case CurrencyTypes.currencies.BP:
                valueText.text = stat + ": " + GameUI.Instance.CurrencyLetterFormatting(Player.Instance.data.healing);
                break;
            default:
                break;
        }
    }

    private void UpdateCost()
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
            case CurrencyTypes.currencies.BP:
                costText.text = "<color=#DBDEC2>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " BP</color>";
                break;
            default:
                break;
        }
    }

    private void CheckforInteractibility()
    {
        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                if (GameManager.Instance.GMData.snowflakesAmount >= cost) button.interactable = true;
                else button.interactable = false;
                break;
            case CurrencyTypes.currencies.IB:
                if (GameManager.Instance.GMData.iceBlocksAmount >= cost) button.interactable = true;
                else button.interactable = false;
                break;
            case CurrencyTypes.currencies.IP:
                if (GameManager.Instance.GMData.intelligencePointsAmount >= cost) button.interactable = true;
                else button.interactable = false;
                break;
            case CurrencyTypes.currencies.BP:
                if (GameManager.Instance.GMData.blessingPointsAmount >= cost) button.interactable = true;
                else button.interactable = false;
                break;
            default:
                break;
        }
    }

    public void OnBuyButtonClick()
    {
        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                Player.Instance.data.hitPoints += bonus;
                GameManager.Instance.GMData.snowflakesAmount -= cost;
                GameUI.Instance.snowflakesUpdateText();
                break;
            case CurrencyTypes.currencies.IB:
                Player.Instance.data.defense += bonus;
                GameManager.Instance.GMData.iceBlocksAmount -= cost;
                GameUI.Instance.iceBlocksUpdateText();
                break;
            case CurrencyTypes.currencies.IP:
                Player.Instance.data.attack += bonus;
                GameManager.Instance.GMData.intelligencePointsAmount -= cost;
                GameUI.Instance.IntelligencePointsUpdateText();
                break;
            case CurrencyTypes.currencies.BP:
                Player.Instance.data.healing += bonus;
                GameManager.Instance.GMData.blessingPointsAmount -= cost;
                GameUI.Instance.BlessingPointsUpdateText();
                break;
            default:
                break;
        }

        cost += addedCost;
        UpdateCost();
        UpdateStatText();
        CheckforInteractibility();
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;

        switch (currency)
        {
            case CurrencyTypes.currencies.SF:
                GameUI.OnSFObtained -= CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.IB:
                GameUI.OnIBObtained -= CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.IP:
                GameUI.OnIPObtained -= CheckforInteractibility;
                break;
            case CurrencyTypes.currencies.BP:
                GameUI.OnBPObtained -= CheckforInteractibility;
                break;
            default:
                break;
        }
    }
}

[Serializable]
public struct StatsData
{
    public double cost;
}
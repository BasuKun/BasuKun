using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UnlocksButton : MonoBehaviour
{
    public int ID;
    public new string name;
    public double cost;
    public double appearCost;
    public double bonus;
    public GameObject unlockRequirement;
    [TextArea] public string logsText;

    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI costText;
    public Color logsColor;

    public UnlData data = new UnlData();

    void Awake()
    {
        SetData();
        UpdateText();
        SetButtonToUninteractable();
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey(name))
        {
            data.isUnlocked = false;
            data.isBought = false;
            this.gameObject.SetActive(data.isUnlocked);
        }
        else
        {
            string jData = PlayerPrefs.GetString(name);
            data = JsonUtility.FromJson<UnlData>(jData);

            if (data.isBought)
            {
                data.isUnlocked = false;
                UnlocksListHandler.Instance.UnlocksButtonsList.Remove(this);
            }       
            this.gameObject.SetActive(data.isUnlocked);
        }
    }

    public void Save()
    {
        data.isUnlocked = this.gameObject.activeSelf;
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(name, jData);
    }

    void Update()
    {
        if (GameManager.Instance.GMData.intelligencePointsAmount >= cost && !button.interactable)
        {
            SetButtonToInteractable();
        }
        else if (GameManager.Instance.GMData.intelligencePointsAmount < cost && button.interactable)
        {
            SetButtonToUninteractable();
        }
    }

    public void OnBuyButtonClick()
    {
        GameManager.Instance.GMData.intelligencePointsAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
        GameUI.Instance.IntelligencePointsUpdateText();
        Logs.Instance.AddLog(logsText, logsColor, true);
        Unlocks.Instance.BuyUnlock(ID, bonus);
        UnlocksListHandler.Instance.UnlocksButtonsList.Remove(this);
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();
        UnlocksListHandler.Instance.CheckForUnlocks();

        data.isBought = true;
        this.gameObject.SetActive(false);
    }

    private void UpdateText()
    {
        buttonText.text = name;
        costText.text = costText.text = "<color=#E69CD9>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " IP</color>";
    }

    private void SetButtonToUninteractable()
    {
        button.interactable = false;
    }

    private void SetButtonToInteractable()
    {
        button.interactable = true;
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct UnlData
{
    public bool isUnlocked;
    public bool isBought;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnlocksButton : MonoBehaviour
{
    public int ID;
    public new string name;
    public double cost;
    public double appearCost;
    public GameObject unlockRequirement;
    [TextArea] public string logsText;

    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI costText;
    public Color logsColor;

    void Start()
    {
        UpdateText();
        SetButtonToUninteractable();
    }

    void Update()
    {
        if (GameManager.Instance.intelligencePointsAmount >= cost && !button.interactable && unlockRequirement.activeSelf)
        {
            SetButtonToInteractable();
        }
        else if (GameManager.Instance.intelligencePointsAmount < cost && button.interactable || !unlockRequirement.activeSelf)
        {
            SetButtonToUninteractable();
        }
    }

    public void OnBuyButtonClick()
    {
        GameManager.Instance.intelligencePointsAmount -= cost;
        GameUI.Instance.IntelligencePointsUpdateText();
        Logs.Instance.AddLog(logsText, logsColor);
        Unlocks.Instance.BuyUnlock(ID);
        UnlocksListHandler.Instance.UnlocksButtonsList.Remove(this);
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();
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
}

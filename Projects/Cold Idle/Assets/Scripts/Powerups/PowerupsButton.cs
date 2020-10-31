using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerupsButton : MonoBehaviour
{
    public new string name;
    public double cost;
    public float bonus;
    public float bonusPerLevel;
    public int level;
    public string infoPopupSuffix;
    [TextArea] public string logsText;
    public Color logsColor;
    public bool isBought;
    public bool isEquipped;

    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI costText;

    public Button equipButton;
    public TextMeshProUGUI equipButtonText;
    public PowerupsNodes powerupsNodes;

    void Start()
    {
        UpdateText();
        AddToPowerupsLists();
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.intelligencePointsAmount >= cost && !button.interactable && !isBought)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.intelligencePointsAmount < cost && button.interactable || isBought)
        {
            button.interactable = false;
        }
    }

    private void UpdateText()
    {
        buttonText.text = name;
        costText.text = "<color=#E69CD9>" + GameUI.Instance.CurrencyLetterFormatting(cost) + " IP</color>";
    }

    private void AddToPowerupsLists()
    {
        Powerups.Instance.PowerupsDict.Add(this.name, this);
        Powerups.Instance.PowerupsButtonsList.Add(this);
    }

    public void OnEquipButtonClick()
    {
        isEquipped = !isEquipped;
        GameManager.Instance.equippedPowerups += isEquipped ? 1 : -1;
        equipButtonText.text = isEquipped ? "Unequip" : "Equip";
        GameUI.Instance.equippedPowerupUpdateText();
        GameUI.Instance.CheckForMaxEquippedPowerups();

        var disabledColors = button.colors;
        disabledColors.disabledColor = isEquipped ? new Color(0.47f, 0.918f, 1f, 0.502f) : new Color(0.4188323f, 0.4475258f, 0.490566f, 0.5019608f);
        button.colors = disabledColors;
    }

    public void OnBuyButtonClick()
    {
        GameManager.Instance.intelligencePointsAmount -= cost;
        isBought = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        costText.gameObject.SetActive(false);
        equipButton.gameObject.SetActive(!SpendBPButton.Instance.isClicked);
        powerupsNodes.gameObject.SetActive(SpendBPButton.Instance.isClicked);
        powerupsNodes.AssignImages();
        powerupsNodes.CheckForAvailability();
    }
}

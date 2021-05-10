using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PowerupsButton : MonoBehaviour
{
    public int id;
    public new string name;
    public double cost;
    public float bonus;
    public float bonusPerLevel;
    public string infoPopupSuffix;
    [TextArea] public string logsText;
    public Color logsColor;
    public BlsData data = new BlsData();

    public Button button;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI costText;

    public Button equipButton;
    public TextMeshProUGUI equipButtonText;
    public PowerupsNodes powerupsNodes;

    void Start()
    {
        SetData();
        AddToPowerupsLists();
        UpdateText();     
        button.interactable = false;
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey(name))
        {
            data.level = 0;
            data.isBought = false;
            data.isEquipped = false;
            data.isUnlocked = false;
            this.gameObject.SetActive(false);
        }
        else
        {
            string jData = PlayerPrefs.GetString(name);
            data = JsonUtility.FromJson<BlsData>(jData);

            this.gameObject.SetActive(data.isUnlocked);

            if (data.isBought)
            {
                costText.gameObject.SetActive(false);
                equipButton.gameObject.SetActive(true);
                powerupsNodes.AssignImages();
                powerupsNodes.CheckForAvailability();
            }
            if (data.isEquipped)
            {
                equipButtonText.text = "Unequip";
                GameUI.Instance.equippedPowerupUpdateText();
                GameUI.Instance.CheckForMaxEquippedPowerups();

                var disabledColors = button.colors;
                disabledColors.disabledColor = new Color(0.47f, 0.918f, 1f, 0.502f);
                button.colors = disabledColors;
            }
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(name, jData);
    }

    void Update()
    {
        if (GameManager.Instance.GMData.intelligencePointsAmount >= cost && !button.interactable && !data.isBought)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.GMData.intelligencePointsAmount < cost && button.interactable || data.isBought)
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

        if (!data.isUnlocked)
        {
            Powerups.Instance.PowerupsToUnlockList.Add(this);
            Powerups.Instance.PowerupsToUnlockList.Sort((x, y) => x.id.CompareTo(y.id));
        }
    }

    public void OnEquipButtonClick()
    {
        data.isEquipped = !data.isEquipped;
        GameManager.Instance.GMData.equippedPowerups += data.isEquipped ? 1 : -1;
        equipButtonText.text = data.isEquipped ? "Unequip" : "Equip";
        GameUI.Instance.equippedPowerupUpdateText();
        GameUI.Instance.CheckForMaxEquippedPowerups();

        var disabledColors = button.colors;
        disabledColors.disabledColor = data.isEquipped ? new Color(0.47f, 0.918f, 1f, 0.502f) : new Color(0.4188323f, 0.4475258f, 0.490566f, 0.5019608f);
        button.colors = disabledColors;
    }

    public void OnBuyButtonClick()
    {
        GameManager.Instance.GMData.intelligencePointsAmount -= Math.Round(cost * (1 - Powerups.Instance.ResourcesRecovery()));
        data.isBought = true;
        GameUI.Instance.IntelligencePointsUpdateText();
        costText.gameObject.SetActive(false);
        equipButton.gameObject.SetActive(!GameUI.Instance.hasClickedBP);
        GameUI.Instance.CheckForMaxEquippedPowerups();
        powerupsNodes.gameObject.SetActive(GameUI.Instance.hasClickedBP);
        powerupsNodes.AssignImages();
        powerupsNodes.CheckForAvailability();
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct BlsData
{
    public int level;
    public bool isBought;
    public bool isEquipped;
    public bool isUnlocked;
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopTabsHandler : MonoBehaviour
{
    public GameObject UpgradesMenu;
    public GameObject UnlocksMenu;
    public GameObject PowerupsMenu;
    public Button UpgradesTabButton;
    public Button UnlocksTabButton;
    public Button PowerupsTabButton;
    public TextMeshProUGUI UpgradesTabText;
    public TextMeshProUGUI UnlocksTabText;
    public TextMeshProUGUI PowerupsTabText;

    public TabData data = new TabData();

    void Start()
    {
        SetData();
        OnTabsButtonsPress("upgrades");
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("Tabs"))
        {
            UnlocksTabButton.gameObject.SetActive(false);
            PowerupsTabButton.gameObject.SetActive(false);
        }
        else
        {
            string jData = PlayerPrefs.GetString("Tabs");
            data = JsonUtility.FromJson<TabData>(jData);
            UnlocksTabButton.gameObject.SetActive(false);

            UnlocksTabButton.gameObject.SetActive(data.hasUnlocksUnlocked);
            PowerupsTabButton.gameObject.SetActive(data.hasBlessingsUnlocked);
        }
    }

    public void Save()
    {
        data.hasUnlocksUnlocked = UnlocksTabButton.gameObject.activeSelf;
        data.hasBlessingsUnlocked = PowerupsTabButton.gameObject.activeSelf;
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("Tabs", jData);
    }

    public void OnTabsButtonsPress(string selectedMenu)
    {
        UpgradesMenu.SetActive(false);
        UnlocksMenu.SetActive(false);
        PowerupsMenu.SetActive(false);

        UpgradesTabButton.interactable = true;
        UnlocksTabButton.interactable = true;
        PowerupsTabButton.interactable = true;

        UpgradesTabText.color = Color.black;
        UnlocksTabText.color = Color.black;
        PowerupsTabText.color = Color.black;

        switch (selectedMenu)
        {
            case "upgrades":
                UpgradesMenu.SetActive(true);
                UpgradesTabButton.interactable = false;
                UpgradesTabText.color = Color.white;
                break;
            case "unlocks":
                UnlocksMenu.SetActive(true);
                UnlocksListHandler.Instance.CheckForUnlocks();
                UnlocksTabButton.interactable = false;
                UnlocksTabText.color = Color.white;
                break;
            case "powerups":
                PowerupsMenu.SetActive(true);
                PowerupsTabButton.interactable = false;
                PowerupsTabText.color = Color.white;
                break;
        }
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct TabData
{
    public bool hasUpgradesUnlocked;
    public bool hasUnlocksUnlocked;
    public bool hasBlessingsUnlocked;
}

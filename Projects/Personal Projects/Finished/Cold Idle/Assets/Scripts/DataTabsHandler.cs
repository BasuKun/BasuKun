using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataTabsHandler : MonoBehaviour
{
    public GameObject LogsMenu;
    public GameObject SettingsMenu;
    public Button LogsTabButton;
    public Button SettingsTabButton;
    public TextMeshProUGUI LogsTabText;
    public TextMeshProUGUI SettingsTabText;

    void Start()
    {
        OnTabsButtonsPress("settings");
        OnTabsButtonsPress("logs");
    }

    public void OnTabsButtonsPress(string selectedMenu)
    {
        LogsMenu.SetActive(false);
        SettingsMenu.SetActive(false);

        LogsTabButton.interactable = true;
        SettingsTabButton.interactable = true;

        LogsTabText.color = Color.black;
        SettingsTabText.color = Color.black;

        switch (selectedMenu)
        {
            case "logs":
                LogsMenu.SetActive(true);
                LogsTabButton.interactable = false;
                LogsTabText.color = Color.white;
                break;
            case "settings":
                SettingsMenu.SetActive(true);
                SettingsTabButton.interactable = false;
                SettingsTabText.color = Color.white;
                break;
        }
    }
}

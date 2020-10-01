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

    void Start()
    {
        OnTabsButtonsPress("upgrades");
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
}

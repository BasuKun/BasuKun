using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAllButton : MonoBehaviour
{
    public List<PlayerStatsButton> upgrades = new List<PlayerStatsButton>();
    public List<Button> upgradesButtons = new List<Button>();
    public Button button;

    void Update()
    {
        button.interactable = (upgradesButtons[0].interactable
            || upgradesButtons[1].interactable
            || upgradesButtons[2].interactable
            || upgradesButtons[3].interactable);
    }

    public void BuyAllUpgrades()
    {
        foreach (var upgrade in upgrades)
        {
            Button button = upgrade.gameObject.GetComponentInChildren<Button>();

            while (button.interactable)
            {
                upgrade.OnBuyButtonClick();
            }
        }
    }
}

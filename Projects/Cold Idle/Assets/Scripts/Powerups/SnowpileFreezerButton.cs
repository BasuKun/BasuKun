using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SnowpileFreezerButton : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI equipText;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.intelligencePointsAmount >= Shop.Instance.snowpileFreezerCost && !button.interactable && !GameManager.Instance.boughtSnowpileFreezer)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.intelligencePointsAmount < Shop.Instance.snowpileFreezerCost && button.interactable || GameManager.Instance.boughtSnowpileFreezer)
        {
            button.interactable = false;
        }
    }

    public void OnEquipButtonClick()
    {
        GameManager.Instance.equippedSnowpileFreezer = !GameManager.Instance.equippedSnowpileFreezer;
        GameManager.Instance.equippedPowerups += GameManager.Instance.equippedSnowpileFreezer ? 1 : -1;
        equipText.text = GameManager.Instance.equippedSnowpileFreezer ? "Unequip" : "Equip";
        GameUI.Instance.equippedPowerupUpdateText();
        GameUI.Instance.CheckForMaxEquippedPowerups();

        var disabledColors = button.colors;
        disabledColors.disabledColor = GameManager.Instance.equippedSnowpileFreezer ? new Color(0.47f, 0.918f, 1f, 0.502f) : new Color(0.4188323f, 0.4475258f, 0.490566f, 0.5019608f);
        button.colors = disabledColors;
    }
}

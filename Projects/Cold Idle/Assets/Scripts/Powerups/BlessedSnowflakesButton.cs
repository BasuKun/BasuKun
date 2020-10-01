using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlessedSnowflakesButton : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI equipText;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.intelligencePointsAmount >= Shop.Instance.blessedSnowflakesCost && !button.interactable && !GameManager.Instance.boughtBlessedSnowflakes)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.intelligencePointsAmount < Shop.Instance.blessedSnowflakesCost && button.interactable || GameManager.Instance.boughtBlessedSnowflakes)
        {
            button.interactable = false;
        }
    }

    public void OnEquipButtonClick()
    {
        GameManager.Instance.equippedBlessedSnowflakes = !GameManager.Instance.equippedBlessedSnowflakes;
        GameManager.Instance.equippedPowerups += GameManager.Instance.equippedBlessedSnowflakes ? 1 : -1;
        equipText.text = GameManager.Instance.equippedBlessedSnowflakes ? "Unequip" : "Equip";
        GameUI.Instance.equippedPowerupUpdateText();
        GameUI.Instance.CheckForMaxEquippedPowerups();

        var disabledColors = button.colors;
        disabledColors.disabledColor = GameManager.Instance.equippedBlessedSnowflakes ? new Color(0.47f, 0.918f, 1f, 0.502f) : new Color(0.4188323f, 0.4475258f, 0.490566f, 0.5019608f);
        button.colors = disabledColors;
    }
}

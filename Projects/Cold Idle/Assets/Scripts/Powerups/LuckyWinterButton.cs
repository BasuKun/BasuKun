﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LuckyWinterButton : MonoBehaviour
{
    public Button button;
    public TextMeshProUGUI equipText;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.intelligencePointsAmount >= Shop.Instance.luckyWinterCost && !button.interactable && !GameManager.Instance.boughtLuckyWinter)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.intelligencePointsAmount < Shop.Instance.luckyWinterCost && button.interactable || GameManager.Instance.boughtLuckyWinter)
        {
            button.interactable = false;
        }
    }

    public void OnEquipButtonClick()
    {
        GameManager.Instance.equippedLuckyWinter = !GameManager.Instance.equippedLuckyWinter;
        GameManager.Instance.equippedPowerups += GameManager.Instance.equippedLuckyWinter ? 1 : -1;
        equipText.text = GameManager.Instance.equippedLuckyWinter ? "Unequip" : "Equip";
        GameUI.Instance.equippedPowerupUpdateText();
        GameUI.Instance.CheckForMaxEquippedPowerups();

        var disabledColors = button.colors;
        disabledColors.disabledColor = GameManager.Instance.equippedLuckyWinter ? new Color(0.47f, 0.918f, 1f, 0.502f) : new Color(0.4188323f, 0.4475258f, 0.490566f, 0.5019608f);
        button.colors = disabledColors;
    }
}

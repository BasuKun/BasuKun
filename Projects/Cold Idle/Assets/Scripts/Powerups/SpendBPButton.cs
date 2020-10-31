using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpendBPButton : MonoBehaviour
{
    public bool isClicked = false;

    public TextMeshProUGUI text;
    public Button button;

    public TextMeshProUGUI equippedAmountText;
    public TextMeshProUGUI costText;

    public static SpendBPButton Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void UpdateButtonText()
    {
        text.text = isClicked ? "Equip" : "Spend BPs";
    }

    private void ActivateNodes()
    {
        foreach (PowerupsButton powerup in Powerups.Instance.PowerupsButtonsList)
        {
            if (powerup.isBought)
            {
                powerup.gameObject.GetComponentInChildren<EquipButton>(true).gameObject.SetActive(!isClicked);
                powerup.gameObject.GetComponentInChildren<PowerupsNodes>(true).gameObject.SetActive(isClicked);
            }
        }
    }

    private void ActivateHeaderText()
    {
        equippedAmountText.gameObject.SetActive(!isClicked);
        costText.gameObject.SetActive(isClicked);
    }

    public void OnButtonPress()
    {
        isClicked = !isClicked;
        UpdateButtonText();
        ActivateNodes();
        ActivateHeaderText();
    }
}

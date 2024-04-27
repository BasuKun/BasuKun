using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceButtons : MonoBehaviour
{
    public Button okButton;
    public Button rerollButton;
    public Button swapButton;

    public static DiceButtons Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        ActivateButtons(false);
    }

    public void ActivateButtons(bool isInteractable)
    {
        okButton.interactable = isInteractable;
        rerollButton.interactable = isInteractable;
        swapButton.interactable = isInteractable;
    }

    public void CheckForInteractableConditions()
	{
        rerollButton.interactable = Battle.Instance.curSelectedDices > 0 && !Battle.Instance.isAutoAttacking ? true : false;
        swapButton.interactable = Battle.Instance.curSelectedDices == 2 && !Battle.Instance.isAutoAttacking ? true : false;
    }
}

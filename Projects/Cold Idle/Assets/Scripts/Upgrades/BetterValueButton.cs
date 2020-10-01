using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BetterValueButton : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.snowflakesAmount >= Shop.Instance.betterValueCost && !button.interactable)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.snowflakesAmount < Shop.Instance.betterValueCost && button.interactable)
        {
            button.interactable = false;
        }
    }
}

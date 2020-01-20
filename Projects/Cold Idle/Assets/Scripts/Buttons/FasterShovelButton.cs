using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FasterShovelButton : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.snowflakesAmount >= Shop.Instance.fasterShovelCost && !button.interactable)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.snowflakesAmount < Shop.Instance.fasterShovelCost && button.interactable)
        {
            button.interactable = false;
        }
    }
}

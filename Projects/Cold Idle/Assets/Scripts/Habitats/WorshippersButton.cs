using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WorshippersButton : MonoBehaviour
{
    public Button button;
    public bool isLeft;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (isLeft ? GameManager.Instance.GMData.worshippersAmount >= PopulationMoveAmount.Instance.moveAmount : GameManager.Instance.GMData.idlePopulationAmount >= PopulationMoveAmount.Instance.moveAmount)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}

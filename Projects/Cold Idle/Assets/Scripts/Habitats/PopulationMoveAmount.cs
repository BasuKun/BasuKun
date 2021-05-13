using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopulationMoveAmount : MonoBehaviour
{
    public int moveAmount = 1;

    public Button button;
    public TextMeshProUGUI text;
    public static PopulationMoveAmount Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeAmount()
    {
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();

        switch (moveAmount)
        {
            case 1:
                moveAmount = 10;
                break;
            case 10:
                moveAmount = 100;
                break;
            case 100:
                moveAmount = 1;
                break;
            default:
                break;
        }
        text.text = "x" + moveAmount;
    }
}

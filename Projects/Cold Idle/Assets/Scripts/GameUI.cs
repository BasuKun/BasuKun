using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [Header("BUTTONS TEXTS")]
    public TextMeshProUGUI moreSnowButtonText;
    public TextMeshProUGUI biggerRadiusButtonText;

    [Header("CURRENCIES")]
    public TextMeshProUGUI snowflakesAmountText;

    public static GameUI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        moreSnowButtonUpdateText();
        biggerRadiusButtonUpdateText();
    }

    public void snowflakesUpdateText()
    {
        snowflakesAmountText.text = "SF: " + GameManager.Instance.snowflakesAmount;
    }

    public void moreSnowButtonUpdateText()
    {
        moreSnowButtonText.text = "More Snow! " + Shop.Instance.moreSnowCost + " SF";
    }

    public void biggerRadiusButtonUpdateText()
    {
        biggerRadiusButtonText.text = "Bigger Radius! " + Shop.Instance.biggerRadiusCost + " SF";
    }
}

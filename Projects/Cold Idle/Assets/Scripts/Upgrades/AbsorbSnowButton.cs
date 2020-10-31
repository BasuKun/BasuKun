using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AbsorbSnowButton : MonoBehaviour
{
    public Button button;
    public ParticleSystem snowBurst;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.snowflakesAmount >= GameManager.Instance.absorbedSnowflakesAmount)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    public void AbsorbSnow()
    {
        GameManager.Instance.snowflakesAmount -= GameManager.Instance.absorbedSnowflakesAmount;
        GameManager.Instance.absorbedSnowflakes++;
        GameUI.Instance.snowflakesUpdateText();

        if (GameManager.Instance.absorbedSnowflakes == 10)
        {
            GameManager.Instance.absorbedSnowflakes = 0;
            GameManager.Instance.intelligencePointsAmount += GameManager.Instance.obtainedIntelligenceAmount;
            GameUI.Instance.IntelligencePointsUpdateText();
            GameManager.Instance.currencyPopout(Camera.main.ScreenToWorldPoint(button.transform.position), GameManager.Instance.obtainedIntelligenceAmount, "IP", GameUI.Instance.intelligencePointsColor);
            UnlocksListHandler.Instance.CheckForUnlocks();
        }
    }
}

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
        if (GameManager.Instance.GMData.snowflakesAmount >= GameManager.Instance.GMData.absorbedSnowflakesAmount)
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
        GameManager.Instance.GMData.snowflakesAmount -= GameManager.Instance.GMData.absorbedSnowflakesAmount;
        GameManager.Instance.GMData.absorbedSnowflakes++;
        GameUI.Instance.snowflakesUpdateText();

        if (GameManager.Instance.GMData.absorbedSnowflakes == 10)
        {
            GameManager.Instance.GMData.absorbedSnowflakes = 0;
            double valueToAdd = Mathf.Round(GameManager.Instance.GMData.obtainedIntelligenceAmount * ConquerRewards.Instance.data.ipReward * GameManager.Instance.GMData.tempMultiplier);
            GameManager.Instance.GMData.intelligencePointsAmount += valueToAdd;
            GameUI.Instance.IntelligencePointsUpdateText();
            GameManager.Instance.currencyPopout('+', Camera.main.ScreenToWorldPoint(button.transform.position), valueToAdd, "IP", GameUI.Instance.intelligencePointsColor);
            UnlocksListHandler.Instance.CheckForUnlocks();
        }
    }
}

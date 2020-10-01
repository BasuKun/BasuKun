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
        if (GameManager.Instance.snowflakesAmount > 0)
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
        GameManager.Instance.snowflakesAmount--;
        GameManager.Instance.absorbedSnowflakes++;
        GameUI.Instance.snowflakesUpdateText();

        if (GameManager.Instance.absorbedSnowflakes == 10)
        {
            GameManager.Instance.absorbedSnowflakes = 0;
            GameManager.Instance.intelligencePointsAmount++;
            GameUI.Instance.IntelligencePointsUpdateText();
            GameManager.Instance.currencyPopout(Camera.main.ScreenToWorldPoint(button.transform.position), 1, "IP", GameUI.Instance.intelligencePointsColor);
        }
    }
}

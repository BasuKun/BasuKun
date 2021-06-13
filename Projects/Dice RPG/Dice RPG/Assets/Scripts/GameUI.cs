using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    [Header("SELECT SCREEN")]
    public GameObject selectScreen;
    public Button leftArrowButton;
    public Button rightArrowButton;
    public Button confirmSelectionButton;

    [Header("AP SCREEN")]
    public GameObject diceRack;
    public GameObject enemyDiceRack;
    public GameObject soulsParent;
    public TextMeshProUGUI soulsCurrencyAmountText;
    public MostRolledDigit playerMostRolledDigitObject;
    public MostRolledDigit enemyMostRolledDigitObject;

    public static GameUI Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator SwitchToAP()
    {
        leftArrowButton.interactable = false;
        rightArrowButton.interactable = false;
        confirmSelectionButton.interactable = false;

        float acceleration = 0f;
        while (selectScreen.transform.position.y > 100)
        {
            selectScreen.transform.position -= new Vector3(0, -1.3f + acceleration, 0) * 100 * Time.deltaTime;
            acceleration += 0.08f;
            yield return new WaitForFixedUpdate();
        }

        yield return null;
    }

    public void UpdateSoulsCurrencyText()
    {
        soulsCurrencyAmountText.text = Player.Instance.soulsCurrency.ToString();
    }
}

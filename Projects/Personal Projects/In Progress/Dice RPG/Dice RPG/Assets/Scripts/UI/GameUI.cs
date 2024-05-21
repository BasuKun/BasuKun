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
	public TextMeshProUGUI levelText;
	public Slider expBar;
	public MostRolledDigit playerMostRolledDigitObject;
	public MostRolledDigit enemyMostRolledDigitObject;
	public Slider idleSlider;
	public Image idleSliderImage;
	public List<Sprite> idleSliderSprites = new List<Sprite>();
	public List<GameObject> battleFilters = new List<GameObject>();

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

		foreach (var item in Shop.Instance.ItemsInShop)
			item.CheckAffordability();
	}

	public void UpdateLevelText()
	{
		levelText.text = "Lv " + Player.Instance.level.ToString();
	}

	public void UpdateExpBar()
	{
		expBar.value = (float)Player.Instance.experience / (float)Player.Instance.experienceNeeded;
	}

	public void OnIdleSliderChange()
	{
		Battle.Instance.isAutoAttacking = idleSlider.value == 1 ? true : false;
		idleSliderImage.sprite = idleSliderSprites[(int)idleSlider.value];
		DiceButtons.Instance.CheckForInteractableConditions();
	}

	public void SetBattleFilter(bool active)
	{
		foreach (var filter in battleFilters)
			filter.SetActive(active);
	}
}

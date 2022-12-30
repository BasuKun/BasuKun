using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;

public class StatsMenu : MonoBehaviour
{
    public int[] statsToAdd = { 0, 0, 0, 0, 0};
    public Color statNormalColor;
    public Color statModifiedColor;
    public Color rangesNormalColor;
    public Color rangedModifiedColor;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI attackRangeText;
    public TextMeshProUGUI skillRangeText;
    public Button confirmButton;
    public List<statData> statsList = new List<statData>();
    public Dictionary<string, statData> statsDictionary = new Dictionary<string, statData>();

    public static StatsMenu Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        foreach (var stat in statsList)
            statsDictionary.Add(stat.name, stat);
    }

    public void UpdateDamageRanges()
    {
        for (int i = 0; i < Player.Instance.attackRange.Length; i++)
            Player.Instance.attackRange[i] = Balancing.GetAttackValue(i + 1, true);

        for (int i = 0; i < Player.Instance.skillRange.Length; i++)
            Player.Instance.skillRange[i] = Balancing.GetSkillValue(i + 1, true);

        UpdateDamageRangesText(Player.Instance.attackRange, Player.Instance.skillRange);
    }

    public void UpdateDamageRangesText(int[] attackRange, int[] skillRange)
	{
        attackRangeText.text = "Attack Range: " + attackRange.Min().ToString() + "-" + attackRange.Max().ToString();
        skillRangeText.text = "Skill Range: " + skillRange.Min().ToString() + "-" + skillRange.Max().ToString();
    }

    public void UpdatePoints()
	{
        pointsText.text = Player.Instance.statPoints.ToString();

        bool hasStatPoints = Player.Instance.statPoints > 0 ? true : false;

		foreach (var stat in statsDictionary)
            stat.Value.plusButton.gameObject.SetActive(hasStatPoints);
    }

    public void UpdateStats()
	{
        statsDictionary["vitality"].SetValue(Player.Instance.vitality + statsToAdd[statsDictionary["vitality"].index]);
        statsDictionary["strength"].SetValue(Player.Instance.strength + statsToAdd[statsDictionary["strength"].index]);
        statsDictionary["finesse"].SetValue(Player.Instance.finesse + statsToAdd[statsDictionary["finesse"].index]);
        statsDictionary["recovery"].SetValue(Player.Instance.recovery + statsToAdd[statsDictionary["recovery"].index]);
        statsDictionary["greed"].SetValue(Player.Instance.greed + statsToAdd[statsDictionary["greed"].index]);
    }

    public void OnPlusButtonClick(string name)
	{
        statsToAdd[statsDictionary[name].index]++;
        confirmButton.gameObject.SetActive(true);

        statsDictionary[name].minusButton.gameObject.SetActive(true);
        statsDictionary[name].valueText.color = statModifiedColor;

        Player.Instance.statPoints--;
        UpdatePoints();
        UpdateStats();
        UpdateDamageRanges();
    }

    public void OnMinusButtonClick(string name)
    {
        statsToAdd[statsDictionary[name].index]--;

        if (statsToAdd[statsDictionary[name].index] == 0)
		{
            statsDictionary[name].valueText.color = statNormalColor;
            statsDictionary[name].minusButton.gameObject.SetActive(false);
        }

        int pointsSpent = statsToAdd.Sum();
		if (pointsSpent == 0)
            confirmButton.gameObject.SetActive(false);

        Player.Instance.statPoints++;
        UpdatePoints();
        UpdateStats();
        UpdateDamageRanges();
    }

    public void OnConfirmButtonClick()
	{
        confirmButton.gameObject.SetActive(false);

        Player.Instance.vitality += statsToAdd[statsDictionary["vitality"].index];
        Player.Instance.strength += statsToAdd[statsDictionary["strength"].index];
        Player.Instance.finesse += statsToAdd[statsDictionary["finesse"].index];
        Player.Instance.recovery += statsToAdd[statsDictionary["recovery"].index];
        Player.Instance.greed += statsToAdd[statsDictionary["greed"].index];

        Array.Clear(statsToAdd, 0, statsToAdd.Length);

        foreach (var stat in statsDictionary)
		{
            stat.Value.minusButton.gameObject.SetActive(false);
            stat.Value.valueText.color = statNormalColor;

            bool hasStatPoints = Player.Instance.statPoints > 0 ? true : false;
            stat.Value.plusButton.gameObject.SetActive(hasStatPoints);
        }
    }
}

[Serializable]
public class statData
{
    public int index;
    public string name;
    public TextMeshProUGUI valueText;
    public Button plusButton;
    public Button minusButton;

    public void SetValue(int value)
	{
        valueText.text = value.ToString();
	}
}
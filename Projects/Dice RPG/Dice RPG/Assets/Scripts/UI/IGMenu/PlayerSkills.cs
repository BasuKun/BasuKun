using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerSkills : MonoBehaviour
{
	public Color pathUnlockedColor;
	public TextMeshProUGUI skillPointsText;
	public List<SkillTreeButton> skillTreeButtonsList = new List<SkillTreeButton>();
	public static PlayerSkills Instance;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	private void Start()
	{
		UpdateSkillPointsText();
		CheckForUnlockedButtons();
	}

	public void UpdateSkillPointsText()
	{
		skillPointsText.text = Player.Instance.skillPoints.ToString();
	}

	public void UnlockSkill(string skillName)
	{
		if (BuffSkillsDictionary.Instance.buffSkillsDictionary.ContainsKey(skillName))
			Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary[skillName]);

		else if (DamageSkillsDictionary.Instance.damageSkillsDictionary.ContainsKey(skillName))
			Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary[skillName]);

		else if (DefenseSkillsDictionary.Instance.defenseSkillsDictionary.ContainsKey(skillName))
			Player.Instance.defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary[skillName]);

		else if (EffectSkillsDictionary.Instance.effectSkillsDictionary.ContainsKey(skillName))
			Player.Instance.effectSkills.Add(EffectSkillsDictionary.Instance.effectSkillsDictionary[skillName]);

		else if (ReactionSkillsDictionary.Instance.reactionSkillsDictionary.ContainsKey(skillName))
			Player.Instance.reactionSkills.Add(ReactionSkillsDictionary.Instance.reactionSkillsDictionary[skillName]);

		else if (SummonSkillsDictionary.Instance.summonSkillsDictionary.ContainsKey(skillName))
			Player.Instance.summonSkills.Add(SummonSkillsDictionary.Instance.summonSkillsDictionary[skillName]);
	}

	public void CheckForUnlockedButtons()
	{
		foreach (var skill in skillTreeButtonsList)
		{
			bool isUnlockable = true;

			if (skill.currentLevel == skill.maxLevel)
			{
				skill.button.interactable = false;
				isUnlockable = false;
				continue;
			}

			if (Player.Instance.skillPoints < skill.currentLevel + 1)
			{
				skill.button.interactable = false;
				isUnlockable = false;
				continue;
			}

			foreach (var requirement in skill.unlockRequirements)
			{
				if (requirement.currentLevel == 0)
				{
					skill.button.interactable = false;
					isUnlockable = false;
					continue;
				}
			}

			skill.button.interactable = isUnlockable;
		}
	}

	public void CheckForUnlockedPaths()
	{
		foreach (var skill in skillTreeButtonsList)
		{
			if (skill.unlockRequirements.Count == 0) continue;

			for (int i = 0; i < skill.unlockRequirements.Count; i++)
			{
				if (skill.unlockRequirements[i].currentLevel > 0)
					skill.lines[i].color = pathUnlockedColor;
			}
		}
	}
}

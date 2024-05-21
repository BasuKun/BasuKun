using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class PlayerSkills : MonoBehaviour
{
	public Color pathUnlockedColor;
	public TextMeshProUGUI skillPointsText;
	public List<SkillTreeButton> skillTreeButtonsList = new List<SkillTreeButton>();
	public List<GameObject> skillTrees = new List<GameObject>();
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
		ISkill skill = null;

		if (BuffSkillsDictionary.Instance.buffSkillsDictionary.ContainsKey(skillName))
		{
			skill = BuffSkillsDictionary.Instance.buffSkillsDictionary[skillName];
			Player.Instance.buffSkills.Add((IBuffSkill)skill);
		}
		else if (DamageSkillsDictionary.Instance.damageSkillsDictionary.ContainsKey(skillName))
		{
			skill = DamageSkillsDictionary.Instance.damageSkillsDictionary[skillName];
			Player.Instance.damageSkills.Add((IDamageSkill)skill);
		}
		else if (DefenseSkillsDictionary.Instance.defenseSkillsDictionary.ContainsKey(skillName))
		{
			skill = DefenseSkillsDictionary.Instance.defenseSkillsDictionary[skillName];
			Player.Instance.defenseSkills.Add((IDefenseSkill)skill);
		}
		else if (EffectSkillsDictionary.Instance.effectSkillsDictionary.ContainsKey(skillName))
		{
			skill = EffectSkillsDictionary.Instance.effectSkillsDictionary[skillName];
			Player.Instance.effectSkills.Add((IEffectSkill)skill);
		}
		else if (ReactionSkillsDictionary.Instance.reactionSkillsDictionary.ContainsKey(skillName))
		{
			skill = ReactionSkillsDictionary.Instance.reactionSkillsDictionary[skillName];
			Player.Instance.reactionSkills.Add((IReactionSkill)skill);
		}
		else if (SummonSkillsDictionary.Instance.summonSkillsDictionary.ContainsKey(skillName))
		{
			skill = SummonSkillsDictionary.Instance.summonSkillsDictionary[skillName];
			Player.Instance.summonSkills.Add((ISummonSkill)skill);
		}

		if (Player.Instance.equippedSkills.Count(skill => skill != null) < Player.Instance.skillSlotsAmount)
		{
			int nullIndex = Player.Instance.equippedSkills.FindIndex(skill => skill == null);

			if (nullIndex != -1)
				Player.Instance.equippedSkills[nullIndex] = skill;
			else
				Player.Instance.equippedSkills.Add(skill);

			skill.isEquipped = true;
			SkillsBar.Instance.UpdateSkillsBar();
		}
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

	public void ActivateSkillTree(CurrentClass.classes curClass)
	{
		foreach (var skillTree in skillTrees)
			skillTree.SetActive(false);

		switch (curClass)
		{
			case CurrentClass.classes.Warrior:
				skillTrees[0].SetActive(true);
				break;
			case CurrentClass.classes.Ronin:
				skillTrees[4].SetActive(true);
				break;
			case CurrentClass.classes.Gunslinger:
				skillTrees[2].SetActive(true);
				break;
			case CurrentClass.classes.Technomancer:
				skillTrees[3].SetActive(true);
				break;
			case CurrentClass.classes.Warlock:
				skillTrees[5].SetActive(true);
				break;
			case CurrentClass.classes.Healer:
				skillTrees[1].SetActive(true);
				break;
			default:
				break;
		}
	}
}

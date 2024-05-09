using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SkillsBar : MonoBehaviour
{
	public List<SkillsBarSlot> skillSlots = new List<SkillsBarSlot>();
	private int lastSeenSkillSlotsAmount = 0;

	public static SkillsBar Instance;

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	private void Start()
	{
		UpdateSkillSlotsAmount();
	}

	private void Update()
	{
		if (Player.Instance.skillSlotsAmount != lastSeenSkillSlotsAmount)
			UpdateSkillSlotsAmount();
	}

	private void UpdateSkillSlotsAmount()
	{
		foreach (var slot in skillSlots)
			slot.gameObject.SetActive(false);

		for (int i = 0; i < Player.Instance.skillSlotsAmount; i++)
			skillSlots[i].gameObject.SetActive(true);

		lastSeenSkillSlotsAmount = Player.Instance.skillSlotsAmount;
	}

	public void UpdateSkillsBar()
	{
		for (int i = 0; i < Player.Instance.equippedSkills.Count; i++)
		{
			if (Player.Instance.equippedSkills[i] != null)
				skillSlots[i].EquipSkill(Player.Instance.equippedSkills[i].skillData);
			else
				skillSlots[i].EmptySkillSlot();
		}
	}

	public void CheckTriggers()
	{
		foreach (var skill in skillSlots)
		{
			if (skill.slotState != SkillsBarSlot.skillSlotState.Empty && skill.slotState != SkillsBarSlot.skillSlotState.OnCooldown)
				skill.CheckTrigger();
		}
	}

	public void ResetTriggers()
	{
		foreach (var skill in skillSlots)
		{
			if (skill.slotState != SkillsBarSlot.skillSlotState.Empty)
				skill.ResetTrigger();
		}
	}

	public void DropSkillOnBar(SkillIcon skillIcon)
	{
		foreach (var slot in skillSlots)
		{
			RectTransform slotRectTransform = slot.gameObject.GetComponent<RectTransform>();
			if (RectTransformUtility.RectangleContainsScreenPoint(slotRectTransform, Input.mousePosition, null))
			{
				Skill droppedSkill = skillIcon.skillData;

				if (slot.skill == droppedSkill) // Dropped in the same slot as equipped
					return;

				int originalIndex = skillSlots.FindIndex(s => s.skill == droppedSkill);
				Skill currentSkill = slot.skill != null ? slot.skill : null;

				if (originalIndex != -1)  // Skill was already equipped in another slot
				{
					if (slot.skill != null)  // Dropped on a slot that already has a skill
					{
						currentSkill = slot.skill;
						SwapSkillsInPlayerList(GetSkillInDicionary(droppedSkill), GetSkillInDicionary(currentSkill));
					}
					else  // Dropped on an empty slot
					{
						skillSlots[originalIndex].EmptySkillSlot();
						RemoveSkillFromPlayerList(originalIndex);
					}

					slot.EquipSkill(droppedSkill);

					if (currentSkill == null) 
						AddSkillToPlayerList(GetSkillInDicionary(droppedSkill), skillSlots.FindIndex(s => s.skill == droppedSkill));
					else
						skillSlots[originalIndex].EquipSkill(currentSkill);
				}
				else // Skill was not already equipped in another slot
				{
					slot.EquipSkill(droppedSkill);
					if (currentSkill != null) // Dropped on a slot that already has a skill
						ReplaceSkillInPlayerList(GetSkillInDicionary(droppedSkill), GetSkillInDicionary(currentSkill));
					else // Dropped on an empty slot
						AddSkillToPlayerList(GetSkillInDicionary(droppedSkill), skillSlots.FindIndex(s => s.skill == droppedSkill));
				}

				break;
			}
		}
	}

	private void ReplaceSkillInPlayerList(ISkill droppedSkill, ISkill currentSkill)
	{
		int index = Player.Instance.equippedSkills.IndexOf(currentSkill);
		Player.Instance.equippedSkills[index] = droppedSkill;

		UpdateSkillsBar();
	}

	private void RemoveSkillFromPlayerList(int index)
	{
		Player.Instance.equippedSkills[index] = null;

		UpdateSkillsBar();
	}

	private void SwapSkillsInPlayerList(ISkill droppedSkill, ISkill currentSkill)
	{
		int droppedIndex = Player.Instance.equippedSkills.IndexOf(currentSkill);
		int oldIndex = Player.Instance.equippedSkills.IndexOf(droppedSkill);

		Player.Instance.equippedSkills[droppedIndex] = droppedSkill;
		Player.Instance.equippedSkills[oldIndex] = currentSkill;

		UpdateSkillsBar();
	}

	private void AddSkillToPlayerList(ISkill skill, int index)
	{
		Player.Instance.equippedSkills[index] = skill;
		UpdateSkillsBar();
	}

	private ISkill GetSkillInDicionary(Skill skillData)
	{
		switch (skillData.skillType)
		{
			case SkillTypes.types.Buff:
				return BuffSkillsDictionary.Instance.buffSkillsDictionary[skillData.skillName];
			case SkillTypes.types.Damage:
				return DamageSkillsDictionary.Instance.damageSkillsDictionary[skillData.skillName];
			case SkillTypes.types.Effect:
				return EffectSkillsDictionary.Instance.effectSkillsDictionary[skillData.skillName];
			case SkillTypes.types.Reaction:
				return ReactionSkillsDictionary.Instance.reactionSkillsDictionary[skillData.skillName];
			case SkillTypes.types.Defense:
				return DefenseSkillsDictionary.Instance.defenseSkillsDictionary[skillData.skillName];
			case SkillTypes.types.Summon:
				return SummonSkillsDictionary.Instance.summonSkillsDictionary[skillData.skillName];
			default:
				return null;
		}
	}
}

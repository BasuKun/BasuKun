using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsBarSlot : MonoBehaviour
{
	public enum skillSlotState
	{
		Empty,
		Available,
		Triggered,
		OnCooldown
	}

	[NonSerialized] public Skill skill;
	[NonSerialized] public skillSlotState slotState = skillSlotState.Empty;

	public Image container;
	public Image skillIcon;
	public Image cooldownFill;
	public TextMeshProUGUI cooldownText;
	public TooltipTrigger tooltip;

	public Color availableColor;
	public Color triggeredColor;
	public Color onCooldownColor;

	private Skill lastEquippedSkill = null;
	private int lastSeenCooldown = -1;
	private bool isTriggered = false;
	private bool lastSeenTriggered = false;

	private void Awake()
	{
		SetEmptyVisuals();
	}

	private void Update()
	{
		if (skill != null && (lastEquippedSkill != skill || lastSeenCooldown != skill.currentCooldown || lastSeenTriggered != isTriggered))
			UpdateState();
	}

	private void UpdateState()
	{
		if (skill == null)
			slotState = skillSlotState.Empty;
		else if (isTriggered)
			slotState = skillSlotState.Triggered;
		else if (skill.currentCooldown == 0)
			slotState = skillSlotState.Available;
		else if (skill.currentCooldown > 0)
			slotState = skillSlotState.OnCooldown;

		switch (slotState)
		{
			case skillSlotState.Empty:
				SetEmptyVisuals();
				break;
			case skillSlotState.Available:
				SetAvailableVisuals();
				break;
			case skillSlotState.Triggered:
				SetTriggeredVisuals();
				break;
			case skillSlotState.OnCooldown:
				SetOnCooldownVisuals();
				break;
			default:
				break;
		}

		if (skill != null)
		{
			lastEquippedSkill = skill;
			lastSeenCooldown = skill.currentCooldown;
			lastSeenTriggered = isTriggered;
		}
		else
		{
			lastEquippedSkill = null;
			lastSeenCooldown = -1;
			lastSeenTriggered = false;
			isTriggered = false;
		}
	}

	private void SetAvailableVisuals()
	{
		container.color = availableColor;
		skillIcon.color = availableColor;
		skillIcon.gameObject.SetActive(true);
		cooldownFill.fillAmount = 0f;
		cooldownText.gameObject.SetActive(false);
		tooltip.enabled = true;
	}

	private void SetEmptyVisuals()
	{
		container.color = availableColor;
		skillIcon.gameObject.SetActive(false);
		cooldownFill.fillAmount = 0f;
		cooldownText.gameObject.SetActive(false);
		tooltip.enabled = false;
	}

	private void SetOnCooldownVisuals()
	{
		container.color = onCooldownColor;
		skillIcon.gameObject.SetActive(true);
		skillIcon.color = onCooldownColor;
		cooldownText.gameObject.SetActive(true);
		cooldownText.text = skill.currentCooldown.ToString();
		tooltip.enabled = true;

		if (skill.skillCooldown != 0)
			cooldownFill.fillAmount = (float)skill.currentCooldown / (float)skill.skillCooldown;
		else 
			cooldownFill.fillAmount = 0;
	}

	private void SetTriggeredVisuals()
	{
		container.color = triggeredColor;
		skillIcon.gameObject.SetActive(true);
		skillIcon.color = triggeredColor;
		cooldownFill.fillAmount = 0f;
		cooldownText.gameObject.SetActive(false);
		tooltip.enabled = true;

	}

	public void EquipSkill(Skill skillData)
	{
		skill = skillData;
		skillIcon.sprite = skill.icon;
		slotState = skill.currentCooldown == 0 ? skillSlotState.Available : skillSlotState.OnCooldown;
		tooltip.SetInfo(skillData);
		tooltip.enabled = true;
	}

	public void EmptySkillSlot()
	{
		skill = null;
		UpdateState();
		tooltip.enabled = false;
	}

	public void CheckTrigger()
	{
		isTriggered = false;

		switch (skill.skillType)
		{
			case SkillTypes.types.Buff:
				isTriggered = BuffSkillsDictionary.Instance.buffSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			case SkillTypes.types.Damage:
				isTriggered = DamageSkillsDictionary.Instance.damageSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			case SkillTypes.types.Effect:
				isTriggered = EffectSkillsDictionary.Instance.effectSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			case SkillTypes.types.Reaction:
				isTriggered = ReactionSkillsDictionary.Instance.reactionSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			case SkillTypes.types.Defense:
				isTriggered = DefenseSkillsDictionary.Instance.defenseSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			case SkillTypes.types.Summon:
				isTriggered = SummonSkillsDictionary.Instance.summonSkillsDictionary[skill.skillName].HasSkillPattern(Battle.Instance.curPlayer.dices, Battle.Instance.curEnemy.dices, false);
				break;
			default:
				break;
		}
	}

	public void ResetTrigger()
	{
		isTriggered = false;
	}
}

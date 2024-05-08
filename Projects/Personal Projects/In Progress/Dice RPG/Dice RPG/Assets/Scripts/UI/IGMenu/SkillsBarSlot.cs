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

	public Color availableColor;
	public Color triggeredColor;
	public Color onCooldownColor;

	private Skill lastEquippedSkill = null;
	private int lastSeenCooldown = -1;

	private void Awake()
	{
		SetEmptyVisuals();
	}

	private void Update()
	{
		if (skill != null && (lastEquippedSkill != skill || lastSeenCooldown != skill.currentCooldown))
			UpdateState();
	}

	private void UpdateState()
	{
		if (skill == null)
			slotState = skillSlotState.Empty;
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

		lastEquippedSkill = skill;
		lastSeenCooldown = skill.currentCooldown;
	}

	private void SetAvailableVisuals()
	{
		container.color = availableColor;
		skillIcon.color = availableColor;
		skillIcon.gameObject.SetActive(true);
		cooldownFill.fillAmount = 0f;
		cooldownText.gameObject.SetActive(false);
	}

	private void SetEmptyVisuals()
	{
		container.color = availableColor;
		skillIcon.gameObject.SetActive(false);
		cooldownFill.fillAmount = 0f;
		cooldownText.gameObject.SetActive(false);
	}

	private void SetOnCooldownVisuals()
	{
		container.color = onCooldownColor;
		skillIcon.gameObject.SetActive(true);
		skillIcon.color = onCooldownColor;
		cooldownText.gameObject.SetActive(true);
		cooldownText.text = skill.currentCooldown.ToString();

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
	}

	public void EquipSkill(Skill skillData)
	{
		skill = skillData;
		skillIcon.sprite = skill.icon;
		slotState = skill.currentCooldown == 0 ? skillSlotState.Available : skillSlotState.OnCooldown;
	}
}

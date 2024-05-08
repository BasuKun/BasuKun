using System.Collections;
using System.Collections.Generic;
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
			skillSlots[i].EquipSkill(Player.Instance.equippedSkills[i].skillData);
		}
	}
}

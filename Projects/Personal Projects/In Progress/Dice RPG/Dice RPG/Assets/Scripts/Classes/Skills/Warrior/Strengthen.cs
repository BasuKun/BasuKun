using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strengthen : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }
	public bool isEquipped { get; set; }

	public void SetData()
	{
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
	{
		if (!isEquipped) return;

		int amount = 0;

		foreach (var dice in dices)
		{
			if (dice.value == 6)
			{
				Player.Instance.tempDamageBonus += 1;
				amount++;
				StartCoroutine(dice.TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
			}
		}

		if (amount > 0)
		{
			Battle.Instance.SkillNamePopout(skillData.skillName + " x" + amount, Player.Instance.character.transform, skillData.skillType);
		}

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		foreach (var dice in dices)
		{
			if (dice.value == 6)
				return true;
		}

		return false;
	}
}

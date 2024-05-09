using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullseye : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
	{
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
	{
		int diceAmount = dices.Count;
		if (dices[diceAmount - 3].value > dices[diceAmount - 2].value && dices[diceAmount - 2].value > dices[diceAmount - 1].value)
		{
			StartCoroutine(dices[diceAmount - 3].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
			StartCoroutine(dices[diceAmount - 2].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
			StartCoroutine(dices[diceAmount - 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));

			Player.Instance.damageToDeal += (int)(Player.Instance.damageToDeal * diceAmount * 0.1f);
		}

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		int diceAmount = dices.Count;
		if (dices[diceAmount - 3].value > dices[diceAmount - 2].value && dices[diceAmount - 2].value > dices[diceAmount - 1].value)
			return true;

		return false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CripplingShot : MonoBehaviour, IEffectSkill
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

		if (dices[dices.Count - 1].value == 1)
		{
			StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
			int random = Random.Range(0, enemyDices.Count - 1);
			enemyDices[random].LockDice(dices[dices.Count - 2].value);
		}

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		if (dices[dices.Count - 1].value == 1)
			return true;

		return false;
	}
}

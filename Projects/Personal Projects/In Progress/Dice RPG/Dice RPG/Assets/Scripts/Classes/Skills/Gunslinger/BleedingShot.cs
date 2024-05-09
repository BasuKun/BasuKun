using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleedingShot : MonoBehaviour, IEffectSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
	{
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
	{
		if (Battle.Instance.curEnemy.isBleeding) return;

		for (int i = 0; i < dices.Count - 1; i++)
		{
			if (dices[i].value == 3 && dices[i + 1].value == 5)
			{
				StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
				StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
				Battle.Instance.curEnemy.isBleeding = true;
				Battle.Instance.curEnemy.bleedingDamage = 3;
				Battle.Instance.curEnemy.bleedingTurns = 5;
			}
		}

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (Battle.Instance.curEnemy.isBleeding) 
			return false;

		for (int i = 0; i < dices.Count - 1; i++)
		{
			if (dices[i].value == 3 && dices[i + 1].value == 5)
				return true;
		}

		return false;
	}

	public float GetAnimLength()
    {
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistancedAdvantage : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        Battle.Instance.hasDistanceAdvantage = false;
        if (Battle.Instance.turn != 1) return;

        if (dices[0].value > 3)
        {
            StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
            Battle.Instance.hasDistanceAdvantage = true;
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (Battle.Instance.turn != 1)
			return false;

		if (dices[0].value > 3)
			return true;

		return false;
	}
}

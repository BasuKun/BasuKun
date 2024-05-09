using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Player.Instance.mostRolledDigit < 3 && Player.Instance.mostRolledDigit != 0)
        {
            Player.Instance.skillsActivated++;
            Player.Instance.damageToDeal *= 2;
            Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (Player.Instance.mostRolledDigit < 3 && Player.Instance.mostRolledDigit != 0)
			return true;

		return false;
	}
}

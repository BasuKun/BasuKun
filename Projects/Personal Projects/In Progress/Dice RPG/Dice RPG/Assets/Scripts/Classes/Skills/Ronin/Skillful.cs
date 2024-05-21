using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillful : MonoBehaviour, IBuffSkill
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

		if (Player.Instance.skillsActivated > 0)
        {
            Player.Instance.damageToDeal += Player.Instance.skillsActivated * 2;
            Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
        }

        Player.Instance.skillsActivated = 0;

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		if (Player.Instance.skillsActivated > 0)
			return true;

		return false;
	}
}

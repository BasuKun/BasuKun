using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunmansInstinct : MonoBehaviour, IBuffSkill
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
		if (Battle.Instance.curPlayer.mostRolledDigit == 0) return;

        if (Battle.Instance.curPlayer.mostRolledDigit == Battle.Instance.curEnemy.mostRolledDigit)
        {
            Player.Instance.tempDamageBonus += 2;
            Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;
		if (Battle.Instance.curPlayer.mostRolledDigit == 0) return false;

		if (Battle.Instance.curPlayer.mostRolledDigit == Battle.Instance.curEnemy.mostRolledDigit)
			return true;

		return false;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBreath : MonoBehaviour, IReactionSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices, int curHitPoints, int maxHitPoints)
    {
        Battle.Instance.isLastBreathing = false;

        if (!Battle.Instance.usedLastBreath && Player.Instance.curHitPoints <= 0)
        {
            Battle.Instance.usedLastBreath = true;
            Battle.Instance.isLastBreathing = true;
            Player.Instance.curHitPoints = 1;
            Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
			skillData.currentCooldown = skillData.skillCooldown;
			Player.Instance.UpdateHP(0, true);
        }
        else if (Battle.Instance.usedLastBreath && dices[dices.Count - 1].value > 5)
        {
            Battle.Instance.isLastBreathing = true;
            Player.Instance.curHitPoints = 1;
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
			skillData.currentCooldown = skillData.skillCooldown;
			Player.Instance.UpdateHP(0, true);
        }
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (Battle.Instance.usedLastBreath && dices[dices.Count - 1].value > 5)
			Battle.Instance.isLastBreathing = true;

		return false;
	}

	public void ResetSkill()
    {
        Battle.Instance.usedLastBreath = false;
        Battle.Instance.isLastBreathing = false;
    }
}

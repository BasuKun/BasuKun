using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonGolem : MonoBehaviour, ISummonSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public bool hasSkillPattern(List<Dice> dices)
    {
        if (skillData.summon.isActive) return false;

        for (int i = 0; i < dices.Count; i++)
        {
            if (dices[i].value == 3 && !dices[i].isTemporary)
            {
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                Player.Instance.summonsToActivate.Add(skillData.summon);
                Player.Instance.hasGolem = true;
				skillData.currentCooldown = skillData.skillCooldown;
				skillData.summon.isActive = true;
				skillData.summon.linkedDice = dices[i];
				skillData.summon.turnsActive = 5;

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSkull : MonoBehaviour, ISummonSkill
{
	[field: SerializeField] public Skill skillData { get; set; }
	public bool isEquipped { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		if (skillData.summon.isActive) 
			return false;

        for (int i = 0; i < dices.Count; i++)
        {
            if (dices[i].value == 2 && !dices[i].isTemporary)
            {
				if (triggerAttack)
				{
					StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
					Player.Instance.summonsToActivate.Add(skillData.summon);
					Player.Instance.hasSkull = true;
					skillData.currentCooldown = skillData.skillCooldown;
					skillData.summon.isActive = true;
					skillData.summon.linkedDice = dices[i];
					skillData.summon.turnsActive = 5;
				}

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
    }
}

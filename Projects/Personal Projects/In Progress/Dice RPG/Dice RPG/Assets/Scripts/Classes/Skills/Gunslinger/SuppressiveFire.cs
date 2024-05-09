using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppressiveFire : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		for (int i = 0; i <= dices.Count - 3; i++)
        {
            if ((dices[i].value - dices[i + 1].value == -1 && dices[i + 1].value -  dices[i + 2].value == -1) 
                || (dices[i].value - dices[i + 1].value == 1 && dices[i + 1].value - dices[i + 2].value == 1))
            {
				if (triggerAttack)
				{
					damageToDeal = dices[i + 2].skillValue + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
					StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
					StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
					StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
				}

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal;
		animator.Play(skillData.stateName);

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public float GetAnimLength()
    {
        return 0;
    }
}
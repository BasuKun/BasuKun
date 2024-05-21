using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
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

		if (dices[dices.Count - 1].value == dices[0].value * 2)
		{
			if (triggerAttack)
			{
				damageToDeal = dices[dices.Count - 1].skillValue * 4;
				StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
				StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
			}

            return true;
        }

        return false;
    }

    public void PerformSkill(Animator animator)
	{
		if (!isEquipped) return;

		Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.Play(skillData.stateName);

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public float GetAnimLength()
    {
        return 0;
    }
}
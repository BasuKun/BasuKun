using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleSlash : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
        skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public bool hasSkillPattern(List<Dice> dices)
    {
        damageToDeal = 0;

        if (dices[1].value < dices[0].value)
        {
            damageToDeal += dices[1].skillValue * 3;
            StartCoroutine(dices[1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
        }

        return damageToDeal > 0;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
		animator.Play(skillData.stateName);

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public float GetAnimLength()
    {
        return 0;
    }
}

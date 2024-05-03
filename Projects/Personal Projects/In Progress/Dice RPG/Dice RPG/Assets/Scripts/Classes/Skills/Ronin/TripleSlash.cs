using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleSlash : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        damageToDeal = 0;

        if (dices[1].value < dices[0].value && dices[2].value < dices[1].value)
        {
            damageToDeal += dices[2].skillValue * 3;
            StartCoroutine(dices[2].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
        }

        return damageToDeal > 0;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);
		animator.Play(skillData.stateName);
	}

	public float GetAnimLength()
    {
        return 0;
    }
}

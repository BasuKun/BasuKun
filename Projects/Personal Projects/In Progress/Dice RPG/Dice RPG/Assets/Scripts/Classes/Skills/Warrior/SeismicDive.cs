using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeismicDive : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 3; i++)
        {
            if (dices[i].value < dices[i + 1].value && dices[i + 1].value == dices[i + 2].value && dices[i + 2].value > dices[i + 3].value)
            {
                damageToDeal = (dices[i].skillValue + dices[i + 1].skillValue + dices[i + 2].skillValue + dices[i + 3].skillValue) * 2;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 3].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
		animator.Play(skillData.stateName);
	}

	public float GetAnimLength()
    {
        return 0;
    }
}

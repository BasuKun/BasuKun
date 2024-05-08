using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrasRush : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
    [System.NonSerialized] public GameObject anim = null;
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 1; i++)
        {
            if (dices[i].value + dices[i + 1].value == 9)
            {
                damageToDeal = (dices[i].skillValue * 3) + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                return true;
            }
        }
        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal;
        anim = Instantiate(skillData.separateAnim);

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public float GetAnimLength()
    {
        return anim.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.length;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatansWrath : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[System.NonSerialized] public GameObject anim = null;
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 2; i++)
        {
            if (dices[i].value == 6 && dices[i + 1].value == 6 && dices[i + 2].value == 6)
            {
                damageToDeal = 666;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal;
        anim = Instantiate(skillData.separateAnim);
    }

    public float GetAnimLength()
    {
        return anim.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.length;
    }
}
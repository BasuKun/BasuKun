using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
        skillData.currentLevel = 0;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i <= dices.Count - 3; i++)
        {
            if (dices[i].value % 2 == 0 && dices[i + 1].value % 2 == 0 && dices[i + 2].value % 2 == 0)
            {
                damageToDeal = (int)(Player.Instance.damageToDeal / 2f);
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
        Battle.Instance.DealDamage(false, Player.Instance.damageToDeal);
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassinate : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        if ((float)Battle.Instance.curEnemy.curHitPoints / (float)Battle.Instance.curEnemy.hitPoints > 0.2f) return false;
        else
        {
            foreach (var dice in dices)
            {
                if (dice.value == 2)
                {
                    damageToDeal = Battle.Instance.curEnemy.curHitPoints;
                    StartCoroutine(dice.TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                    return true;
                }
            }

            return false;
        }
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        Player.Instance.damageToDeal = damageToDeal;
		animator.Play(skillData.stateName);
	}

	public float GetAnimLength()
    {
        return 0;
    }
}

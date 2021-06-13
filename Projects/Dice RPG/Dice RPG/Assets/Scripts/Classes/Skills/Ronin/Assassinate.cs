using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assassinate : MonoBehaviour, IDamageSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public int damageToDeal { get; set; }

    public void SetData()
    {
        skillName = "Assassinate";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Damage;
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
                    StartCoroutine(dice.TriggerSkillAnimation(0f, skillName, true, skillType));
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
        animator.SetTrigger("isAttacking02");
    }
}

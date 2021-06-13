using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pierce : MonoBehaviour, IDamageSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public int damageToDeal { get; set; }

    public void SetData()
    {
        skillName = "Pierce";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Damage;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 2; i++)
        {
            if (dices[i].value == 1 && dices[i + 1].value == 1)
            {
                damageToDeal = dices[i + 2].value * 3;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, skillType));
                StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillName, false, skillType));

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.SetTrigger("isAttacking02");
    }
}

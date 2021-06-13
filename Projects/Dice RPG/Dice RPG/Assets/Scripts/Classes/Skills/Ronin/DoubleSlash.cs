using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleSlash : MonoBehaviour, IDamageSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public int damageToDeal { get; set; }

    public void SetData()
    {
        skillName = "Double Slash";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Damage;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        damageToDeal = 0;
        int firstRoll = dices[0].value;
        if (firstRoll == 1) return false;

        foreach (var dice in dices)
        {
            if (dice.value < firstRoll)
            {
                damageToDeal += dice.value;
                StartCoroutine(dice.TriggerSkillAnimation(0f, skillName, false, skillType));
            }
        }

        return damageToDeal > 0;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
        animator.SetTrigger("isAttacking03");
    }
}

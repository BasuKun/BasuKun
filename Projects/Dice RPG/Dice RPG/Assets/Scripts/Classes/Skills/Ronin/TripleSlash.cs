using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleSlash : MonoBehaviour, IDamageSkill
{
    public int currentLevel { get; set; }
    public int maxLevel { get; set; }
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public bool hasSeparateAnim { get; set; }
    public int damageToDeal { get; set; }

    public void SetData()
    {
        currentLevel = 0;
        maxLevel = 1;
        skillName = "Triple Slash";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        damageToDeal = 0;

        if (dices[1].value < dices[0].value && dices[2].value < dices[1].value)
        {
            damageToDeal += dices[2].skillValue * 3;
            StartCoroutine(dices[2].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
        }

        return damageToDeal > 0;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
        animator.SetTrigger("isTripleSlashing");
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

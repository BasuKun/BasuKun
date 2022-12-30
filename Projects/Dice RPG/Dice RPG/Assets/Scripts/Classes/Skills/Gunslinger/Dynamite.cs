using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour, IDamageSkill
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
        skillName = "Dynamite";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        if (dices[dices.Count - 1].value == dices[0].value * 2)
		{
            damageToDeal = dices[dices.Count - 1].skillValue * 4;
            StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));

            return true;
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.SetTrigger("isDynamiting");
    }

    public float GetAnimLength()
    {
        return 0;
    }
}
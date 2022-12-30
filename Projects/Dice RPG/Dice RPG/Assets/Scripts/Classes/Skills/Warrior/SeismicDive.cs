using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeismicDive : MonoBehaviour, IDamageSkill
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
        maxLevel = 2;
        skillName = "Seismic Dive";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 3; i++)
        {
            if (dices[i].value < dices[i + 1].value && dices[i + 1].value == dices[i + 2].value && dices[i + 2].value > dices[i + 3].value)
            {
                damageToDeal = (dices[i].skillValue + dices[i + 1].skillValue + dices[i + 2].skillValue + dices[i + 3].skillValue) * 2;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 3].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.SetTrigger("isSeismicDiving");
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

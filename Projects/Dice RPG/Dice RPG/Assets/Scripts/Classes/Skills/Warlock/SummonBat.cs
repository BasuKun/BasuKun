using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonBat : MonoBehaviour, ISummonSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public Summon summon;

    public void SetData()
    {
        skillName = "Summon Bat";
        skillClass = CurrentClass.classes.Warlock;
        skillType = SkillTypes.types.Summon;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        if (summon.isActive) return false;

        for (int i = 0; i < dices.Count; i++)
        {
            if (dices[i].value == 1 && !dices[i].isTemporary)
            {
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                Player.Instance.summonsToActivate.Add(summon);
                Player.Instance.hasBat = true;
                summon.isActive = true;
                summon.linkedDice = dices[i];
                summon.turnsActive = 5;

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
    }
}

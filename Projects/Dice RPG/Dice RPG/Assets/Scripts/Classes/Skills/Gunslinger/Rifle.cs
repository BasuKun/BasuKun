using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour, IDamageSkill
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
        skillName = "Rifle";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 2; i++)
        {
            if (dices[i].value % 2 == 0 && dices[i + 1].value < dices[i].value && dices[i + 2].value == dices[i + 1].value)
            {
                damageToDeal = (dices[i].skillValue + dices[i + 1].skillValue + dices[i + 2].skillValue) * 2;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 2].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));

                return true;
            }
        }

        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.SetTrigger("isRifling");
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebound : MonoBehaviour, IDamageSkill
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
        skillName = "Rebound";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i <= dices.Count - 3; i++)
        {
            if (dices[i].value % 2 == 0 && dices[i + 1].value % 2 == 0 && dices[i + 2].value % 2 == 0)
            {
                damageToDeal = (int)(Player.Instance.damageToDeal / 2f);
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
        Player.Instance.damageToDeal = damageToDeal;
        Battle.Instance.DealDamage(false, Player.Instance.damageToDeal);
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

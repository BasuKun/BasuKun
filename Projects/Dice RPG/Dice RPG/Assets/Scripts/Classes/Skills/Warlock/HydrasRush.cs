using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrasRush : MonoBehaviour, IDamageSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public bool hasSeparateAnim { get; set; }
    public int damageToDeal { get; set; }
    public GameObject hydrasRushAnim;
    public GameObject anim = null;

    public void SetData()
    {
        skillName = "Hydra's Rush";
        skillClass = CurrentClass.classes.Warlock;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = true;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 1; i++)
        {
            if (dices[i].value + dices[i + 1].value == 9)
            {
                damageToDeal = (dices[i].value * 3) + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                return true;
            }
        }
        return false;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.damageToDeal = damageToDeal;
        anim = Instantiate(hydrasRushAnim);
    }

    public float GetAnimLength()
    {
        return anim.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.length;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatansWrath : MonoBehaviour, IDamageSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public bool hasSeparateAnim { get; set; }
    public int damageToDeal { get; set; }
    public GameObject satansWrathAnim;
    public GameObject anim = null;

    public void SetData()
    {
        skillName = "Satan's Wrath";
        skillClass = CurrentClass.classes.Warlock;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = true;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        for (int i = 0; i < dices.Count - 2; i++)
        {
            if (dices[i].value == 6 && dices[i + 1].value == 6 && dices[i + 2].value == 6)
            {
                damageToDeal = 666;
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
        anim = Instantiate(satansWrathAnim);
    }

    public float GetAnimLength()
    {
        return anim.GetComponent<Animator>().GetCurrentAnimatorClipInfo(0)[0].clip.length;
    }
}
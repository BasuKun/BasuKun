using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickpocket : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Pickpocket";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        for (int i = 0; i < dices.Count - 1; i++)
        {
            if (dices[i].value + dices[i + 1].value == 7)
            {
                Player.Instance.skillsActivated++;
                Player.Instance.soulCurrencyBonus++;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, skillType));
                break;
            }
        }
    }
}

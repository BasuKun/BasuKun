using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Bandage";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if ((float)Player.Instance.curHitPoints / (float)Player.Instance.maxHitPoints > 0.30f) return;
        else
        {
            for (int i = 1; i < dices.Count - 1; i++)
            {
                if (dices[i - 1].value == dices[i + 1].value)
                {
                    Player.Instance.skillsActivated++;
                    StartCoroutine(dices[i - 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                    StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                    StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                    StartCoroutine(Player.Instance.UpdateHP(dices[i].value * 2, true));
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowRetreat : MonoBehaviour, IDefenseSkill
{
    public int currentLevel { get; set; }
    public int maxLevel { get; set; }
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        currentLevel = 0;
        maxLevel = 1;
        skillName = "Shadow Retreat";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Defense;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Battle.Instance.curPlayer.mostRolledDigit == 0) return;

        if (Battle.Instance.curPlayer.mostRolledDigit <= Battle.Instance.curEnemy.mostRolledDigit / 2)
        {
            Battle.Instance.isShadowRetreating = true;
        }
        else Battle.Instance.isShadowRetreating = false;
    }
}

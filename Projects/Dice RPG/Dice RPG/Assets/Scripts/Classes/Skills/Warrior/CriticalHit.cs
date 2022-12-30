using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalHit : MonoBehaviour, IBuffSkill
{
    public int currentLevel { get; set; }
    public int maxLevel { get; set; }
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        currentLevel = 0;
        maxLevel = 2;
        skillName = "Critical Hit";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Buff;
    }
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        foreach (var dice in dices)
        {
            if (dice.value == 6)
            {
                dice.attackValue = (int)(dice.attackValue * 0.3f);
                dice.skillValue = (int)(dice.skillValue * 0.3f);
            }
        }
    }
}

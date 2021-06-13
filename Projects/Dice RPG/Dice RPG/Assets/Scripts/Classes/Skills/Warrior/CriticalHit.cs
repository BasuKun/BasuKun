using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalHit : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
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
                Player.Instance.damageToDeal += 2;
            }
        }
    }
}

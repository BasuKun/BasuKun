using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDefenseSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData();
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices);
}
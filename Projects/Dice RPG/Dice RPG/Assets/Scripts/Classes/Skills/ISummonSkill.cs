using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISummonSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData();
    public bool hasSkillPattern(List<Dice> dices);
    public void PerformSkill(Animator animator);
}
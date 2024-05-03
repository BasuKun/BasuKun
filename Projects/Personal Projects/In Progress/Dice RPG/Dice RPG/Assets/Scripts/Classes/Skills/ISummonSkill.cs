using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISummonSkill : ISkill
{
    public void SetData();
    public bool hasSkillPattern(List<Dice> dices);
    public void PerformSkill(Animator animator);
}
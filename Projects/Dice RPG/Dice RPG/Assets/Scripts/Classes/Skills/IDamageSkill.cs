using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageSkill : ISkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public bool hasSeparateAnim { get; set; }
    public int damageToDeal { get; set; }

    public void SetData();
    public bool hasSkillPattern(List<Dice> dices);
    public void PerformSkill(Animator animator);
    public float GetAnimLength();
}
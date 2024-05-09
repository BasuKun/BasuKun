using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageSkill : ISkill
{
    public int damageToDeal { get; set; }

    public void SetData();
    public void PerformSkill(Animator animator);
    public float GetAnimLength();
}
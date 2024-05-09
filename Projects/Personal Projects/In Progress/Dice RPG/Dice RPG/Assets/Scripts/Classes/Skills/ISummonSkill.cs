using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISummonSkill : ISkill
{
    public void SetData();
    public void PerformSkill(Animator animator);
}
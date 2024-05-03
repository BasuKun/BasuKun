using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEffectSkill : ISkill
{
    public void SetData();
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IReactionSkill : ISkill
{
    public void SetData();
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices, int curHitPoints, int maxHitPoints);
    public void ResetSkill();
}

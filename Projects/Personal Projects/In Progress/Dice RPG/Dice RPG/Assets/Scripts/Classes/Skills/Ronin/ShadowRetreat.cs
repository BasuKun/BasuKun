using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowRetreat : MonoBehaviour, IDefenseSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Battle.Instance.curPlayer.mostRolledDigit == 0) return;

        if (Battle.Instance.curPlayer.mostRolledDigit <= Battle.Instance.curEnemy.mostRolledDigit / 2)
        {
            Battle.Instance.isShadowRetreating = true;
			skillData.currentCooldown = skillData.skillCooldown;
		}
		else Battle.Instance.isShadowRetreating = false;
    }
}

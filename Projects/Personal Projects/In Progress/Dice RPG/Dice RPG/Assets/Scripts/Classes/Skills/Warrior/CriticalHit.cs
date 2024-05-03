using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriticalHit : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        foreach (var dice in dices)
        {
            if (dice.value == 6)
            {
                dice.attackValue = (int)(dice.attackValue * 0.3f);
                dice.skillValue = (int)(dice.skillValue * 0.3f);
            }
        }
    }
}

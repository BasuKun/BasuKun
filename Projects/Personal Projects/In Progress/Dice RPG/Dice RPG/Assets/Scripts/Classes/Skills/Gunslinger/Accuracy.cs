using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accuracy : MonoBehaviour, IBuffSkill
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
            if (dice.value == 1)
            {
                dice.attackValue *= 2;
                dice.skillValue *= 2;
            }
        }
    }
}
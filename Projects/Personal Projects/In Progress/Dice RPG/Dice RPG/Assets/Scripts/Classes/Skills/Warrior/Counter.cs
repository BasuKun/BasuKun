using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour, IDefenseSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        int diceAmount = dices.Count;
        int enemyDiceAmount = enemyDices.Count;
        if (diceAmount < 2 || enemyDiceAmount < 3)
        {
            Battle.Instance.isCountering = false;
            return;
        }

        int playerValue = dices[diceAmount - 1].value + dices[diceAmount - 2].value;
        int enemyValue = enemyDices[enemyDiceAmount - 1].value + enemyDices[enemyDiceAmount - 2].value + enemyDices[enemyDiceAmount - 3].value;
        if (playerValue > enemyValue)
        {
            Battle.Instance.isCountering = true;
            return;
        }
        else Battle.Instance.isCountering = false;
    }
}

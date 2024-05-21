using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accuracy : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }
	public bool isEquipped { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
	{
		if (!isEquipped) return;

		foreach (var dice in dices)
        {
            if (dice.value == 1)
            {
                dice.attackValue *= 2;
                dice.skillValue *= 2;
            }
        }

		skillData.currentCooldown = skillData.skillCooldown;
    }

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		foreach (var dice in dices)
		{
			if (dice.value == 1)
				return true;
		}

		return false;
	}
}
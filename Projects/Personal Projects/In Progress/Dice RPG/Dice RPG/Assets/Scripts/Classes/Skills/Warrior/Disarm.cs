using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disarm : MonoBehaviour, IEffectSkill
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

		if (dices[dices.Count - 1].value == enemyDices[enemyDices.Count - 1].value)
        {
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
            for (int i = 0; i < enemyDices.Count / 2; i++)
            {
                enemyDices[i].LockDice(dices[dices.Count - 1].value);
            }
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		if (dices[dices.Count - 1].value == enemyDices[enemyDices.Count - 1].value)
			return true;

		return false;
	}
}

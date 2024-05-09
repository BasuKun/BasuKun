using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideStep : MonoBehaviour, IDefenseSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        Player.Instance.damageToAvoid = 0;
        int maxDice = Mathf.Min(dices.Count, enemyDices.Count);
        int amountTriggered = 0;

        for (int i = 0; i < maxDice; i++)
        {
            if (dices[i].value == enemyDices[i].value)
            {
                Battle.Instance.isSideStepping = true;
                Player.Instance.damageToAvoid += dices[i].value;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
				skillData.currentCooldown = skillData.skillCooldown;
				amountTriggered++;
            }
        }

        if (amountTriggered == 0) Battle.Instance.isSideStepping = false;
    }

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		int maxDice = Mathf.Min(dices.Count, enemyDices.Count);

		for (int i = 0; i < maxDice; i++)
		{
			if (dices[i].value == enemyDices[i].value)
				return true;
		}

		return false;
	}
}

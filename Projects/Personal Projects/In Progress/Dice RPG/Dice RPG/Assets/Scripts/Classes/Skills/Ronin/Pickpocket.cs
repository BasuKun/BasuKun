using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickpocket : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        for (int i = 0; i < dices.Count - 1; i++)
        {
            if (dices[i].value + dices[i + 1].value == 7)
            {
                Player.Instance.skillsActivated++;
                Player.Instance.soulCurrencyBonus++;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                break;
            }
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		for (int i = 0; i < dices.Count - 1; i++)
		{
			if (dices[i].value + dices[i + 1].value == 7)
				return true;
		}

		return false;
	}
}

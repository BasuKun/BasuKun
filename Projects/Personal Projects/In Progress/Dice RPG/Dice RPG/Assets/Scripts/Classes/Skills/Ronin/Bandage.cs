using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour, IBuffSkill
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

		if ((float)Player.Instance.curHitPoints / (float)Player.Instance.maxHitPoints > 0.30f) return;
        else
        {
            for (int i = 1; i < dices.Count - 1; i++)
            {
                if (dices[i - 1].value == dices[i + 1].value)
                {
                    Player.Instance.skillsActivated++;
                    StartCoroutine(dices[i - 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                    StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
                    StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
                    StartCoroutine(Player.Instance.UpdateHP(dices[i].skillValue * 2, true));
                }
            }
        }

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		if (!isEquipped) return false;

		if ((float)Player.Instance.curHitPoints / (float)Player.Instance.maxHitPoints > 0.30f) return false;
		else
		{
			for (int i = 1; i < dices.Count - 1; i++)
			{
				if (dices[i - 1].value == dices[i + 1].value)
					return true;
			}
		}

		return false;
	}
}

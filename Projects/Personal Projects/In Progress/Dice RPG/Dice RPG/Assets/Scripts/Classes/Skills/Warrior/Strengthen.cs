using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strengthen : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        int amount = 0;

        foreach (var dice in dices)
        {
            if (dice.value == 6)
            {
                Player.Instance.tempDamageBonus += 1;
                amount++;
                StartCoroutine(dice.TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));
            }
        }

        if (amount > 0)
        {
            Battle.Instance.SkillNamePopout(skillData.skillName + " x" + amount, Player.Instance.character.transform, skillData.skillType);
        }
    }
}

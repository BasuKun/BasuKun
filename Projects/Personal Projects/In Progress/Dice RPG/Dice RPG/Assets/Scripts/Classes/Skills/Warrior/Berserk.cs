using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserk : MonoBehaviour, IReactionSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices, int curHitPoints, int maxHitPoints)
    {
        if (curHitPoints <= 0 && !Battle.Instance.isLastBreathing)
        {
            ResetSkill();
            return;
        }

        if ((float)curHitPoints / (float)maxHitPoints <= 0.25f && !Battle.Instance.isBerserking)
        {
            Battle.Instance.isBerserking = true;
            Battle.Instance.SkillNamePopout("Berserk", Player.Instance.character.transform, SkillTypes.types.Reaction);
            Player.Instance.AddDice(true, false, int.MaxValue);
            Player.Instance.AddDice(true, false, int.MaxValue);
        }

        if (((float)curHitPoints / (float)maxHitPoints > 0.25f && Battle.Instance.isBerserking))
        {
            ResetSkill();
        }
    }

    public void ResetSkill()
    {
        Battle.Instance.isBerserking = false;

        foreach (var dice in Player.Instance.dices)
        {
            if (dice.isBerserkDice)
            {
                Player.Instance.dices.Remove(dice);
                Destroy(dice.gameObject);
            }
        }

        Player.Instance.diceRack.GetComponent<DiceRackSizeFitter>().ResizeRack(Player.Instance.dices);
    }
}

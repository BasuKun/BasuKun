using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EclipseRush : MonoBehaviour, IDamageSkill
{
    public int damageToDeal { get; set; }
	[field: SerializeField] public Skill skillData { get; set; }

	private Dictionary<int, Dice> diceReqs = new Dictionary<int, Dice>();

    public void SetData()
    {
		skillData.currentLevel = 0;
		skillData.currentCooldown = 0;
	}

	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true)
	{
		diceReqs.Clear();

        foreach (var dice in dices)
        {
            if (!diceReqs.TryGetValue(dice.value, out Dice assignedDice))
				diceReqs.Add(dice.value, dice);
		}

        return diceReqs.Count == 6;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        damageToDeal = GetSkillValue((int)(Player.Instance.diceAmount / 5f));
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillData.skillName, Player.Instance.character.transform, skillData.skillType);

        foreach (var dice in diceReqs)
			StartCoroutine(dice.Value.TriggerSkillAnimation(0f, skillData.skillName, false, Player.Instance.character.transform, skillData.skillType));

		animator.Play(skillData.stateName);

		skillData.currentCooldown = skillData.skillCooldown;
	}

	public float GetAnimLength()
    {
        return 0;
    }

    public int GetSkillValue(int value)
    {
        int moddedValue = (int)(value * (Player.Instance.finesse * Balancing.finesseSkillMod)) + (int)(value * (Player.Instance.strength * Balancing.strengthSkillMod));
        return moddedValue;
    }
}

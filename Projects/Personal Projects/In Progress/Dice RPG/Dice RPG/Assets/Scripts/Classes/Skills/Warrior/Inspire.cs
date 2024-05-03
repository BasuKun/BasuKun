using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspire : MonoBehaviour, IBuffSkill
{
	[field: SerializeField] public Skill skillData { get; set; }

	public void SetData()
    {
		skillData.currentLevel = 0;
    }
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (dices[0].value == 6)
        {
            Player.Instance.damageToDeal += dices.Count;
            StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillData.skillName, true, Player.Instance.character.transform, skillData.skillType));
        }
    }
}

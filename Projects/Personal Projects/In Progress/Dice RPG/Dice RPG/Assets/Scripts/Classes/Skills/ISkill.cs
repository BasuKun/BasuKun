using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISkill
{
	public Skill skillData { get; set; }
	public bool isEquipped { get; set; }
	public bool HasSkillPattern(List<Dice> dices, List<Dice> enemyDices = null, bool triggerAttack = true);
}

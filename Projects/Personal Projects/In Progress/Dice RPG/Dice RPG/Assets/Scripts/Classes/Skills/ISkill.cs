using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISkill
{
	public int currentLevel { get; set; }
	public int maxLevel { get; set; }
	public SkillTypes.types skillType { get; set; }
}

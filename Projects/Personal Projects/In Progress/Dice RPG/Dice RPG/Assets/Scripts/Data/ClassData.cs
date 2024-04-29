using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClassData", menuName = "Dice RPG/Class Data")]
public class ClassData : ScriptableObject
{
	[Header("STATS")]
	public string className;
	public CurrentClass.classes curClass;
	public int vitality;
	public int strength;
	public int finesse;
	public int recovery;
	public int greed;
	public int dice;
}

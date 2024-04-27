using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancing : MonoBehaviour
{
	[Header("STATS")]
	public float _vitalityMod;
	public float _strengthAttackMod;
	public float _strengthSkillMod;
	public float _finesseAttackMod;
	public float _finesseSkillMod;
	public float _recoveryMod;
	public float _greedGoldMod;
	public static float vitalityMod;
	public static float strengthAttackMod;
	public static float strengthSkillMod;
	public static float finesseAttackMod;
	public static float finesseSkillMod;
	public static float recoveryMod;
	public static float greedGoldMod;

	private void Awake()
	{
		vitalityMod = _vitalityMod;
		strengthAttackMod = _strengthAttackMod;
		strengthSkillMod = _strengthSkillMod;
		finesseAttackMod = _finesseAttackMod;
		finesseSkillMod = _finesseSkillMod;
		recoveryMod = _recoveryMod;
		greedGoldMod = _greedGoldMod;
	}

	public static int GetAttackValue(int value, bool simulatesNewStats)
	{
		int strengthSimulationMod = simulatesNewStats ? StatsMenu.Instance.statsToAdd[StatsMenu.Instance.statsDictionary["strength"].index] : 0;
		int finesseSimulationMod = simulatesNewStats ? StatsMenu.Instance.statsToAdd[StatsMenu.Instance.statsDictionary["finesse"].index] : 0;

		int moddedValue = (int)Math.Round(value * ((Player.Instance.strength + strengthSimulationMod) * strengthAttackMod)) + 
			(int)Math.Round((Player.Instance.finesse + finesseSimulationMod) / (Mathf.Sqrt(value) * finesseAttackMod));
		return moddedValue;
	}

	public static int GetSkillValue(int value, bool simulatesNewStats)
	{
		int strengthSimulationMod = simulatesNewStats ? StatsMenu.Instance.statsToAdd[StatsMenu.Instance.statsDictionary["strength"].index] : 0;
		int finesseSimulationMod = simulatesNewStats ? StatsMenu.Instance.statsToAdd[StatsMenu.Instance.statsDictionary["finesse"].index] : 0;

		int moddedValue = (int)Math.Round(value * ((Player.Instance.finesse + finesseSimulationMod) * finesseSkillMod)) + 
			(int)Math.Round(value * ((Player.Instance.strength + strengthSimulationMod) * strengthSkillMod));
		return moddedValue;
	}
}

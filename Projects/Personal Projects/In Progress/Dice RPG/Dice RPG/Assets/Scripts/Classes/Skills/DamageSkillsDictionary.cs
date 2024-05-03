using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DamageSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, IDamageSkill> damageSkillsDictionary = new Dictionary<string, IDamageSkill>();
    public static DamageSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<IDamageSkill> damageSkillsList = GetComponentsInChildren<IDamageSkill>().ToList();
        foreach (var skill in damageSkillsList) 
        {
            skill.SetData();
            damageSkillsDictionary.Add(skill.skillData.skillName, skill);
        }
    }
}

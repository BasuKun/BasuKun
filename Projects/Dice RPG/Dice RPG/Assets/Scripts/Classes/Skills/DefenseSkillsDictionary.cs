using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DefenseSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, IDefenseSkill> defenseSkillsDictionary = new Dictionary<string, IDefenseSkill>();
    public List<GameObject> namePopouts = new List<GameObject>();

    public static DefenseSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<IDefenseSkill> defenseSkillsList = GetComponentsInChildren<IDefenseSkill>().ToList();
        foreach (var skill in defenseSkillsList)
        {
            skill.SetData();
            defenseSkillsDictionary.Add(skill.skillName, skill);
        }
    }
}

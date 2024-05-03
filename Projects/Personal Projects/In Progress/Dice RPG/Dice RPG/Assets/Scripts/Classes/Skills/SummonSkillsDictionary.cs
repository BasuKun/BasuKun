using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SummonSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, ISummonSkill> summonSkillsDictionary = new Dictionary<string, ISummonSkill>();
    public List<GameObject> namePopouts = new List<GameObject>();
    
    public static SummonSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<ISummonSkill> summonSkillsList = GetComponentsInChildren<ISummonSkill>().ToList();
        foreach (var skill in summonSkillsList) 
        {
            skill.SetData();
            summonSkillsDictionary.Add(skill.skillData.skillName, skill);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BuffSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, IBuffSkill> buffSkillsDictionary = new Dictionary<string, IBuffSkill>();
    public List<GameObject> namePopouts = new List<GameObject>();
    
    public static BuffSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<IBuffSkill> buffSkillsList = GetComponentsInChildren<IBuffSkill>().ToList();
        foreach (var skill in buffSkillsList) 
        {
            skill.SetData();
            buffSkillsDictionary.Add(skill.skillData.skillName, skill);
        }
    }
}

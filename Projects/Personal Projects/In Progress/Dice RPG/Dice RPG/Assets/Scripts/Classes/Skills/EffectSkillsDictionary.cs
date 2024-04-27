using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EffectSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, IEffectSkill> effectSkillsDictionary = new Dictionary<string, IEffectSkill>();
    public List<GameObject> namePopouts = new List<GameObject>();

    public static EffectSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<IEffectSkill> effectSkillsList = GetComponentsInChildren<IEffectSkill>().ToList();
        foreach (var skill in effectSkillsList)
        {
            skill.SetData();
            effectSkillsDictionary.Add(skill.skillName, skill);
        }
    }
}

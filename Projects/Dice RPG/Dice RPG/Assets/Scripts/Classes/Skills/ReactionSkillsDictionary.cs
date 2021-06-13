using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ReactionSkillsDictionary : MonoBehaviour
{
    public Dictionary<string, IReactionSkill> reactionSkillsDictionary = new Dictionary<string, IReactionSkill>();
    public List<GameObject> namePopouts = new List<GameObject>();

    public static ReactionSkillsDictionary Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        List<IReactionSkill> reactionSkillsList = GetComponentsInChildren<IReactionSkill>().ToList();
        foreach (var skill in reactionSkillsList)
        {
            skill.SetData();
            reactionSkillsDictionary.Add(skill.skillName, skill);
        }
    }
}

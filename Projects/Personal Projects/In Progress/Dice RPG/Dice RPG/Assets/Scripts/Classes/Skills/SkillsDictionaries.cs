using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillsDictionaries", menuName = "Dice RPG/SkillsDictionaries")]
public class SkillsDictionaries : ScriptableObject
{
    public List<Skill> buffs = new List<Skill>();
    public List<Skill> damages = new List<Skill>();
    public List<Skill> defenses = new List<Skill>();
    public List<Skill> effects = new List<Skill>();
    public List<Skill> reactions = new List<Skill>();
    public List<Skill> summons = new List<Skill>();

    public Dictionary<string, Skill> buffSkills = new Dictionary<string, Skill>();
    public Dictionary<string, Skill> damageSkills = new Dictionary<string, Skill>();
    public Dictionary<string, Skill> defenseSkills = new Dictionary<string, Skill>();
    public Dictionary<string, Skill> effectSkills = new Dictionary<string, Skill>();
    public Dictionary<string, Skill> reactionSkills = new Dictionary<string, Skill>();
    public Dictionary<string, Skill> summonSkills = new Dictionary<string, Skill>();
}

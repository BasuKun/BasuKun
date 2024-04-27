using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SkillsCategorizer : Editor
{
    [MenuItem("Dice RPG/Categorize Skills")]
    private static void CategorizeSpells()
    {
        string[] guids = AssetDatabase.FindAssets("t:" + typeof(Skill).Name);
        List<Skill> skillDatas = new List<Skill>();

        foreach (string guid in guids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Skill skill = AssetDatabase.LoadAssetAtPath<Skill>(path);
            if (skill != null)
            {
                Debug.Log("Found skill: " + skill.name);
                skillDatas.Add(skill);
            }
			else
			{
                Debug.Log("Failed to load skills.");
            }
        }

        string[] dict = AssetDatabase.FindAssets("t:" + typeof(SkillsDictionaries).Name);
        SkillsDictionaries globalSkillsDictionaries = null;

        if (dict.Length > 0)
        {
            string path = AssetDatabase.GUIDToAssetPath(dict[0]);
            globalSkillsDictionaries = AssetDatabase.LoadAssetAtPath<SkillsDictionaries>(path);

            if (globalSkillsDictionaries != null)
            {
                Debug.Log("Found Skills Dictionary: " + globalSkillsDictionaries.name);
            }
            else
            {
                Debug.Log("Failed to load Skills Dictionary.");
            }
        }
        else
        {
            Debug.Log("Skills Dictionary not found.");
        }

        if (skillDatas != null && globalSkillsDictionaries != null)
        {
            globalSkillsDictionaries.buffs.Clear();
            globalSkillsDictionaries.buffSkills.Clear();
            globalSkillsDictionaries.damages.Clear();
            globalSkillsDictionaries.damageSkills.Clear();
            globalSkillsDictionaries.defenses.Clear();
            globalSkillsDictionaries.defenseSkills.Clear();
            globalSkillsDictionaries.effects.Clear();
            globalSkillsDictionaries.effectSkills.Clear();
            globalSkillsDictionaries.reactions.Clear();
            globalSkillsDictionaries.reactionSkills.Clear();
            globalSkillsDictionaries.summons.Clear();
            globalSkillsDictionaries.summonSkills.Clear();

            foreach (var skill in skillDatas)
            {
                switch (skill.skillType)
                {
                    case SkillTypes.types.Buff:
                        globalSkillsDictionaries.buffs.Add(skill);
                        globalSkillsDictionaries.buffSkills.Add(skill.skillName, skill);
                        break;
                    case SkillTypes.types.Damage:
                        globalSkillsDictionaries.damages.Add(skill);
                        globalSkillsDictionaries.damageSkills.Add(skill.skillName, skill);
                        break;
                    case SkillTypes.types.Defense:
                        globalSkillsDictionaries.defenses.Add(skill);
                        globalSkillsDictionaries.defenseSkills.Add(skill.skillName, skill);
                        break;
                    case SkillTypes.types.Effect:
                        globalSkillsDictionaries.effects.Add(skill);
                        globalSkillsDictionaries.effectSkills.Add(skill.skillName, skill);
                        break;
                    case SkillTypes.types.Reaction:
                        globalSkillsDictionaries.reactions.Add(skill);
                        globalSkillsDictionaries.reactionSkills.Add(skill.skillName, skill);
                        break;
                    case SkillTypes.types.Summon:
                        globalSkillsDictionaries.summons.Add(skill);
                        globalSkillsDictionaries.summonSkills.Add(skill.skillName, skill);
                        break;
                    default:
                        Debug.LogWarning("Unknown SpellCategory value: " + skill.skillType);
                        break;
                }
            }

            EditorUtility.SetDirty(globalSkillsDictionaries);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Debug.Log("Spell categorization complete.");
        }
        else
        {
            Debug.LogError("Failed to find SpellData objects or GlobalSpellData object.");
        }
    }
}

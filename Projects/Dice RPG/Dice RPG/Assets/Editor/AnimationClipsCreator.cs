using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class AnimationClipsCreator : Editor
{
    [MenuItem("Dice RPG/Create All Animation Clips")]
    public static void CreateAnimationClipsForAll()
    {
        Skill[] scriptableObjects = AssetDatabase.FindAssets("t:Skill")
            .Select(guid => AssetDatabase.LoadAssetAtPath<Skill>(AssetDatabase.GUIDToAssetPath(guid)))
            .ToArray();

        if (scriptableObjects.Length > 0)
        {
            for (int i = 0; i < scriptableObjects.Length; i++)
            {
                scriptableObjects[i].CreateAnimationClip();
            }

            Debug.Log("Created/Updated Animation Clips for all ScriptableObjects.");
        }
        else
        {
            Debug.Log("No ScriptableObjects of type AnimationClipCreator found.");
        }
    }
}

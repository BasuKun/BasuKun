using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System;

[CreateAssetMenu(fileName = "Skill", menuName = "Dice RPG/Skill")]
public class Skill : ScriptableObject
{
    [Header("SkillData")]
    public string skillName;
    public int currentLevel;
    public int maxLevel;
    public int skillCooldown;
    public SkillTypes.types skillType;
    public CurrentClass.classes skillClass;

    [Header("AnimationData")]
    public Sprite[] sprites;
    public float frameDuration;
    public AnimationClip createdAnimationClip;

    [ContextMenu("Create Animation Clip")]
    public void CreateAnimationClip()
    {
        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogError("No sprites found for animation clip creation.");
            return;
        }

        string folderPath = "Assets/Animations/" + Enum.GetName(typeof(CurrentClass.classes), skillClass);
        string filePath = Path.Combine(folderPath, skillName + ".anim");
        AnimationClip existingAnimationClip = AssetDatabase.LoadAssetAtPath<AnimationClip>(filePath);

        if (existingAnimationClip != null)
        {
            ObjectReferenceKeyframe[] frames = new ObjectReferenceKeyframe[sprites.Length];
            for (int i = 0; i < sprites.Length; i++)
            {
                frames[i] = new ObjectReferenceKeyframe();
                frames[i].time = i * frameDuration;
                frames[i].value = sprites[i];
            }

            AnimationUtility.SetObjectReferenceCurve(existingAnimationClip, EditorCurveBinding.PPtrCurve("", typeof(SpriteRenderer), "m_Sprite"), frames);

            existingAnimationClip.wrapMode = WrapMode.Once;

            Debug.Log("Updated existing AnimationClip: " + skillName);
        }
        else
        {
            AnimationClip animationClip = new AnimationClip();
            animationClip.name = skillName;

            ObjectReferenceKeyframe[] frames = new ObjectReferenceKeyframe[sprites.Length];
            for (int i = 0; i < sprites.Length; i++)
            {
                frames[i] = new ObjectReferenceKeyframe();
                frames[i].time = i * frameDuration;
                frames[i].value = sprites[i];
            }

            AnimationUtility.SetObjectReferenceCurve(animationClip, EditorCurveBinding.PPtrCurve("", typeof(SpriteRenderer), "m_Sprite"), frames);

            animationClip.wrapMode = WrapMode.Once;

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            AssetDatabase.CreateAsset(animationClip, filePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log("Created new AnimationClip: " + skillName);
        }

        createdAnimationClip = AssetDatabase.LoadAssetAtPath<AnimationClip>(filePath);

        EditorUtility.SetDirty(this);
        AssetDatabase.SaveAssets();
    }

    [ContextMenu("Search for Sprites")]
    void SearchForSprites()
    {
        sprites = new Sprite[0];

        string skillNameNoSpaces = skillName.Replace(" ", "");
        string skillClassString = Enum.GetName(typeof(CurrentClass.classes), skillClass);
        string searchPath = "Assets/Art/Classes/" + skillClassString + "/" + skillNameNoSpaces;
        string searchPattern = skillClassString + "_" + skillNameNoSpaces;
        string[] guids = AssetDatabase.FindAssets(searchPattern, new[] { searchPath });
        Debug.Log("Searching for: " + searchPattern);

        foreach (string guid in guids)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            Sprite sprite = AssetDatabase.LoadAssetAtPath<Sprite>(assetPath);
            if (sprite != null)
            {
                int previousSize = sprites.Length;
                System.Array.Resize(ref sprites, previousSize + 1);
                sprites[previousSize] = sprite;
            }
        }

        Debug.Log("Found " + sprites.Length + " sprites for Skill: " + skillName + " and SkillClass: " + skillClassString);

        EditorUtility.SetDirty(this);
        AssetDatabase.SaveAssets();
    }
}
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Skill", menuName = "Dice RPG/Skill")]
public class Skill : ScriptableObject
{
    [Header("DATA")]
    public string skillName;
	public string stateName;
	public int currentLevel;
    public int maxLevel;
    public int skillCooldown;
    public SkillTypes.types skillType;
    public CurrentClass.classes skillClass;
	public bool hasSeparateAnim;
	[Multiline()] public string description;

	[Header("VISUALS")]
	public Sprite icon;

	[Header("ANIMATIONS")]
    public Sprite[] sprites;
	public float frameDuration;
	public int[] eventFrames;
	public AnimationClip createdAnimationClip;
	public GameObject separateAnim;
	public Summon summon;

	[ContextMenu("Create Animation Clip")]
	public void CreateAnimationClip()
	{
		if (sprites == null || sprites.Length == 0)
		{
			Debug.LogError("No sprites found for animation clip creation.");
			return;
		}

		string skillNameNoSpaces = skillName.Replace(" ", "");
		string fileName = skillClass.ToString() + "_" + skillType.ToString() + "_" + skillNameNoSpaces;

		string folderPath = "Assets/Animations/" + Enum.GetName(typeof(CurrentClass.classes), skillClass);
		string filePath = Path.Combine(folderPath, fileName + ".anim");
		AnimationClip targetClip = AssetDatabase.LoadAssetAtPath<AnimationClip>(filePath) ?? new AnimationClip { name = fileName };
		targetClip.frameRate = 100f;

		ObjectReferenceKeyframe[] frames = new ObjectReferenceKeyframe[sprites.Length];
		List<AnimationEvent> animationEventsList = new List<AnimationEvent>();  // Using a List to handle events dynamically

		for (int i = 0; i < sprites.Length; i++)
		{
			float exactTime = Mathf.Round(i * frameDuration * 1000f) / 1000f;  // Round to three decimal places
			frames[i] = new ObjectReferenceKeyframe { time = exactTime, value = sprites[i] };

			// Check if this frame index is listed in eventFrames, and add an event if it is
			if (eventFrames != null && eventFrames.Contains(i))
			{
				AnimationEvent animationEvent = new AnimationEvent
				{
					time = exactTime, // Use the exact same time as the frame
					functionName = "DealSkillDamage"
				};
				animationEventsList.Add(animationEvent); // Add the new event to the list
			}
		}

		AnimationUtility.SetObjectReferenceCurve(targetClip, EditorCurveBinding.PPtrCurve("", typeof(SpriteRenderer), "m_Sprite"), frames);
		if (animationEventsList.Count > 0)
		{
			AnimationUtility.SetAnimationEvents(targetClip, animationEventsList.ToArray());
		}
		targetClip.wrapMode = WrapMode.Once;

		if (!AssetDatabase.Contains(targetClip))
		{
			if (!Directory.Exists(folderPath))
				Directory.CreateDirectory(folderPath);

			AssetDatabase.CreateAsset(targetClip, filePath);
		}

		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();

		createdAnimationClip = targetClip;
		Debug.Log(AssetDatabase.Contains(targetClip) ? "Updated existing Animation Clip: " + fileName : "Created new Animation Clip: " + fileName);

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
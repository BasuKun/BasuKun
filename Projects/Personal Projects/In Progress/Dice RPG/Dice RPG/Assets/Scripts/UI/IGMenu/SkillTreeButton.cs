using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkillTreeButton : MonoBehaviour
{
    public int currentLevel = 0;
    public int maxLevel = 0;
    public string skillName;
    public ISkill skill;
    public bool isUnlocked;
    public Button button;
    public Image outline;
    public Color outlineDefaultColor;
    public Color outlineBoughtColor;
    public Color outlineMaxedColor;
    public Color skillMaxedColor;
    public TextMeshProUGUI currentLevelText;
    public TextMeshProUGUI levelSlashText;
    public TextMeshProUGUI maxLevelText;
    public List<Image> lines = new List<Image>();
    public List<SkillTreeButton> unlockRequirements = new List<SkillTreeButton>();

    private Transform startLineTransform;
    private Transform endLineTransform;

    private void Awake()
    {
        GenerateLine();
    }

	private void Start()
	{
        LinkSkillToButton();
        PlayerSkills.Instance.skillTreeButtonsList.Add(this);
        UpdateOutlineColor();
    }

    private void UpdateOutlineColor()
	{
        if (currentLevel == 0)
            outline.color = outlineDefaultColor;
        else if (currentLevel > 0 && currentLevel < maxLevel)
            outline.color = outlineBoughtColor;
        else if (currentLevel == maxLevel)
		{
            outline.color = outlineMaxedColor;

            var newColorBlock = button.colors;
            newColorBlock.disabledColor = skillMaxedColor;
            button.colors = newColorBlock;
        }
    }

	private void GenerateLine()
	{
        if (unlockRequirements.Count == 0) return;

		for (int i = 0; i < unlockRequirements.Count; i++)
		{
            button.interactable = false;
            startLineTransform = button.gameObject.GetComponent<RectTransform>();
            endLineTransform = unlockRequirements[i].gameObject.GetComponent<RectTransform>();

            Vector3 startPos = startLineTransform.position;
            Vector3 endPos = endLineTransform.position;

            float angle = Mathf.Atan2(endPos.y - startPos.y, endPos.x - startPos.x) * Mathf.Rad2Deg;

            lines[i].rectTransform.rotation = Quaternion.Euler(0, 0, angle);
            lines[i].rectTransform.position = startPos;

            float distance = Vector3.Distance(startPos, endPos);

            lines[i].rectTransform.sizeDelta = new Vector2(distance, lines[i].rectTransform.sizeDelta.y);
        }
    }

    private void LinkSkillToButton()
    {
		if (BuffSkillsDictionary.Instance.buffSkillsDictionary.ContainsKey(skillName))
            skill = BuffSkillsDictionary.Instance.buffSkillsDictionary[skillName];

        else if (DamageSkillsDictionary.Instance.damageSkillsDictionary.ContainsKey(skillName))
            skill = DamageSkillsDictionary.Instance.damageSkillsDictionary[skillName];

        else if (DefenseSkillsDictionary.Instance.defenseSkillsDictionary.ContainsKey(skillName))
            skill = DefenseSkillsDictionary.Instance.defenseSkillsDictionary[skillName];

        else if (EffectSkillsDictionary.Instance.effectSkillsDictionary.ContainsKey(skillName))
            skill = EffectSkillsDictionary.Instance.effectSkillsDictionary[skillName];

        else if (ReactionSkillsDictionary.Instance.reactionSkillsDictionary.ContainsKey(skillName))
            skill = ReactionSkillsDictionary.Instance.reactionSkillsDictionary[skillName];

        else if (SummonSkillsDictionary.Instance.summonSkillsDictionary.ContainsKey(skillName))
            skill = SummonSkillsDictionary.Instance.summonSkillsDictionary[skillName];

        UpdateInfo();
        UpdateCurrentLevel();
    }

    private void UpdateInfo()
	{
        currentLevel = skill.skillData.currentLevel;
        maxLevel = skill.skillData.maxLevel;

        maxLevelText.text = maxLevel.ToString();
    }

    public void UpdateCurrentLevel()
	{
        currentLevel = skill.skillData.currentLevel;
        currentLevelText.text = currentLevel.ToString();

        if (currentLevel == maxLevel)
		{
            currentLevelText.color = outlineMaxedColor;
            levelSlashText.color = outlineMaxedColor;
            maxLevelText.color = outlineMaxedColor;
        }
    }

    public void BuySkillLevel()
    {
        if (currentLevel == 0)
            PlayerSkills.Instance.UnlockSkill(skillName);

        skill.skillData.currentLevel++;
        UpdateCurrentLevel();

        Player.Instance.skillPoints -= currentLevel;
        PlayerSkills.Instance.UpdateSkillPointsText();
        PlayerSkills.Instance.CheckForUnlockedButtons();
        PlayerSkills.Instance.CheckForUnlockedPaths();

        UpdateOutlineColor();
    }
}
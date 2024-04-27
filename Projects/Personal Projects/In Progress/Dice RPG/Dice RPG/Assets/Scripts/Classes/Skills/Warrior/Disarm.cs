using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disarm : MonoBehaviour, IEffectSkill
{
    public int currentLevel { get; set; }
    public int maxLevel { get; set; }
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        currentLevel = 0;
        maxLevel = 1;
        skillName = "Disarm";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Effect;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (dices[dices.Count - 1].value == enemyDices[enemyDices.Count - 1].value)
        {
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            for (int i = 0; i < enemyDices.Count / 2; i++)
            {
                enemyDices[i].LockDice(dices[dices.Count - 1].value);
            }
        }
    }
}

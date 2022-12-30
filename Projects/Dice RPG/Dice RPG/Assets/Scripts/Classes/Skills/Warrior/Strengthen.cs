using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strengthen : MonoBehaviour, IBuffSkill
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
        skillName = "Strengthen";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        int amount = 0;

        foreach (var dice in dices)
        {
            if (dice.value == 6)
            {
                Player.Instance.tempDamageBonus += 1;
                amount++;
                StartCoroutine(dice.TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
            }
        }

        if (amount > 0)
        {
            Battle.Instance.SkillNamePopout(skillName + " x" + amount, Player.Instance.character.transform, skillType);
        }
    }
}

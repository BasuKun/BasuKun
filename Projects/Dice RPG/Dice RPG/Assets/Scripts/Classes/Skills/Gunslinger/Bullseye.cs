using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullseye : MonoBehaviour, IBuffSkill
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
        skillName = "Bullseye";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        int diceAmount = dices.Count;
        if (dices[diceAmount - 3].value > dices[diceAmount - 2].value && dices[diceAmount - 2].value > dices[diceAmount - 1].value)
        {
            StartCoroutine(dices[diceAmount - 3].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            StartCoroutine(dices[diceAmount - 2].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
            StartCoroutine(dices[diceAmount - 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));

            Player.Instance.damageToDeal += (int)(Player.Instance.damageToDeal * diceAmount * 0.1f);
        }
    }
}

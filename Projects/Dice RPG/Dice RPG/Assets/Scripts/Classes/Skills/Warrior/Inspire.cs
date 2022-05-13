using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inspire : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Inspire";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Buff;
    }
    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (dices[0].value == 6)
        {
            Player.Instance.damageToDeal += dices.Count;
            StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
        }
    }
}

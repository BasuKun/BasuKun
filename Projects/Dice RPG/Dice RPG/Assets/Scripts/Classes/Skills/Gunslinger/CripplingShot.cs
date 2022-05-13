using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CripplingShot : MonoBehaviour, IEffectSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Crippling Shot";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (dices[dices.Count - 1].value == 1)
        {
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            int random = Random.Range(0, enemyDices.Count - 1);
            enemyDices[random].LockDice(dices[dices.Count - 2].value);
        }
    }
}

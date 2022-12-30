using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BleedingShot : MonoBehaviour, IEffectSkill
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
        skillName = "Bleeding Shot";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Effect;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Battle.Instance.curEnemy.isBleeding) return;

        for (int i = 0; i < dices.Count - 1; i++)
        {
            if (dices[i].value == 3 && dices[i + 1].value == 5)
            {
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
                StartCoroutine(dices[i + 1].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                Battle.Instance.curEnemy.isBleeding = true;
                Battle.Instance.curEnemy.bleedingDamage = 3;
                Battle.Instance.curEnemy.bleedingTurns = 5;
            }
        }
    }

    public float GetAnimLength()
    {
        return 0;
    }
}

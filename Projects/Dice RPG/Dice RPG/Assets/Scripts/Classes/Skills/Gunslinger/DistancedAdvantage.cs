using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistancedAdvantage : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Distanced Advantage";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        Battle.Instance.hasDistanceAdvantage = false;
        if (Battle.Instance.turn != 1) return;

        if (dices[0].value > 3)
        {
            StartCoroutine(dices[0].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            Battle.Instance.hasDistanceAdvantage = true;
        }
    }
}

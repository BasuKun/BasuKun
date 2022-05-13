using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideStep : MonoBehaviour, IDefenseSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Side Step";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Defense;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        Player.Instance.damageToAvoid = 0;
        int maxDice = Mathf.Min(dices.Count, enemyDices.Count);
        int amountTriggered = 0;

        for (int i = 0; i < maxDice; i++)
        {
            if (dices[i].value == enemyDices[i].value)
            {
                Battle.Instance.isSideStepping = true;
                Player.Instance.damageToAvoid += dices[i].value;
                StartCoroutine(dices[i].TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
                amountTriggered++;
            }
        }

        if (amountTriggered == 0) Battle.Instance.isSideStepping = false;
    }
}

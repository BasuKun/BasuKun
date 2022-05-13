using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBreath : MonoBehaviour, IReactionSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Last Breath";
        skillClass = CurrentClass.classes.Warrior;
        skillType = SkillTypes.types.Reaction;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices, int curHitPoints, int maxHitPoints)
    {
        Battle.Instance.isLastBreathing = false;

        if (!Battle.Instance.usedLastBreath && Player.Instance.curHitPoints <= 0)
        {
            Battle.Instance.usedLastBreath = true;
            Battle.Instance.isLastBreathing = true;
            Player.Instance.curHitPoints = 1;
            Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
            Player.Instance.UpdateHP(0, true);
        }
        else if (Battle.Instance.usedLastBreath && dices[dices.Count - 1].value > 5)
        {
            Battle.Instance.isLastBreathing = true;
            Player.Instance.curHitPoints = 1;
            StartCoroutine(dices[dices.Count - 1].TriggerSkillAnimation(0f, skillName, true, Player.Instance.character.transform, skillType));
            Player.Instance.UpdateHP(0, true);
        }
    }

    public void ResetSkill()
    {
        Battle.Instance.usedLastBreath = false;
        Battle.Instance.isLastBreathing = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karma : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Karma";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Player.Instance.mostRolledDigit < 3 && Player.Instance.mostRolledDigit != 0)
        {
            Player.Instance.skillsActivated++;
            Player.Instance.damageToDeal *= 2;
            Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skillful : MonoBehaviour, IBuffSkill
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
        skillName = "Skillful";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Player.Instance.skillsActivated > 0)
        {
            Player.Instance.damageToDeal += Player.Instance.skillsActivated * 2;
            Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
        }

        Player.Instance.skillsActivated = 0;
    }
}

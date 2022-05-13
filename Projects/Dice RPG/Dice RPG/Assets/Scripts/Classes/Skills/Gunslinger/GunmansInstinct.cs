using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunmansInstinct : MonoBehaviour, IBuffSkill
{
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }

    public void SetData()
    {
        skillName = "Gunman's Instinct";
        skillClass = CurrentClass.classes.Gunslinger;
        skillType = SkillTypes.types.Buff;
    }

    public void PerformSkill(List<Dice> dices, List<Dice> enemyDices)
    {
        if (Battle.Instance.curPlayer.mostRolledDigit == 0) return;

        if (Battle.Instance.curPlayer.mostRolledDigit == Battle.Instance.curEnemy.mostRolledDigit)
        {
            Player.Instance.tempDamageBonus += 2;
            Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EclipseRush : MonoBehaviour, IDamageSkill
{
    public int currentLevel { get; set; }
    public int maxLevel { get; set; }
    public string skillName { get; set; }
    public CurrentClass.classes skillClass { get; set; }
    public SkillTypes.types skillType { get; set; }
    public bool hasSeparateAnim { get; set; }
    public int damageToDeal { get; set; }

    private Dictionary<int, Dice> diceReqs = new Dictionary<int, Dice>();

    public void SetData()
    {
        currentLevel = 0;
        maxLevel = 1;
        skillName = "Eclipse Rush";
        skillClass = CurrentClass.classes.Ronin;
        skillType = SkillTypes.types.Damage;
        hasSeparateAnim = false;
    }

    public bool hasSkillPattern(List<Dice> dices)
    {
        diceReqs.Clear();

        foreach (var dice in dices)
        {
            if (!diceReqs.TryGetValue(dice.value, out Dice assignedDice))
            {
                diceReqs.Add(dice.value, dice);
            }
        }

        return diceReqs.Count == 6;
    }

    public void PerformSkill(Animator animator)
    {
        Player.Instance.skillsActivated++;
        damageToDeal = GetSkillValue((int)(Player.Instance.diceAmount / 5f));
        Player.Instance.damageToDeal = damageToDeal + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);

        foreach (var dice in diceReqs)
        {
            StartCoroutine(dice.Value.TriggerSkillAnimation(0f, skillName, false, Player.Instance.character.transform, skillType));
        }

        animator.SetTrigger("isEclipseRushing");
    }

    public float GetAnimLength()
    {
        return 0;
    }

    public int GetSkillValue(int value)
    {
        int moddedValue = (int)(value * (Player.Instance.finesse * Balancing.finesseSkillMod)) + (int)(value * (Player.Instance.strength * Balancing.strengthSkillMod));
        return moddedValue;
    }
}
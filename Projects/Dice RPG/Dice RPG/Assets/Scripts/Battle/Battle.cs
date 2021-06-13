using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Battle : MonoBehaviour
{
    private Vector3 damageOffset = new Vector3(0, 0.2f, 0f);

    [Header("BATTLE BOOLS")]
    public bool hasFinishedAttacking = false;
    public bool isCountering = false;
    public bool isBerserking = false;
    public bool usedLastBreath = false;
    public bool isLastBreathing = false;
    public bool isSideStepping = false;
    public bool isShadowRetreating = false;

    [Header("GAMEOBJECTS")]
    public GameObject damagePopout;
    public GameObject skillNamePopout;
    public Canvas uiCanvas;
    public Canvas worldUICanvas;

    [Header("FIGHTERS")]
    public Enemy curEnemy;
    public Player curPlayer;

    public static Battle Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator BattleSequence(Enemy enemy, Player player)
    {
        curEnemy = enemy;
        curPlayer = player;
        curPlayer.soulCurrencyBonus = 0;

        while (enemy.curHitPoints > 0 && player.curHitPoints > 0)
        {
            hasFinishedAttacking = false;

            yield return new WaitForSeconds(0.5f);
            StartCoroutine(enemy.RollDamage());
            StartCoroutine(player.Attack());

            while (!hasFinishedAttacking) yield return new WaitForFixedUpdate();
            yield return new WaitForSeconds(0.75f);

            if (enemy.curHitPoints > 0) StartCoroutine(enemy.Attack());
            yield return new WaitForSeconds(1f);
        }

        yield return new WaitForSeconds(1f);
        player.tempDamageBonus = 0;
        ResetSkills();

        StartCoroutine(Player.Instance.Move());
        yield return null;
    }

    public void ResetSkills()
    {
        foreach (var skill in Player.Instance.reactionSkills)
        {
            skill.ResetSkill();
        }
    }

    public void ReceiveDamage()
    {
        foreach (var skill in curPlayer.defenseSkills)
        {
            skill.PerformSkill(curPlayer.dices, curEnemy.dices);
        }

        if (isShadowRetreating)
        {
            Player.Instance.skillsActivated++;
            SkillNamePopout("Shadow Retreat", Player.Instance.character.transform, SkillTypes.types.Defense);
            DamagePopout(curPlayer.character.gameObject, 0);
            curPlayer.GetHurt(0, "isShadowRetreating");
        }
        else if (isCountering)
        {
            Player.Instance.skillsActivated++;
            StartCoroutine(curPlayer.dices[curPlayer.dices.Count - 1].TriggerSkillAnimation(0, "Counter", true, SkillTypes.types.Reaction));
            StartCoroutine(curPlayer.dices[curPlayer.dices.Count - 2].TriggerSkillAnimation(0, "Counter", false, SkillTypes.types.Reaction));

            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal / 2);
            curPlayer.GetHurt(curEnemy.damageToDeal / 2, "isAttacking03");

            DamagePopout(curEnemy.gameObject, curEnemy.damageToDeal / 2);
            curEnemy.GetHurt(curEnemy.damageToDeal / 2);
        }
        else if (isSideStepping)
        {
            Player.Instance.skillsActivated++;
            SkillNamePopout("Side Step", Player.Instance.character.transform, SkillTypes.types.Defense);
            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal - curPlayer.damageToAvoid);
            curPlayer.GetHurt(curEnemy.damageToDeal - curPlayer.damageToAvoid, "isSideStepping");
        }
        else
        {
            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal);
            curPlayer.GetHurt(curEnemy.damageToDeal, "isHurt");
        }
    }

    public void DealDamage(bool isNormalAttack)
    {
        if (isNormalAttack)
        {
            foreach (var skill in curPlayer.effectSkills)
            {
                skill.PerformSkill(curPlayer.dices, curEnemy.dices);
            }
        }

        DamagePopout(curEnemy.gameObject, curPlayer.damageToDeal);
        curEnemy.GetHurt(Player.Instance.damageToDeal);
    }

    public void DamagePopout(GameObject target, int damage)
    {
        GameObject damageText = Instantiate(damagePopout, Camera.main.WorldToScreenPoint(target.transform.position + damageOffset), Quaternion.identity, uiCanvas.transform);
        damageText.GetComponent<DamageFloatingText>().UpdateDamageText(damage);
    }

    public void SkillNamePopout(string skillName, Transform pos, SkillTypes.types skillType)
    {
        GameObject skillNameText = null;

        switch (skillType)
        {
            case SkillTypes.types.Buff:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * BuffSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                BuffSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Damage:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f)), Quaternion.identity, uiCanvas.transform);
                break;
            case SkillTypes.types.Effect:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * EffectSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                EffectSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Reaction:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * ReactionSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                ReactionSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Defense:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * DefenseSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                DefenseSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            default:
                break;
        }

        skillNameText.GetComponent<SkillFloatingText>().UpdateSkillNameText(skillName, skillType);
    }

    public bool AnimatorIsPlaying(Animator animator)
    {
        return animator.GetCurrentAnimatorStateInfo(0).length >
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    public int CalculateMostRolledDigit(List<Dice> dices)
    {
        int[] digitAmounts = new int[] {0, 0, 0, 0, 0, 0, 0};

        foreach (var dice in dices)
        {
            digitAmounts[dice.value]++;
        }

        var maxIndices =
        digitAmounts
        .Select((n, i) => new { n, i })
        .GroupBy(x => x.n, x => x.i)
        .OrderByDescending(x => x.Key)
        .Take(1)
        .SelectMany(x => x)
        .ToArray();

        if (maxIndices.Length > 1) return 0;
        else return maxIndices[0];
    }
}

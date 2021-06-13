using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("BATTLE STATS")]
    public CurrentClass.classes currentClass;
    public int maxHitPoints;
    public int curHitPoints;
    public int damageBonus;
    public int tempDamageBonus;
    public int skillsActivated;
    public int soulCurrencyBonus;
    public int damageToDeal;
    public int damageToAvoid;
    public int mostRolledDigit;
    public int diceAmount;
    public List<IDamageSkill> damageSkills = new List<IDamageSkill>();
    public List<IBuffSkill> buffSkills = new List<IBuffSkill>();
    public List<IEffectSkill> effectSkills = new List<IEffectSkill>();
    public List<IReactionSkill> reactionSkills = new List<IReactionSkill>();
    public List<IDefenseSkill> defenseSkills = new List<IDefenseSkill>();

    [Header("OTHER STATS")]
    public int level;
    public long experience;
    public long soulsCurrency;
    public int looting;
    public int healing;

    [Header("DICE STUFF")]
    public List<Dice> dices = new List<Dice>();
    public List<Dice> tempDices = new List<Dice>();
    public GameObject dicePrefab;
    public GameObject diceRack;

    public bool hasReturnToIdle = false;
    public bool isMoving;
    public Class character = null;
    public List<HPSoulFloating> souls = new List<HPSoulFloating>();
    public ParticleSystem hpSoulHurtAnimation;
    public static Player Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Skillful"]);
        defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Shadow Retreat"]);
        defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Side Step"]);
        damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Double Slash"]);
        damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Assassinate"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Karma"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Pickpocket"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Bandage"]);
        /*
        damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Pierce"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Strengthen"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Critical Hit"]);
        buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Inspire"]);
        defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Counter"]);
        effectSkills.Add(EffectSkillsDictionary.Instance.effectSkillsDictionary["Disarm"]);
        reactionSkills.Add(ReactionSkillsDictionary.Instance.reactionSkillsDictionary["Last Breath"]);
        reactionSkills.Add(ReactionSkillsDictionary.Instance.reactionSkillsDictionary["Berserk"]);
        */
    }

    public void AddDice(bool isPermanentDice)
    {
        GameObject dice = Instantiate(dicePrefab, diceRack.transform.position + new Vector3(0f, 0f, 0f), Quaternion.identity, diceRack.transform);
        if (isPermanentDice) dices.Add(dice.GetComponent<Dice>());
        else tempDices.Add(dice.GetComponent<Dice>());

        diceRack.GetComponent<DiceRackSizeFitter>().ResizeRack(dices, tempDices);
    }

    public IEnumerator Attack()
    {
        damageToDeal = 0;
        foreach (Dice dice in dices)
        {
            StartCoroutine(dice.Roll());
            damageToDeal += dice.value;
        }
        foreach (Dice dice in tempDices)
        {
            StartCoroutine(dice.Roll());
            damageToDeal += dice.value;
        }

        yield return new WaitForSeconds(0.95f);

        mostRolledDigit = Battle.Instance.CalculateMostRolledDigit(dices);
        GameUI.Instance.playerMostRolledDigitObject.UpdateAppearance(mostRolledDigit);

        foreach (var skill in buffSkills)
        {
            skill.PerformSkill(dices, Battle.Instance.curEnemy.dices);
        }

        yield return new WaitForSeconds(0.05f);
        damageToDeal += damageBonus;
        damageToDeal += tempDamageBonus;

        character.animator.SetTrigger("isAttacking01");
        yield return new WaitForSeconds(0.02f);
        yield return new WaitForSeconds(character.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length);

        foreach (var skill in damageSkills)
        {
            if (Battle.Instance.curEnemy.isDying) break;

            if (skill.hasSkillPattern(dices))
            {
                skill.PerformSkill(character.animator);
                yield return new WaitForSeconds(0.02f);
                yield return new WaitForSeconds(character.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length);
            }
        }

        if (hasReturnToIdle) character.animator.SetTrigger("ReturnToIdle");

        Battle.Instance.hasFinishedAttacking = true;
        yield return null;
    }

    public void GetHurt(int receivedDamage, string animToTrigger)
    {
        character.animator.SetTrigger(animToTrigger);
        StartCoroutine(UpdateHP(receivedDamage, false));
    }

    public IEnumerator UpdateHP(int amount, bool isHealing)
    {
        curHitPoints = isHealing ? curHitPoints + amount : curHitPoints - amount;

        if (!isHealing)
        {
            foreach (var skill in reactionSkills)
            {
                skill.PerformSkill(dices, dices, curHitPoints, maxHitPoints);
            }
        }

        float hpPercent = (float)curHitPoints / (float)maxHitPoints * 100f;
        float offset = 80f;

        for (int i = souls.Count - 1; i >= 0; i--)
        {
            var soul = souls[i];

            SpriteRenderer soulSprite = soul.gameObject.GetComponent<SpriteRenderer>();
            int previousStage = soul.currentStage;

            if (hpPercent - offset > 16f) soul.currentStage = 0;
            else if (hpPercent - offset <= 16f && hpPercent - offset > 12f) soul.currentStage = 1;
            else if (hpPercent - offset <= 12f && hpPercent - offset > 8f) soul.currentStage = 2;
            else if (hpPercent - offset <= 8f && hpPercent - offset > 4f) soul.currentStage = 3;
            else if (hpPercent - offset <= 4f && hpPercent - offset > 0f) soul.currentStage = 4;
            else if (hpPercent - offset <= 0f) soul.currentStage = 5;

            if (!isHealing)
            {
                ParticleSystem hpSoulHurtFX = Instantiate(hpSoulHurtAnimation, soul.transform.position, hpSoulHurtAnimation.transform.rotation);
                var animEmission = hpSoulHurtFX.emission;
                animEmission.rateOverTime = (soul.currentStage - previousStage) * 6;
            }

            soulSprite.sprite = soul.stages[soul.currentStage];

            //if (curHitPoints <= 0) Die();

            offset -= 20f;
        }

        yield return null;
    }

    public IEnumerator Move()
    {
        isMoving = true;
        character.animator.SetTrigger("isMoving");

        foreach (Dice dice in dices) dice.animator.SetBool("isMoving", true);

        while (curHitPoints < maxHitPoints)
        {
            yield return new WaitForSeconds(1f);
            curHitPoints = Mathf.Min(curHitPoints + healing, maxHitPoints);
            StartCoroutine(UpdateHP(0, true));
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(1f);
        EnemySpawner.Instance.SpawnEnemy("Skeleton");

        yield return null;
    }

    public void StopMoving()
    {
        foreach (Dice dice in dices) dice.animator.SetBool("isMoving", false);

        isMoving = false;
        character.animator.SetTrigger("isIdle");
    }
}

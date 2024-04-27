using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("MAIN STATS")]
    public int vitality;
    public int strength;
    public int finesse;
    public int recovery;
    public int greed;

    [Header("BATTLE STATS")]
    public CurrentClass.classes currentClass;
    public int maxHitPoints;
    public int curHitPoints;
    public int damageBonus;
    public int tempDamageBonus;
    public int skillsActivated;
    public int soulCurrencyBonus;
    public int damageToDeal;
    public int skilldamageToDeal;
    public int damageToAvoid;
    public int mostRolledDigit;
    public int diceAmount;
    public List<IDamageSkill> damageSkills = new List<IDamageSkill>();
    public List<IBuffSkill> buffSkills = new List<IBuffSkill>();
    public List<IEffectSkill> effectSkills = new List<IEffectSkill>();
    public List<IReactionSkill> reactionSkills = new List<IReactionSkill>();
    public List<IDefenseSkill> defenseSkills = new List<IDefenseSkill>();
    public List<ISummonSkill> summonSkills = new List<ISummonSkill>();

    [Header("OTHER STATS")]
    public int level = 1;
    public long experience = 0;
    public long experienceNeeded = 10;
    public long soulsCurrency = 0;
    public int statPoints = 0;
    public int skillPoints = 0;
    public int[] attackRange = { 1, 2, 3, 4, 5, 6 };
    public int[] skillRange = { 1, 2, 3, 4, 5, 6 };
    public int looting;
    public int healing;

    [Header("DICE STUFF")]
    public List<Dice> dices = new List<Dice>();
    public GameObject dicePrefab;
    public GameObject diceRack;
    public int maxRerolls = 1;
    public int maxSwaps = 1;
    public int curRerolls = 0;
    public int curSwaps = 0;

    [Header("SUMMONS")]
    public bool hasBat;
    public bool hasSkull;
    public bool hasGolem;
    public bool hasDemon;
    public List<Summon> summonsToActivate = new List<Summon>();
    public Dictionary<string, Summon> activeSummons = new Dictionary<string, Summon>();

    public bool hasReturnToIdle = false;
    public bool isMoving;
    public bool isSummoning;
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

    public void AddDice(bool isBerserkDice, bool isPermanentDice, int permTurnAmount)
    {
        GameObject dice = Instantiate(dicePrefab, diceRack.transform.position, Quaternion.identity, diceRack.transform);
        Dice diceStats = dice.GetComponent<Dice>();
        diceStats.isPlayerDice = true;
        diceStats.isBerserkDice = isBerserkDice;
        diceStats.isTemporary = !isPermanentDice;
        if (!isPermanentDice) diceStats.tempTurns = permTurnAmount;

        dices.Add(diceStats);

        diceRack.GetComponent<DiceRackSizeFitter>().ResizeRack(dices);
    }

    public IEnumerator Attack()
    {
        damageToDeal = 0;
        foreach (Dice dice in dices) StartCoroutine(dice.Roll());
        yield return new WaitForSeconds(0.95f);

        Battle.Instance.canModifyDices = true;
        DiceButtons.Instance.okButton.interactable = true;
        while (!Battle.Instance.isReadyToAttack && !Battle.Instance.isAutoAttacking) yield return null;
        Battle.Instance.canModifyDices = false;
        foreach (Dice dice in dices) dice.RemoveHighlight();

        foreach (Dice dice in dices) damageToDeal += dice.value;
        mostRolledDigit = Battle.Instance.CalculateMostRolledDigit(dices);
        GameUI.Instance.playerMostRolledDigitObject.UpdateAppearance(mostRolledDigit);

        damageToDeal += damageBonus;
        damageToDeal += tempDamageBonus;

        foreach (var skill in buffSkills)
        {
            skill.PerformSkill(dices, Battle.Instance.curEnemy.dices);
        }

        yield return new WaitForSeconds(0.05f);

        character.animator.SetTrigger("isAttacking01");
        yield return new WaitForSeconds(0.01f);
        yield return new WaitForSeconds(character.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length - 0.01f);

        foreach (var skill in damageSkills)
        {
            if (Battle.Instance.curEnemy.isDying) break;

            if (skill.hasSkillPattern(dices))
            {
                skill.PerformSkill(character.animator);
                yield return new WaitForSeconds(0.01f);

                if (!skill.hasSeparateAnim) yield return new WaitForSeconds(character.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length - 0.01f);
                else yield return new WaitForSeconds(skill.GetAnimLength() - 0.01f);
            }
        }

        if (hasReturnToIdle) character.animator.SetTrigger("ReturnToIdle");

        if (hasBat)
        {
            activeSummons["Bat"].Attack();
            yield return new WaitForSeconds(0.7f);
        }
        if (hasSkull)
        {
            activeSummons["Skull"].Attack();
            yield return new WaitForSeconds(0.7f);
        }
        if (hasGolem)
        {
            activeSummons["Golem"].Attack();
            yield return new WaitForSeconds(0.7f);
        }
        if (hasDemon)
        {
            activeSummons["Demon"].Attack();
            yield return new WaitForSeconds(0.7f);
        }

        foreach (var skill in summonSkills)
        {
            if (Battle.Instance.curEnemy.isDying) break;

            if (skill.hasSkillPattern(dices))
            {
                skill.PerformSkill(character.animator);
                isSummoning = true;
            }
        }
        if (isSummoning)
        {
            yield return new WaitForSeconds(0.3f);
            character.animator.SetTrigger("isSummoning");
            yield return new WaitForSeconds(0.02f);
            yield return new WaitForSeconds(character.animator.GetCurrentAnimatorClipInfo(0)[0].clip.length);
            isSummoning = false;
        }

        Battle.Instance.hasFinishedAttacking = true;
        yield return null;
    }

    public void GetHurt(int receivedDamage, string animToTrigger)
    {
        character.animator.SetTrigger(animToTrigger);
        StartCoroutine(UpdateHP(receivedDamage, false));
    }

    public void ActivateSummons()
    {
        foreach (var summon in summonsToActivate)
        {
            summon.gameObject.SetActive(true);
            StartCoroutine(summon.Appear());
            activeSummons.Add(summon.summonName, summon);
        }
        summonsToActivate.Clear();
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
                animEmission.rateOverTime = (soul.currentStage - previousStage) * 30;
            }

            soul.animator.SetInteger("Stage", soul.currentStage);

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

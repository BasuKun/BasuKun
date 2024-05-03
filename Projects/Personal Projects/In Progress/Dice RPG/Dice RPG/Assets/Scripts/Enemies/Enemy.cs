using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;

public class Enemy : MonoBehaviour
{
    [Header("STATS")]
    public string enemyName;
    public int hitPoints;
    public int curHitPoints;
    public int damage;
    public int damageToDeal = 0;
    public int diceAmount;

    [Header("LOOT")]
    public GameObject soulCurrencyPrefab;
    public GameObject expPrefab;
    public int soulCurrencies;
    public int exp;

    [Header("ANIMATION")]
    public Animator animator;
    public AnimationClip idleAnim;
    public AnimationClip moveAnim;
    public AnimationClip attackAnim01;
    public AnimationClip attackAnim02;
    public AnimationClip attackAnim03;
    public AnimationClip returnToIdleAnim;
    public AnimationClip hurtAnim;
    public AnimationClip deathAnim;
    public bool hasReturnToIdleAnim;
    public bool isDying = false;

    [Header("SOULS")]
    public Transform soulsPosition;
    public GameObject soulsPrefab;
    public ParticleSystem hpSoulHurtAnimation;
    public List<HPSoulFloating> souls = new List<HPSoulFloating>();

    [Header("DICE STUFF")]
    public List<Dice> dices = new List<Dice>();
    public GameObject dicePrefab;
    public int mostRolledDigit;

    [Header("BATTLE STATUSES")]
    public bool isBleeding = false;
    public int bleedingDamage = 0;
    public int bleedingTurns = 0;

    public Light2D spotlight;

    void Awake()
    {
        SetAnimations();
    }

    public void SetAnimations()
    {
        AnimatorOverrideController AOC = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = AOC;

        AOC["Idle"] = idleAnim;
        AOC["Move"] = moveAnim;
        AOC["Attack"] = attackAnim01;
        if (attackAnim02 != null) AOC["Attack02"] = attackAnim02;
        if (attackAnim03 != null) AOC["Attack03"] = attackAnim03;
        if (returnToIdleAnim != null) AOC["ReturnToIdle"] = returnToIdleAnim;
        AOC["Hurt"] = hurtAnim;
        AOC["Death"] = deathAnim;

        animator.runtimeAnimatorController = AOC;
        animator.SetBool("hasReturnToIdle", hasReturnToIdleAnim);
    }

    public IEnumerator MoveToFightLocation()
    {
        while (transform.position != EnemySpawner.Instance.moveLocation.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, EnemySpawner.Instance.moveLocation.position, Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }

        Player.Instance.StopMoving();
        StartCoroutine(SoulsAppear());

        AddDice();

        yield return new WaitForSeconds(1f);

        curHitPoints = hitPoints;
        StartCoroutine(Battle.Instance.BattleSequence(this, Player.Instance));

        yield return null;
    }

    public void AddDice()
    {
        float offset = 0;
        for (int i = 0; i < diceAmount; i++)
        {
            GameObject dice = Instantiate(dicePrefab, GameUI.Instance.enemyDiceRack.transform.position + new Vector3(offset, 0f, 0f), Quaternion.identity, GameUI.Instance.enemyDiceRack.transform);
            dices.Add(dice.GetComponent<Dice>());

            offset += 0.3f;
        }
    }

    public IEnumerator SoulsAppear()
    {
        GameObject soulsPack = Instantiate(soulsPrefab, soulsPosition.position, Quaternion.identity, GameUI.Instance.soulsParent.transform);
        souls = soulsPack.GetComponentsInChildren<HPSoulFloating>().ToList();

        foreach (var soul in souls)
        {
            soul.GetComponent<HPSoulFloating>().appearAnimator.SetTrigger("isAppearing");
            yield return new WaitForSeconds(0.3f);

            SpriteRenderer soulSprite = soul.gameObject.GetComponent<SpriteRenderer>();
            soulSprite.color = ColorGradingChanger.Instance.soulsColor;
            soulSprite.enabled = true;
        }

        yield return null;
    }

    public IEnumerator UpdateHP(int receivedDamage, bool isHealing)
    {
        curHitPoints -= receivedDamage;

        float hpPercent = (float)curHitPoints / (float)hitPoints * 100f;
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

            offset -= 20f;
        }

        if (curHitPoints <= 0 && !isDying) Die();

        yield return null;
    }

    public IEnumerator RollDamage()
    {
        damageToDeal = 0;
        foreach (Dice dice in dices)
        {
            StartCoroutine(dice.Roll());
            damageToDeal += dice.value;
        }

        yield return new WaitForSeconds(1f);
        mostRolledDigit = Battle.Instance.CalculateMostRolledDigit(dices);
        GameUI.Instance.enemyMostRolledDigitObject.UpdateAppearance(mostRolledDigit);
        damageToDeal += damage;

        yield return null;
    }

    public IEnumerator Attack()
    {
        animator.SetTrigger("isAttacking01");
        yield return null;
    }

    public void Die()
    {
        isDying = true;
        animator.SetTrigger("isDying");

        for (int i = 0; i < soulCurrencies + Player.Instance.soulCurrencyBonus; i++)
        {
            GameObject soulCurrency = Instantiate(soulCurrencyPrefab, this.gameObject.transform.position, Quaternion.identity);
        }
        for (int i = 0; i < exp; i++)
        {
            GameObject expBall = Instantiate(expPrefab, this.gameObject.transform.position, Quaternion.identity);
        }

        Destroy(spotlight.gameObject);

        foreach (var dice in dices)
        {
            Destroy(dice.gameObject);
        }
    }

    public void GetHurt(int receivedDamage)
    {
        animator.SetTrigger("isHurt");
        StartCoroutine(UpdateHP(receivedDamage, false));
    }
}

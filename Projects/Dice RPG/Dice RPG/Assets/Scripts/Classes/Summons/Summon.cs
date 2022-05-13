using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    public int linkDigit;
    public string summonName;
    public bool isSummon;
    public bool isActive;
    public int turnsActive;
    public int damageToDeal;
    public Dice linkedDice;

    [Header("ANIMATION")]
    public SpriteRenderer sprite;
    public Animator animator;
    public AnimationClip appearAnim;
    public AnimationClip idleAnim;
    public AnimationClip moveAnim;
    public AnimationClip attackAnim;
    public AnimationClip returnToIdleAnim;
    public AnimationClip hurtAnim;
    public AnimationClip deathAnim;
    public bool hasReturnToIdleAnim;

    void Awake()
    {
        SetAnimations();
    }

    public void SetAnimations()
    {
        AnimatorOverrideController AOC = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = AOC;

        AOC["Appear"] = appearAnim;
        AOC["Idle"] = idleAnim;
        AOC["Move"] = moveAnim;
        AOC["Attack01"] = attackAnim;
        if (returnToIdleAnim != null) AOC["ReturnToIdle"] = returnToIdleAnim;
        AOC["Hurt"] = hurtAnim;
        AOC["Death"] = deathAnim;

        animator.runtimeAnimatorController = AOC;
        animator.SetBool("hasReturnToIdle", hasReturnToIdleAnim);
        animator.SetBool("isSummon", isSummon);
    }

    public IEnumerator Appear()
    {
        animator.SetTrigger("isAppearing");
        yield return new WaitForFixedUpdate();
        sprite.enabled = true;

        yield return null;
    }

    public void Attack()
    {
        Player.Instance.damageToDeal = linkedDice.value + Player.Instance.damageBonus + Player.Instance.tempDamageBonus;
        animator.SetTrigger("isAttacking01");

        if (linkedDice.value == linkDigit)
        {
            switch (summonName)
            {
                case "Bat":
                    BatSkill();
                    break;
                case "Skull":
                    SkullSkill();
                    break;
                case "Golem":
                    GolemSkill();
                    break;
                case "Demon":
                    DemonSkill();
                    break;
            }
        }
    }

    public void BatSkill()
    {
        StartCoroutine(linkedDice.TriggerSkillAnimation(0f, "Leech Life", true, this.gameObject.transform, SkillTypes.types.Damage));
    }

    public void SkullSkill()
    {
        StartCoroutine(linkedDice.TriggerSkillAnimation(0f, "Assistance", true, this.gameObject.transform, SkillTypes.types.Damage));
    }

    public void GolemSkill()
    {
        StartCoroutine(linkedDice.TriggerSkillAnimation(0f, "Rock Skin", true, this.gameObject.transform, SkillTypes.types.Damage));
    }

    public void DemonSkill()
    {
        StartCoroutine(linkedDice.TriggerSkillAnimation(0f, "Hellfire", true, this.gameObject.transform, SkillTypes.types.Damage));
    }
}

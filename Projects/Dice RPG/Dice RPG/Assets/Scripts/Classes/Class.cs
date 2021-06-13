using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Class : MonoBehaviour
{
    [Header("STATS")]
    public string className;
    public CurrentClass.classes curClass;
    public int hitPoints;
    public int damage;
    public int dice;
    public int looting;
    public int healing;
    public float selectionScreenAngle;

    [DisplayName("Gamma")]
    [Trackball(TrackballAttribute.Mode.Gamma)]
    public Vector4Parameter gamma;

    [Header("ANIMATION")]
    public Animator animator;
    public AnimationClip idleAnim;
    public AnimationClip moveAnim;
    public AnimationClip attackAnim01;
    public AnimationClip attackAnim02;
    public AnimationClip attackAnim03;
    public AnimationClip returnToIdleAnim;
    public AnimationClip hurtAnim;
    public AnimationClip hurtSideStepAnim;
    public AnimationClip hurtShadowRetreatAnim;
    public AnimationClip deathAnim;
    public AnimationClip soulTransformAnim;
    public bool hasReturnToIdleAnim;

    [Header("OTHER")]
    public Transform soulsPosition;

    void Awake()
    {
        SetAnimations();
        AddToClassesDictionary();
    }

    public void SetAnimations()
    {
        AnimatorOverrideController AOC = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = AOC;

        AOC["Idle"] = idleAnim;
        AOC["Move"] = moveAnim;
        AOC["Attack01"] = attackAnim01;
        if (attackAnim02 != null) AOC["Attack02"] = attackAnim02;
        if (attackAnim03 != null) AOC["Attack03"] = attackAnim03;
        if (returnToIdleAnim != null) AOC["ReturnToIdle"] = returnToIdleAnim;
        AOC["Hurt"] = hurtAnim;
        if (hurtSideStepAnim != null) AOC["Hurt_SideStep"] = hurtSideStepAnim;
        if (hurtShadowRetreatAnim != null) AOC["Hurt_ShadowRetreat"] = hurtShadowRetreatAnim;
        AOC["Death"] = deathAnim;
        AOC["SoulTransform"] = soulTransformAnim;

        animator.runtimeAnimatorController = AOC;
        animator.SetBool("hasReturnToIdle", hasReturnToIdleAnim);
    }

    void AddToClassesDictionary()
    {
        ClassesObjects.Instance.characters.Add(curClass, this);
    }

    public void Attack()
    {
        animator.SetTrigger("isAttacking01");
    }

    public void AttackTwo()
    {
        animator.SetTrigger("isAttacking02");
    }
}

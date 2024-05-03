using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Class : MonoBehaviour
{
	[Header("DATA")]
	public ClassData classData;
	public ClassGraphicsData classGraphicsData;
	public ClassAnimationData classAnimData;

	[Header("ANIMATION")]
    public Animator animator;

    [Header("OTHER")]
    public Transform soulsPosition;
    public Transform chatBoxPosition;

    void Awake()
    {
        SetAnimations();
        AddToClassesDictionary();
    }

    public void SetAnimations()
    {
        AnimatorOverrideController AOC = new AnimatorOverrideController(animator.runtimeAnimatorController);
        animator.runtimeAnimatorController = AOC;

		//GLOBAL
        AOC["Idle"] = classAnimData.idleAnim;
        AOC["Move"] = classAnimData.moveAnim;
        AOC["Attack"] = classAnimData.basicAttackAnim;
		AOC["Hurt"] = classAnimData.hurtAnim;
		AOC["Death"] = classAnimData.deathAnim;
		AOC["SoulTransform"] = classAnimData.soulTransformAnim;

		//OPTIONAL
		if (classAnimData.returnToIdleAnim != null) AOC["ReturnToIdle"] = classAnimData.returnToIdleAnim;

		//WARRIOR
		if (classAnimData.attackSeismicDiveAnim != null) AOC["Attack_SeismicDive"] = classAnimData.attackSeismicDiveAnim;
		if (classAnimData.attackWhirlwindSlashAnim != null) AOC["Attack_WhirlwindSlash"] = classAnimData.attackWhirlwindSlashAnim;

		//RONIN
		if (classAnimData.attackEclipseRushAnim != null) AOC["Attack_EclipseRush"] = classAnimData.attackEclipseRushAnim;
		if (classAnimData.attackTripleSlashAnim != null) AOC["Attack_TripleSlash"] = classAnimData.attackTripleSlashAnim;
		if (classAnimData.hurtSideStepAnim != null) AOC["Hurt_SideStep"] = classAnimData.hurtSideStepAnim;
		if (classAnimData.hurtShadowRetreatAnim != null) AOC["Hurt_ShadowRetreat"] = classAnimData.hurtShadowRetreatAnim;

		//GUNSLINGER
		if (classAnimData.attackSuppressiveFireAnim != null) AOC["Attack_SuppressiveFire"] = classAnimData.attackSuppressiveFireAnim;
		if (classAnimData.attackDynamiteAnim != null) AOC["Attack_Dynamite"] = classAnimData.attackDynamiteAnim;
		if (classAnimData.attackRifleAnim != null) AOC["Attack_Rifle"] = classAnimData.attackRifleAnim;

		//TECHNOMANCER
		//nothing for now

		//WARLOCK
		if (classAnimData.summonAnim != null) AOC["Summon"] = classAnimData.summonAnim;

		//HEALER
		//nothing for now

		animator.runtimeAnimatorController = AOC;
        animator.SetBool("hasReturnToIdle", classAnimData.hasReturnToIdle);
    }

    void AddToClassesDictionary()
    {
        ClassesObjects.Instance.characters.Add(classData.curClass, this);
    }

    public void Attack()
    {
        animator.Play("Attack");
    }
}

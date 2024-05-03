using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClassAnimationData", menuName = "Dice RPG/Class Animation Data")]
public class ClassAnimationData : ScriptableObject
{
	[Header("GLOBAL")]
	public AnimationClip idleAnim;
	public AnimationClip moveAnim;
	public AnimationClip basicAttackAnim;
	public AnimationClip hurtAnim;
	public AnimationClip deathAnim;
	public AnimationClip soulTransformAnim;

	[Header("OPTIONAL")]
	public bool hasReturnToIdle;
	public AnimationClip returnToIdleAnim;

	[Header("WARRIOR")]
	public AnimationClip attackPierceAnim;
	public AnimationClip attackSeismicDiveAnim;
	public AnimationClip attackWhirlwindSlashAnim;
	public AnimationClip hurtParryAnim;

	[Header("RONIN")]
	public AnimationClip attackEclipseRushAnim;
	public AnimationClip attackDoubleSlashAnim;
	public AnimationClip attackTripleSlashAnim;
	public AnimationClip attackAssassinate;
	public AnimationClip hurtSideStepAnim;
	public AnimationClip hurtShadowRetreatAnim;

	[Header("GUNSLINGER")]
	public AnimationClip attackSuppressiveFireAnim;
	public AnimationClip attackDynamiteAnim;
	public AnimationClip attackRifleAnim;

	//[Header("TECHNOMANCER")]

	[Header("WARLOCK")]
	public AnimationClip summonAnim;

	//[Header("HEALER")]
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[CreateAssetMenu(fileName = "ClassGraphicsData", menuName = "Dice RPG/Class Graphics Data")]
public class ClassGraphicsData : ScriptableObject
{
	[Header("CHARACTER SELECTION SCREEN")]
	public float selectionScreenAngle;

	[Header("CLASS COLORS")]
	[Trackball(TrackballAttribute.Mode.Gamma)]
	public Vector4Parameter gamma;
	public Color lightShaftColor;
	public Color lightShaftColor2;
	public Color backgroundFilterColor;
	public Color soulsColor;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	private static LTDescr delay;
	[NonSerialized] public string header;
	[NonSerialized] public string description;

	public void OnPointerEnter(PointerEventData eventData)
	{
		delay = LeanTween.delayedCall(0.5f, () =>
		{
			TooltipSystem.Show(description, header);
		});
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		LeanTween.cancel(delay.uniqueId);
		TooltipSystem.Hide();
	}

	public void SetInfo(Skill skill)
	{
		header = skill.skillName;
		description = skill.description;
	}
}

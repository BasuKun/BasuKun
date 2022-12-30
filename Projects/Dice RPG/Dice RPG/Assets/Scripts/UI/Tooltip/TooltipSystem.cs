using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooltipSystem : MonoBehaviour
{
	public Tooltip tooltip;
	public static TooltipSystem Instance;

	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	public static void Show(string content, string header = "")
	{
		Instance.tooltip.SetText(content, header);
	}

	public static void Hide()
	{
		Instance.tooltip.gameObject.SetActive(false);
	}
}

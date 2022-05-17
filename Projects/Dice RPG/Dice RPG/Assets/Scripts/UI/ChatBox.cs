using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Febucci.UI;

public class ChatBox : MonoBehaviour
{
	public TextAnimator chatText;
	public TextAnimatorPlayer chatTextPlayer;
	public Animator animator;

	private bool hasAppeared = false;
	private bool isSetToDestroy = false;
	private bool isDestroying = false;
	public bool isDisappearing = false;
	private float timeToAppear = 0f;

	private void Update()
	{
		if (!hasAppeared)
		{
			timeToAppear += Time.deltaTime;
		}
		else
		{
			if (!isSetToDestroy)
			{
				Invoke("StartDisappear", 3f);
				isSetToDestroy = true;
			}
		}
	}

	public void UpdateText(string dialog)
    {
        chatTextPlayer.ShowText(dialog);
    }

	public void StopAppearingTimer()
	{
		hasAppeared = true;
	}

	public void StartDisappear()
	{
		if (isDisappearing) return;

		isDisappearing = true;
		chatText.gameObject.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 0f);
		AnimateDisappear();
	}

	public void AnimateDisappear()
	{
		if (isDestroying) return;

		ChatBoxHandler.Instance.activeChatBoxes.Remove(this);
		isDestroying = true;
		animator.SetTrigger("Disappear");
		Destroy(this.gameObject, 1f);
	}

	public void QuickDestroyChatBox()
	{
		if (!hasAppeared) chatTextPlayer.StopShowingText();
		chatText.gameObject.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 0f);
		AnimateDisappear();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
	public CanvasGroup canvasGroup;
	public RectTransform rectTransform;
	public TextMeshProUGUI headerField;
	public TextMeshProUGUI contentField;
	public LayoutElement layoutElement;
	public GameObject dicePattern;
	public Image patternImage;
	public int characterWrapLimit;
	public Vector3 mouseOffset;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	private void Update()
	{
		Vector2 position = Input.mousePosition + mouseOffset;
		float pivotX = position.x / Screen.width;
		float pivotY = position.y / Screen.height;

		rectTransform.pivot = new Vector2(pivotX, pivotY);
		transform.position = position;
	}

	public void SetText(string content, string header = "")
	{
		if (string.IsNullOrEmpty(header))
			headerField.gameObject.SetActive(false);
		else
		{
			headerField.gameObject.SetActive(true);
			headerField.text = header;
		}

		contentField.text = content;

		int headerLength = headerField.text.Length;
		int contentLength = contentField.text.Length;
		layoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;

		canvasGroup.alpha = 0f;
		gameObject.SetActive(true);

		LeanTween.alphaCanvas(canvasGroup, 1f, 0.15f);
	}

	public void SetPattern(Sprite pattern)
	{
		if (pattern != null)
		{
			patternImage.sprite = pattern;
			patternImage.SetNativeSize();
			dicePattern.SetActive(true);
		}
		else
			dicePattern.SetActive(false);
	}
}

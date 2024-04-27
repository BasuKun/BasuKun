using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MistDrifter : MonoBehaviour
{
	private SpriteRenderer mistSprite;
	private float moveMultiplier = 1;
	private float mistStartWidth;
	public float driftSpeed;

	private void Awake()
	{
		mistSprite = GetComponent<SpriteRenderer>();
		mistStartWidth = mistSprite.size.x;
	}

	private void Update()
	{
		moveMultiplier = Player.Instance.isMoving ? 6 : 1;
		mistSprite.size += new Vector2(driftSpeed * moveMultiplier, 0f) * Time.deltaTime;

		if (mistSprite.size.x >= mistStartWidth * 4.948f)
			mistSprite.size = new Vector2(mistStartWidth, mistSprite.size.y);
	}
}

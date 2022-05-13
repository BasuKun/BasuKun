using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSoulFloating : MonoBehaviour
{
    public List<Sprite> stages = new List<Sprite>();
    public int currentStage;
    public Animator animator;
    public Animator appearAnimator;

    public float angleOffset;
    private float angle = 0;
    private float radius = 0.0001f;
    private float speed = 3f;

	private void Start()
	{
        animator.Play("Soul_100", -1, Random.Range(0.0f, 1.0f));
    }

	void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + Mathf.Sin(angle + angleOffset) * radius);
        angle += Time.deltaTime * speed;
    }
}

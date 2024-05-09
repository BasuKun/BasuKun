using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillIcon : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public Skill skillData;
	public GameObject iconPrefab;

	private float pressTime = 0;
	private bool isHeld = false;
	private GameObject dragIcon = null;

	void Update()
	{
		if (isHeld)
		{
			pressTime += Time.deltaTime;
			if (pressTime >= 0.2f)
			{
				StartDrag();
				isHeld = false;
			}
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		pressTime = 0;
		isHeld = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		isHeld = false;
	}

	private void StartDrag()
	{
		if (iconPrefab)
		{
			dragIcon = Instantiate(iconPrefab, transform.position, Quaternion.identity, GameUI.Instance.gameObject.transform);
			dragIcon.GetComponent<Image>().sprite = GetComponent<Image>().sprite;
			skillData = this.gameObject.GetComponentInParent<SkillTreeButton>().skillData;
			StartCoroutine(DragSkill());
		}
	}

	IEnumerator DragSkill()
	{
		while (Input.GetMouseButton(0) && dragIcon)
		{
			dragIcon.transform.position = Input.mousePosition;
			yield return null;
		}
		if (dragIcon)
		{
			SkillsBar.Instance.DropSkillOnBar(this);
			Destroy(dragIcon);
		}
	}
}

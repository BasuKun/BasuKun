using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public int value { get; set; }
    public int attackValue { get; set; }
    public int skillValue { get; set; }
    public bool isBerserkDice { get; set; }
    public bool isPlayerDice { get; set; }
    public bool isTemporary { get; set; }
    public int tempTurns { get; set; }
    public bool isLocked { get; set; }
    public int lockedTurns { get; set; }
    public bool isSelected { get; set; }
    public List<Sprite> sides = new List<Sprite>();
    public SpriteRenderer appearance;
    public SpriteRenderer overlay;
    public SpriteRenderer highlight;
    public GameObject diceTriggerAnim;
    public Animator animator;

    private void Start()
    {
        value = 1; 
        animator.SetInteger("StartValue", value);
        animator.SetInteger("EndValue", value);
        animator.SetTrigger("isAppearing");
    }

    public IEnumerator Roll()
    {
        if (isTemporary && tempTurns <= 0) RemoveDice();

        if (lockedTurns <= 0) UnlockDice();

        if (!isLocked)
        {
            animator.SetInteger("StartValue", value);
            animator.SetBool("isRolling", true);
            value = Random.Range(1, 7);
            attackValue = Balancing.GetAttackValue(value, false);
            skillValue = Balancing.GetSkillValue(value, false);

            yield return new WaitForFixedUpdate();
            animator.SetInteger("EndValue", value);
            animator.SetInteger("StartValue", value);

            animator.SetBool("isRolling", false);
        }
        else
        {
            lockedTurns--;
        }
        if (isTemporary)
        {
            tempTurns--;
        }

        yield return null;
    }

    public void Swap(int newValue)
	{
        value = newValue;
        animator.SetInteger("EndValue", newValue);
        animator.SetInteger("StartValue", newValue); 
        animator.SetTrigger("isAppearing");
    }

    public IEnumerator TriggerSkillAnimation(float time, string skillName, bool triggersSkillName, Transform character, SkillTypes.types skillType)
    {
        if (!isLocked)
        {
            yield return new WaitForSeconds(time);
            GameObject diceTrigger = Instantiate(diceTriggerAnim, this.gameObject.transform.position, Quaternion.identity);
            if (triggersSkillName) Battle.Instance.SkillNamePopout(skillName, character, skillType);

            yield return null;
        }
    }

    public void LockDice(int amountOfTurns)
    {
        isLocked = true;
        overlay.enabled = true;
        overlay.sortingOrder = appearance.sortingOrder + 1;
        value = 0;
        attackValue = 0;
        skillValue = 0;
        lockedTurns = amountOfTurns;
    }

    public void UnlockDice()
    {
        isLocked = false;
        overlay.enabled = false;
    }

    public void RemoveDice()
    {
        Destroy(this.gameObject);
    }

    public void RemoveHighlight()
	{
		if (isSelected)
		{
            isSelected = false;
            highlight.enabled = false; 
            Battle.Instance.curSelectedDices--;
            DiceButtons.Instance.CheckForInteractableConditions();
        }
    }

	public void OnMouseOver()
	{
		if (Input.GetMouseButtonDown(0) && isPlayerDice && !isLocked && Battle.Instance.canModifyDices)
		{
            if (!isSelected && Battle.Instance.curSelectedDices == Battle.Instance.maxSelectedDices) return;

            isSelected = !isSelected;
            highlight.enabled = isSelected;

            Battle.Instance.curSelectedDices += isSelected ? 1 : -1;

            DiceButtons.Instance.CheckForInteractableConditions();
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    public int value { get; set; }
    public bool isLocked { get; set; }
    public int lockedTurns { get; set; }
    public List<Sprite> sides = new List<Sprite>();
    public SpriteRenderer appearance;
    public SpriteRenderer overlay;
    public GameObject diceTriggerAnim;
    public Animator animator;

    private void Start()
    {
        value = 1;
        animator.SetTrigger("isAppearing");
    }

    public IEnumerator Roll()
    {
        if (lockedTurns <= 0) UnlockDice();

        if (!isLocked)
        {
            animator.SetInteger("StartValue", value);
            animator.SetBool("isRolling", true);
            value = Random.Range(1, 7);

            yield return new WaitForFixedUpdate();
            animator.SetInteger("EndValue", value);
            animator.SetInteger("StartValue", value);

            animator.SetBool("isRolling", false);
        }
        else
        {
            lockedTurns -= 1;
        }

        yield return null;
    }

    public IEnumerator TriggerSkillAnimation(float time, string skillName, bool triggersSkillName, SkillTypes.types skillType)
    {
        if (!isLocked)
        {
            yield return new WaitForSeconds(time);
            GameObject diceTrigger = Instantiate(diceTriggerAnim, this.gameObject.transform.position, Quaternion.identity);
            if (triggersSkillName) Battle.Instance.SkillNamePopout(skillName, Player.Instance.character.transform, skillType);

            yield return null;
        }
    }

    public void LockDice(int amountOfTurns)
    {
        isLocked = true;
        overlay.enabled = true;
        overlay.sortingOrder = appearance.sortingOrder + 1;
        value = 0;
        lockedTurns = amountOfTurns;
    }

    public void UnlockDice()
    {
        isLocked = false;
        overlay.enabled = false;
    }
}

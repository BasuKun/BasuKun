using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Febucci.UI;

public class SkillFloatingText : MonoBehaviour
{
    public float posOffset = 0;
    public TextAnimator skillNameText;
    public SkillTypes.types skillType;

    private void Awake()
    {
        Invoke("DestroyGameObject", 2.5f);
    }

    private void Update()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, Camera.main.WorldToScreenPoint(new Vector2(0f, 0.3f + posOffset)), Time.deltaTime * 2);
    }

    public void UpdateSkillNameText(string skillName, SkillTypes.types type)
    {
        skillNameText.SetText("{size}<fade>" + skillName + "!</fade>{size}", false);
        skillType = type;
        UpdateOffset();
    }

    public void UpdateOffset()
    {
        switch (skillType)
        {
            case SkillTypes.types.Buff:
                posOffset = 0.08f * BuffSkillsDictionary.Instance.namePopouts.Count;
                break;
            case SkillTypes.types.Damage:
                posOffset = 0;
                break;
            case SkillTypes.types.Effect:
                posOffset = 0.08f * EffectSkillsDictionary.Instance.namePopouts.Count;
                break;
            case SkillTypes.types.Reaction:
                posOffset = 0.08f * ReactionSkillsDictionary.Instance.namePopouts.Count;
                break;
            case SkillTypes.types.Defense:
                posOffset = 0.08f * DefenseSkillsDictionary.Instance.namePopouts.Count;
                break;
            case SkillTypes.types.Summon:
                posOffset = 0.08f * SummonSkillsDictionary.Instance.namePopouts.Count;
                break;
            default:
                break;
        }
    }

    public void DestroyGameObject()
    {
        switch (skillType)
        {
            case SkillTypes.types.Buff:
                BuffSkillsDictionary.Instance.namePopouts.Remove(this.gameObject);
                break;
            case SkillTypes.types.Damage:
                break;
            case SkillTypes.types.Effect:
                EffectSkillsDictionary.Instance.namePopouts.Remove(this.gameObject);
                break;
            case SkillTypes.types.Reaction:
                ReactionSkillsDictionary.Instance.namePopouts.Remove(this.gameObject);
                break;
            case SkillTypes.types.Defense:
                DefenseSkillsDictionary.Instance.namePopouts.Remove(this.gameObject);
                break;
            case SkillTypes.types.Summon:
                SummonSkillsDictionary.Instance.namePopouts.Remove(this.gameObject);
                break;
            default:
                break;
        }
        Destroy(this.gameObject);
    }
}

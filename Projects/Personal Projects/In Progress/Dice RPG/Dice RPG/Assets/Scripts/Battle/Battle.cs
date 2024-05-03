using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MoreMountains.Feedbacks;

public class Battle : MonoBehaviour
{
    private Vector3 damageOffset = new Vector3(0, 0.2f, 0f);
    public int turn = 0; 
    public int maxSelectedDices = 2;
    public int curSelectedDices = 0;

    [Header("BATTLE BOOLS")]
    public bool hasFinishedAttacking = false;
    public bool isCountering = false;
    public bool isBerserking = false;
    public bool usedLastBreath = false;
    public bool isLastBreathing = false;
    public bool isSideStepping = false;
    public bool isShadowRetreating = false;
    public bool hasDistanceAdvantage = false;
    public bool isAutoAttacking = false;
    public bool isReadyToAttack = false;
    public bool canModifyDices = false;

    [Header("GAMEOBJECTS")]
    public GameObject damagePopout;
    public GameObject skillNamePopout;
    public Canvas uiCanvas;
    public Canvas worldUICanvas;
    public MMFeedbacks attackFeedback;

    [Header("FIGHTERS")]
    public Enemy curEnemy;
    public Player curPlayer;

    public static Battle Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public IEnumerator BattleSequence(Enemy enemy, Player player)
    {
        curEnemy = enemy;
        curPlayer = player;
        curPlayer.soulCurrencyBonus = 0;
        turn = 1;

        while (enemy.curHitPoints > 0 && player.curHitPoints > 0)
        {
            curSelectedDices = 0;
            hasFinishedAttacking = false;
            isReadyToAttack = false;

            yield return new WaitForSeconds(0.5f);
            StartCoroutine(enemy.RollDamage());
            StartCoroutine(player.Attack());

            while (!hasFinishedAttacking) yield return new WaitForFixedUpdate();

            yield return new WaitForSeconds(0.2f);
            if (enemy.isBleeding && enemy.curHitPoints > 0)
            {
                DealDamage(false, enemy.bleedingDamage);
                enemy.bleedingTurns--;
                if (enemy.bleedingTurns == 0) enemy.isBleeding = false;
            }
            yield return new WaitForSeconds(0.5f);

            if (enemy.curHitPoints > 0 && !hasDistanceAdvantage)
            {
                StartCoroutine(enemy.Attack());
                yield return new WaitForSeconds(1f);
            }

            turn++;
        }

        yield return new WaitForSeconds(1f);
        player.tempDamageBonus = 0;
        turn = 0;
        ResetSkills();

        ChatBoxHandler.Instance.Speak(ChatBoxHandler.DialogTypes.Win);
        StartCoroutine(Player.Instance.Move());
        yield return null;
    }

    public void ResetSkills()
    {
        foreach (var skill in Player.Instance.reactionSkills)
        {
            skill.ResetSkill();
        }

        foreach (var dice in Player.Instance.dices)
        {
            if (dice.isTemporary)
            {
                Player.Instance.dices.Remove(dice);
                Destroy(dice.gameObject);
            }
        }

        Player.Instance.diceRack.GetComponent<DiceRackSizeFitter>().ResizeRack(Player.Instance.dices);
    }

    public void ReceiveDamage()
    {
        foreach (var skill in curPlayer.defenseSkills)
        {
            skill.PerformSkill(curPlayer.dices, curEnemy.dices);
        }

        if (isShadowRetreating)
        {
            Player.Instance.skillsActivated++;
            SkillNamePopout("Shadow Retreat", Player.Instance.character.transform, SkillTypes.types.Defense);
            DamagePopout(curPlayer.character.gameObject, 0);
            curPlayer.GetHurt(0, "Hurt_ShadowRetreat");
        }
        else if (isCountering)
        {
            Player.Instance.skillsActivated++;
            StartCoroutine(curPlayer.dices[curPlayer.dices.Count - 1].TriggerSkillAnimation(0, "Parry", true, Player.Instance.character.transform, SkillTypes.types.Reaction));
            StartCoroutine(curPlayer.dices[curPlayer.dices.Count - 2].TriggerSkillAnimation(0, "Parry", false, Player.Instance.character.transform, SkillTypes.types.Reaction));

            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal / 2);
            curPlayer.GetHurt(curEnemy.damageToDeal / 2, "Hurt_Parry");

            DamagePopout(curEnemy.gameObject, curEnemy.damageToDeal / 2);
            curEnemy.GetHurt(curEnemy.damageToDeal / 2);
        }
        else if (isSideStepping)
        {
            Player.Instance.skillsActivated++;
            SkillNamePopout("Side Step", Player.Instance.character.transform, SkillTypes.types.Defense);
            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal - curPlayer.damageToAvoid);
            curPlayer.GetHurt(curEnemy.damageToDeal - curPlayer.damageToAvoid, "Hurt_SideStep");
        }
        else
        {
            DamagePopout(curPlayer.character.gameObject, curEnemy.damageToDeal);
            curPlayer.GetHurt(curEnemy.damageToDeal, "Hurt");
        }
    }

    public void DealDamage(bool isNormalAttack, int damageToDeal)
    {
        if (isNormalAttack)
        {
            foreach (var skill in curPlayer.effectSkills)
            {
                skill.PerformSkill(curPlayer.dices, curEnemy.dices);
            }
        }

        attackFeedback.FeedbacksIntensity = 0.5f;
        attackFeedback.DurationMultiplier = 0.5f;
        attackFeedback.PlayFeedbacks();

        DamagePopout(curEnemy.gameObject, damageToDeal);
        curEnemy.GetHurt(damageToDeal);
    }

    public void DamagePopout(GameObject target, int damage)
    {
        GameObject damageText = Instantiate(damagePopout, Camera.main.WorldToScreenPoint(target.transform.position + damageOffset), Quaternion.identity, uiCanvas.transform);
        damageText.GetComponent<DamageFloatingText>().UpdateDamageText(damage);
    }

    public void SkillNamePopout(string skillName, Transform pos, SkillTypes.types skillType)
    {
        GameObject skillNameText = null;

        switch (skillType)
        {
            case SkillTypes.types.Buff:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * BuffSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                BuffSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Damage:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f, 0f)), Quaternion.identity, uiCanvas.transform);
                break;
            case SkillTypes.types.Effect:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * EffectSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                EffectSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Reaction:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * ReactionSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                ReactionSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Defense:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * DefenseSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                DefenseSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            case SkillTypes.types.Summon:
                skillNameText = Instantiate(skillNamePopout, Camera.main.WorldToScreenPoint(new Vector3(0f, 0.1f + 0.08f * SummonSkillsDictionary.Instance.namePopouts.Count, 0f)), Quaternion.identity, uiCanvas.transform);
                SummonSkillsDictionary.Instance.namePopouts.Add(skillNameText);
                break;
            default:
                break;
        }

        skillNameText.GetComponent<SkillFloatingText>().UpdateSkillNameText(skillName, skillType);
    }

    public bool AnimatorIsPlaying(Animator animator)
    {
        return animator.GetCurrentAnimatorStateInfo(0).length >
               animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
    }

    public int CalculateMostRolledDigit(List<Dice> dices)
    {
        int[] digitAmounts = new int[] { 0, 0, 0, 0, 0, 0, 0 };

        foreach (var dice in dices)
        {
            digitAmounts[dice.value]++;
        }

        var maxIndices =
        digitAmounts
        .Select((n, i) => new { n, i })
        .GroupBy(x => x.n, x => x.i)
        .OrderByDescending(x => x.Key)
        .Take(1)
        .SelectMany(x => x)
        .ToArray();

        if (maxIndices.Length > 1) return 0;
        else return maxIndices[0];
    }

    public void ConfirmAttack()
    {
        isReadyToAttack = true;
        DiceButtons.Instance.ActivateButtons(false);
    }

    public void RerollDicesWrapper()
	{
        StartCoroutine(RerollDices());
	}

    public IEnumerator RerollDices()
    {
        DiceButtons.Instance.ActivateButtons(false);
        canModifyDices = false;
        
        foreach (var dice in curPlayer.dices)
		{
			if (dice.isSelected)
			{
                StartCoroutine(dice.Roll());
                dice.RemoveHighlight();
            }
		}

        yield return new WaitForSeconds(0.95f);
        DiceButtons.Instance.okButton.interactable = true;
        canModifyDices = true;

        yield return null;
	}

    public void SwapDices()
	{
        List<Dice> dicesToSwap = new List<Dice>();

        foreach (var dice in curPlayer.dices)
        {
            if (dice.isSelected)
            {
                dicesToSwap.Add(dice);
                dice.RemoveHighlight();
            } 
        }

        int firstValue = dicesToSwap[0].value;
        int secondValue = dicesToSwap[1].value;

        dicesToSwap[0].Swap(secondValue);
        dicesToSwap[1].Swap(firstValue);
    }
}

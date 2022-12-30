using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public enum CurrencyTypes
	{
        Soul,
        Exp
	}

    public CurrencyTypes currencyType;
    public Rigidbody2D rig;

    void Awake()
    {
        rig.AddForce(new Vector2(Random.Range(-4f, 4f), Random.Range(-4f, 4f)), ForceMode2D.Impulse);
        StartCoroutine(FlyTowardsPlayer());
    }

    private IEnumerator FlyTowardsPlayer()
    {
        yield return new WaitForSeconds(Random.Range(0.8f, 1.4f));

        while (gameObject.transform.position.x > Player.Instance.character.gameObject.transform.position.x)
        {
            gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, Player.Instance.character.gameObject.transform.position - new Vector3(0.2f, 0f, 0f), Time.deltaTime * Random.Range(0.5f, 2.3f));
            yield return new WaitForFixedUpdate();
        }

		switch (currencyType)
		{
			case CurrencyTypes.Soul:
                ObtainSoulsCurrency();
                break;
			case CurrencyTypes.Exp:
                ObtainExp();
                break;
			default:
				break;
		}

		Destroy(this.gameObject);
        yield return null;
    }

    private void ObtainSoulsCurrency()
	{
        Player.Instance.soulsCurrency++;
        GameUI.Instance.UpdateSoulsCurrencyText();
    }

    private void ObtainExp()
	{
        Player.Instance.experience++;

		if (Player.Instance.experience >= Player.Instance.experienceNeeded)
		{
            Player.Instance.level++;
            Player.Instance.experience = 0;
            Player.Instance.experienceNeeded *= 2;
            GameUI.Instance.UpdateLevelText();

            Player.Instance.statPoints += 3;
            Player.Instance.strength++;
            Player.Instance.finesse++;
            Player.Instance.vitality++;
            Player.Instance.recovery++;
            Player.Instance.greed++;
            Player.Instance.skillPoints += 10;

            StatsMenu.Instance.UpdatePoints();
            StatsMenu.Instance.UpdateStats();
            StatsMenu.Instance.UpdateDamageRanges();

            PlayerSkills.Instance.UpdateSkillPointsText();
            PlayerSkills.Instance.CheckForUnlockedButtons();
        }
        GameUI.Instance.UpdateExpBar();
    }
}

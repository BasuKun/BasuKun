using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle : MonoBehaviour
{
    private int round = 1;
    private float roundMultiplier = 0.25f;
    public string currentLocation;

    public Vector2 enemyStartingPosition = new Vector2(850f, 300f);
    public Vector3 enemyPosOffset = new Vector3(270f, 55f, 0f);

    public GameObject actionScene;
    public GameObject uiScene;
    public RectTransform background;
    public GameObject enemyPrefab;

    public void OnConquerButtonClick()
    {
        Unlocks.Instance.conquestButton.GetComponent<Button>().interactable = false;

        round = 1;
        currentLocation = LocationSelection.Instance.selectedLocation;
        uiScene.SetActive(false);
        LocationSelection.Instance.StartConquerButton.interactable = false;
        actionScene.SetActive(true);

        Player.Instance.playerObject.SetActive(true);
        Player.Instance.currentHP = Player.Instance.data.hitPoints;
        Player.Instance.hpBar.value = 1;

        StartCoroutine(BackgroundParallax(round));
    }

    public IEnumerator BackgroundParallax(int round)
    {
        float scrollTime = 3f;
        GameObject enemy = SpawnEnemy(30, 15, (round - 1));

        while (scrollTime > 0)
        {
            float width = background.rect.width;
            width += 0.7f;
            background.sizeDelta = new Vector2(width, background.rect.height);

            enemy.transform.position -= new Vector3(0.7f, 0f, 0f);

            scrollTime -= Time.deltaTime;

            yield return null;
        }

        StartCoroutine(Fight(enemy));
        yield return null;
    }

    public IEnumerator Fight(GameObject e)
    {
        int damageToDeal;
        Enemy enemy = e.GetComponent<Enemy>();
        yield return new WaitForSeconds(1f);

        while (Player.Instance.currentHP > 0 && enemy.hitPoints > 0)
        {
            Player.Instance.playerObject.transform.position += new Vector3(8f, 0f, 0);
            yield return new WaitForSeconds(0.1f);
            damageToDeal = Player.Instance.data.attack + Random.Range(0, 4);
            enemy.currentHP -= damageToDeal;
            enemy.hpBar.value = (float)enemy.currentHP / (float)enemy.hitPoints;
            GameManager.Instance.currencyPopout('-', Camera.main.ScreenToWorldPoint(enemy.hpBar.gameObject.transform.position), damageToDeal, "", new Color(1f, 0.54f, 0.53f));
            Player.Instance.playerObject.transform.position -= new Vector3(8f, 0f, 0);

            if (enemy.currentHP <= 0) break;
            StartCoroutine(DamageColor(enemy.appearance, new Color(1f, 0.54f, 0.53f)));
            yield return new WaitForSeconds(1f);

            enemy.gameObject.transform.position -= new Vector3(8f, 0f, 0);
            yield return new WaitForSeconds(0.1f);
            damageToDeal = enemy.attack * enemy.attack / (enemy.attack + Player.Instance.data.defense) + Random.Range(0, 4);
            Player.Instance.currentHP -= damageToDeal;
            Player.Instance.hpBar.value = (float)Player.Instance.currentHP / (float)Player.Instance.data.hitPoints;
            GameManager.Instance.currencyPopout('-', Camera.main.ScreenToWorldPoint(Player.Instance.hpBar.gameObject.transform.position), damageToDeal, "", new Color(1f, 0.54f, 0.53f));
            enemy.gameObject.transform.position += new Vector3(8f, 0f, 0);

            if (Player.Instance.currentHP <= 0) break;
            StartCoroutine(DamageColor(Player.Instance.appearance, new Color(1f, 0.54f, 0.53f)));
            yield return new WaitForSeconds(1f);
        }

        if (Player.Instance.currentHP <= 0)
        {
            Player.Instance.playerObject.SetActive(false);
            yield return new WaitForSeconds(2f);
            uiScene.SetActive(true);
            LocationSelection.Instance.ResetUI();
            actionScene.SetActive(false);

            Destroy(e);
        }
        else if (enemy.currentHP <= 0)
        {
            Destroy(e);
            yield return new WaitForSeconds(2f);

            if (round < 5)
            {
                int amountToHeal = !Unlocks.Instance.data.hasBetterHealing ? Player.Instance.data.healing : Player.Instance.data.healing * Player.Instance.data.currentUniverse;
                Player.Instance.currentHP = Mathf.Clamp(Player.Instance.currentHP + amountToHeal, 0, Player.Instance.data.hitPoints);
                Player.Instance.hpBar.value = (float)Player.Instance.currentHP / (float)Player.Instance.data.hitPoints;
                GameManager.Instance.currencyPopout('+', Camera.main.ScreenToWorldPoint(Player.Instance.hpBar.gameObject.transform.position), amountToHeal, "", new Color(0.28f, 0.94f, 0.66f));
                StartCoroutine(DamageColor(Player.Instance.appearance, new Color(0.28f, 0.94f, 0.66f)));

                round++;
                StartCoroutine(BackgroundParallax(round));
            }
            else
            {
                Player.Instance.playerObject.SetActive(false);
                Player.Instance.data.wonContinents++;

                uiScene.SetActive(true);
                CompleteLocation(currentLocation);
                actionScene.SetActive(false);
            }
        }

        yield return null;
    }

    public void CompleteLocation(string location)
    {
        switch (location)
        {
            case "Africa": // gives IB
                LocationSelection.Instance.data.completedAfrica = true;
                LocationSelection.Instance.locations[0].interactable = false;
                ConquerRewards.Instance.ibRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.ibReward += 0.8f;
                GameUI.Instance.conquerIBRewardUpdateText();
                break;
            case "Asia": // gives Population
                LocationSelection.Instance.data.completedAsia = true;
                LocationSelection.Instance.locations[1].interactable = false;
                ConquerRewards.Instance.habitatRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.habitatReward += 1f;
                GameUI.Instance.conquerHabitatRewardUpdateText();

                UpgradesButton button = Unlocks.Instance.moreHabitatButton.gameObject.GetComponent<UpgradesButton>();
                GameManager.Instance.GMData.habitatsAmount += 1 * button.data.level;
                GameManager.Instance.GMData.idlePopulationAmount += 1 * button.data.level;
                GameUI.Instance.idlePopulationUpdateText();
                GameUI.Instance.populationUpdateText();
                break;
            case "Australia": // gives IP
                LocationSelection.Instance.data.completedAustralia = true;
                LocationSelection.Instance.locations[2].interactable = false;
                ConquerRewards.Instance.ipRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.ipReward += 1f;
                GameUI.Instance.conquerIPRewardUpdateText();
                break;
            case "Europe": // gives SF
                LocationSelection.Instance.data.completedEurope = true;
                LocationSelection.Instance.locations[3].interactable = false;
                ConquerRewards.Instance.sfRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.sfReward += 0.5f;
                GameUI.Instance.conquerSFRewardUpdateText();
                break;
            case "NA": // gives IB & SF
                LocationSelection.Instance.data.completedNA = true;
                LocationSelection.Instance.locations[4].interactable = false;
                ConquerRewards.Instance.ibRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.sfRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.ibReward += 0.4f;
                ConquerRewards.Instance.data.sfReward += 0.2f;
                GameUI.Instance.conquerIBRewardUpdateText();
                GameUI.Instance.conquerSFRewardUpdateText();
                break;
            case "SA": // gives BP
                LocationSelection.Instance.data.completedSA = true;
                LocationSelection.Instance.locations[5].interactable = false;
                ConquerRewards.Instance.bpRewardText.gameObject.SetActive(true);
                ConquerRewards.Instance.data.bpReward += 1f;
                GameUI.Instance.conquerBPRewardUpdateText();
                break;
            default:
                break;
        }

        LocationSelection.Instance.data.completionPercentage = (int)((float)(Player.Instance.data.wonContinents - ((Player.Instance.data.currentUniverse - 1) * 6f)) / 6f * 100f);
        GameUI.Instance.completedPercentageUpdateText();

        switch (Player.Instance.data.wonContinents)
        {
            case 1:
                Logs.Instance.AddLog("As you seize your first continent, you realize humans had more firepower than expected. But no matter, the cold will conquer it all.", Color.white);
                break;
            case 2:
                Logs.Instance.AddLog("Now that you have vanquished your second continent, the penguins and polar bears will have more space to live. \n" +
                    "They are the superior species for they thrive in the cold.", Color.white);
                break;
            case 3:
                Logs.Instance.AddLog("You have blessed half of this world with the gift of winter. This knowledge motivates you further.", Color.white);
                break;
            case 4:
                Logs.Instance.AddLog("Having conquered your fourth continent, you gaze upon the tall mountain peaks which are snowy once more.", Color.white);
                break;
            case 5:
                Logs.Instance.AddLog("Oh, how breathtaking this world will look once every land will be in your frozen embrace, you wonder. Almost there!", Color.white);
                break;
            case 6:
                Logs.Instance.AddLog("At last, the missing piece has been put into place. The entire planet has now been put into a neverending, freezing winter. How peaceful. How beautiful. \n" +
                    "But your job doesn't end there. The humans were conducting research on parallel universes. Intrigued, you decide to give this a go. If there are more universes out there begging to be conquered, who are you to say no?", Color.white);
                break;
            case 7:
                break;
            default:
                break;
        }

        if (Player.Instance.data.wonContinents % 6 == 0) LocationSelection.Instance.CompleteUniverse();

        LocationSelection.Instance.ResetUI();
    }

    public GameObject SpawnEnemy(int hp, int atk, int appearanceID)
    {
        GameObject enemy = Instantiate(enemyPrefab, enemyStartingPosition, Quaternion.identity, actionScene.transform);
        Enemy stats = enemy.GetComponent<Enemy>();
        stats.hitPoints = (int)(hp * ((round - 1) * roundMultiplier + 1) * (int)((Player.Instance.data.wonContinents + 1) * Player.Instance.data.wonContinents + 1 - Player.Instance.data.wonContinents));
        stats.currentHP = stats.hitPoints;
        stats.attack = (int)(atk * ((round - 1) * roundMultiplier + 1) * (int)((Player.Instance.data.wonContinents + 1) * Player.Instance.data.wonContinents + 1 - Player.Instance.data.wonContinents));
        stats.appearance.sprite = stats.possibleAppearances[appearanceID];
        stats.appearance.SetNativeSize();

        enemy.transform.position += enemyPosOffset;

        return enemy;
    }

    public IEnumerator DamageColor(Image image, Color damageColor)
    {
        image.color = damageColor;
        yield return new WaitForSeconds(0.15f);
        image.color = Color.white;
        yield return null;
    }
}

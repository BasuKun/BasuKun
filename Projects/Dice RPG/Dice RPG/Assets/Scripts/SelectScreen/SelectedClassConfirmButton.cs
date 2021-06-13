using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedClassConfirmButton : MonoBehaviour
{
    public GameObject smokeBoomFX;
    public GameObject groundSmokeFX;
    public GameObject playerSouls;

    public void OnConfirmButtonPress()
    {
        StartCoroutine(GameUI.Instance.SwitchToAP());

        GameObject selectedCharacter = ClassesObjects.Instance.characters[(CurrentClass.classes)EllipsePositions.Instance.currentSelected].gameObject;
        GameObject groundSmoke = Instantiate(groundSmokeFX, new Vector2(selectedCharacter.transform.position.x, selectedCharacter.transform.position.y - 0.06f), Quaternion.identity);

        StartCoroutine(SetPlayerStats(selectedCharacter));
        StartCoroutine(EraseOtherClasses());
        StartCoroutine(PlaceCamera(ClassesObjects.Instance.characters[(CurrentClass.classes)EllipsePositions.Instance.currentSelected].soulsPosition));
        StartCoroutine(StartMoving());
    }

    private IEnumerator EraseOtherClasses()
    {
        yield return new WaitForSeconds(0.2f);

        int order = 0;

        foreach (var character in ClassesObjects.Instance.characters)
        {
            if (character.Key == (CurrentClass.classes)EllipsePositions.Instance.currentSelected) continue;

            character.Value.animator.SetTrigger("isSoulTransforming");
            order++;
            StartCoroutine(FlyTowardsSelectedCharacter(character.Value.gameObject, order));

            yield return new WaitForSeconds(0.2f);
        }

        yield return null;
    }

    private IEnumerator FlyTowardsSelectedCharacter(GameObject character, int order)
    {
        GameObject currentSoul = Player.Instance.souls[order - 1].gameObject;

        yield return new WaitForSeconds(0.7f);

        float time = 0f;
        while (time < 2f)
        {
            character.gameObject.transform.position = Vector2.Lerp(character.gameObject.transform.position, currentSoul.transform.position - new Vector3(-0.01f, 0.04f, 0f), Time.deltaTime * 3f);
            time += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        currentSoul.GetComponentInChildren<Animator>().SetTrigger("isAppearing");
        currentSoul.GetComponent<HPSoulFloating>().currentStage = 0;

        yield return new WaitForSeconds(0.4f);
        character.SetActive(false);
        currentSoul.GetComponent<SpriteRenderer>().enabled = true;

        yield return null;
    }

    private IEnumerator PlaceCamera(Transform soulsPosition)
    {
        while (Camera.main.transform.position.x < 0.299f)
        {
            playerSouls.transform.position = soulsPosition.position;
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(0.3f, -0.33f, -10f), Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
        Camera.main.transform.position = new Vector3(0.3f, -0.33f, -10f);
        yield return null;
    }

    private IEnumerator StartMoving()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(Player.Instance.Move());
        yield return null;
    }

    private IEnumerator SetPlayerStats(GameObject character)
    {
        Class characterStats = character.GetComponent<Class>();
        Player.Instance.character = characterStats;
        Player.Instance.hasReturnToIdle = characterStats.hasReturnToIdleAnim;
        Player.Instance.currentClass = characterStats.curClass;
        Player.Instance.maxHitPoints = characterStats.hitPoints;
        Player.Instance.curHitPoints = Player.Instance.maxHitPoints;
        Player.Instance.damageBonus = characterStats.damage;
        Player.Instance.diceAmount = characterStats.dice;
        Player.Instance.looting = characterStats.looting;
        Player.Instance.healing = characterStats.healing;
        Player.Instance.level = 1;
        Player.Instance.experience = 0;
        Player.Instance.soulsCurrency = 0;

        yield return new WaitForSeconds(1.9f);
        for (int i = 0; i < Player.Instance.diceAmount; i++)
        {
            Player.Instance.AddDice(true);
        }

        yield return null;
    }
}

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

        ChatBoxHandler.Instance.CheckToClearChatBoxes();
        GameObject selectedCharacter = ClassesObjects.Instance.characters[(CurrentClass.classes)EllipsePositions.Instance.currentSelected].gameObject;
        GameObject groundSmoke = Instantiate(groundSmokeFX, new Vector2(selectedCharacter.transform.position.x, selectedCharacter.transform.position.y - 0.06f), Quaternion.identity);

        StartCoroutine(SetPlayerStats(selectedCharacter));
        //AddSkills();
        StartCoroutine(EraseOtherClasses());
        StartCoroutine(PlaceCamera(ClassesObjects.Instance.characters[(CurrentClass.classes)EllipsePositions.Instance.currentSelected].soulsPosition));
        StartCoroutine(StartMoving());
        SelectMusic();
    }

    private IEnumerator EraseOtherClasses()
    {
        yield return new WaitForSeconds(0.2f);

        int order = 0;

        foreach (var character in ClassesObjects.Instance.characters)
        {
            if (character.Key == (CurrentClass.classes)EllipsePositions.Instance.currentSelected) continue;

            character.Value.animator.Play("SoulTransform");
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
            character.gameObject.transform.position = Vector2.Lerp(character.gameObject.transform.position, currentSoul.transform.position - new Vector3(-0.01f, 0.01f, 0f), Time.deltaTime * 3f);
            time += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        currentSoul.GetComponent<HPSoulFloating>().appearAnimator.SetTrigger("isAppearing");
        currentSoul.GetComponent<HPSoulFloating>().currentStage = 0;

        yield return new WaitForSeconds(0.4f);
        character.SetActive(false);
        currentSoul.GetComponent<SpriteRenderer>().enabled = true;

        yield return null;
    }

    private IEnumerator PlaceCamera(Transform soulsPosition)
    {
        while (Camera.main.transform.position.x < 0.489f)
        {
            playerSouls.transform.position = soulsPosition.position;
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(0.49f, -0.33f, -10f), Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
        Camera.main.transform.position = new Vector3(0.49f, -0.33f, -10f);
        yield return null;
    }

    private IEnumerator StartMoving()
    {
        yield return new WaitForSeconds(2f);
        ChatBoxHandler.Instance.Speak(ChatBoxHandler.DialogTypes.Welcome);
        StartCoroutine(Player.Instance.Move());
        yield return null;
    }

    private void SelectMusic()
    {
        switch (Player.Instance.currentClass)
        {
            case CurrentClass.classes.Warrior:
                AudioManager.Instance.PlayMusic(AudioManager.Instance.warriorThemeMusic);
                break;
            case CurrentClass.classes.Ronin:
                AudioManager.Instance.PlayMusic(AudioManager.Instance.roninThemeMusic);
                break;
            case CurrentClass.classes.Gunslinger:
                AudioManager.Instance.PlayMusic(AudioManager.Instance.gunslingerThemeMusic);
                break;
            case CurrentClass.classes.Technomancer:
                break;
            case CurrentClass.classes.Warlock:
                AudioManager.Instance.PlayMusic(AudioManager.Instance.warlockThemeMusic);
                break;
            case CurrentClass.classes.Healer:
                break;
        }
    }

    private void AddSkills()
    {
        switch (Player.Instance.currentClass)
        {
            case CurrentClass.classes.Warrior:
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Pierce"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Whirlwind Slash"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Seismic Dive"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Strengthen"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Critical Hit"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Inspire"]);
                Player.Instance.defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Counter"]);
                Player.Instance.effectSkills.Add(EffectSkillsDictionary.Instance.effectSkillsDictionary["Disarm"]);
                Player.Instance.reactionSkills.Add(ReactionSkillsDictionary.Instance.reactionSkillsDictionary["Last Breath"]);
                Player.Instance.reactionSkills.Add(ReactionSkillsDictionary.Instance.reactionSkillsDictionary["Berserk"]);
                break;
            case CurrentClass.classes.Ronin:
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Skillful"]);
                Player.Instance.defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Shadow Retreat"]);
                Player.Instance.defenseSkills.Add(DefenseSkillsDictionary.Instance.defenseSkillsDictionary["Side Step"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Double Slash"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Triple Slash"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Eclipse Rush"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Assassinate"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Karma"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Pickpocket"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Bandage"]);
                break;
            case CurrentClass.classes.Gunslinger:
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Distanced Advantage"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Bullseye"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Accuracy"]);
                Player.Instance.buffSkills.Add(BuffSkillsDictionary.Instance.buffSkillsDictionary["Gunman's Instinct"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Rebound"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Suppressive Fire"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Dynamite"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Rifle"]);
                Player.Instance.effectSkills.Add(EffectSkillsDictionary.Instance.effectSkillsDictionary["Bleeding Shot"]);
                Player.Instance.effectSkills.Add(EffectSkillsDictionary.Instance.effectSkillsDictionary["Crippling Shot"]);
                break;
            case CurrentClass.classes.Technomancer:
                break;
            case CurrentClass.classes.Warlock:
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Hydra's Rush"]);
                Player.Instance.damageSkills.Add(DamageSkillsDictionary.Instance.damageSkillsDictionary["Satan's Wrath"]);
                Player.Instance.summonSkills.Add(SummonSkillsDictionary.Instance.summonSkillsDictionary["Summon Bat"]);
                Player.Instance.summonSkills.Add(SummonSkillsDictionary.Instance.summonSkillsDictionary["Summon Skull"]);
                Player.Instance.summonSkills.Add(SummonSkillsDictionary.Instance.summonSkillsDictionary["Summon Golem"]);
                Player.Instance.summonSkills.Add(SummonSkillsDictionary.Instance.summonSkillsDictionary["Summon Demon"]);
                break;
            case CurrentClass.classes.Healer:
                break;
        }
    }

    private IEnumerator SetPlayerStats(GameObject character)
    {
        Class characterStats = character.GetComponent<Class>();
        Player.Instance.character = characterStats;
        Player.Instance.hasReturnToIdle = characterStats.classAnimData.hasReturnToIdle;
        Player.Instance.currentClass = characterStats.classData.curClass;

        Player.Instance.vitality = characterStats.classData.vitality;
        Player.Instance.strength = characterStats.classData.strength;
        Player.Instance.finesse = characterStats.classData.finesse;
        Player.Instance.recovery = characterStats.classData.recovery;
        Player.Instance.greed = characterStats.classData.greed;

        Player.Instance.maxHitPoints = characterStats.classData.vitality * (int)Balancing.vitalityMod;
        Player.Instance.curHitPoints = Player.Instance.maxHitPoints;
        Player.Instance.diceAmount = characterStats.classData.dice;
        Player.Instance.looting = characterStats.classData.greed * (int)Balancing.greedGoldMod;
        Player.Instance.healing = characterStats.classData.recovery * (int)Balancing.recoveryMod;
        Player.Instance.level = 1;
        Player.Instance.experience = 0;
        Player.Instance.soulsCurrency = 0;

        StatsMenu.Instance.UpdatePoints();
        StatsMenu.Instance.UpdateStats();
        StatsMenu.Instance.UpdateDamageRanges();

        yield return new WaitForSeconds(1.9f);
        for (int i = 0; i < Player.Instance.diceAmount; i++)
        {
            Player.Instance.AddDice(false, true, 0);
        }

        yield return null;
    }
}

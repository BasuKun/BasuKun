using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public GameObject blackScreenCanvas;
    public Image blackScreen;
    public IntroData data = new IntroData();
    
    void Start()
    {
        SetData();
        SaveManager.OnSavedGame += Save;
    }

    void Update()
    {
        if (GameManager.Instance.GMData.snowflakesAmount > 0 && !data.hasCollectedFirstSnowflake)
        {
            Unlocks.Instance.currenciesContainer.gameObject.SetActive(true);
            Logs.Instance.AddLog("Seems you can collect those snowflakes. You wonder what use could it have.", Color.white, true);

            data.hasCollectedFirstSnowflake = true;
        }

        if (GameManager.Instance.GMData.snowflakesAmount >= 5 && !data.hasWatchedIntro)
        {
            Unlocks.Instance.shopContainer.gameObject.SetActive(true);
            Unlocks.Instance.absorbSnowflakesButton.gameObject.SetActive(true);
            Unlocks.Instance.LogsTab.gameObject.SetActive(true);
            Unlocks.Instance.SettingsTab.gameObject.SetActive(true);

            Logs.Instance.AddLog("You can definitely power yourself up in some various ways using those Snowflakes. Maybe this will help you get back your memories in the process?", Color.white, true);
            Logs.Instance.AddLog("(Hover on buttons for tooltips. This can be useful to learn more about the mechanics and whatnots.)", Color.grey, false);

            data.hasWatchedIntro = true;
            Save();
            this.gameObject.SetActive(false);
        }
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("Intro"))
        {
            data.completedStartStory = false;
            data.hasWatchedIntro = false;
            data.hasCollectedFirstSnowflake = false;
            blackScreenCanvas.SetActive(true);
            Unlocks.Instance.shopContainer.gameObject.SetActive(false);
            Unlocks.Instance.logsContainer.gameObject.SetActive(false);
            Unlocks.Instance.currenciesContainer.gameObject.SetActive(false);
            Unlocks.Instance.absorbSnowflakesButton.gameObject.SetActive(false);
            Unlocks.Instance.LogsTab.gameObject.SetActive(false);
            Unlocks.Instance.SettingsTab.gameObject.SetActive(false);
            Unlocks.Instance.logsTabX.gameObject.SetActive(false);
            StartCoroutine(FadeIn());
        }
        else
        {
            string jData = PlayerPrefs.GetString("Intro");
            data = JsonUtility.FromJson<IntroData>(jData);

            blackScreenCanvas.SetActive(false);
            Unlocks.Instance.snowflakeSpawner.SetActive(true);

            data.hasWatchedIntro = true;
            Save();
            this.gameObject.SetActive(false);
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("Intro", jData);
    }

    public IEnumerator FadeIn()
    {
        Color blackScreenColor = blackScreen.color;
        float fadeAmount;

        yield return new WaitForSeconds(1.5f);

        while (blackScreen.color.a > 0)
        {
            fadeAmount = blackScreenColor.a - (0.2f * Time.deltaTime);

            blackScreenColor = new Color(blackScreenColor.r, blackScreenColor.g, blackScreenColor.b, fadeAmount);
            blackScreen.color = blackScreenColor;
            
            yield return null;
        }

        blackScreenCanvas.SetActive(false);
        StartCoroutine(StartStory());
        yield return null;
    }

    public IEnumerator StartStory()
    {
        Unlocks.Instance.logsContainer.gameObject.SetActive(true);

        Logs.Instance.AddLog("... You wake up in a cold, empty valley.", Color.white, true);
        yield return new WaitForSeconds(4f);
        Logs.Instance.AddLog("Twinkling stars high in the sky are shining upon the snowy ground and mountains around you. You find the scenery beautiful.", Color.white, true);
        yield return new WaitForSeconds(6f);
        Logs.Instance.AddLog("Why were you sleeping there, you wonder. You try to think but cannot remember anything prior to waking up.", Color.white, true);
        yield return new WaitForSeconds(4f);
        Unlocks.Instance.snowflakeSpawner.SetActive(true);
        yield return new WaitForSeconds(4f);
        Logs.Instance.AddLog("Oh? It's snowing.", Color.white, true);
        Logs.Instance.AddLog("(Collect snowflakes by hovering your cursor over it.)", Color.grey, false);
        yield return new WaitForSeconds(1.5f);

        Unlocks.Instance.logsTabX.gameObject.SetActive(true);
        data.completedStartStory = true;

        yield return null;
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct IntroData
{
    public bool hasWatchedIntro;
    public bool hasCollectedFirstSnowflake;
    public bool completedStartStory;
}

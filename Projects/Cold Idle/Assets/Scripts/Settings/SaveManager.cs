using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    public int saveTimer = 10;
    public float currentTimer;
    public Slider saveSlider;
    public TextMeshProUGUI saveTimerText;

    public delegate void SavedGame();
    public static event SavedGame OnSavedGame;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        currentTimer = saveTimer;
    }

    void Update()
    {
        currentTimer -= Time.deltaTime;
        if (currentTimer < 0)
        {
            Save();
            currentTimer = saveTimer;
        }
    }

    public void Save()
    {
        if (OnSavedGame != null) OnSavedGame();

        string data = JsonUtility.ToJson(GameManager.Instance.GMData);
        PlayerPrefs.SetString("GameManager", data);
        PlayerPrefs.Save();
    }

    public void UpdateFrequency()
    {
        saveTimer = (int)saveSlider.value;
        saveTimerText.text = saveSlider.value + "s";
    }
}

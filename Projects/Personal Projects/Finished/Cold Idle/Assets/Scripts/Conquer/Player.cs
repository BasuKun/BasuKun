using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float currentHP;
    public Slider hpBar;
    public GameObject playerObject;
    public Image appearance;

    public static Player Instance;
    public PlyrData data = new PlyrData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        SetData();
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("PlayerStats"))
        {
            data.hitPoints = 100;
            data.attack = 10;
            data.defense = 10;
            data.healing = 10;
            data.wonContinents = 0;
            data.currentUniverse = 1;
        }
        else
        {
            string jData = PlayerPrefs.GetString("PlayerStats");
            data = JsonUtility.FromJson<PlyrData>(jData);

            if (data.currentUniverse > 1)
            {
                LocationSelection.Instance.currentUniverseText.gameObject.SetActive(true);
                GameUI.Instance.currentUniverseUpdateText();
            }
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("PlayerStats", jData);
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct PlyrData
{
    public float hitPoints;
    public float attack;
    public float defense;
    public float healing;
    public int wonContinents;
    public int currentUniverse;
}
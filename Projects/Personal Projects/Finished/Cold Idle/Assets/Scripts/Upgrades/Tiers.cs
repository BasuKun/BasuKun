using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiers : MonoBehaviour
{
    public List<GameObject> tiers = new List<GameObject>();
    public TierData data = new TierData();

    public static Tiers Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        SetData();
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("tiers"))
        {
            data.hasTierOne = false;
            data.hasTierTwo = false;
            data.hasTierThree = false;
            data.hasTierFour = false;
            data.hasTierOne = false;
        }
        else
        {
            string jData = PlayerPrefs.GetString("tiers");
            data = JsonUtility.FromJson<TierData>(jData);

            tiers[0].SetActive(data.hasTierOne);
            tiers[1].SetActive(data.hasTierTwo);
            tiers[2].SetActive(data.hasTierThree);
            tiers[3].SetActive(data.hasTierFour);
            tiers[4].SetActive(data.hasTierFive);
        }
    }

    public void Save()
    {
        data.hasTierOne = tiers[0].activeSelf;
        data.hasTierTwo = tiers[1].activeSelf;
        data.hasTierThree = tiers[2].activeSelf;
        data.hasTierFour = tiers[3].activeSelf;
        data.hasTierOne = tiers[4].activeSelf;

        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("tiers", jData);
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct TierData
{ 
    public bool hasTierOne;
    public bool hasTierTwo;
    public bool hasTierThree;
    public bool hasTierFour;
    public bool hasTierFive;
}
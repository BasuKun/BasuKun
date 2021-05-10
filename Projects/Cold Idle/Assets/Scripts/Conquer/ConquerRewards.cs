using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ConquerRewards : MonoBehaviour
{
    public TextMeshProUGUI sfRewardText;
    public TextMeshProUGUI ibRewardText;
    public TextMeshProUGUI ipRewardText;
    public TextMeshProUGUI bpRewardText;
    public TextMeshProUGUI habitatRewardText;

    public static ConquerRewards Instance;
    public RwrdData data = new RwrdData();

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
        if (!PlayerPrefs.HasKey("ConquerRewards"))
        {
            data.sfReward = 1;
            data.ibReward = 1;
            data.ipReward = 1;
            data.bpReward = 1;
            data.habitatReward = 0;
}
        else
        {
            string jData = PlayerPrefs.GetString("ConquerRewards");
            data = JsonUtility.FromJson<RwrdData>(jData);

            if (data.sfReward != 1)
            {
                sfRewardText.gameObject.SetActive(true);
                GameUI.Instance.conquerSFRewardUpdateText();
            }
            if (data.ibReward != 1)
            {
                ibRewardText.gameObject.SetActive(true);
                GameUI.Instance.conquerIBRewardUpdateText();
            }
            if (data.ipReward != 1)
            {
                ipRewardText.gameObject.SetActive(true);
                GameUI.Instance.conquerIPRewardUpdateText();
            }
            if (data.bpReward != 1)
            {
                bpRewardText.gameObject.SetActive(true);
                GameUI.Instance.conquerBPRewardUpdateText();
            }
            if (data.habitatReward != 0)
            {
                habitatRewardText.gameObject.SetActive(true);
                GameUI.Instance.conquerHabitatRewardUpdateText();
            }
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("ConquerRewards", jData);
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct RwrdData
{
    public float sfReward;
    public float ibReward;
    public float ipReward;
    public float bpReward;
    public float habitatReward;
}

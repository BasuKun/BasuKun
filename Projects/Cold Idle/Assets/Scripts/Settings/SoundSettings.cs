using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SoundSettings : MonoBehaviour
{
    public Slider sfxSlider;
    public Slider musicSlider;
    public TextMeshProUGUI sfxText;
    public TextMeshProUGUI musicText;

    public SndData data = new SndData();

    public static SoundSettings Instance;

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
        if (!PlayerPrefs.HasKey("Sound"))
        {
            data.sfxVolume = 0.5f;
            data.musicVolume = 0.5f;
        }
        else
        {
            string jData = PlayerPrefs.GetString("Sound");
            data = JsonUtility.FromJson<SndData>(jData);

            sfxSlider.value = data.sfxVolume;
            musicSlider.value = data.musicVolume;
            UpdateSFXVoume();
            UpdateMusicVoume();
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("Sound", jData);
    }

    public void UpdateSFXVoume()
    {
        data.sfxVolume = sfxSlider.value;
        AudioManager.Instance.ambSource.volume = data.sfxVolume;
        sfxText.text = (int)(sfxSlider.value * 100) + "%";
    }

    public void UpdateMusicVoume()
    {
        data.musicVolume = musicSlider.value;
        AudioManager.Instance.musicSource.volume = data.musicVolume;
        musicText.text = (int)(musicSlider.value * 100) + "%";
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct SndData
{
    public float sfxVolume;
    public float musicVolume;
}

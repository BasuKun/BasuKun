using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public List<Button> musicButtons = new List<Button>();
    public List<GameObject> unlockedMusics = new List<GameObject>();
    public List<AudioClip> tracks = new List<AudioClip>();

    public MusData data = new MusData();

    public static MusicManager Instance;

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
        if (!PlayerPrefs.HasKey("Music"))
        {
            data.currentTrack = 0;
            data.unlockedAmount = 0;
        }
        else
        {
            string jData = PlayerPrefs.GetString("Music");
            data = JsonUtility.FromJson<MusData>(jData);

            for (int i = 1; i <= data.unlockedAmount; i++)
            {
                musicButtons[i].interactable = true;
                unlockedMusics[i].SetActive(true);
            }

            AudioManager.Instance.PlayMusic(tracks[data.currentTrack]);
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("Music", jData);
    }

    public void SelectTrack(int index)
    {
        if (data.currentTrack != index)
        {
            AudioManager.Instance.PlayMusic(tracks[index]);
            data.currentTrack = index;
        }
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }
}

[Serializable]
public struct MusData
{
    public int currentTrack;
    public int unlockedAmount;
}

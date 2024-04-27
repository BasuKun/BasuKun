using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip warriorThemeMusic;
    public AudioClip gunslingerThemeMusic;
    public AudioClip warlockThemeMusic;
    public AudioClip roninThemeMusic;
    public AudioSource musicSource;

    public static AudioManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayMusic(AudioClip music)
    {
        musicSource.clip = music;
        musicSource.Play();
    }
}

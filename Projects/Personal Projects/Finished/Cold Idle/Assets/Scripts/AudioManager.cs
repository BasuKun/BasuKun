using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("SFX")]
    public List<AudioClip> snowpileShovelRealSFX = new List<AudioClip>();
    public List<AudioClip> snowflakeCollectRealSFX = new List<AudioClip>();
    public AudioClip popSFX;
    public AudioClip clickSFX;
    public AudioClip buySFX;
    public AudioClip logsWriteSFX;
    public AudioClip absorbLoopSFX;
    public AudioClip absorbHitSFX;
    public AudioClip blessingUnlockSFX;

    [Header("Audio Sources")]
    public AudioSource musicSource;
    public AudioSource ambSource;
    public AudioSource sfxSource;
    public AudioSource popSfxSource;
    public AudioSource sfxLoopSource;
    public AudioSource raisingPitchSource;
    public AudioSource noPitchPlayer;
    public AudioSource UIPlayer;

    public static AudioManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlaySound(AudioClip sfx, float minPitch, float maxPitch)
    {
        sfxSource.pitch = UnityEngine.Random.Range(minPitch, maxPitch);
        sfxSource.PlayOneShot(sfx, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayPopSound(AudioClip sfx, float minPitch, float maxPitch)
    {
        popSfxSource.pitch = UnityEngine.Random.Range(minPitch, maxPitch);
        popSfxSource.PlayOneShot(sfx, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayRaisingSound(AudioClip sfx, float pitch)
    {
        raisingPitchSource.pitch = pitch;
        raisingPitchSource.PlayOneShot(sfx, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayNoPitchSound(AudioClip sfx)
    {
        noPitchPlayer.PlayOneShot(sfx, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayUIClick()
    {
        UIPlayer.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
        UIPlayer.PlayOneShot(clickSFX, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayBuyClick()
    {
        UIPlayer.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
        UIPlayer.PlayOneShot(buySFX, SoundSettings.Instance.data.sfxVolume);
    }

    public void PlayMusic(AudioClip track)
    {
        musicSource.Stop();
        musicSource.clip = track;
        musicSource.Play();
    }

    public IEnumerator FadeIn(AudioClip sfx, float fadingTime, Func<float, float, float, float> Interpolate)
    {
        sfxLoopSource.clip = sfx;
        sfxLoopSource.Stop();
        sfxLoopSource.volume = 0;
        sfxLoopSource.Play();

        float resultVolume = SoundSettings.Instance.data.sfxVolume;
        float frameCount = fadingTime / Time.deltaTime;
        float framesPassed = 0;

        while (framesPassed <= frameCount)
        {
            var t = framesPassed++ / frameCount;
            sfxLoopSource.volume = Interpolate(0, resultVolume, t);
            yield return null;
        }

        sfxLoopSource.volume = resultVolume;
    }
    public IEnumerator FadeOut(float fadingTime, Func<float, float, float, float> Interpolate)
    {
        float startVolume = sfxLoopSource.volume;
        float frameCount = fadingTime / Time.deltaTime;
        float framesPassed = 0;

        while (framesPassed <= frameCount)
        {
            var t = framesPassed++ / frameCount;
            sfxLoopSource.volume = Interpolate(startVolume, 0, t);
            yield return null;
        }

        sfxLoopSource.volume = 0;
        sfxLoopSource.Stop();
    }
}

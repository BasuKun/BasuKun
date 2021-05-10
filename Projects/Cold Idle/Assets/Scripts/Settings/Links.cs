using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Links : MonoBehaviour
{
    public void OpenSubredditLink()
    {
        Application.OpenURL("https://fr.reddit.com/r/AColdNight/");
    }

    public void OpenDiscordLink()
    {
        Application.OpenURL("https://discord.gg/sRxNWREtTU");
    }

    public void OpenMusicLink()
    {
        Application.OpenURL("https://www.youtube.com/channel/UChZE0-0R__Z5JtyImRGpDmw");
    }
}

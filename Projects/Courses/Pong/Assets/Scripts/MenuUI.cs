using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public void OnPlayAIButton()
    {
        ModeSelection.instance.modeSelected = "PVE";
        SceneManager.LoadScene(1);
    }

    public void OnPlayMultiplayerButton()
    {
        ModeSelection.instance.modeSelected = "PVP";
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}

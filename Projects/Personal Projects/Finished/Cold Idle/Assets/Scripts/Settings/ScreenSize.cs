using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{
    public int multiplier = 1;
    public static ScreenSize Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeScreenSize(int param)
    {
        multiplier = param;

        switch (param)
        {
            case 1:
                Screen.SetResolution(1280, 720, false);
                break;
            case 2:
                Screen.SetResolution(2560, 1440, false);
                break;
            case 3:
                Screen.SetResolution(3840, 2160, false);
                break;
            default:
                break;
        }
    }
}

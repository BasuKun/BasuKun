﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ShovelersButtons : MonoBehaviour
{
    public Button button;
    public bool isLeft;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (isLeft ? GameManager.Instance.shovelersAmount > 0 : GameManager.Instance.idlePopulationAmount > 0)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}

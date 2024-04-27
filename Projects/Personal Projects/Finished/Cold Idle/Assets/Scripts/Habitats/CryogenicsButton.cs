using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CryogenicsButton : MonoBehaviour
{
    public Button button;
    public bool isLeft;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (isLeft ? GameManager.Instance.GMData.cryogenicsAmount > 0 : GameManager.Instance.GMData.idlePopulationAmount > 0)
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }
}

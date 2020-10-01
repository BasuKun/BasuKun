using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreHabitatButton : MonoBehaviour
{
    public Button button;

    void Start()
    {
        button.interactable = false;
    }

    void Update()
    {
        if (GameManager.Instance.iceBlocksAmount >= Shop.Instance.moreHabitatCost && !button.interactable)
        {
            button.interactable = true;
        }
        else if (GameManager.Instance.iceBlocksAmount < Shop.Instance.moreHabitatCost && button.interactable)
        {
            button.interactable = false;
        }
    }
}

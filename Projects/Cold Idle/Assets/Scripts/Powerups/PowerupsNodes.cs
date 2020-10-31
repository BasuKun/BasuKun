using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupsNodes : MonoBehaviour
{
    public Button[] nodesArray = new Button[5];
    public Image[] nodesImageArray = new Image[5];
    public PowerupsButton powerup;
    public Sprite availableNode;
    public Sprite boughtNode;

    public delegate void BPSpent();
    public static event BPSpent OnBPSpent;

    void Start()
    {
        Habitats.OnBPObtained += CheckForAvailability;
        OnBPSpent += CheckForAvailability;
        AssignImages();
        CheckForAvailability();
    }

    public void AssignImages()
    {
        for (int i = 0; i < nodesArray.Length; i++)
        {
            nodesImageArray[i].sprite = i >= powerup.level ? availableNode : boughtNode;
        }
    }

    public void CheckForAvailability()
    {
        for (int i = 0; i < nodesArray.Length; i++)
        {
            nodesArray[i].interactable = false;

            if (i < powerup.level)
            {
                var disabledColors = nodesArray[i].colors;
                disabledColors.disabledColor = Color.white;
                nodesArray[i].colors = disabledColors;
            }
        }

        if (powerup.level < nodesArray.Length)
        {
            nodesArray[powerup.level].interactable = GameManager.Instance.blessingPointsAmount > powerup.level ? true : false;
        }
    }

    public void BuyNode()
    {
        powerup.level++;
        GameManager.Instance.blessingPointsAmount -= powerup.level;
        GameUI.Instance.BlessingPointsUpdateText();
        AssignImages();

        if (OnBPSpent != null)
        {
            OnBPSpent();
        }
        powerup.gameObject.GetComponent<OnMouseOverHandler>().RefreshText();
    }
}

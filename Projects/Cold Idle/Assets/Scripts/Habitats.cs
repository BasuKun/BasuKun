using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habitats : MonoBehaviour
{
    public ShovelButton ShovelButton;
    public float autoShovelInterval = 5f;

    void Update()
    {
        if (GameManager.Instance.shovelersAmount > 0)
        {
            autoShovelInterval -= Time.deltaTime + GameManager.Instance.autoShovelSpeed;

            if (autoShovelInterval <= 0 && PileHandler.Instance.pileDict.Count > 0)
            {
                autoShovelInterval = 5f;
                ShovelButton.ShovelSnow();
            }
        }
        if (PileHandler.Instance.pileDict.Count <= 0 && autoShovelInterval != 5f)
        {
            autoShovelInterval = 5f;
        }
    }

    public void AddOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount--;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount++;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 1000f);
                GameUI.Instance.shovelersUpdateText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }

    public void RemoveOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount++;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount--;
                GameManager.Instance.autoShovelSpeed = (float)(GameManager.Instance.shovelersAmount / 1000f);
                GameUI.Instance.shovelersUpdateText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }
}

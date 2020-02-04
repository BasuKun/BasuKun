using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habitats : MonoBehaviour
{
    public void AddOccupation(string occupation)
    {
        GameManager.Instance.idlePopulationAmount--;

        switch (occupation)
        {
            case "shoveler":
                GameManager.Instance.shovelersAmount++;
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
                GameUI.Instance.shovelersUpdateText();
                break;
        }
        GameUI.Instance.idlePopulationUpdateText();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MonoBehaviour
{
    public GameObject button;

    public void SaveFile()
    {
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();
        SaveManager.Instance.Save();
        GameManager.Instance.textPopout(Camera.main.ScreenToWorldPoint(button.transform.position), "Saved!", Color.white);
    }
}

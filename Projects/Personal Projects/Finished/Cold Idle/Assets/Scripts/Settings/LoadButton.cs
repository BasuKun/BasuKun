using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour
{
    public void LoadFile()
    {
        this.gameObject.GetComponent<OnMouseOverHandler>().DespawnPopup();
        SceneManager.LoadScene(0);
    }
}

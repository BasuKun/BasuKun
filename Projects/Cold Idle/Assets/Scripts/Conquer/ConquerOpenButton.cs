using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConquerOpenButton : MonoBehaviour
{
    private float valueToAdd = -1000f;
    public bool isOpened;
    public GameObject conquerMenu;

    public void OnClick()
    {
        float y = isOpened ? valueToAdd : -valueToAdd;
        conquerMenu.transform.position = new Vector2(conquerMenu.transform.position.x, conquerMenu.transform.position.y + y);
        isOpened = !isOpened;
    }
}

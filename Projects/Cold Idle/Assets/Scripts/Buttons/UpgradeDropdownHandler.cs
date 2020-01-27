using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeDropdownHandler : MonoBehaviour
{
    public TextMeshProUGUI expandButtonText;
    private bool isOpened = true;

    public void ExpandUpgradeButton()
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
        expandButtonText.text = isOpened ? ">>" : "<<";
        isOpened = !isOpened;
    }
}

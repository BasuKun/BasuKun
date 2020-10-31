using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeDropdownHandler : MonoBehaviour
{
    public TextMeshProUGUI expandButtonText;
    public bool isOpened = true;

    public void ExpandUpgradeButton()
    {
        transform.position = new Vector2(-transform.position.x, transform.position.y);
        expandButtonText.text = isOpened ? ">>" : "<<";
        isOpened = !isOpened;
    }

    public void ExpandLogsButton()
    {
        RectTransform rect = this.gameObject.GetComponent<RectTransform>();
        float size = isOpened ? rect.rect.width : -rect.rect.width;
        transform.position = new Vector2(transform.position.x + size, transform.position.y);
        expandButtonText.text = isOpened ? "<<" : ">>";
        isOpened = !isOpened;
    }
}

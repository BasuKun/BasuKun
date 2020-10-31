using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogsOpacityController : MonoBehaviour
{
    private Image image;
    private TextMeshProUGUI text;

    void Start()
    {
        GetPanelColor();
        GetTextColor();
        StartCoroutine("PanelFadeIn");
        StartCoroutine("TextFadeIn");
    }

    private void GetPanelColor()
    {
        image = GetComponent<Image>();
        Color color = image.color;
        color.a = 0f;
        image.color = color;
    }

    private void GetTextColor()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        Color color = text.color;
        color.a = 0f;
        text.color = color;
    }

    IEnumerator PanelFadeIn()
    {
        for (float i = 0f; i < 0.235f; i += 0.02f)
        {
            Color color = image.color;
            color.a = i;
            image.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }

    IEnumerator TextFadeIn()
    {
        for (float i = 0f; i < 1f; i += 0.05f)
        {
            Color color = text.color;
            color.a = i;
            text.color = color;
            yield return new WaitForSeconds(0.05f);
        }
    }
}

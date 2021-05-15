using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogsOpacityController : MonoBehaviour
{
    public Button settingsButton;
    public Button logsButton;
    private Image image;
    public Image newTag;
    private TextMeshProUGUI text;
    public bool hasFadedIn = false;
    public bool hasFadedBackOut = false;

    void Start()
    {
        settingsButton = Unlocks.Instance.SettingsTab.GetComponent<Button>();
        logsButton = Unlocks.Instance.LogsTab.GetComponent<Button>();
        GetPanelColor();
        GetTextColor();
        StartCoroutine("PanelFadeIn");
        StartCoroutine("TextFadeIn");
    }

    void Update()
    {
        if (!hasFadedBackOut)
        {
            if (hasFadedIn && !logsButton.interactable && Unlocks.Instance.logsContainer.isOpened)
            {
                StartCoroutine("PanelFadeOut");
                StartCoroutine("NewTagFadeOut");
            }
        }
    }

    private void GetPanelColor()
    {
        image = GetComponent<Image>();
        Color color = image.color;
        color.a = 0f;
        image.color = color;

        Color newTagColor = newTag.color;
        newTagColor.a = 0f;
        newTag.color = newTagColor;

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
        settingsButton.interactable = false;

        for (float i = 0f; i < 0.435f; i += 0.02f)
        {
            Color color = image.color;
            color.a = i;
            image.color = color;

            Color newTagColor = newTag.color;
            newTagColor.a = i * 2;
            newTag.color = newTagColor;

            yield return new WaitForSeconds(0.05f);
        }

        hasFadedIn = true;
        yield return null;
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
        yield return null;
    }

    IEnumerator NewTagFadeOut()
    {
        hasFadedBackOut = true;
        yield return new WaitForSeconds(4f);

        for (float i = 0.870f; i >= -0.04f; i -= 0.04f)
        {
            Color newTagColor = newTag.color;
            newTagColor.a = i;
            newTag.color = newTagColor;

            yield return new WaitForSeconds(0.05f);
        }

        settingsButton.interactable = true;
        yield return null;
    }

    IEnumerator PanelFadeOut()
    {
        yield return new WaitForSeconds(4f);

        for (float i = 0.435f; i > 0.235f; i -= 0.01f)
        {
            Color color = image.color;
            color.a = i;
            image.color = color;

            yield return new WaitForSeconds(0.05f);
        }

        yield return null;
    }
}

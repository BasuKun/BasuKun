using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrencyGainPopout : MonoBehaviour
{
    private float fadeoutCooldown = 0.75f;
    private float fadeoutSpeed = 0.03f;

    private RectTransform rt;
    public TextMeshProUGUI text;

    void Awake()
    {
        rt = this.GetComponent<RectTransform>();
        StartCoroutine("FadeOut");
    }

    void Update()
    {
        if (text.color.a <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void FixedUpdate()
    {
        FloatUp();
    }

    public void UpdateText(char sign, double value, string currency, Color color)
    {
        text.color = color;
        text.text = sign + GameUI.Instance.CurrencyLetterFormatting(value) + " " + currency;
    }

    public void UpdateTextNoDigit(string info, Color color)
    {
        text.color = color;
        text.text = info;
    }

    void FloatUp()
    {
        rt.localPosition += new Vector3(0, 0.5f, 0);
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(fadeoutCooldown);
        while (text.color.a > 0)
        {
            text.color -= new Color(0, 0, 0, fadeoutSpeed);
            yield return new WaitForFixedUpdate();
        } 
    }
}

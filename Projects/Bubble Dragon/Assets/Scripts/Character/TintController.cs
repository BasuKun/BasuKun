using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintController : MonoBehaviour
{
    public float tintAmount;
    public Material tintMat;
    private float blinkSpeed = 6f;

    [ColorUsageAttribute(true, true)] public Color tintColor;
    [ColorUsageAttribute(true, true)] public Color tintColorCharged;

    void Update()
    {
        tintAmount = Mathf.Lerp(tintAmount, 0, Time.deltaTime * blinkSpeed);
        tintAmount = Mathf.Clamp(tintAmount, 0, 1);
        tintMat.SetFloat("_TintAmount", tintAmount);
    }

    public void Blink(float intensity)
    {
        blinkSpeed = 6f;
        tintMat.SetColor("_TintColor", tintColor);
        tintAmount += 0.01f * intensity;
    }

    public void BlinkCharged()
    {
        tintMat.SetColor("_TintColorCharged", tintColor);
        blinkSpeed = 5f;
        tintAmount += 1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ColorGradingChanger : MonoBehaviour
{
    public static ColorGradingChanger Instance;
    public Volume volume;
    private LiftGammaGain colorGrading;
    public Color soulsColor;
    public Color shaftLightColor;
    public Color shaftLightColor2;
    public List<LightColorChanger> shaftLights = new List<LightColorChanger>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeColor(int currentSelected)
    {
        volume.profile.TryGet(out colorGrading);
        colorGrading.gamma.Override(ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].gamma);

        shaftLightColor = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].lightShaftColor;
        shaftLightColor2 = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].lightShaftColor2;
        foreach (var lights in shaftLights)
		{
            lights.lightShaft.color = shaftLightColor;
            lights.lightShaft2.color = shaftLightColor2;
		}

        soulsColor = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].soulsColor;
		foreach (var soul in Player.Instance.souls)
            soul.gameObject.GetComponent<SpriteRenderer>().color = soulsColor;
    }
}

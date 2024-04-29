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
    public List<SpriteRenderer> backgroundFilters = new List<SpriteRenderer>();

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
        colorGrading.gamma.Override(ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].classGraphicsData.gamma);

        shaftLightColor = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].classGraphicsData.lightShaftColor;
        shaftLightColor2 = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].classGraphicsData.lightShaftColor2;
        foreach (var lights in shaftLights)
		{
            lights.lightShaft.color = shaftLightColor;
            lights.lightShaft2.color = shaftLightColor2;
		}

        foreach (var filter in backgroundFilters)
        {
            filter.color = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].classGraphicsData.backgroundFilterColor;
        }

        soulsColor = ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].classGraphicsData.soulsColor;
		foreach (var soul in Player.Instance.souls)
            soul.gameObject.GetComponent<SpriteRenderer>().color = soulsColor;
    }
}

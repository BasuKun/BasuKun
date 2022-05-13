using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ColorGradingChanger : MonoBehaviour
{
    public static ColorGradingChanger Instance;
    public PostProcessVolume volume;
    public ColorGrading colorGrading;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeColor(int currentSelected)
    {
        volume = this.gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGrading);
        colorGrading.gamma.Override(ClassesObjects.Instance.characters[(CurrentClass.classes)currentSelected].gamma);
    }
}

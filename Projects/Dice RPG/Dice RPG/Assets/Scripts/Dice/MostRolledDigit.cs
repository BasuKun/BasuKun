using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostRolledDigit : MonoBehaviour
{
    public Image appearance;
    public List<Sprite> sides = new List<Sprite>();

    public void UpdateAppearance(int digit)
    {
        appearance.sprite = sides[digit];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public double hitPoints;
    public double currentHP;
    public double attack;
    public Slider hpBar;

    public Image appearance;
    public List<Sprite> possibleAppearances = new List<Sprite>();
}

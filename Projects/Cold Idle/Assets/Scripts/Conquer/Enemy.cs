using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int hitPoints;
    public int currentHP;
    public int attack;
    public Slider hpBar;

    public Image appearance;
    public List<Sprite> possibleAppearances = new List<Sprite>();
}

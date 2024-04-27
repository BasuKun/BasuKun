using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsGenerator : MonoBehaviour
{
    public SpriteRenderer prop;
    public List<Sprite> props = new List<Sprite>();

    private void Start()
    {
        GenerateSprite();
    }

    public void GenerateSprite()
    {
        prop.sprite = props[Random.Range(0, props.Count)];
        prop.flipX = Random.value > 0.5f;
    }
}

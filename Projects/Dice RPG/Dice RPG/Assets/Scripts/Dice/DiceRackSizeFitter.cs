using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRackSizeFitter : MonoBehaviour
{
    private int diceAmount;
    private List<Dice> dicesTotal = new List<Dice>();

    public void ResizeRack(List<Dice> permDices)
    {
        dicesTotal.Clear();
        foreach (var dice in permDices) dicesTotal.Add(dice);
        diceAmount = dicesTotal.Count;

        int dicePerLine = 5 + (diceAmount / 10);
        float scale = 1f * (1f - (Mathf.Max(0, dicePerLine - 5) / 5f));
        float offset = 0.3f * scale;

        for (int y = 0; y < dicePerLine; y++)
        {
            for (int x = 0 + (y * dicePerLine); x < diceAmount; x++)
            {
                dicesTotal[x].gameObject.transform.position = new Vector3(-0.5f + (offset * (x - (y * dicePerLine))), -0.8f - (offset / 1.5f * y), 0f);
                dicesTotal[x].gameObject.transform.localScale = new Vector3(scale, scale, 1f);
                dicesTotal[x].gameObject.GetComponent<SpriteRenderer>().sortingOrder = y - (x - (y * dicePerLine));
            }
        }
    }
}

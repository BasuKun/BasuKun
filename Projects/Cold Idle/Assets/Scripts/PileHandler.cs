using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileHandler : MonoBehaviour
{
    [Header("SPRITES")]
    public Sprite singlePile;
    public Sprite horizontalPile;
    public Sprite verticalPile;
    public Sprite leftSlopePile;
    public Sprite rightSlopePile;
    public Sprite fullPile;
    public Sprite fullPileLeft;
    public Sprite fullPileRight;

    public GameObject snowPile;
    public GameObject pileLimitArrow;
    public GameObject limitLineText;
    public Dictionary<Vector3, GameObject> pileDict = new Dictionary<Vector3, GameObject>();

    public AudioSource audioSource;
    public AudioClip shovelSFX;

    public static PileHandler Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        MovePileHeightLimitArrow();
    }

    public void AutoTile()
    {
        foreach (var tile in pileDict)
        {
            int value = 0;

            //checking left
            value += pileDict.ContainsKey(new Vector3(tile.Key.x - 0.25f, tile.Key.y, 0)) ? 1 : 0;
            //checking top
            value += pileDict.ContainsKey(new Vector3(tile.Key.x, tile.Key.y + 0.25f, 0)) ? 2 : 0;
            //checking right
            value += pileDict.ContainsKey(new Vector3(tile.Key.x + 0.25f, tile.Key.y, 0)) ? 4 : 0;
            //checking down
            value += pileDict.ContainsKey(new Vector3(tile.Key.x, tile.Key.y - 0.25f, 0)) ? 8 : 0;

            switch (value)
            {
                case 0:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = singlePile;
                    break;
                case 1:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = leftSlopePile;
                    break;
                case 2:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = verticalPile;
                    break;
                case 3:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPileLeft;
                    break;
                case 4:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = rightSlopePile;
                    break;
                case 5:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = horizontalPile;
                    break;
                case 6:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPileRight;
                    break;
                case 7: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPile;
                    break;
                case 8: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = singlePile;
                    break;
                case 9: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = leftSlopePile;
                    break;
                case 10: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = verticalPile;
                    break;
                case 11:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPileLeft;
                    break;
                case 12: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = rightSlopePile;
                    break;
                case 13: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = horizontalPile;
                    break;
                case 14:
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPileRight;
                    break;
                case 15: 
                    tile.Value.gameObject.GetComponent<SpriteRenderer>().sprite = fullPile;
                    break;
            }
        }
    }

    public void MovePileHeightLimitArrow()
    {
        pileLimitArrow.transform.position = Camera.main.WorldToScreenPoint(new Vector2(transform.position.x + 8.75f, GameManager.Instance.GMData.snowpileHeightLimit));
    }

    public void DisplayLimitLine()
    {
        limitLineText.SetActive(!limitLineText.activeSelf);
    }
}

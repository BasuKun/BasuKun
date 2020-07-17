using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isUsingMouse = true;
    public bool hasSpecialItem;
    public static GameManager instance;

    public List<Bubble> bubblesOptions = new List<Bubble>();
    public List<Bubble> bubblesInventory = new List<Bubble>();
    public List<Bubble> itemInventory = new List<Bubble>();

    public Sprite normalBubble;
    public Sprite spikedBubble;
    public Sprite key;
    public GameObject normalPrefab;
    public GameObject keyPrefab;
    public GameObject spikedPrefab;

    public int bubbleAmount = 3;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        GenerateBubblesList();
        RestartInventory();
    }

    void GenerateBubblesList()
    {
        bubblesOptions.Add(new Bubble(0, "normal", false, normalBubble, normalPrefab));
        bubblesOptions.Add(new Bubble(1, "key", true, key, keyPrefab));
        bubblesOptions.Add(new Bubble(2, "spiked", false, spikedBubble, spikedPrefab));
    }

    public void RestartInventory()
    {
        itemInventory.Clear();
        bubblesInventory.Clear();

        bubblesInventory.Add(bubblesOptions[0]);
        bubblesInventory.Add(bubblesOptions[0]);
        bubblesInventory.Add(bubblesOptions[2]);
        GameUI.instance.UpdateBubbleAmountUI();
    }
}

public class Bubble : MonoBehaviour
{
    public int index;
    public string type;
    public bool isSpecialItem;
    public Sprite appearance;
    public GameObject prefab;

    public Bubble(int index, string type, bool isSpecialItem, Sprite appearance, GameObject prefab)
    {
        this.index = index;
        this.type = type;
        this.isSpecialItem = isSpecialItem;
        this.appearance = appearance;
        this.prefab = prefab;
    }
}


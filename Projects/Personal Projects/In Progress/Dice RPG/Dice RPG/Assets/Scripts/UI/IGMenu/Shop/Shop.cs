using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public ShopItem[] Items;
    public List<ShopItemUI> ItemsInShop = new List<ShopItemUI>();
    public Transform ShopContainer;
    public GameObject ShopItemPrefab;

    public static Shop Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        foreach (ShopItem item in Items)
        {
            GameObject shopItem = Instantiate(ShopItemPrefab, ShopContainer);
            shopItem.GetComponent<ShopItemUI>().Setup(item, this);
        }
    }

    public void Purchase(ShopItemUI item)
    {
        int price = item.ItemData.GetPrice();
        if (Player.Instance.soulsCurrency >= price)
        {
            Player.Instance.soulsCurrency -= price;
            GameUI.Instance.UpdateSoulsCurrencyText();

            if (item.HasLevel)
            {
                item.ItemData.currentLevel++;
                item.UpdateCurrentLevel();              
            }

            item.UpdatePrice();

            // Add the purchased item to the player's inventory or perform any other desired actions
        }
        else
        {
            // Display a message indicating that the player does not have enough funds to purchase the item
        }
    }

    public bool CanAfford(ShopItem item)
    {
        return Player.Instance.soulsCurrency >= item.GetPrice();
    }
}

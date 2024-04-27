using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopItemUI : MonoBehaviour
{
    public bool HasLevel;
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI PriceText;
    public TextMeshProUGUI LevelText;
    public Image IconImage;
    public Button PurchaseButton;

    private Shop Shop;
    public ShopItem ItemData;

    public void Setup(ShopItem item, Shop shop)
    {
        this.ItemData = item;
        this.Shop = shop;

        NameText.text = item.ItemName;
        UpdatePrice();
        HasLevel = item.HasLevel;
        IconImage.sprite = item.Icon;

        if (HasLevel) UpdateCurrentLevel();
        else LevelText.gameObject.SetActive(false);
        CheckAffordability();
        PurchaseButton.onClick.AddListener(() => Shop.Purchase(this));

        Shop.ItemsInShop.Add(this);
    }

    public void CheckAffordability()
	{
        PurchaseButton.interactable = Shop.CanAfford(ItemData);
    }

    public void UpdateCurrentLevel()
	{
        LevelText.text = ItemData.currentLevel.ToString();
    }

    public void UpdatePrice()
	{
        PriceText.text = ItemData.GetPrice().ToString();
    }
}

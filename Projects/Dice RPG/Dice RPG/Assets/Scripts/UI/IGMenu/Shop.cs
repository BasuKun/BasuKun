using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
	public Transform ShopItemTemplate;
	public Transform Container;
	private IShopCustomer ShopCustomer;

	private void Start()
	{
		LinkCustomer(Player.Instance);
		CreateItemButton(Item.ItemType.Armor0, Item.GetSprite(Item.ItemType.Armor1), "Armor 1", Item.GetCost(Item.ItemType.Armor1));
		CreateItemButton(Item.ItemType.Armor1, Item.GetSprite(Item.ItemType.Armor2), "Armor 2", Item.GetCost(Item.ItemType.Armor2));
		CreateItemButton(Item.ItemType.Armor2, Item.GetSprite(Item.ItemType.Armor2), "Armor 3", Item.GetCost(Item.ItemType.Armor3));
	}

	public void CreateItemButton(Item.ItemType itemType, Sprite itemSprite, string itemName, int itemCost)
	{
		Transform shopItemTransform = Instantiate(ShopItemTemplate, Container);
		shopItemTransform.gameObject.SetActive(true);
		ShopItem item = shopItemTransform.GetComponent<ShopItem>();

		item.Name.SetText(itemName);
		item.Cost.SetText(itemCost.ToString());
		item.Icon.sprite = itemSprite;
		item.BuyButton.onClick.AddListener(delegate { TryBuyItem(itemType); });
	}

	private void TryBuyItem(Item.ItemType itemType)
	{
		if (ShopCustomer.TrySpendSoulAmount(Item.GetCost(itemType)))
		{
			ShopCustomer.BoughtItem(itemType);
		}
	}

	public void LinkCustomer(IShopCustomer shopCustomer)
	{
		this.ShopCustomer = shopCustomer;
	}
}

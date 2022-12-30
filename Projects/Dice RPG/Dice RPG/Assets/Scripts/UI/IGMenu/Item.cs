using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
	public enum ItemType
	{
		Weapon0,
		Weapon1,
		Weapon2,
		Weapon3,
		Armor0,
		Armor1,
		Armor2,
		Armor3,
		Gloves0,
		Gloves1,
		Gloves2,
		Gloves3,
		Boots0,
		Boots1,
		Boots2,
		Boots3,
		Potion,
		HighPotion,
		EnergyRoot,
		Steroids,
		Tent,
	}

	public static int GetCost(ItemType itemType)
	{
		switch (itemType)
		{
			default:
			case ItemType.Weapon0:		return 0;
			case ItemType.Weapon1:		return 100;
			case ItemType.Weapon2:		return 200;
			case ItemType.Weapon3:		return 300;
			case ItemType.Armor0:		return 0;
			case ItemType.Armor1:		return 100;
			case ItemType.Armor2:		return 200;
			case ItemType.Armor3:		return 300;
			case ItemType.Gloves0:		return 0;
			case ItemType.Gloves1:		return 100;
			case ItemType.Gloves2:		return 200;
			case ItemType.Gloves3:		return 300;
			case ItemType.Boots0:		return 0;
			case ItemType.Boots1:		return 100;
			case ItemType.Boots2:		return 200;
			case ItemType.Boots3:		return 300;
			case ItemType.Potion:		return 50;
			case ItemType.HighPotion:	return 200;
			case ItemType.EnergyRoot:	return 200;
			case ItemType.Steroids:		return 150;
			case ItemType.Tent:			return 100;
		}
	}

	public static Sprite GetSprite(ItemType itemType)
	{
		switch (itemType)
		{
			default:
			case ItemType.Weapon0:		return GameAssets.Instance.Template;
			case ItemType.Weapon1:		return GameAssets.Instance.Template;
			case ItemType.Weapon2:		return GameAssets.Instance.Template;
			case ItemType.Weapon3:		return GameAssets.Instance.Template;
			case ItemType.Armor0:		return GameAssets.Instance.Template;
			case ItemType.Armor1:		return GameAssets.Instance.Template;
			case ItemType.Armor2:		return GameAssets.Instance.Template;
			case ItemType.Armor3:		return GameAssets.Instance.Template;
			case ItemType.Gloves0:		return GameAssets.Instance.Template;
			case ItemType.Gloves1:		return GameAssets.Instance.Template;
			case ItemType.Gloves2:		return GameAssets.Instance.Template;
			case ItemType.Gloves3:		return GameAssets.Instance.Template;
			case ItemType.Boots0:		return GameAssets.Instance.Template;
			case ItemType.Boots1:		return GameAssets.Instance.Template;
			case ItemType.Boots2:		return GameAssets.Instance.Template;
			case ItemType.Boots3:		return GameAssets.Instance.Template;
			case ItemType.Potion:		return GameAssets.Instance.Template;
			case ItemType.HighPotion:	return GameAssets.Instance.Template;
			case ItemType.EnergyRoot:	return GameAssets.Instance.Template;
			case ItemType.Steroids:		return GameAssets.Instance.Template;
			case ItemType.Tent:			return GameAssets.Instance.Template;
		}
	}
}

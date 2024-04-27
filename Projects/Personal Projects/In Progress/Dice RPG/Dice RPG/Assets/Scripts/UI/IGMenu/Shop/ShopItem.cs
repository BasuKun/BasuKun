using UnityEngine;

[CreateAssetMenu(fileName = "ShopItem", menuName = "Shop/Shop Item")]
public class ShopItem : ScriptableObject
{
    public string ItemName;
    public string Description;
    public int BasePrice;
    public bool HasLevel;
    public float PriceMultiplier;
    public int MaxLevel;
    public Sprite Icon;

    [HideInInspector]
    public int currentLevel;

    public int GetPrice()
    {
        if (HasLevel) return Mathf.RoundToInt(BasePrice * (PriceMultiplier * (currentLevel + 1)));
        else return BasePrice;
    }

    private void OnEnable()
    {
        currentLevel = 0;
    }
}

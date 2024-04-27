using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHighlight : MonoBehaviour, IPointerEnterHandler
{
    private float blinkingTimer = 0.7f;
    private float timer = 0.7f;
    private bool isFullOpacity = true;
    private bool isHabitatXButton = false;
    private bool isShopXButton = false;
    private bool isUpgradeTabButton = false;
    private bool isBlessingsTabButton = false;
    private bool isLogsXButton = false;
    public Image highlight;
    public RectTransform rect;
    public Color highlightedColor;
    private Color noOpacityColor = new Color(0f, 0f, 0f, 0f);

    void Awake()
    {
        highlight.color = highlightedColor;
    }

    void Update()
    {
        Blink();
    }

    private void Blink()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            isFullOpacity = !isFullOpacity;
            highlight.color = isFullOpacity ? highlightedColor : noOpacityColor;
            timer = blinkingTimer;
        }
    }

    public void Reshape(float width, float height, bool isHabitatX, bool isShopX, bool isUpgradeTab, bool isBlessingTab, bool islogsX)
    {
        rect.sizeDelta = new Vector2(width, height);
        isHabitatXButton = isHabitatX;
        isShopXButton = isShopX;
        isUpgradeTabButton = isUpgradeTab;
        isBlessingsTabButton = isBlessingTab;
        isLogsXButton = islogsX;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (isHabitatXButton) Unlocks.Instance.hasHabitatXHighlight = false;
        if (isShopXButton) Unlocks.Instance.hasShopXHighlight = false;
        if (isUpgradeTabButton) Unlocks.Instance.hasUpgradeTabHighlight = false;
        if (isBlessingsTabButton) Unlocks.Instance.hasBlessingsTabHighlight = false;
        if (isLogsXButton) Unlocks.Instance.hasLogsHighlight = false;
        Destroy(this.gameObject);
    }
}

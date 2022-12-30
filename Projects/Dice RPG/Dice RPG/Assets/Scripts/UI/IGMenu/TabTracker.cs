using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabTracker : MonoBehaviour
{
    public Sprite tabOpenSprite;
    public Sprite tabClosedSprite;
    public Image[] tabImages;
    public GameObject[] tabPanels;

    private int currentTabIndex = 999;

    void Start()
    {
        UpdateTabSprites();
    }

    public void OnTabClicked(int tabIndex)
    {
		if (currentTabIndex == 999 && !MenuToggle.Instance.isMoving)
		{
            MenuToggle.Instance.MoveUIOnClick();
            currentTabIndex = tabIndex;
        }
		else if (currentTabIndex == tabIndex && !MenuToggle.Instance.isMoving)
		{
            MenuToggle.Instance.MoveUIOnClick();
            currentTabIndex = 999;
		}
		else
            currentTabIndex = tabIndex;

        UpdateTabSprites();
        UpdateTabPanels();
    }

    void UpdateTabSprites()
    {
        for (int i = 0; i < tabImages.Length; i++)
        {
            if (i == currentTabIndex)
                tabImages[i].sprite = tabOpenSprite;
            else
                tabImages[i].sprite = tabClosedSprite;
        }
    }

    void UpdateTabPanels()
	{
        for (int i = 0; i < tabPanels.Length; i++)
        {
            if (i == currentTabIndex)
                tabPanels[i].SetActive(true);
            else
                tabPanels[i].SetActive(false);
        }
    }
}
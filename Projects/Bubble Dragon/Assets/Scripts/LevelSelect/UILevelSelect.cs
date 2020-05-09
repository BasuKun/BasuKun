using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UILevelSelect : MonoBehaviour
{
    [SerializeField] private LevelController levelController;
    [SerializeField] private UILevel levelUI;
    [SerializeField] private Text worldText;
    [SerializeField] private Button leftArrow;
    [SerializeField] private Button rightArrow;
    [SerializeField] private Text WorldText;
    private Transform levelSelectPanel;
    private int currentPage;
    private List<UILevel> levelList = new List<UILevel>();

    void Start()
    {
        levelSelectPanel = transform;

        for (int i = 0; i < levelController.levels.Count; i++)
        {
            levelList.Add(levelUI);
        }
        BuildLevelPage(0);
    }

    void BuildLevelPage(int page)
    {
        RemoveItemsFromPage();

        currentPage = page;
        int pageSize = 10;
        worldText.text = "World " + (currentPage + 1);

        CheckForPreviousPage();
        CheckForNextPage();

        List<UILevel> pageList = levelList.Skip(page * pageSize).Take(pageSize).ToList();

        for (int i = 0; i < pageList.Count; i++)
        {
            Level level = levelController.levels[(page * pageSize) + i];
            UILevel instance = Instantiate(pageList[i]);
            instance.SetStars(level.Stars);
            instance.transform.SetParent(levelSelectPanel);

            if (!level.IsLocked)
            {
                instance.lockImage.SetActive(false);
                instance.starsImage.SetActive(true);
                instance.playButton.SetActive(true);
                instance.levelNameText.text = level.LevelName.ToString();
                instance.GetComponentInChildren<Button>().onClick.AddListener(() => SelectLevel(level));
            }
            else
            {
                instance.lockImage.SetActive(true);
                instance.starsImage.SetActive(false);
                instance.playButton.SetActive(false);
                instance.levelNameText.text = level.LevelName.ToString();
            }
        }
    }

    void RemoveItemsFromPage()
    {
        for (int i = 0; i < levelSelectPanel.childCount; i++)
        {
            Destroy(levelSelectPanel.GetChild(i).gameObject);
        }
    }

    public void NextPage()
    {
        BuildLevelPage(currentPage + 1);
    }

    public void PreviousPage()
    {
        BuildLevelPage(currentPage - 1);
    }

    public void CheckForPreviousPage()
    {
        leftArrow.interactable = currentPage == 0 ? false : true;
    }

    public void CheckForNextPage()
    {
        rightArrow.interactable = currentPage == 2 ? false : true;
    }

    void SelectLevel(Level level)
    {
        Debug.Log("Going to level: " + level.LevelName);
        levelController.StartLevel(level.LevelName);
    }
}

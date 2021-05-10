using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UnlocksListHandler : MonoBehaviour
{
    public List<UnlocksButton> UnlocksButtonsList = new List<UnlocksButton>();
    public GameObject unlocksContent;

    public static UnlocksListHandler Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        UnlocksButtonsList = unlocksContent.GetComponentsInChildren<UnlocksButton>(true).ToList();
    }

    public void CheckForUnlocks()
    {
        foreach (var unlock in UnlocksButtonsList)
        {
            if (GameManager.Instance.GMData.intelligencePointsAmount >= unlock.appearCost && unlock.unlockRequirement.activeSelf)
            {
                unlock.gameObject.SetActive(true);
            }
        }
    }
}

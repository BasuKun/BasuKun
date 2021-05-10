using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Logs : MonoBehaviour
{
    public int maxLogsAmount = 25;
    private List<GameObject> logsList = new List<GameObject>();

    public GameObject scrollView;
    public GameObject logsPrefabTwo;

    public static Logs Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddLog(string text, Color color)
    {
        AudioManager.Instance.PlayNoPitchSound(AudioManager.Instance.logsWriteSFX);
        GameObject prefab = Instantiate(logsPrefabTwo, scrollView.transform);
        TextMeshProUGUI prefabText = prefab.gameObject.GetComponentInChildren<TextMeshProUGUI>();
        prefabText.text = text;
        prefabText.color = color;
        logsList.Add(prefab);
        CheckForMaxLogs();

        if (!Unlocks.Instance.hasLogsHighlight && !Unlocks.Instance.logsContainer.isOpened)
        {
            Unlocks.Instance.SpawnHighlight(Unlocks.Instance.logsTabX, false, false, false, false, true);
        }
    }

    void CheckForMaxLogs()
    {
        if (logsList.Count > maxLogsAmount)
        {
            Destroy(logsList[0]);
            logsList.RemoveAt(0);
        }
    }
}

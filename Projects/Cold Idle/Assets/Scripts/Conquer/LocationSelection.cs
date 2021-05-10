using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class LocationSelection : MonoBehaviour
{
    public string selectedLocation;
    public TextMeshProUGUI locationSelectedText;
    public TextMeshProUGUI completedPercentageText;
    public TextMeshProUGUI currentUniverseText;
    public Button StartConquerButton;
    public List<Button> locations = new List<Button>();

    public static LocationSelection Instance;
    public LocData data = new LocData();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        SetData();
        SaveManager.OnSavedGame += Save;
    }

    public void SetData()
    {
        if (!PlayerPrefs.HasKey("Locations"))
        {
            data.completedAfrica = false;
            data.completedAsia = false;
            data.completedAustralia = false;
            data.completedEurope = false;
            data.completedNA = false;
            data.completedSA = false;
            data.completionPercentage = 0;
        }
        else
        {
            string jData = PlayerPrefs.GetString("Locations");
            data = JsonUtility.FromJson<LocData>(jData);

            locations[0].interactable = !data.completedAfrica;
            locations[1].interactable = !data.completedAsia;
            locations[2].interactable = !data.completedAustralia;
            locations[3].interactable = !data.completedEurope;
            locations[4].interactable = !data.completedNA;
            locations[5].interactable = !data.completedSA;

            GameUI.Instance.completedPercentageUpdateText();
        }
    }

    public void Save()
    {
        string jData = JsonUtility.ToJson(data);
        PlayerPrefs.SetString("Locations", jData);
    }

    private void OnDestroy()
    {
        SaveManager.OnSavedGame -= Save;
    }

    public void SelectLocation(string location)
    {
        selectedLocation = location;
        switch (location)
        {
            case "NA":
                locationSelectedText.text = "Location: North America\nReward: x1.4 IB and x1.2 SF";
                break;
            case "SA":
                locationSelectedText.text = "Location: South America\nReward: x2 BP";
                break;
            case "Europe":
                locationSelectedText.text = "Location: Europe\nReward: x1.5 SF";
                break;
            case "Asia":
                locationSelectedText.text = "Location: Asia\nReward: +1 Habitat per upgrade level";
                break;
            case "Africa":
                locationSelectedText.text = "Location: Africa\nReward: x1.8 IB";
                break;
            case "Australia":
                locationSelectedText.text = "Location: Australia\nReward: x1.5 IP";
                break;
            default:
                break;
        }
        StartConquerButton.interactable = true;
    }

    public void ResetUI()
    {
        Unlocks.Instance.conquestButton.GetComponent<Button>().interactable = true;
        selectedLocation = "";
        StartConquerButton.interactable = false;
        locationSelectedText.text = "\nNo location selected.";
    }

    public void CompleteUniverse()
    {
        currentUniverseText.gameObject.SetActive(true);
        Player.Instance.data.currentUniverse++;
        GameUI.Instance.currentUniverseUpdateText();

        data.completedAfrica = false;
        data.completedAsia = false;
        data.completedAustralia = false;
        data.completedEurope = false;
        data.completedNA = false;
        data.completedSA = false;
        locations[0].interactable = true;
        locations[1].interactable = true;
        locations[2].interactable = true;
        locations[3].interactable = true;
        locations[4].interactable = true;
        locations[5].interactable = true;

        data.completionPercentage = 0;
        GameUI.Instance.completedPercentageUpdateText();
    }
}

[Serializable]
public struct LocData
{
    public bool completedAfrica;
    public bool completedAsia;
    public bool completedAustralia;
    public bool completedEurope;
    public bool completedNA;
    public bool completedSA;
    public int completionPercentage;
}

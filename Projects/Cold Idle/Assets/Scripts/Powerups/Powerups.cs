using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Powerups : MonoBehaviour
{
    public List<PowerupsButton> PowerupsToUnlockList = new List<PowerupsButton>();
    public GameObject PowerupsContent;
    public List<PowerupsButton> PowerupsButtonsList = new List<PowerupsButton>();
    public Dictionary<string, PowerupsButton> PowerupsDict = new Dictionary<string, PowerupsButton>();

    public static Powerups Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        PowerupsToUnlockList = PowerupsContent.GetComponentsInChildren<PowerupsButton>(true).ToList();
    }

    public float SnowstormSeeker()
    {
        if (!PowerupsDict.ContainsKey("Snowstorm Seeker")) return 1;
        bool isActive = PowerupsDict["Snowstorm Seeker"].isEquipped;
        if (!isActive) return 1;

        float bonus = 1 + (SnowflakeSpawner.Instance.currentSnowflakesList.Count * 
            (PowerupsDict["Snowstorm Seeker"].bonus + 
            PowerupsDict["Snowstorm Seeker"].bonusPerLevel * 
            PowerupsDict["Snowstorm Seeker"].level));
        return bonus;
    }
    
    public int LuckyWinter()
    {
        if (!PowerupsDict.ContainsKey("Lucky Winter")) return 0;
        bool isActive = PowerupsDict["Lucky Winter"].isEquipped;
        if (!isActive) return 0;

        int bonus = (int)(PowerupsDict["Lucky Winter"].bonus +
            PowerupsDict["Lucky Winter"].bonusPerLevel *
            PowerupsDict["Lucky Winter"].level);
        return bonus;
    }

    public float BlessedSnowflakes()
    {
        if (!PowerupsDict.ContainsKey("Blessed Snowflakes")) return 0;
        bool isActive = PowerupsDict["Blessed Snowflakes"].isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Blessed Snowflakes"].bonus +
            PowerupsDict["Blessed Snowflakes"].bonusPerLevel *
            PowerupsDict["Blessed Snowflakes"].level);
        return bonus;
    }

    public float ShovelMaster()
    {
        if (!PowerupsDict.ContainsKey("Shovel Master")) return 1;
        bool isActive = PowerupsDict["Shovel Master"].isEquipped;
        if (!isActive) return 1;

        float bonus = PowerupsDict["Shovel Master"].bonus +
            PowerupsDict["Shovel Master"].bonusPerLevel *
            PowerupsDict["Shovel Master"].level;
        return bonus;
    }

    public float SnowflakeBooster()
    {
        if (!PowerupsDict.ContainsKey("Snowflake Booster")) return 1;
        bool isActive = PowerupsDict["Snowflake Booster"].isEquipped;
        if (!isActive) return 1;

        float bonus = (PowerupsDict["Snowflake Booster"].bonus +
            (PowerupsDict["Snowflake Booster"].bonusPerLevel *
            PowerupsDict["Snowflake Booster"].level));
        return bonus;
    }

    public float SnowpileFreezer()
    {
        if (!PowerupsDict.ContainsKey("Snowpile Freezer")) return 1;
        bool isActive = PowerupsDict["Snowpile Freezer"].isEquipped;
        if (!isActive) return 1;

        float bonus = (PowerupsDict["Snowpile Freezer"].bonus +
            PowerupsDict["Snowpile Freezer"].bonusPerLevel *
            PowerupsDict["Snowpile Freezer"].level);
        return bonus;
    }

    public float AbsorbantBody()
    {
        if (!PowerupsDict.ContainsKey("Absorbant Body")) return 0;
        bool isActive = PowerupsDict["Absorbant Body"].isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Absorbant Body"].bonus +
            PowerupsDict["Absorbant Body"].bonusPerLevel *
            PowerupsDict["Absorbant Body"].level);
        return bonus;
    }

    public float FateConqueror()
    {
        if (!PowerupsDict.ContainsKey("Fate Conqueror")) return 0;
        bool isActive = PowerupsDict["Fate Conqueror"].isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Fate Conqueror"].bonus +
            PowerupsDict["Fate Conqueror"].bonusPerLevel *
            PowerupsDict["Fate Conqueror"].level) * 
            (float)GameManager.Instance.worshippersAmount * Habitats.Instance.amountOfTimesFailed;
        return bonus;
    }

    public float ResourcesRecovery()
    {
        if (!PowerupsDict.ContainsKey("Resources Recovery")) return 0;
        bool isActive = PowerupsDict["Resources Recovery"].isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Resources Recovery"].bonus +
            PowerupsDict["Resources Recovery"].bonusPerLevel *
            PowerupsDict["Resources Recovery"].level);
        return bonus;
    }
}

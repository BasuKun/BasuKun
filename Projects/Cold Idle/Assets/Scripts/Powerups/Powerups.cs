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

    public float SnowstormSeeker()
    {
        if (!PowerupsDict.ContainsKey("Snowstorm Seeker")) return 1;
        bool isActive = PowerupsDict["Snowstorm Seeker"].data.isEquipped;
        if (!isActive) return 1;

        float bonus = 1 + (SnowflakeSpawner.Instance.currentSnowflakesList.Count * 
            (PowerupsDict["Snowstorm Seeker"].bonus + 
            PowerupsDict["Snowstorm Seeker"].bonusPerLevel * 
            PowerupsDict["Snowstorm Seeker"].data.level));
        return bonus;
    }
    
    public int LuckyWinter()
    {
        if (!PowerupsDict.ContainsKey("Lucky Winter")) return 0;
        bool isActive = PowerupsDict["Lucky Winter"].data.isEquipped;
        if (!isActive) return 0;

        int bonus = (int)(PowerupsDict["Lucky Winter"].bonus +
            PowerupsDict["Lucky Winter"].bonusPerLevel *
            PowerupsDict["Lucky Winter"].data.level);
        return bonus;
    }

    public float BlessedSnowflakes()
    {
        if (!PowerupsDict.ContainsKey("Blessed Snowflakes")) return 0;
        bool isActive = PowerupsDict["Blessed Snowflakes"].data.isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Blessed Snowflakes"].bonus +
            PowerupsDict["Blessed Snowflakes"].bonusPerLevel *
            PowerupsDict["Blessed Snowflakes"].data.level);
        return bonus;
    }

    public float ShovelMaster()
    {
        if (!PowerupsDict.ContainsKey("Shovel Master")) return 1;
        bool isActive = PowerupsDict["Shovel Master"].data.isEquipped;
        if (!isActive) return 1;

        float bonus = 1 + PowerupsDict["Shovel Master"].bonus +
            PowerupsDict["Shovel Master"].bonusPerLevel *
            PowerupsDict["Shovel Master"].data.level;
        return bonus;
    }

    public float SnowflakeBooster()
    {
        if (!PowerupsDict.ContainsKey("Snowflake Booster")) return 1;
        bool isActive = PowerupsDict["Snowflake Booster"].data.isEquipped;
        if (!isActive) return 1;

        float bonus = (PowerupsDict["Snowflake Booster"].bonus +
            (PowerupsDict["Snowflake Booster"].bonusPerLevel *
            PowerupsDict["Snowflake Booster"].data.level));
        return bonus;
    }

    public float SnowpileFreezer()
    {
        if (!PowerupsDict.ContainsKey("Snowpile Freezer")) return 1;
        bool isActive = PowerupsDict["Snowpile Freezer"].data.isEquipped;
        if (!isActive) return 1;

        float bonus = (PowerupsDict["Snowpile Freezer"].bonus +
            PowerupsDict["Snowpile Freezer"].bonusPerLevel *
            PowerupsDict["Snowpile Freezer"].data.level);
        return bonus;
    }

    public float AbsorbantBody()
    {
        if (!PowerupsDict.ContainsKey("Absorbant Body")) return 0;
        bool isActive = PowerupsDict["Absorbant Body"].data.isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Absorbant Body"].bonus +
            PowerupsDict["Absorbant Body"].bonusPerLevel *
            PowerupsDict["Absorbant Body"].data.level);
        return bonus;
    }

    public float FateConqueror()
    {
        if (!PowerupsDict.ContainsKey("Fate Conqueror")) return 0;
        bool isActive = PowerupsDict["Fate Conqueror"].data.isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Fate Conqueror"].bonus +
            PowerupsDict["Fate Conqueror"].bonusPerLevel *
            PowerupsDict["Fate Conqueror"].data.level) * 
            (float)GameManager.Instance.GMData.worshippersAmount * Habitats.Instance.amountOfTimesFailed;
        return bonus;
    }

    public float ResourcesRecovery()
    {
        if (!PowerupsDict.ContainsKey("Resources Recovery")) return 0;
        bool isActive = PowerupsDict["Resources Recovery"].data.isEquipped;
        if (!isActive) return 0;

        float bonus = (PowerupsDict["Resources Recovery"].bonus +
            PowerupsDict["Resources Recovery"].bonusPerLevel *
            PowerupsDict["Resources Recovery"].data.level);
        return bonus;
    }
}

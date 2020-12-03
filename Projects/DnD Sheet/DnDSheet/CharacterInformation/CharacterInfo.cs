using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class CharacterInfo
    {
        public static string characterName { get; set; }
        public static string characterClass { get; set; }
        public static string characterRace { get; set; }
        public static string characterBackground { get; set; }
        public static string characterAlignment { get; set; }

        public static int level;
        public static int experiencePoints;
        public static int proficiencyBonus;
        public static int inspiration;

        public static void SetProficiencyBonus()
        {
            switch (level)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    proficiencyBonus = 2;
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    proficiencyBonus = 3;
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    proficiencyBonus = 4;
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                    proficiencyBonus = 5;
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                    proficiencyBonus = 6;
                    break;
                default:
                    break;
            }

            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                skill.Value.UpdateText();
            }
        }
    }
}

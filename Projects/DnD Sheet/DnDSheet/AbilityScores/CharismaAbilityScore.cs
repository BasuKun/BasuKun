using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class CharismaAbilityScore
    {
        public static int charismaValue { get; private set; }
        public static int charismaModifier { get; private set; }

        public static void SetValue(string value)
        {
            charismaValue = int.Parse(value);
            SetModifier();
        }

        public static void SetModifier()
        {
            charismaModifier = (charismaValue - 10) / 2;

            if (charismaValue == 9 || charismaValue == 7 || charismaValue == 5 || charismaValue == 3 || charismaValue == 1)
            {
                charismaModifier -= 1;
            }
            UpdateSkills();
            UpdateSavingThrow();
        }

        public static void UpdateSkills()
        {
            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                if (skill.Value.abilityModifier == "Cha")
                {
                    skill.Value.value = charismaModifier;
                    skill.Value.UpdateText();
                }
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["CHA_Saving_Throw"].value = charismaModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["CHA_Saving_Throw"].UpdateText();
        }
    }
}

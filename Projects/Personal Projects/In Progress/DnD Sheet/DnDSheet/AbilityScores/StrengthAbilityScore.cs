using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class StrengthAbilityScore
    {
        public static int strengthValue { get; private set; }
        public static int strengthModifier { get; private set; }

        public static void SetValue(string value)
        {
            strengthValue = int.Parse(value);
            SetModifier();
        }

        public static void SetModifier()
        {
            strengthModifier = (strengthValue - 10) / 2;
            if (strengthValue == 9 || strengthValue == 7 || strengthValue == 5 || strengthValue == 3 || strengthValue == 1)
            {
                strengthModifier -= 1;
            }
            UpdateSkills();
            UpdateSavingThrow();
        }

        public static void UpdateSkills()
        {
            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                if (skill.Value.abilityModifier == "Str")
                {
                    skill.Value.value = strengthModifier;
                    skill.Value.UpdateText();
                }
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["STR_Saving_Throw"].value = strengthModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["STR_Saving_Throw"].UpdateText();
        }
    }
}

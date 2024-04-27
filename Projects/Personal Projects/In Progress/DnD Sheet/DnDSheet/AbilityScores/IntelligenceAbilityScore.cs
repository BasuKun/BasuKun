using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class IntelligenceAbilityScore
    {
        public static int intelligenceValue { get; private set; }
        public static int intelligenceModifier { get; private set; }

        public static void SetValue(string value)
        {
            intelligenceValue = int.Parse(value);
            SetModifier();
        }

        public static void SetModifier()
        {
            intelligenceModifier = (intelligenceValue - 10) / 2;
            if (intelligenceValue == 9 || intelligenceValue == 7 || intelligenceValue == 5 || intelligenceValue == 3 || intelligenceValue == 1)
            {
                intelligenceModifier -= 1;
            }
            UpdateSkills();
            UpdateSavingThrow();
        }

        public static void UpdateSkills()
        {
            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                if (skill.Value.abilityModifier == "Int")
                {
                    skill.Value.value = intelligenceModifier;
                    skill.Value.UpdateText();
                }
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["INT_Saving_Throw"].value = intelligenceModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["INT_Saving_Throw"].UpdateText();
        }
    }
}

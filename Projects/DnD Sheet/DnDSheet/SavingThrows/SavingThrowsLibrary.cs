using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class SavingThrowsLibrary
    {
        public static Dictionary<string, SavingThrow> SavingThrowsDictionary = new Dictionary<string, SavingThrow>();

        public static void PopulateSavingThrowsDictionary()
        {
            SavingThrowsDictionary.Add("STR_Saving_Throw", new SavingThrow("Strength",
                Sheet.Instance.StrengthSavingThrowValueText,
                Sheet.Instance.StrengthSavingThrowProficiencyCheckbox,
                "Str"));
            SavingThrowsDictionary.Add("DEX_Saving_Throw", new SavingThrow("Dexterity",
                Sheet.Instance.DexteritySavingThrowValueText,
                Sheet.Instance.DexteritySavingThrowProficiencyCheckbox,
                "Dex"));
            SavingThrowsDictionary.Add("CON_Saving_Throw", new SavingThrow("Constitution",
                Sheet.Instance.ConstitutionSavingThrowValueText,
                Sheet.Instance.ConstitutionSavingThrowProficiencyCheckbox,
                "Con"));
            SavingThrowsDictionary.Add("INT_Saving_Throw", new SavingThrow("Intelligence",
                Sheet.Instance.IntelligenceSavingThrowValueText,
                Sheet.Instance.IntelligenceSavingThrowProficiencyCheckbox,
                "Int"));
            SavingThrowsDictionary.Add("WIS_Saving_Throw", new SavingThrow("Wisdom",
                Sheet.Instance.WisdomSavingThrowValueText,
                Sheet.Instance.WisdomSavingThrowProficiencyCheckbox,
                "Wis"));
            SavingThrowsDictionary.Add("CHA_Saving_Throw", new SavingThrow("Charisma",
                Sheet.Instance.CharismaSavingThrowValueText,
                Sheet.Instance.CharismaSavingThrowProficiencyCheckbox,
                "Cha"));
        }
    }
}

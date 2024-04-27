using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class DexterityAbilityScore
    {
        public static int dexterityValue { get; private set; }
        public static int dexterityModifier { get; private set; }

        public static void SetValue(string value)
        {
            dexterityValue = int.Parse(value);
            SetModifier();
        }

        public static void SetModifier()
        {
            dexterityModifier = (dexterityValue - 10) / 2;
            if (dexterityValue == 9 || dexterityValue == 7 || dexterityValue == 5 || dexterityValue == 3 || dexterityValue == 1)
            {
                dexterityModifier -= 1;
            }
            UpdateSkills();
            UpdateSavingThrow();
            ArmorClass.SetArmorClass();
            Initiative.SetInitiative();
        }

        public static void UpdateSkills()
        {
            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                if (skill.Value.abilityModifier == "Dex")
                {
                    skill.Value.value = dexterityModifier;
                    skill.Value.UpdateText();
                }
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["DEX_Saving_Throw"].value = dexterityModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["DEX_Saving_Throw"].UpdateText();
        }
    }
}

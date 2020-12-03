using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class WisdomAbilityScore
    {
        public static int wisdomValue { get; private set; }
        public static int wisdomModifier { get; private set; }

        public static void SetValue(string value)
        {
            wisdomValue = int.Parse(value);
            SetModifier();
        }

        public static void SetModifier()
        {
            wisdomModifier = (wisdomValue - 10) / 2;
            if (wisdomValue == 9 || wisdomValue == 7 || wisdomValue == 5 || wisdomValue == 3 || wisdomValue == 1)
            {
                wisdomModifier -= 1;
            }
            UpdateSkills();
            UpdateSavingThrow();
        }

        public static void UpdateSkills()
        {
            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                if (skill.Value.abilityModifier == "Wis")
                {
                    skill.Value.value = wisdomModifier;
                    skill.Value.UpdateText();
                }
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["WIS_Saving_Throw"].value = wisdomModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["WIS_Saving_Throw"].UpdateText();
        }
    }
}

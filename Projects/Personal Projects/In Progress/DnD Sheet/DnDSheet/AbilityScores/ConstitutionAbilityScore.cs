using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class ConstitutionAbilityScore
    {
        public static int constitutionValue { get; private set; }
        public static int constitutionModifier { get; private set; }

        public static void SetValue(string value)
        {
            constitutionValue = int.Parse(value);
            SetModifier();
            UpdateSavingThrow();
        }

        public static void SetModifier()
        {
            constitutionModifier = (constitutionValue - 10) / 2;
            if (constitutionValue == 9 || constitutionValue == 7 || constitutionValue == 5 || constitutionValue == 3 || constitutionValue == 1)
            {
                constitutionModifier -= 1;
            }
        }

        public static void UpdateSavingThrow()
        {
            SavingThrowsLibrary.SavingThrowsDictionary["CON_Saving_Throw"].value = constitutionModifier;
            SavingThrowsLibrary.SavingThrowsDictionary["CON_Saving_Throw"].UpdateText();
        }
    }
}

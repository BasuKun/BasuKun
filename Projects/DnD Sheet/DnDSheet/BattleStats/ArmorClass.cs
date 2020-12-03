using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class ArmorClass
    {
        public static int baseValue;
        public static int armorClassValue { get; set; }
        public static int armorBonus { get; set; }
        public static int otherBonuses { get; set; }
        public static ArmorTypes.types armorType { get; set; }

        public static void SetArmorClass()
        {
            //TODO - Remove this line when armor section is complete
            armorType = ArmorTypes.types.None;
            switch (armorType)
            {
                case ArmorTypes.types.None:
                    baseValue = 10;
                    armorClassValue = baseValue + 
                        DexterityAbilityScore.dexterityModifier +
                        otherBonuses;
                    break;
                case ArmorTypes.types.Light:
                    armorClassValue = armorBonus +
                        DexterityAbilityScore.dexterityModifier +
                        otherBonuses;
                    break;
                case ArmorTypes.types.Medium:
                    int dexModifierLimit = DexterityAbilityScore.dexterityModifier > 2 ? 2 : DexterityAbilityScore.dexterityModifier;
                    armorClassValue = armorBonus +
                        dexModifierLimit + 
                        otherBonuses;
                    break;
                case ArmorTypes.types.Heavy:
                    armorClassValue = armorBonus +
                        otherBonuses;
                    break;
            }
            Sheet.Instance.ArmorClassValueText.Text = armorClassValue.ToString();
        }
    }
}
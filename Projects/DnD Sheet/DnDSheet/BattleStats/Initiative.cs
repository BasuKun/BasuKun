using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class Initiative
    {
        public static int initiativeValue { get; set; }
        public static int bonus { get; set; }
        public static List<ExtraBonus> extraBonuses = new List<ExtraBonus>();

        public static void SetInitiative()
        {
            bonus = 0;
            foreach (var extraBonus in extraBonuses)
            {
                if (!extraBonus.isEquipped) continue;

                int.TryParse(extraBonus.bonus, out int result);
                bonus += result;
            }

            initiativeValue = DexterityAbilityScore.dexterityModifier + bonus;
            string symbol = initiativeValue >= 0 ? "+" : "";
            Sheet.Instance.InitiativeValueText.Text = symbol + initiativeValue.ToString();
        }
    }
}

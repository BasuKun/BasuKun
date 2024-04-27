using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet
{
    public class SavingThrow
    {
        public string name { get; set; }
        public int value { get; set; }
        public int bonus { get; set; }
        public List<ExtraBonus> extraBonuses = new List<ExtraBonus>();
        public string abilityModifier { get; set; }
        public Label label;
        public CheckBox proficiencyCheckBox;
        public bool hasProficiency { get; set; }

        public SavingThrow(string name, Label label, CheckBox proficiencyCheckbox, string abilityModifier)
        {
            this.name = name;
            this.value = 0;
            this.bonus = 0;
            this.abilityModifier = abilityModifier;
            this.label = label;
            this.proficiencyCheckBox = proficiencyCheckbox;
            this.hasProficiency = false;
        }

        public void UpdateText()
        {
            bonus = 0;
            foreach (var extraBonus in extraBonuses)
            {
                if (!extraBonus.isEquipped) continue;

                int.TryParse(extraBonus.bonus, out int result);
                bonus += result;
            }

            hasProficiency = proficiencyCheckBox.Checked;
            int valueToDisplay = value +
                bonus +
                SavingThrowGlobalValues.globalBonus +
                (hasProficiency ? CharacterInfo.proficiencyBonus : 0);
            string symbolToDisplay = valueToDisplay >= 0 ? "+" : "";
            label.Text = symbolToDisplay + valueToDisplay;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet
{
    public class Skill
    {
        public string name { get; set; }
        public int value { get; set; }
        public int bonus { get; set; }
        public List<ExtraBonus> extraBonuses = new List<ExtraBonus>();
        public string abilityModifier { get; set; }
        public Label label;
        public CheckBox proficiencyCheckBox;
        public CheckBox expertiseCheckbox;
        public bool hasProficiency { get; set; }
        public bool hasExpertise { get; set; }
        public AffectedValues.values affectedValue { get; set; }


        public Skill(string name, Label label, CheckBox proficiencyCheckbox, CheckBox expertiseCheckbox, string abilityModifier, AffectedValues.values affectedValue)
        {
            this.name = name;
            this.value = 0;
            this.bonus = 0;
            this.abilityModifier = abilityModifier;
            this.label = label;
            this.proficiencyCheckBox = proficiencyCheckbox;
            this.expertiseCheckbox = expertiseCheckbox;
            this.hasProficiency = false;
            this.hasExpertise = false;
            this.affectedValue = affectedValue;
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
            hasExpertise = expertiseCheckbox.Checked;

            int valueToDisplay = value + 
                bonus +
                SkillsGlobalValues.globalBonus +
                (hasProficiency ? CharacterInfo.proficiencyBonus : 0) +
                (hasExpertise ? CharacterInfo.proficiencyBonus : 0);
            string symbolToDisplay = valueToDisplay >= 0 ? "+" : "";
            label.Text = symbolToDisplay + valueToDisplay;
        }
    }
}

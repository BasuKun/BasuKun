using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public class ExtraBonus
    {
        public bool isEquipped { get; set; }
        public string bonusName { get; set; }
        public AffectedValues.values affectedValue { get; set; }
        public string bonus { get; set; }
        private AffectedValues.values currentAffectedValue = AffectedValues.values.None;

        public void ApplyBonus()
        {
            CheckIfNewAffectedValue();

            if (currentAffectedValue.ToString() == "Initiative")
            {
                if (!Initiative.extraBonuses.Contains(this)) Initiative.extraBonuses.Add(this);
                Initiative.SetInitiative();
            }
            else if (currentAffectedValue.ToString() == "All_Saving_Throws")
            {
                if (!SavingThrowGlobalValues.globalExtraBonuses.Contains(this)) SavingThrowGlobalValues.globalExtraBonuses.Add(this);
                SavingThrowGlobalValues.setGlobalBonus();
            }
            else if (currentAffectedValue.ToString() == "All_Skills")
            {
                if (!SkillsGlobalValues.globalExtraBonuses.Contains(this)) SkillsGlobalValues.globalExtraBonuses.Add(this);
                SkillsGlobalValues.setGlobalBonus();
            }
            else if (SavingThrowsLibrary.SavingThrowsDictionary.TryGetValue(affectedValue.ToString(), out SavingThrow st))
            {
                if (!st.extraBonuses.Contains(this)) st.extraBonuses.Add(this);
                st.UpdateText();
            }
            else if (SkillsLibrary.SkillsDictionary.TryGetValue(affectedValue.ToString(), out Skill skill))
            {
                if (!skill.extraBonuses.Contains(this)) skill.extraBonuses.Add(this);
                skill.UpdateText();
            }
        }

        private void CheckIfNewAffectedValue()
        {
            if (currentAffectedValue == AffectedValues.values.None) currentAffectedValue = affectedValue;
            if (currentAffectedValue != affectedValue)
            {
                if (currentAffectedValue.ToString() == "Initiative")
                {
                    Initiative.extraBonuses.Remove(this);
                    Initiative.SetInitiative();
                }
                else if (currentAffectedValue.ToString() == "All_Saving_Throws")
                {
                    SavingThrowGlobalValues.globalExtraBonuses.Remove(this);
                    SavingThrowGlobalValues.setGlobalBonus();
                }
                else if (currentAffectedValue.ToString() == "All_Skills")
                {
                    SkillsGlobalValues.globalExtraBonuses.Remove(this);
                    SkillsGlobalValues.setGlobalBonus();
                }
                else if (SavingThrowsLibrary.SavingThrowsDictionary.TryGetValue(currentAffectedValue.ToString(), out SavingThrow oldST))
                {
                    oldST.extraBonuses.Remove(this);
                    oldST.UpdateText();
                }
                else if (SkillsLibrary.SkillsDictionary.TryGetValue(currentAffectedValue.ToString(), out Skill oldSkill))
                {
                    oldSkill.extraBonuses.Remove(this);
                    oldSkill.UpdateText();
                }
                currentAffectedValue = affectedValue;
            }
        }
    }
}

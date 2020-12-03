using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet
{
    public static class SkillsLibrary
    {
        public static Dictionary<string, Skill> SkillsDictionary = new Dictionary<string, Skill>();

        public static void PopulateSkillsDictionary()
        {
            SkillsDictionary.Add("Acrobatics", new Skill("Acrobatics", 
                Sheet.Instance.AcrobaticsValueText, 
                Sheet.Instance.AcrobaticsProficiencyCheckbox, 
                Sheet.Instance.AcrobaticsExpertiseCheckbox, 
                "Dex",
                AffectedValues.values.Acrobatics));
            SkillsDictionary.Add("Animal_Handling", new Skill("Animal Handling", 
                Sheet.Instance.AnimalHandlingValueText, 
                Sheet.Instance.AnimalHandlingProficiencyCheckbox,
                Sheet.Instance.AnimalHandlingExpertiseCheckbox, 
                "Wis",
                AffectedValues.values.Animal_Handling));
            SkillsDictionary.Add("Arcana", new Skill("Arcana", 
                Sheet.Instance.ArcanaValueText, 
                Sheet.Instance.ArcanaProficiencyCheckbox, 
                Sheet.Instance.ArcanaExpertiseCheckbox, 
                "Int",
                AffectedValues.values.Arcana));
            SkillsDictionary.Add("Athletics", new Skill("Athletics", 
                Sheet.Instance.AthleticsValueText, 
                Sheet.Instance.AthleticsProficiencyCheckbox, 
                Sheet.Instance.AthleticsExpertiseCheckbox, 
                "Str",
                AffectedValues.values.Athletics));
            SkillsDictionary.Add("Deception", new Skill("Deception", 
                Sheet.Instance.DeceptionValueText, 
                Sheet.Instance.DeceptionProficiencyCheckbox, 
                Sheet.Instance.DeceptionExpertiseCheckbox, 
                "Cha",
                AffectedValues.values.Deception));
            SkillsDictionary.Add("History", new Skill("History", 
                Sheet.Instance.HistoryValueText, 
                Sheet.Instance.HistoryProficiencyCheckbox, 
                Sheet.Instance.HistoryExpertiseCheckbox, 
                "Int",
                AffectedValues.values.History));
            SkillsDictionary.Add("Insight", new Skill("Insight", 
                Sheet.Instance.InsightValueText, 
                Sheet.Instance.InsightProficiencyCheckbox, 
                Sheet.Instance.InsightExpertiseCheckbox, 
                "Wis",
                AffectedValues.values.Insight));
            SkillsDictionary.Add("Intimidation", new Skill("Intimidation", 
                Sheet.Instance.IntimidationValueText, 
                Sheet.Instance.IntimidationProficiencyCheckbox, 
                Sheet.Instance.IntimidationExpertiseCheckbox, 
                "Cha",
                AffectedValues.values.Intimidation));
            SkillsDictionary.Add("Investigation", new Skill("Investigation", 
                Sheet.Instance.InvestigationValueText, 
                Sheet.Instance.InvestigationProficiencyCheckbox, 
                Sheet.Instance.InvestigationExpertiseCheckbox, 
                "Int",
                AffectedValues.values.Investigation));
            SkillsDictionary.Add("Medicine", new Skill("Medicine", 
                Sheet.Instance.MedicineValueText, 
                Sheet.Instance.MedicineProficiencyCheckbox, 
                Sheet.Instance.MedicineExpertiseCheckbox, 
                "Wis",
                AffectedValues.values.Medicine));
            SkillsDictionary.Add("Nature", new Skill("Nature", 
                Sheet.Instance.NatureValueText, 
                Sheet.Instance.NatureProficiencyCheckbox, 
                Sheet.Instance.NatureExpertiseCheckbox, 
                "Int",
                AffectedValues.values.Nature));
            SkillsDictionary.Add("Perception", new Skill("Perception", 
                Sheet.Instance.PerceptionValueText, 
                Sheet.Instance.PerceptionProficiencyCheckbox, 
                Sheet.Instance.PerceptionExpertiseCheckbox, 
                "Wis",
                AffectedValues.values.Perception));
            SkillsDictionary.Add("Performance", new Skill("Performance", 
                Sheet.Instance.PerformanceValueText, 
                Sheet.Instance.PerformanceProficiencyCheckbox, 
                Sheet.Instance.PerformanceExpertiseCheckbox, 
                "Cha",
                AffectedValues.values.Performance));
            SkillsDictionary.Add("Persuasion", new Skill("Persuasion", 
                Sheet.Instance.PersuasionValueText, 
                Sheet.Instance.PersuasionProficiencyCheckbox, 
                Sheet.Instance.PersuasionExpertiseCheckbox, 
                "Cha",
                AffectedValues.values.Persuasion));
            SkillsDictionary.Add("Religion", new Skill("Religion", 
                Sheet.Instance.ReligionValueText, 
                Sheet.Instance.ReligionProficiencyCheckbox, 
                Sheet.Instance.ReligionExpertiseCheckbox, 
                "Int",
                AffectedValues.values.Religion));
            SkillsDictionary.Add("Sleight_Of_Hand", new Skill("Sleight Of Hand", 
                Sheet.Instance.SleightOfHandValueText, 
                Sheet.Instance.SleightOfHandProficiencyCheckbox, 
                Sheet.Instance.SleightOfHandExpertiseCheckbox, 
                "Dex",
                AffectedValues.values.Sleight_Of_Hand));
            SkillsDictionary.Add("Stealth", new Skill("Stealth", 
                Sheet.Instance.StealthValueText, 
                Sheet.Instance.StealthProficiencyCheckbox, 
                Sheet.Instance.StealthExpertiseCheckbox, 
                "Dex",
                AffectedValues.values.Stealth));
            SkillsDictionary.Add("Survival", new Skill("Survival", 
                Sheet.Instance.SurvivalValueText, 
                Sheet.Instance.SurvivalProficiencyCheckbox, 
                Sheet.Instance.SurvivalExpertiseCheckbox, 
                "Wis",
                AffectedValues.values.Survival));
        }
    }
}

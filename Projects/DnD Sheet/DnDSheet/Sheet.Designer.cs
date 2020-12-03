using System.Drawing;
using System.Windows.Forms;

namespace DnDSheet
{
    partial class Sheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sheet));
            this.CharacterNameLabelText = new System.Windows.Forms.Label();
            this.ClassLabelText = new System.Windows.Forms.Label();
            this.LevelLabelText = new System.Windows.Forms.Label();
            this.StrengthLabelText = new System.Windows.Forms.Label();
            this.InspirationLabelText = new System.Windows.Forms.Label();
            this.StrengthSavingThrowLabelText = new System.Windows.Forms.Label();
            this.DexteritySavingThrowLabelText = new System.Windows.Forms.Label();
            this.ConstitutionSavingThrowLabelText = new System.Windows.Forms.Label();
            this.IntelligenceSavingThrowLabelText = new System.Windows.Forms.Label();
            this.WisdomSavingThrowLabelText = new System.Windows.Forms.Label();
            this.CharismaSavingThrowLabelText = new System.Windows.Forms.Label();
            this.CharacterAppearanceImage = new System.Windows.Forms.PictureBox();
            this.HistoryLabelText = new System.Windows.Forms.Label();
            this.DeceptionLabelText = new System.Windows.Forms.Label();
            this.AthleticsLabelText = new System.Windows.Forms.Label();
            this.ArcanaLabelText = new System.Windows.Forms.Label();
            this.AnimalHandlingLabelText = new System.Windows.Forms.Label();
            this.AcrobaticsLabelText = new System.Windows.Forms.Label();
            this.PerceptionLabelText = new System.Windows.Forms.Label();
            this.NatureLabelText = new System.Windows.Forms.Label();
            this.MedicineLabelText = new System.Windows.Forms.Label();
            this.InvestigationLabelText = new System.Windows.Forms.Label();
            this.IntimidationLabelText = new System.Windows.Forms.Label();
            this.InsightLabelText = new System.Windows.Forms.Label();
            this.SurvivalLabelText = new System.Windows.Forms.Label();
            this.StealthLabelText = new System.Windows.Forms.Label();
            this.SleightOfHandLabelText = new System.Windows.Forms.Label();
            this.ReligionLabelText = new System.Windows.Forms.Label();
            this.PersuasionLabelText = new System.Windows.Forms.Label();
            this.PerformanceLabelText = new System.Windows.Forms.Label();
            this.ResetCurrentHitPointsButton = new System.Windows.Forms.Button();
            this.HealHitPointsButton = new System.Windows.Forms.Button();
            this.SuccessDeathSaveLabelText = new System.Windows.Forms.Label();
            this.FailureDeathSaveLabelText = new System.Windows.Forms.Label();
            this.WeaponsNameLabelText = new System.Windows.Forms.Label();
            this.WeaponsAttackBonusLabelText = new System.Windows.Forms.Label();
            this.WeaponsDamageLabelText = new System.Windows.Forms.Label();
            this.AbilityScoresContainer = new System.Windows.Forms.Panel();
            this.CharismaLabelContainer = new System.Windows.Forms.Panel();
            this.CharismaLabelText = new System.Windows.Forms.Label();
            this.CharismaContainer = new System.Windows.Forms.Panel();
            this.CharismaValueTextBox = new System.Windows.Forms.TextBox();
            this.CharismaModifierContainer = new System.Windows.Forms.Panel();
            this.CharismaModifierValueText = new System.Windows.Forms.Label();
            this.WisdomLabelContainer = new System.Windows.Forms.Panel();
            this.WisdomLabelText = new System.Windows.Forms.Label();
            this.WisdomContainer = new System.Windows.Forms.Panel();
            this.WisdomValueTextBox = new System.Windows.Forms.TextBox();
            this.WisdomModifierContainer = new System.Windows.Forms.Panel();
            this.WisdomModifierValueText = new System.Windows.Forms.Label();
            this.IntelligenceLabelContainer = new System.Windows.Forms.Panel();
            this.IntelligenceLabelText = new System.Windows.Forms.Label();
            this.IntelligenceContainer = new System.Windows.Forms.Panel();
            this.IntelligenceValueTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceModifierContainer = new System.Windows.Forms.Panel();
            this.IntelligenceModifierValueText = new System.Windows.Forms.Label();
            this.ConstitutionLabelContainer = new System.Windows.Forms.Panel();
            this.ConstitutionLabelText = new System.Windows.Forms.Label();
            this.ConstitutionContainer = new System.Windows.Forms.Panel();
            this.ConstitutionValueTextBox = new System.Windows.Forms.TextBox();
            this.ConstitutionModifierContainer = new System.Windows.Forms.Panel();
            this.ConstitutionModifierValueText = new System.Windows.Forms.Label();
            this.DexterityLabelContainer = new System.Windows.Forms.Panel();
            this.DexterityLabelText = new System.Windows.Forms.Label();
            this.DexterityContainer = new System.Windows.Forms.Panel();
            this.DexterityValueTextBox = new System.Windows.Forms.TextBox();
            this.DexterityModifierContainer = new System.Windows.Forms.Panel();
            this.DexterityModifierValueText = new System.Windows.Forms.Label();
            this.StrengthLabelContainer = new System.Windows.Forms.Panel();
            this.StrengthContainer = new System.Windows.Forms.Panel();
            this.StrengthValueTextBox = new System.Windows.Forms.TextBox();
            this.StrengthModifierContainer = new System.Windows.Forms.Panel();
            this.StrengthModifierValueText = new System.Windows.Forms.Label();
            this.InspirationContainer = new System.Windows.Forms.Panel();
            this.InspirationValueContainer = new System.Windows.Forms.Panel();
            this.InspirationValueTextBox = new System.Windows.Forms.TextBox();
            this.InspirationLabelContainer = new System.Windows.Forms.Panel();
            this.ProficiencyContainer = new System.Windows.Forms.Panel();
            this.ProficiencyValueContainer = new System.Windows.Forms.Panel();
            this.ProficiencyBonusValueText = new System.Windows.Forms.Label();
            this.ProficiencyLabelContainer = new System.Windows.Forms.Panel();
            this.ProficiencyLabelText = new System.Windows.Forms.Label();
            this.SavingThrowsContainer = new System.Windows.Forms.Panel();
            this.CharismaSavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.WisdomSavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.IntelligenceSavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.ConstitutionSavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.DexteritySavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.StrengthSavingThrowProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.SavingThrowsValuesContainer = new System.Windows.Forms.Panel();
            this.CharismaSavingThrowValueText = new System.Windows.Forms.Label();
            this.WisdomSavingThrowValueText = new System.Windows.Forms.Label();
            this.IntelligenceSavingThrowValueText = new System.Windows.Forms.Label();
            this.ConstitutionSavingThrowValueText = new System.Windows.Forms.Label();
            this.DexteritySavingThrowValueText = new System.Windows.Forms.Label();
            this.StrengthSavingThrowValueText = new System.Windows.Forms.Label();
            this.SavingThrowsLabelsContainer = new System.Windows.Forms.Panel();
            this.SkillsContainer = new System.Windows.Forms.Panel();
            this.SurvivalExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.StealthExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.SleightOfHandExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.ReligionExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.PersuasionExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.PerformanceExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.PerceptionExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.NatureExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.MedicineExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.InvestigationExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.IntimidationExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.InsightExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.HistoryExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.DeceptionExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.AthleticsExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.ArcanaExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.AnimalHandlingExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.AcrobaticsExpertiseCheckbox = new System.Windows.Forms.CheckBox();
            this.SurvivalProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.StealthProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.SleightOfHandProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.ReligionProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.PersuasionProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.PerformanceProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.PerceptionProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.NatureProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.MedicineProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.InvestigationProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.IntimidationProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.InsightProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.HistoryProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.DeceptionProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.AthleticsProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.ArcanaProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.AnimalHandlingProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.AcrobaticsProficiencyCheckbox = new System.Windows.Forms.CheckBox();
            this.SkillsValuesContainer = new System.Windows.Forms.Panel();
            this.SurvivalValueText = new System.Windows.Forms.Label();
            this.StealthValueText = new System.Windows.Forms.Label();
            this.SleightOfHandValueText = new System.Windows.Forms.Label();
            this.ReligionValueText = new System.Windows.Forms.Label();
            this.PersuasionValueText = new System.Windows.Forms.Label();
            this.PerformanceValueText = new System.Windows.Forms.Label();
            this.PerceptionValueText = new System.Windows.Forms.Label();
            this.NatureValueText = new System.Windows.Forms.Label();
            this.MedicineValueText = new System.Windows.Forms.Label();
            this.InvestigationValueText = new System.Windows.Forms.Label();
            this.IntimidationValueText = new System.Windows.Forms.Label();
            this.InsightValueText = new System.Windows.Forms.Label();
            this.HistoryValueText = new System.Windows.Forms.Label();
            this.DeceptionValueText = new System.Windows.Forms.Label();
            this.AthleticsValueText = new System.Windows.Forms.Label();
            this.ArcanaValueText = new System.Windows.Forms.Label();
            this.AnimalHandlingValueText = new System.Windows.Forms.Label();
            this.AcrobaticsValueText = new System.Windows.Forms.Label();
            this.SkillsLabelsContainer = new System.Windows.Forms.Panel();
            this.ChaTipFour = new System.Windows.Forms.Label();
            this.ChaTipThree = new System.Windows.Forms.Label();
            this.ChaTipTwo = new System.Windows.Forms.Label();
            this.ChaTipOne = new System.Windows.Forms.Label();
            this.StrTipOne = new System.Windows.Forms.Label();
            this.IntTipFive = new System.Windows.Forms.Label();
            this.IntTipFour = new System.Windows.Forms.Label();
            this.IntTipThree = new System.Windows.Forms.Label();
            this.IntTipTwo = new System.Windows.Forms.Label();
            this.IntTipOne = new System.Windows.Forms.Label();
            this.WisTipFive = new System.Windows.Forms.Label();
            this.WisTipFour = new System.Windows.Forms.Label();
            this.WisTipThree = new System.Windows.Forms.Label();
            this.WisTipTwo = new System.Windows.Forms.Label();
            this.WisTipOne = new System.Windows.Forms.Label();
            this.DexTipThree = new System.Windows.Forms.Label();
            this.DexTipTwo = new System.Windows.Forms.Label();
            this.DexTipOne = new System.Windows.Forms.Label();
            this.ExtraBonusesContainer = new System.Windows.Forms.Panel();
            this.ExtraBonusesHeaderContainer = new System.Windows.Forms.Panel();
            this.ExtraBonusesBonusLabelText = new System.Windows.Forms.Label();
            this.ExtraBonusesNameLabelText = new System.Windows.Forms.Label();
            this.ExtraBonusesAffectedValueLabelText = new System.Windows.Forms.Label();
            this.ExtraBonusesValuesContainer = new System.Windows.Forms.Panel();
            this.ExtraBonusesGridView = new System.Windows.Forms.DataGridView();
            this.ExtraBonusesLabelContainer = new System.Windows.Forms.Panel();
            this.ExtraBonusesLabelText = new System.Windows.Forms.Label();
            this.CharacterNameLevelContainer = new System.Windows.Forms.Panel();
            this.CharacterLevelValueContainer = new System.Windows.Forms.Panel();
            this.CharacterLevelValueTextBox = new System.Windows.Forms.TextBox();
            this.CharacterNameValueContainer = new System.Windows.Forms.Panel();
            this.CharacterNameValueTextBox = new System.Windows.Forms.TextBox();
            this.CharacterLevelLabelContainer = new System.Windows.Forms.Panel();
            this.CharacterNameLabelContainer = new System.Windows.Forms.Panel();
            this.CharacterInfoContainer = new System.Windows.Forms.Panel();
            this.ExpValueContainer = new System.Windows.Forms.Panel();
            this.ExpValueTextBox = new System.Windows.Forms.TextBox();
            this.ExpLabelContainer = new System.Windows.Forms.Panel();
            this.ExpLabelText = new System.Windows.Forms.Label();
            this.AlignmentValueContainer = new System.Windows.Forms.Panel();
            this.AlignmentValueTextBox = new System.Windows.Forms.TextBox();
            this.AlignmentLabelContainer = new System.Windows.Forms.Panel();
            this.AlignmentLabelText = new System.Windows.Forms.Label();
            this.BackgroundValueContainer = new System.Windows.Forms.Panel();
            this.BackgroundValueTextBox = new System.Windows.Forms.TextBox();
            this.RaceValueContainer = new System.Windows.Forms.Panel();
            this.RaceValueTextBox = new System.Windows.Forms.TextBox();
            this.BackgroundLabelContainer = new System.Windows.Forms.Panel();
            this.BackgroundLabelText = new System.Windows.Forms.Label();
            this.ClassValueContainer = new System.Windows.Forms.Panel();
            this.ClassValueTextBox = new System.Windows.Forms.TextBox();
            this.RaceLabelContainer = new System.Windows.Forms.Panel();
            this.RaceLabelText = new System.Windows.Forms.Label();
            this.ClassLabelContainer = new System.Windows.Forms.Panel();
            this.BattleStatsContainer = new System.Windows.Forms.Panel();
            this.SpeedValueContainer = new System.Windows.Forms.Panel();
            this.SpeedValueTextBox = new System.Windows.Forms.TextBox();
            this.SpeedLabelContainer = new System.Windows.Forms.Panel();
            this.SpeedLabelText = new System.Windows.Forms.Label();
            this.InitiativeValueContainer = new System.Windows.Forms.Panel();
            this.InitiativeValueText = new System.Windows.Forms.Label();
            this.InitiativeLabelContainer = new System.Windows.Forms.Panel();
            this.InitiativeLabelText = new System.Windows.Forms.Label();
            this.ArmorClassValueContainer = new System.Windows.Forms.Panel();
            this.ArmorClassValueText = new System.Windows.Forms.Label();
            this.ArmorClassLabelContainer = new System.Windows.Forms.Panel();
            this.ArmorClassLabelText = new System.Windows.Forms.Label();
            this.HitPointsContainer = new System.Windows.Forms.Panel();
            this.ReceiveDamageButton = new System.Windows.Forms.Button();
            this.AddTemporaryHitPointsButton = new System.Windows.Forms.Button();
            this.CurrentHitPointsValueContainer = new System.Windows.Forms.Panel();
            this.CurrentHitPointsValueText = new System.Windows.Forms.RichTextBox();
            this.CurrentHitPointsLabelContainer = new System.Windows.Forms.Panel();
            this.CurrentHitPointsLabelText = new System.Windows.Forms.Label();
            this.MaxHitPointsValueContainer = new System.Windows.Forms.Panel();
            this.MaxHitPointsValueTextBox = new System.Windows.Forms.TextBox();
            this.MaxHitPointsLabelContainer = new System.Windows.Forms.Panel();
            this.MaxHitPointsLabelText = new System.Windows.Forms.Label();
            this.HitDiceContainer = new System.Windows.Forms.Panel();
            this.RefillHitDiceButton = new System.Windows.Forms.Button();
            this.RemainingHitDiceValueContainer = new System.Windows.Forms.Panel();
            this.RemainingHitDiceValueTextBox = new System.Windows.Forms.TextBox();
            this.TotalHitDiceValueContainer = new System.Windows.Forms.Panel();
            this.TotalHitDiceValueText = new System.Windows.Forms.Label();
            this.RemainingHitDiceLabelContainer = new System.Windows.Forms.Panel();
            this.RemainingHitDiceLabelText = new System.Windows.Forms.Label();
            this.DeathSavesValueContainer = new System.Windows.Forms.Panel();
            this.FailureDeathSaveCheckBoxThree = new System.Windows.Forms.CheckBox();
            this.FailureDeathSaveCheckBoxTwo = new System.Windows.Forms.CheckBox();
            this.FailureDeathSaveCheckBoxOne = new System.Windows.Forms.CheckBox();
            this.SuccessDeathSaveCheckBoxThree = new System.Windows.Forms.CheckBox();
            this.SuccessDeathSaveCheckBoxTwo = new System.Windows.Forms.CheckBox();
            this.SuccessDeathSaveCheckBoxOne = new System.Windows.Forms.CheckBox();
            this.DeathSavesLabelContainer = new System.Windows.Forms.Panel();
            this.DeathSavesLabelText = new System.Windows.Forms.Label();
            this.TotalHitDiceLabelContainer = new System.Windows.Forms.Panel();
            this.TotalHitDiceLabelText = new System.Windows.Forms.Label();
            this.HitDiceValueContainer = new System.Windows.Forms.Panel();
            this.HitDiceValueTextBox = new System.Windows.Forms.TextBox();
            this.HitDiceLabelContainer = new System.Windows.Forms.Panel();
            this.HitDiceLabelText = new System.Windows.Forms.Label();
            this.WeaponsContainer = new System.Windows.Forms.Panel();
            this.WeaponsHeaderContainer = new System.Windows.Forms.Panel();
            this.WeaponsValuesContainer = new System.Windows.Forms.Panel();
            this.WeaponsLabelContainer = new System.Windows.Forms.Panel();
            this.WeaponsLabelText = new System.Windows.Forms.Label();
            this.ArmorContainer = new System.Windows.Forms.Panel();
            this.ArmorHeaderContainer = new System.Windows.Forms.Panel();
            this.ArmorNameLabelText = new System.Windows.Forms.Label();
            this.ArmorTypeLabelText = new System.Windows.Forms.Label();
            this.ArmorACBonusLabelText = new System.Windows.Forms.Label();
            this.ArmorValuesContainer = new System.Windows.Forms.Panel();
            this.ArmorLabelContainer = new System.Windows.Forms.Panel();
            this.ArmorLabelText = new System.Windows.Forms.Label();
            this.CharacterAppearanceContainer = new System.Windows.Forms.Panel();
            this.InventoryContainer = new System.Windows.Forms.Panel();
            this.InventoryHeaderContainer = new System.Windows.Forms.Panel();
            this.InventoryNameLabelText = new System.Windows.Forms.Label();
            this.InventoryQuantityLabelText = new System.Windows.Forms.Label();
            this.InventoryValuesContainer = new System.Windows.Forms.Panel();
            this.InventoryLabelContainer = new System.Windows.Forms.Panel();
            this.InventoryLabelText = new System.Windows.Forms.Label();
            this.PlatinumPiecesValueContainer = new System.Windows.Forms.Panel();
            this.PlatinumPiecesValueTextBox = new System.Windows.Forms.TextBox();
            this.GoldPiecesValueContainer = new System.Windows.Forms.Panel();
            this.GoldPiecesValueTextBox = new System.Windows.Forms.TextBox();
            this.PlatinumPiecesLabelContainer = new System.Windows.Forms.Panel();
            this.PlatinumPiecesLabelText = new System.Windows.Forms.Label();
            this.SilverPiecesValueContainer = new System.Windows.Forms.Panel();
            this.SilverPiecesValueTextBox = new System.Windows.Forms.TextBox();
            this.GoldPiecesLabelContainer = new System.Windows.Forms.Panel();
            this.GoldPiecesLabelText = new System.Windows.Forms.Label();
            this.CopperPiecesValueContainer = new System.Windows.Forms.Panel();
            this.CopperPiecesValueTextBox = new System.Windows.Forms.TextBox();
            this.SilverPiecesLabelContainer = new System.Windows.Forms.Panel();
            this.SilverPiecesLabelText = new System.Windows.Forms.Label();
            this.CoppierPiecesLabelContainer = new System.Windows.Forms.Panel();
            this.CoppierPiecesLabelText = new System.Windows.Forms.Label();
            this.LanguageProficienciesContainer = new System.Windows.Forms.Panel();
            this.LanguageProficienciesHeaderContainer = new System.Windows.Forms.Panel();
            this.LanguageProficienciesTypeLabelText = new System.Windows.Forms.Label();
            this.LanguageProficienciesNameLabelText = new System.Windows.Forms.Label();
            this.LanguageProficienciesValuesContainer = new System.Windows.Forms.Panel();
            this.LanguageProficienciesLabelContainer = new System.Windows.Forms.Panel();
            this.LanguageProficienciesLabelText = new System.Windows.Forms.Label();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BonusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AffectedValue = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAppearanceImage)).BeginInit();
            this.AbilityScoresContainer.SuspendLayout();
            this.CharismaLabelContainer.SuspendLayout();
            this.CharismaContainer.SuspendLayout();
            this.CharismaModifierContainer.SuspendLayout();
            this.WisdomLabelContainer.SuspendLayout();
            this.WisdomContainer.SuspendLayout();
            this.WisdomModifierContainer.SuspendLayout();
            this.IntelligenceLabelContainer.SuspendLayout();
            this.IntelligenceContainer.SuspendLayout();
            this.IntelligenceModifierContainer.SuspendLayout();
            this.ConstitutionLabelContainer.SuspendLayout();
            this.ConstitutionContainer.SuspendLayout();
            this.ConstitutionModifierContainer.SuspendLayout();
            this.DexterityLabelContainer.SuspendLayout();
            this.DexterityContainer.SuspendLayout();
            this.DexterityModifierContainer.SuspendLayout();
            this.StrengthLabelContainer.SuspendLayout();
            this.StrengthContainer.SuspendLayout();
            this.StrengthModifierContainer.SuspendLayout();
            this.InspirationContainer.SuspendLayout();
            this.InspirationValueContainer.SuspendLayout();
            this.InspirationLabelContainer.SuspendLayout();
            this.ProficiencyContainer.SuspendLayout();
            this.ProficiencyValueContainer.SuspendLayout();
            this.ProficiencyLabelContainer.SuspendLayout();
            this.SavingThrowsContainer.SuspendLayout();
            this.SavingThrowsValuesContainer.SuspendLayout();
            this.SavingThrowsLabelsContainer.SuspendLayout();
            this.SkillsContainer.SuspendLayout();
            this.SkillsValuesContainer.SuspendLayout();
            this.SkillsLabelsContainer.SuspendLayout();
            this.ExtraBonusesContainer.SuspendLayout();
            this.ExtraBonusesHeaderContainer.SuspendLayout();
            this.ExtraBonusesValuesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraBonusesGridView)).BeginInit();
            this.ExtraBonusesLabelContainer.SuspendLayout();
            this.CharacterNameLevelContainer.SuspendLayout();
            this.CharacterLevelValueContainer.SuspendLayout();
            this.CharacterNameValueContainer.SuspendLayout();
            this.CharacterLevelLabelContainer.SuspendLayout();
            this.CharacterNameLabelContainer.SuspendLayout();
            this.CharacterInfoContainer.SuspendLayout();
            this.ExpValueContainer.SuspendLayout();
            this.ExpLabelContainer.SuspendLayout();
            this.AlignmentValueContainer.SuspendLayout();
            this.AlignmentLabelContainer.SuspendLayout();
            this.BackgroundValueContainer.SuspendLayout();
            this.RaceValueContainer.SuspendLayout();
            this.BackgroundLabelContainer.SuspendLayout();
            this.ClassValueContainer.SuspendLayout();
            this.RaceLabelContainer.SuspendLayout();
            this.ClassLabelContainer.SuspendLayout();
            this.BattleStatsContainer.SuspendLayout();
            this.SpeedValueContainer.SuspendLayout();
            this.SpeedLabelContainer.SuspendLayout();
            this.InitiativeValueContainer.SuspendLayout();
            this.InitiativeLabelContainer.SuspendLayout();
            this.ArmorClassValueContainer.SuspendLayout();
            this.ArmorClassLabelContainer.SuspendLayout();
            this.HitPointsContainer.SuspendLayout();
            this.CurrentHitPointsValueContainer.SuspendLayout();
            this.CurrentHitPointsLabelContainer.SuspendLayout();
            this.MaxHitPointsValueContainer.SuspendLayout();
            this.MaxHitPointsLabelContainer.SuspendLayout();
            this.HitDiceContainer.SuspendLayout();
            this.RemainingHitDiceValueContainer.SuspendLayout();
            this.TotalHitDiceValueContainer.SuspendLayout();
            this.RemainingHitDiceLabelContainer.SuspendLayout();
            this.DeathSavesValueContainer.SuspendLayout();
            this.DeathSavesLabelContainer.SuspendLayout();
            this.TotalHitDiceLabelContainer.SuspendLayout();
            this.HitDiceValueContainer.SuspendLayout();
            this.HitDiceLabelContainer.SuspendLayout();
            this.WeaponsContainer.SuspendLayout();
            this.WeaponsHeaderContainer.SuspendLayout();
            this.WeaponsValuesContainer.SuspendLayout();
            this.WeaponsLabelContainer.SuspendLayout();
            this.ArmorContainer.SuspendLayout();
            this.ArmorHeaderContainer.SuspendLayout();
            this.ArmorValuesContainer.SuspendLayout();
            this.ArmorLabelContainer.SuspendLayout();
            this.CharacterAppearanceContainer.SuspendLayout();
            this.InventoryContainer.SuspendLayout();
            this.InventoryHeaderContainer.SuspendLayout();
            this.InventoryValuesContainer.SuspendLayout();
            this.InventoryLabelContainer.SuspendLayout();
            this.PlatinumPiecesValueContainer.SuspendLayout();
            this.GoldPiecesValueContainer.SuspendLayout();
            this.PlatinumPiecesLabelContainer.SuspendLayout();
            this.SilverPiecesValueContainer.SuspendLayout();
            this.GoldPiecesLabelContainer.SuspendLayout();
            this.CopperPiecesValueContainer.SuspendLayout();
            this.SilverPiecesLabelContainer.SuspendLayout();
            this.CoppierPiecesLabelContainer.SuspendLayout();
            this.LanguageProficienciesContainer.SuspendLayout();
            this.LanguageProficienciesHeaderContainer.SuspendLayout();
            this.LanguageProficienciesValuesContainer.SuspendLayout();
            this.LanguageProficienciesLabelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterNameLabelText
            // 
            this.CharacterNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameLabelText.Location = new System.Drawing.Point(0, 0);
            this.CharacterNameLabelText.Name = "CharacterNameLabelText";
            this.CharacterNameLabelText.Size = new System.Drawing.Size(215, 23);
            this.CharacterNameLabelText.TabIndex = 0;
            this.CharacterNameLabelText.Text = "CHARACTER NAME";
            this.CharacterNameLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassLabelText
            // 
            this.ClassLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLabelText.Location = new System.Drawing.Point(0, 0);
            this.ClassLabelText.Name = "ClassLabelText";
            this.ClassLabelText.Size = new System.Drawing.Size(48, 24);
            this.ClassLabelText.TabIndex = 1;
            this.ClassLabelText.Text = "CLASS";
            this.ClassLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLabelText
            // 
            this.LevelLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabelText.Location = new System.Drawing.Point(0, 0);
            this.LevelLabelText.Name = "LevelLabelText";
            this.LevelLabelText.Size = new System.Drawing.Size(68, 23);
            this.LevelLabelText.TabIndex = 2;
            this.LevelLabelText.Text = "LEVEL";
            this.LevelLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthLabelText
            // 
            this.StrengthLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabelText.Location = new System.Drawing.Point(0, 0);
            this.StrengthLabelText.Name = "StrengthLabelText";
            this.StrengthLabelText.Size = new System.Drawing.Size(87, 23);
            this.StrengthLabelText.TabIndex = 8;
            this.StrengthLabelText.Text = "STRENGTH";
            this.StrengthLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InspirationLabelText
            // 
            this.InspirationLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspirationLabelText.Location = new System.Drawing.Point(3, 0);
            this.InspirationLabelText.Name = "InspirationLabelText";
            this.InspirationLabelText.Size = new System.Drawing.Size(151, 28);
            this.InspirationLabelText.TabIndex = 14;
            this.InspirationLabelText.Text = "INSPIRATION";
            this.InspirationLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthSavingThrowLabelText
            // 
            this.StrengthSavingThrowLabelText.AutoSize = true;
            this.StrengthSavingThrowLabelText.Location = new System.Drawing.Point(13, 6);
            this.StrengthSavingThrowLabelText.Name = "StrengthSavingThrowLabelText";
            this.StrengthSavingThrowLabelText.Size = new System.Drawing.Size(47, 13);
            this.StrengthSavingThrowLabelText.TabIndex = 17;
            this.StrengthSavingThrowLabelText.Text = "Strength";
            // 
            // DexteritySavingThrowLabelText
            // 
            this.DexteritySavingThrowLabelText.AutoSize = true;
            this.DexteritySavingThrowLabelText.Location = new System.Drawing.Point(13, 23);
            this.DexteritySavingThrowLabelText.Name = "DexteritySavingThrowLabelText";
            this.DexteritySavingThrowLabelText.Size = new System.Drawing.Size(51, 13);
            this.DexteritySavingThrowLabelText.TabIndex = 18;
            this.DexteritySavingThrowLabelText.Text = "Dexterity";
            // 
            // ConstitutionSavingThrowLabelText
            // 
            this.ConstitutionSavingThrowLabelText.AutoSize = true;
            this.ConstitutionSavingThrowLabelText.Location = new System.Drawing.Point(13, 40);
            this.ConstitutionSavingThrowLabelText.Name = "ConstitutionSavingThrowLabelText";
            this.ConstitutionSavingThrowLabelText.Size = new System.Drawing.Size(64, 13);
            this.ConstitutionSavingThrowLabelText.TabIndex = 19;
            this.ConstitutionSavingThrowLabelText.Text = "Constitution";
            // 
            // IntelligenceSavingThrowLabelText
            // 
            this.IntelligenceSavingThrowLabelText.AutoSize = true;
            this.IntelligenceSavingThrowLabelText.Location = new System.Drawing.Point(13, 57);
            this.IntelligenceSavingThrowLabelText.Name = "IntelligenceSavingThrowLabelText";
            this.IntelligenceSavingThrowLabelText.Size = new System.Drawing.Size(63, 13);
            this.IntelligenceSavingThrowLabelText.TabIndex = 20;
            this.IntelligenceSavingThrowLabelText.Text = "Intelligence";
            // 
            // WisdomSavingThrowLabelText
            // 
            this.WisdomSavingThrowLabelText.AutoSize = true;
            this.WisdomSavingThrowLabelText.Location = new System.Drawing.Point(13, 74);
            this.WisdomSavingThrowLabelText.Name = "WisdomSavingThrowLabelText";
            this.WisdomSavingThrowLabelText.Size = new System.Drawing.Size(46, 13);
            this.WisdomSavingThrowLabelText.TabIndex = 21;
            this.WisdomSavingThrowLabelText.Text = "Wisdom";
            // 
            // CharismaSavingThrowLabelText
            // 
            this.CharismaSavingThrowLabelText.AutoSize = true;
            this.CharismaSavingThrowLabelText.Location = new System.Drawing.Point(13, 91);
            this.CharismaSavingThrowLabelText.Name = "CharismaSavingThrowLabelText";
            this.CharismaSavingThrowLabelText.Size = new System.Drawing.Size(52, 13);
            this.CharismaSavingThrowLabelText.TabIndex = 22;
            this.CharismaSavingThrowLabelText.Text = "Charisma";
            // 
            // CharacterAppearanceImage
            // 
            this.CharacterAppearanceImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CharacterAppearanceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterAppearanceImage.Location = new System.Drawing.Point(8, 8);
            this.CharacterAppearanceImage.Name = "CharacterAppearanceImage";
            this.CharacterAppearanceImage.Size = new System.Drawing.Size(227, 216);
            this.CharacterAppearanceImage.TabIndex = 27;
            this.CharacterAppearanceImage.TabStop = false;
            // 
            // HistoryLabelText
            // 
            this.HistoryLabelText.AutoSize = true;
            this.HistoryLabelText.Location = new System.Drawing.Point(12, 92);
            this.HistoryLabelText.Name = "HistoryLabelText";
            this.HistoryLabelText.Size = new System.Drawing.Size(41, 13);
            this.HistoryLabelText.TabIndex = 33;
            this.HistoryLabelText.Text = "History";
            // 
            // DeceptionLabelText
            // 
            this.DeceptionLabelText.AutoSize = true;
            this.DeceptionLabelText.Location = new System.Drawing.Point(12, 75);
            this.DeceptionLabelText.Name = "DeceptionLabelText";
            this.DeceptionLabelText.Size = new System.Drawing.Size(55, 13);
            this.DeceptionLabelText.TabIndex = 32;
            this.DeceptionLabelText.Text = "Deception";
            // 
            // AthleticsLabelText
            // 
            this.AthleticsLabelText.AutoSize = true;
            this.AthleticsLabelText.Location = new System.Drawing.Point(12, 58);
            this.AthleticsLabelText.Name = "AthleticsLabelText";
            this.AthleticsLabelText.Size = new System.Drawing.Size(48, 13);
            this.AthleticsLabelText.TabIndex = 31;
            this.AthleticsLabelText.Text = "Athletics";
            // 
            // ArcanaLabelText
            // 
            this.ArcanaLabelText.AutoSize = true;
            this.ArcanaLabelText.Location = new System.Drawing.Point(12, 41);
            this.ArcanaLabelText.Name = "ArcanaLabelText";
            this.ArcanaLabelText.Size = new System.Drawing.Size(40, 13);
            this.ArcanaLabelText.TabIndex = 30;
            this.ArcanaLabelText.Text = "Arcana";
            // 
            // AnimalHandlingLabelText
            // 
            this.AnimalHandlingLabelText.AutoSize = true;
            this.AnimalHandlingLabelText.Location = new System.Drawing.Point(12, 24);
            this.AnimalHandlingLabelText.Name = "AnimalHandlingLabelText";
            this.AnimalHandlingLabelText.Size = new System.Drawing.Size(84, 13);
            this.AnimalHandlingLabelText.TabIndex = 29;
            this.AnimalHandlingLabelText.Text = "Animal Handling";
            // 
            // AcrobaticsLabelText
            // 
            this.AcrobaticsLabelText.AutoSize = true;
            this.AcrobaticsLabelText.Location = new System.Drawing.Point(12, 7);
            this.AcrobaticsLabelText.Name = "AcrobaticsLabelText";
            this.AcrobaticsLabelText.Size = new System.Drawing.Size(56, 13);
            this.AcrobaticsLabelText.TabIndex = 28;
            this.AcrobaticsLabelText.Text = "Acrobatics";
            // 
            // PerceptionLabelText
            // 
            this.PerceptionLabelText.AutoSize = true;
            this.PerceptionLabelText.Location = new System.Drawing.Point(12, 194);
            this.PerceptionLabelText.Name = "PerceptionLabelText";
            this.PerceptionLabelText.Size = new System.Drawing.Size(58, 13);
            this.PerceptionLabelText.TabIndex = 39;
            this.PerceptionLabelText.Text = "Perception";
            // 
            // NatureLabelText
            // 
            this.NatureLabelText.AutoSize = true;
            this.NatureLabelText.Location = new System.Drawing.Point(12, 177);
            this.NatureLabelText.Name = "NatureLabelText";
            this.NatureLabelText.Size = new System.Drawing.Size(40, 13);
            this.NatureLabelText.TabIndex = 38;
            this.NatureLabelText.Text = "Nature";
            // 
            // MedicineLabelText
            // 
            this.MedicineLabelText.AutoSize = true;
            this.MedicineLabelText.Location = new System.Drawing.Point(12, 160);
            this.MedicineLabelText.Name = "MedicineLabelText";
            this.MedicineLabelText.Size = new System.Drawing.Size(51, 13);
            this.MedicineLabelText.TabIndex = 37;
            this.MedicineLabelText.Text = "Medicine";
            // 
            // InvestigationLabelText
            // 
            this.InvestigationLabelText.AutoSize = true;
            this.InvestigationLabelText.Location = new System.Drawing.Point(12, 143);
            this.InvestigationLabelText.Name = "InvestigationLabelText";
            this.InvestigationLabelText.Size = new System.Drawing.Size(67, 13);
            this.InvestigationLabelText.TabIndex = 36;
            this.InvestigationLabelText.Text = "Investigation";
            // 
            // IntimidationLabelText
            // 
            this.IntimidationLabelText.AutoSize = true;
            this.IntimidationLabelText.Location = new System.Drawing.Point(12, 126);
            this.IntimidationLabelText.Name = "IntimidationLabelText";
            this.IntimidationLabelText.Size = new System.Drawing.Size(64, 13);
            this.IntimidationLabelText.TabIndex = 35;
            this.IntimidationLabelText.Text = "Intimidation";
            // 
            // InsightLabelText
            // 
            this.InsightLabelText.AutoSize = true;
            this.InsightLabelText.Location = new System.Drawing.Point(12, 109);
            this.InsightLabelText.Name = "InsightLabelText";
            this.InsightLabelText.Size = new System.Drawing.Size(39, 13);
            this.InsightLabelText.TabIndex = 34;
            this.InsightLabelText.Text = "Insight";
            // 
            // SurvivalLabelText
            // 
            this.SurvivalLabelText.AutoSize = true;
            this.SurvivalLabelText.Location = new System.Drawing.Point(12, 296);
            this.SurvivalLabelText.Name = "SurvivalLabelText";
            this.SurvivalLabelText.Size = new System.Drawing.Size(44, 13);
            this.SurvivalLabelText.TabIndex = 45;
            this.SurvivalLabelText.Text = "Survival";
            // 
            // StealthLabelText
            // 
            this.StealthLabelText.AutoSize = true;
            this.StealthLabelText.Location = new System.Drawing.Point(12, 279);
            this.StealthLabelText.Name = "StealthLabelText";
            this.StealthLabelText.Size = new System.Drawing.Size(41, 13);
            this.StealthLabelText.TabIndex = 44;
            this.StealthLabelText.Text = "Stealth";
            // 
            // SleightOfHandLabelText
            // 
            this.SleightOfHandLabelText.AutoSize = true;
            this.SleightOfHandLabelText.Location = new System.Drawing.Point(12, 262);
            this.SleightOfHandLabelText.Name = "SleightOfHandLabelText";
            this.SleightOfHandLabelText.Size = new System.Drawing.Size(78, 13);
            this.SleightOfHandLabelText.TabIndex = 43;
            this.SleightOfHandLabelText.Text = "Sleight Of Hand";
            // 
            // ReligionLabelText
            // 
            this.ReligionLabelText.AutoSize = true;
            this.ReligionLabelText.Location = new System.Drawing.Point(12, 245);
            this.ReligionLabelText.Name = "ReligionLabelText";
            this.ReligionLabelText.Size = new System.Drawing.Size(45, 13);
            this.ReligionLabelText.TabIndex = 42;
            this.ReligionLabelText.Text = "Religion";
            // 
            // PersuasionLabelText
            // 
            this.PersuasionLabelText.AutoSize = true;
            this.PersuasionLabelText.Location = new System.Drawing.Point(12, 228);
            this.PersuasionLabelText.Name = "PersuasionLabelText";
            this.PersuasionLabelText.Size = new System.Drawing.Size(60, 13);
            this.PersuasionLabelText.TabIndex = 41;
            this.PersuasionLabelText.Text = "Persuasion";
            // 
            // PerformanceLabelText
            // 
            this.PerformanceLabelText.AutoSize = true;
            this.PerformanceLabelText.Location = new System.Drawing.Point(12, 211);
            this.PerformanceLabelText.Name = "PerformanceLabelText";
            this.PerformanceLabelText.Size = new System.Drawing.Size(68, 13);
            this.PerformanceLabelText.TabIndex = 40;
            this.PerformanceLabelText.Text = "Performance";
            // 
            // ResetCurrentHitPointsButton
            // 
            this.ResetCurrentHitPointsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(197)))));
            this.ResetCurrentHitPointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetCurrentHitPointsButton.Location = new System.Drawing.Point(123, 122);
            this.ResetCurrentHitPointsButton.Name = "ResetCurrentHitPointsButton";
            this.ResetCurrentHitPointsButton.Size = new System.Drawing.Size(106, 23);
            this.ResetCurrentHitPointsButton.TabIndex = 50;
            this.ResetCurrentHitPointsButton.Text = "Reset Current HP";
            this.ResetCurrentHitPointsButton.UseVisualStyleBackColor = false;
            this.ResetCurrentHitPointsButton.Click += new System.EventHandler(this.ResetCurrentHitPointsButton_Click);
            // 
            // HealHitPointsButton
            // 
            this.HealHitPointsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(201)))), ((int)(((byte)(169)))));
            this.HealHitPointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealHitPointsButton.Location = new System.Drawing.Point(9, 93);
            this.HealHitPointsButton.Name = "HealHitPointsButton";
            this.HealHitPointsButton.Size = new System.Drawing.Size(106, 23);
            this.HealHitPointsButton.TabIndex = 51;
            this.HealHitPointsButton.Text = "Heal HP";
            this.HealHitPointsButton.UseVisualStyleBackColor = false;
            this.HealHitPointsButton.Click += new System.EventHandler(this.HealHitPointsButton_Click);
            // 
            // SuccessDeathSaveLabelText
            // 
            this.SuccessDeathSaveLabelText.AutoSize = true;
            this.SuccessDeathSaveLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessDeathSaveLabelText.Location = new System.Drawing.Point(4, 29);
            this.SuccessDeathSaveLabelText.Name = "SuccessDeathSaveLabelText";
            this.SuccessDeathSaveLabelText.Size = new System.Drawing.Size(44, 13);
            this.SuccessDeathSaveLabelText.TabIndex = 56;
            this.SuccessDeathSaveLabelText.Text = "Success";
            // 
            // FailureDeathSaveLabelText
            // 
            this.FailureDeathSaveLabelText.AutoSize = true;
            this.FailureDeathSaveLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FailureDeathSaveLabelText.Location = new System.Drawing.Point(4, 51);
            this.FailureDeathSaveLabelText.Name = "FailureDeathSaveLabelText";
            this.FailureDeathSaveLabelText.Size = new System.Drawing.Size(40, 13);
            this.FailureDeathSaveLabelText.TabIndex = 57;
            this.FailureDeathSaveLabelText.Text = "Failure";
            // 
            // WeaponsNameLabelText
            // 
            this.WeaponsNameLabelText.AutoSize = true;
            this.WeaponsNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponsNameLabelText.Location = new System.Drawing.Point(4, 5);
            this.WeaponsNameLabelText.Name = "WeaponsNameLabelText";
            this.WeaponsNameLabelText.Size = new System.Drawing.Size(35, 13);
            this.WeaponsNameLabelText.TabIndex = 58;
            this.WeaponsNameLabelText.Text = "Name";
            // 
            // WeaponsAttackBonusLabelText
            // 
            this.WeaponsAttackBonusLabelText.AutoSize = true;
            this.WeaponsAttackBonusLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponsAttackBonusLabelText.Location = new System.Drawing.Point(118, 5);
            this.WeaponsAttackBonusLabelText.Name = "WeaponsAttackBonusLabelText";
            this.WeaponsAttackBonusLabelText.Size = new System.Drawing.Size(27, 13);
            this.WeaponsAttackBonusLabelText.TabIndex = 59;
            this.WeaponsAttackBonusLabelText.Text = "+Atk";
            // 
            // WeaponsDamageLabelText
            // 
            this.WeaponsDamageLabelText.AutoSize = true;
            this.WeaponsDamageLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponsDamageLabelText.Location = new System.Drawing.Point(167, 5);
            this.WeaponsDamageLabelText.Name = "WeaponsDamageLabelText";
            this.WeaponsDamageLabelText.Size = new System.Drawing.Size(46, 13);
            this.WeaponsDamageLabelText.TabIndex = 60;
            this.WeaponsDamageLabelText.Text = "Damage";
            // 
            // AbilityScoresContainer
            // 
            this.AbilityScoresContainer.BackColor = System.Drawing.Color.LightGray;
            this.AbilityScoresContainer.Controls.Add(this.CharismaLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.CharismaContainer);
            this.AbilityScoresContainer.Controls.Add(this.WisdomLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.WisdomContainer);
            this.AbilityScoresContainer.Controls.Add(this.IntelligenceLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.IntelligenceContainer);
            this.AbilityScoresContainer.Controls.Add(this.ConstitutionLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.ConstitutionContainer);
            this.AbilityScoresContainer.Controls.Add(this.DexterityLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.DexterityContainer);
            this.AbilityScoresContainer.Controls.Add(this.StrengthLabelContainer);
            this.AbilityScoresContainer.Controls.Add(this.StrengthContainer);
            this.AbilityScoresContainer.Location = new System.Drawing.Point(8, 202);
            this.AbilityScoresContainer.Name = "AbilityScoresContainer";
            this.AbilityScoresContainer.Padding = new System.Windows.Forms.Padding(5);
            this.AbilityScoresContainer.Size = new System.Drawing.Size(103, 388);
            this.AbilityScoresContainer.TabIndex = 73;
            // 
            // CharismaLabelContainer
            // 
            this.CharismaLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CharismaLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CharismaLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.CharismaLabelContainer.Controls.Add(this.CharismaLabelText);
            this.CharismaLabelContainer.Location = new System.Drawing.Point(8, 323);
            this.CharismaLabelContainer.Name = "CharismaLabelContainer";
            this.CharismaLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.CharismaLabelContainer.TabIndex = 87;
            // 
            // CharismaLabelText
            // 
            this.CharismaLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharismaLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabelText.Location = new System.Drawing.Point(0, 0);
            this.CharismaLabelText.Name = "CharismaLabelText";
            this.CharismaLabelText.Size = new System.Drawing.Size(87, 23);
            this.CharismaLabelText.TabIndex = 8;
            this.CharismaLabelText.Text = "CHARISMA";
            this.CharismaLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharismaContainer
            // 
            this.CharismaContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CharismaContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CharismaContainer.BackColor = System.Drawing.Color.White;
            this.CharismaContainer.Controls.Add(this.CharismaValueTextBox);
            this.CharismaContainer.Controls.Add(this.CharismaModifierContainer);
            this.CharismaContainer.Location = new System.Drawing.Point(8, 323);
            this.CharismaContainer.Name = "CharismaContainer";
            this.CharismaContainer.Size = new System.Drawing.Size(87, 57);
            this.CharismaContainer.TabIndex = 88;
            // 
            // CharismaValueTextBox
            // 
            this.CharismaValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharismaValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.CharismaValueTextBox.Name = "CharismaValueTextBox";
            this.CharismaValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.CharismaValueTextBox.TabIndex = 81;
            this.CharismaValueTextBox.TabStop = false;
            this.CharismaValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharismaValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CharismaValueTextBox_KeyDown);
            this.CharismaValueTextBox.Leave += new System.EventHandler(this.CharismaValueTextBox_Leave);
            // 
            // CharismaModifierContainer
            // 
            this.CharismaModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CharismaModifierContainer.Controls.Add(this.CharismaModifierValueText);
            this.CharismaModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.CharismaModifierContainer.Name = "CharismaModifierContainer";
            this.CharismaModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.CharismaModifierContainer.TabIndex = 1;
            // 
            // CharismaModifierValueText
            // 
            this.CharismaModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.CharismaModifierValueText.Name = "CharismaModifierValueText";
            this.CharismaModifierValueText.Size = new System.Drawing.Size(43, 34);
            this.CharismaModifierValueText.TabIndex = 84;
            this.CharismaModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WisdomLabelContainer
            // 
            this.WisdomLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WisdomLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WisdomLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.WisdomLabelContainer.Controls.Add(this.WisdomLabelText);
            this.WisdomLabelContainer.Location = new System.Drawing.Point(8, 260);
            this.WisdomLabelContainer.Name = "WisdomLabelContainer";
            this.WisdomLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.WisdomLabelContainer.TabIndex = 85;
            // 
            // WisdomLabelText
            // 
            this.WisdomLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WisdomLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomLabelText.Location = new System.Drawing.Point(1, 0);
            this.WisdomLabelText.Name = "WisdomLabelText";
            this.WisdomLabelText.Size = new System.Drawing.Size(86, 23);
            this.WisdomLabelText.TabIndex = 8;
            this.WisdomLabelText.Text = "WISDOM";
            this.WisdomLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WisdomContainer
            // 
            this.WisdomContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WisdomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WisdomContainer.BackColor = System.Drawing.Color.White;
            this.WisdomContainer.Controls.Add(this.WisdomValueTextBox);
            this.WisdomContainer.Controls.Add(this.WisdomModifierContainer);
            this.WisdomContainer.Location = new System.Drawing.Point(8, 260);
            this.WisdomContainer.Name = "WisdomContainer";
            this.WisdomContainer.Size = new System.Drawing.Size(87, 57);
            this.WisdomContainer.TabIndex = 86;
            // 
            // WisdomValueTextBox
            // 
            this.WisdomValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WisdomValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.WisdomValueTextBox.Name = "WisdomValueTextBox";
            this.WisdomValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.WisdomValueTextBox.TabIndex = 81;
            this.WisdomValueTextBox.TabStop = false;
            this.WisdomValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WisdomValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WisdomValueTextBox_KeyDown);
            this.WisdomValueTextBox.Leave += new System.EventHandler(this.WisdomValueTextBox_Leave);
            // 
            // WisdomModifierContainer
            // 
            this.WisdomModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.WisdomModifierContainer.Controls.Add(this.WisdomModifierValueText);
            this.WisdomModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.WisdomModifierContainer.Name = "WisdomModifierContainer";
            this.WisdomModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.WisdomModifierContainer.TabIndex = 1;
            // 
            // WisdomModifierValueText
            // 
            this.WisdomModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.WisdomModifierValueText.Name = "WisdomModifierValueText";
            this.WisdomModifierValueText.Size = new System.Drawing.Size(42, 34);
            this.WisdomModifierValueText.TabIndex = 83;
            this.WisdomModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntelligenceLabelContainer
            // 
            this.IntelligenceLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntelligenceLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IntelligenceLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.IntelligenceLabelContainer.Controls.Add(this.IntelligenceLabelText);
            this.IntelligenceLabelContainer.Location = new System.Drawing.Point(8, 197);
            this.IntelligenceLabelContainer.Name = "IntelligenceLabelContainer";
            this.IntelligenceLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.IntelligenceLabelContainer.TabIndex = 83;
            // 
            // IntelligenceLabelText
            // 
            this.IntelligenceLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntelligenceLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceLabelText.Location = new System.Drawing.Point(1, 0);
            this.IntelligenceLabelText.Name = "IntelligenceLabelText";
            this.IntelligenceLabelText.Size = new System.Drawing.Size(86, 23);
            this.IntelligenceLabelText.TabIndex = 8;
            this.IntelligenceLabelText.Text = "INTELLIGENCE";
            this.IntelligenceLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntelligenceContainer
            // 
            this.IntelligenceContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntelligenceContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.IntelligenceContainer.BackColor = System.Drawing.Color.White;
            this.IntelligenceContainer.Controls.Add(this.IntelligenceValueTextBox);
            this.IntelligenceContainer.Controls.Add(this.IntelligenceModifierContainer);
            this.IntelligenceContainer.Location = new System.Drawing.Point(8, 197);
            this.IntelligenceContainer.Name = "IntelligenceContainer";
            this.IntelligenceContainer.Size = new System.Drawing.Size(87, 57);
            this.IntelligenceContainer.TabIndex = 84;
            // 
            // IntelligenceValueTextBox
            // 
            this.IntelligenceValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IntelligenceValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.IntelligenceValueTextBox.Name = "IntelligenceValueTextBox";
            this.IntelligenceValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.IntelligenceValueTextBox.TabIndex = 81;
            this.IntelligenceValueTextBox.TabStop = false;
            this.IntelligenceValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntelligenceValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IntelligenceValueTextBox_KeyDown);
            this.IntelligenceValueTextBox.Leave += new System.EventHandler(this.IntelligenceValueTextBox_Leave);
            // 
            // IntelligenceModifierContainer
            // 
            this.IntelligenceModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.IntelligenceModifierContainer.Controls.Add(this.IntelligenceModifierValueText);
            this.IntelligenceModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.IntelligenceModifierContainer.Name = "IntelligenceModifierContainer";
            this.IntelligenceModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.IntelligenceModifierContainer.TabIndex = 1;
            // 
            // IntelligenceModifierValueText
            // 
            this.IntelligenceModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.IntelligenceModifierValueText.Name = "IntelligenceModifierValueText";
            this.IntelligenceModifierValueText.Size = new System.Drawing.Size(42, 34);
            this.IntelligenceModifierValueText.TabIndex = 82;
            this.IntelligenceModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConstitutionLabelContainer
            // 
            this.ConstitutionLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConstitutionLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConstitutionLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ConstitutionLabelContainer.Controls.Add(this.ConstitutionLabelText);
            this.ConstitutionLabelContainer.Location = new System.Drawing.Point(8, 134);
            this.ConstitutionLabelContainer.Name = "ConstitutionLabelContainer";
            this.ConstitutionLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.ConstitutionLabelContainer.TabIndex = 81;
            // 
            // ConstitutionLabelText
            // 
            this.ConstitutionLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConstitutionLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionLabelText.Location = new System.Drawing.Point(0, 0);
            this.ConstitutionLabelText.Name = "ConstitutionLabelText";
            this.ConstitutionLabelText.Size = new System.Drawing.Size(87, 23);
            this.ConstitutionLabelText.TabIndex = 8;
            this.ConstitutionLabelText.Text = "CONSTITUTION";
            this.ConstitutionLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConstitutionContainer
            // 
            this.ConstitutionContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConstitutionContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConstitutionContainer.BackColor = System.Drawing.Color.White;
            this.ConstitutionContainer.Controls.Add(this.ConstitutionValueTextBox);
            this.ConstitutionContainer.Controls.Add(this.ConstitutionModifierContainer);
            this.ConstitutionContainer.Location = new System.Drawing.Point(8, 134);
            this.ConstitutionContainer.Name = "ConstitutionContainer";
            this.ConstitutionContainer.Size = new System.Drawing.Size(87, 57);
            this.ConstitutionContainer.TabIndex = 82;
            // 
            // ConstitutionValueTextBox
            // 
            this.ConstitutionValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConstitutionValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.ConstitutionValueTextBox.Name = "ConstitutionValueTextBox";
            this.ConstitutionValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.ConstitutionValueTextBox.TabIndex = 81;
            this.ConstitutionValueTextBox.TabStop = false;
            this.ConstitutionValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConstitutionValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConstitutionValueTextBox_KeyDown);
            this.ConstitutionValueTextBox.Leave += new System.EventHandler(this.ConstitutionValueTextBox_Leave);
            // 
            // ConstitutionModifierContainer
            // 
            this.ConstitutionModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ConstitutionModifierContainer.Controls.Add(this.ConstitutionModifierValueText);
            this.ConstitutionModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.ConstitutionModifierContainer.Name = "ConstitutionModifierContainer";
            this.ConstitutionModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.ConstitutionModifierContainer.TabIndex = 1;
            // 
            // ConstitutionModifierValueText
            // 
            this.ConstitutionModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.ConstitutionModifierValueText.Name = "ConstitutionModifierValueText";
            this.ConstitutionModifierValueText.Size = new System.Drawing.Size(42, 34);
            this.ConstitutionModifierValueText.TabIndex = 82;
            this.ConstitutionModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexterityLabelContainer
            // 
            this.DexterityLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DexterityLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DexterityLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.DexterityLabelContainer.Controls.Add(this.DexterityLabelText);
            this.DexterityLabelContainer.Location = new System.Drawing.Point(8, 71);
            this.DexterityLabelContainer.Name = "DexterityLabelContainer";
            this.DexterityLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.DexterityLabelContainer.TabIndex = 79;
            // 
            // DexterityLabelText
            // 
            this.DexterityLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexterityLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabelText.Location = new System.Drawing.Point(0, 0);
            this.DexterityLabelText.Name = "DexterityLabelText";
            this.DexterityLabelText.Size = new System.Drawing.Size(87, 23);
            this.DexterityLabelText.TabIndex = 8;
            this.DexterityLabelText.Text = "DEXTERITY";
            this.DexterityLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexterityContainer
            // 
            this.DexterityContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DexterityContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DexterityContainer.BackColor = System.Drawing.Color.White;
            this.DexterityContainer.Controls.Add(this.DexterityValueTextBox);
            this.DexterityContainer.Controls.Add(this.DexterityModifierContainer);
            this.DexterityContainer.Location = new System.Drawing.Point(8, 71);
            this.DexterityContainer.Name = "DexterityContainer";
            this.DexterityContainer.Size = new System.Drawing.Size(87, 57);
            this.DexterityContainer.TabIndex = 80;
            // 
            // DexterityValueTextBox
            // 
            this.DexterityValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DexterityValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.DexterityValueTextBox.Name = "DexterityValueTextBox";
            this.DexterityValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.DexterityValueTextBox.TabIndex = 81;
            this.DexterityValueTextBox.TabStop = false;
            this.DexterityValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DexterityValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DexterityValueTextBox_KeyDown);
            this.DexterityValueTextBox.Leave += new System.EventHandler(this.DexterityValueTextBox_Leave);
            // 
            // DexterityModifierContainer
            // 
            this.DexterityModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DexterityModifierContainer.Controls.Add(this.DexterityModifierValueText);
            this.DexterityModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.DexterityModifierContainer.Name = "DexterityModifierContainer";
            this.DexterityModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.DexterityModifierContainer.TabIndex = 1;
            // 
            // DexterityModifierValueText
            // 
            this.DexterityModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.DexterityModifierValueText.Name = "DexterityModifierValueText";
            this.DexterityModifierValueText.Size = new System.Drawing.Size(42, 34);
            this.DexterityModifierValueText.TabIndex = 81;
            this.DexterityModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthLabelContainer
            // 
            this.StrengthLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StrengthLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StrengthLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.StrengthLabelContainer.Controls.Add(this.StrengthLabelText);
            this.StrengthLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.StrengthLabelContainer.Name = "StrengthLabelContainer";
            this.StrengthLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.StrengthLabelContainer.TabIndex = 0;
            // 
            // StrengthContainer
            // 
            this.StrengthContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StrengthContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StrengthContainer.BackColor = System.Drawing.Color.White;
            this.StrengthContainer.Controls.Add(this.StrengthValueTextBox);
            this.StrengthContainer.Controls.Add(this.StrengthModifierContainer);
            this.StrengthContainer.Location = new System.Drawing.Point(8, 8);
            this.StrengthContainer.Name = "StrengthContainer";
            this.StrengthContainer.Size = new System.Drawing.Size(87, 57);
            this.StrengthContainer.TabIndex = 78;
            // 
            // StrengthValueTextBox
            // 
            this.StrengthValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StrengthValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthValueTextBox.Location = new System.Drawing.Point(2, 26);
            this.StrengthValueTextBox.Name = "StrengthValueTextBox";
            this.StrengthValueTextBox.Size = new System.Drawing.Size(41, 26);
            this.StrengthValueTextBox.TabIndex = 80;
            this.StrengthValueTextBox.TabStop = false;
            this.StrengthValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StrengthValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StrengthValueTextBox_KeyDown);
            this.StrengthValueTextBox.Leave += new System.EventHandler(this.StrengthValueTextBox_Leave);
            // 
            // StrengthModifierContainer
            // 
            this.StrengthModifierContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StrengthModifierContainer.Controls.Add(this.StrengthModifierValueText);
            this.StrengthModifierContainer.Location = new System.Drawing.Point(45, 23);
            this.StrengthModifierContainer.Name = "StrengthModifierContainer";
            this.StrengthModifierContainer.Size = new System.Drawing.Size(44, 34);
            this.StrengthModifierContainer.TabIndex = 0;
            // 
            // StrengthModifierValueText
            // 
            this.StrengthModifierValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthModifierValueText.Location = new System.Drawing.Point(0, 0);
            this.StrengthModifierValueText.Name = "StrengthModifierValueText";
            this.StrengthModifierValueText.Size = new System.Drawing.Size(42, 34);
            this.StrengthModifierValueText.TabIndex = 80;
            this.StrengthModifierValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InspirationContainer
            // 
            this.InspirationContainer.BackColor = System.Drawing.Color.LightGray;
            this.InspirationContainer.Controls.Add(this.InspirationValueContainer);
            this.InspirationContainer.Controls.Add(this.InspirationLabelContainer);
            this.InspirationContainer.Location = new System.Drawing.Point(118, 106);
            this.InspirationContainer.Name = "InspirationContainer";
            this.InspirationContainer.Padding = new System.Windows.Forms.Padding(5);
            this.InspirationContainer.Size = new System.Drawing.Size(199, 42);
            this.InspirationContainer.TabIndex = 74;
            // 
            // InspirationValueContainer
            // 
            this.InspirationValueContainer.BackColor = System.Drawing.Color.White;
            this.InspirationValueContainer.Controls.Add(this.InspirationValueTextBox);
            this.InspirationValueContainer.Location = new System.Drawing.Point(8, 8);
            this.InspirationValueContainer.Name = "InspirationValueContainer";
            this.InspirationValueContainer.Size = new System.Drawing.Size(33, 28);
            this.InspirationValueContainer.TabIndex = 15;
            // 
            // InspirationValueTextBox
            // 
            this.InspirationValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InspirationValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspirationValueTextBox.Location = new System.Drawing.Point(0, 4);
            this.InspirationValueTextBox.Name = "InspirationValueTextBox";
            this.InspirationValueTextBox.Size = new System.Drawing.Size(33, 20);
            this.InspirationValueTextBox.TabIndex = 80;
            this.InspirationValueTextBox.TabStop = false;
            this.InspirationValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InspirationValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InspirationValueTextBox_KeyDown);
            this.InspirationValueTextBox.Leave += new System.EventHandler(this.InspirationValueTextBox_Leave);
            // 
            // InspirationLabelContainer
            // 
            this.InspirationLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.InspirationLabelContainer.Controls.Add(this.InspirationLabelText);
            this.InspirationLabelContainer.Location = new System.Drawing.Point(37, 8);
            this.InspirationLabelContainer.Name = "InspirationLabelContainer";
            this.InspirationLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.InspirationLabelContainer.Size = new System.Drawing.Size(154, 28);
            this.InspirationLabelContainer.TabIndex = 9;
            // 
            // ProficiencyContainer
            // 
            this.ProficiencyContainer.BackColor = System.Drawing.Color.LightGray;
            this.ProficiencyContainer.Controls.Add(this.ProficiencyValueContainer);
            this.ProficiencyContainer.Controls.Add(this.ProficiencyLabelContainer);
            this.ProficiencyContainer.Location = new System.Drawing.Point(8, 106);
            this.ProficiencyContainer.Name = "ProficiencyContainer";
            this.ProficiencyContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ProficiencyContainer.Size = new System.Drawing.Size(103, 90);
            this.ProficiencyContainer.TabIndex = 75;
            // 
            // ProficiencyValueContainer
            // 
            this.ProficiencyValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ProficiencyValueContainer.Controls.Add(this.ProficiencyBonusValueText);
            this.ProficiencyValueContainer.Location = new System.Drawing.Point(8, 31);
            this.ProficiencyValueContainer.Name = "ProficiencyValueContainer";
            this.ProficiencyValueContainer.Size = new System.Drawing.Size(87, 51);
            this.ProficiencyValueContainer.TabIndex = 15;
            // 
            // ProficiencyBonusValueText
            // 
            this.ProficiencyBonusValueText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProficiencyBonusValueText.Location = new System.Drawing.Point(0, 0);
            this.ProficiencyBonusValueText.Name = "ProficiencyBonusValueText";
            this.ProficiencyBonusValueText.Size = new System.Drawing.Size(87, 51);
            this.ProficiencyBonusValueText.TabIndex = 0;
            this.ProficiencyBonusValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProficiencyLabelContainer
            // 
            this.ProficiencyLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ProficiencyLabelContainer.Controls.Add(this.ProficiencyLabelText);
            this.ProficiencyLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.ProficiencyLabelContainer.Name = "ProficiencyLabelContainer";
            this.ProficiencyLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ProficiencyLabelContainer.Size = new System.Drawing.Size(87, 23);
            this.ProficiencyLabelContainer.TabIndex = 9;
            // 
            // ProficiencyLabelText
            // 
            this.ProficiencyLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProficiencyLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProficiencyLabelText.Location = new System.Drawing.Point(0, 0);
            this.ProficiencyLabelText.Name = "ProficiencyLabelText";
            this.ProficiencyLabelText.Size = new System.Drawing.Size(87, 23);
            this.ProficiencyLabelText.TabIndex = 14;
            this.ProficiencyLabelText.Text = "PROFICIENCY";
            this.ProficiencyLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingThrowsContainer
            // 
            this.SavingThrowsContainer.BackColor = System.Drawing.Color.LightGray;
            this.SavingThrowsContainer.Controls.Add(this.CharismaSavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.WisdomSavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.IntelligenceSavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.ConstitutionSavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.DexteritySavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.StrengthSavingThrowProficiencyCheckbox);
            this.SavingThrowsContainer.Controls.Add(this.SavingThrowsValuesContainer);
            this.SavingThrowsContainer.Controls.Add(this.SavingThrowsLabelsContainer);
            this.SavingThrowsContainer.Location = new System.Drawing.Point(118, 154);
            this.SavingThrowsContainer.Name = "SavingThrowsContainer";
            this.SavingThrowsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SavingThrowsContainer.Size = new System.Drawing.Size(199, 126);
            this.SavingThrowsContainer.TabIndex = 76;
            // 
            // CharismaSavingThrowProficiencyCheckbox
            // 
            this.CharismaSavingThrowProficiencyCheckbox.AutoSize = true;
            this.CharismaSavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 98);
            this.CharismaSavingThrowProficiencyCheckbox.Name = "CharismaSavingThrowProficiencyCheckbox";
            this.CharismaSavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.CharismaSavingThrowProficiencyCheckbox.TabIndex = 21;
            this.CharismaSavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.CharismaSavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.CharismaSavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // WisdomSavingThrowProficiencyCheckbox
            // 
            this.WisdomSavingThrowProficiencyCheckbox.AutoSize = true;
            this.WisdomSavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 81);
            this.WisdomSavingThrowProficiencyCheckbox.Name = "WisdomSavingThrowProficiencyCheckbox";
            this.WisdomSavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.WisdomSavingThrowProficiencyCheckbox.TabIndex = 20;
            this.WisdomSavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.WisdomSavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.WisdomSavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // IntelligenceSavingThrowProficiencyCheckbox
            // 
            this.IntelligenceSavingThrowProficiencyCheckbox.AutoSize = true;
            this.IntelligenceSavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 65);
            this.IntelligenceSavingThrowProficiencyCheckbox.Name = "IntelligenceSavingThrowProficiencyCheckbox";
            this.IntelligenceSavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.IntelligenceSavingThrowProficiencyCheckbox.TabIndex = 19;
            this.IntelligenceSavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.IntelligenceSavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.IntelligenceSavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // ConstitutionSavingThrowProficiencyCheckbox
            // 
            this.ConstitutionSavingThrowProficiencyCheckbox.AutoSize = true;
            this.ConstitutionSavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 48);
            this.ConstitutionSavingThrowProficiencyCheckbox.Name = "ConstitutionSavingThrowProficiencyCheckbox";
            this.ConstitutionSavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ConstitutionSavingThrowProficiencyCheckbox.TabIndex = 18;
            this.ConstitutionSavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.ConstitutionSavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.ConstitutionSavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // DexteritySavingThrowProficiencyCheckbox
            // 
            this.DexteritySavingThrowProficiencyCheckbox.AutoSize = true;
            this.DexteritySavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 31);
            this.DexteritySavingThrowProficiencyCheckbox.Name = "DexteritySavingThrowProficiencyCheckbox";
            this.DexteritySavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.DexteritySavingThrowProficiencyCheckbox.TabIndex = 17;
            this.DexteritySavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.DexteritySavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.DexteritySavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // StrengthSavingThrowProficiencyCheckbox
            // 
            this.StrengthSavingThrowProficiencyCheckbox.AutoSize = true;
            this.StrengthSavingThrowProficiencyCheckbox.Location = new System.Drawing.Point(21, 14);
            this.StrengthSavingThrowProficiencyCheckbox.Name = "StrengthSavingThrowProficiencyCheckbox";
            this.StrengthSavingThrowProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.StrengthSavingThrowProficiencyCheckbox.TabIndex = 16;
            this.StrengthSavingThrowProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.StrengthSavingThrowProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.StrengthSavingThrowProficiencyCheckbox_CheckedChanged);
            // 
            // SavingThrowsValuesContainer
            // 
            this.SavingThrowsValuesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SavingThrowsValuesContainer.Controls.Add(this.CharismaSavingThrowValueText);
            this.SavingThrowsValuesContainer.Controls.Add(this.WisdomSavingThrowValueText);
            this.SavingThrowsValuesContainer.Controls.Add(this.IntelligenceSavingThrowValueText);
            this.SavingThrowsValuesContainer.Controls.Add(this.ConstitutionSavingThrowValueText);
            this.SavingThrowsValuesContainer.Controls.Add(this.DexteritySavingThrowValueText);
            this.SavingThrowsValuesContainer.Controls.Add(this.StrengthSavingThrowValueText);
            this.SavingThrowsValuesContainer.Location = new System.Drawing.Point(38, 8);
            this.SavingThrowsValuesContainer.Name = "SavingThrowsValuesContainer";
            this.SavingThrowsValuesContainer.Size = new System.Drawing.Size(31, 112);
            this.SavingThrowsValuesContainer.TabIndex = 15;
            // 
            // CharismaSavingThrowValueText
            // 
            this.CharismaSavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.CharismaSavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaSavingThrowValueText.Location = new System.Drawing.Point(0, 90);
            this.CharismaSavingThrowValueText.Name = "CharismaSavingThrowValueText";
            this.CharismaSavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.CharismaSavingThrowValueText.TabIndex = 83;
            this.CharismaSavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WisdomSavingThrowValueText
            // 
            this.WisdomSavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.WisdomSavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomSavingThrowValueText.Location = new System.Drawing.Point(0, 73);
            this.WisdomSavingThrowValueText.Name = "WisdomSavingThrowValueText";
            this.WisdomSavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.WisdomSavingThrowValueText.TabIndex = 83;
            this.WisdomSavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntelligenceSavingThrowValueText
            // 
            this.IntelligenceSavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.IntelligenceSavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceSavingThrowValueText.Location = new System.Drawing.Point(0, 56);
            this.IntelligenceSavingThrowValueText.Name = "IntelligenceSavingThrowValueText";
            this.IntelligenceSavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.IntelligenceSavingThrowValueText.TabIndex = 83;
            this.IntelligenceSavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConstitutionSavingThrowValueText
            // 
            this.ConstitutionSavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.ConstitutionSavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionSavingThrowValueText.Location = new System.Drawing.Point(0, 39);
            this.ConstitutionSavingThrowValueText.Name = "ConstitutionSavingThrowValueText";
            this.ConstitutionSavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.ConstitutionSavingThrowValueText.TabIndex = 83;
            this.ConstitutionSavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DexteritySavingThrowValueText
            // 
            this.DexteritySavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.DexteritySavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexteritySavingThrowValueText.Location = new System.Drawing.Point(0, 22);
            this.DexteritySavingThrowValueText.Name = "DexteritySavingThrowValueText";
            this.DexteritySavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.DexteritySavingThrowValueText.TabIndex = 83;
            this.DexteritySavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StrengthSavingThrowValueText
            // 
            this.StrengthSavingThrowValueText.BackColor = System.Drawing.Color.Transparent;
            this.StrengthSavingThrowValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthSavingThrowValueText.Location = new System.Drawing.Point(0, 5);
            this.StrengthSavingThrowValueText.Name = "StrengthSavingThrowValueText";
            this.StrengthSavingThrowValueText.Size = new System.Drawing.Size(31, 15);
            this.StrengthSavingThrowValueText.TabIndex = 83;
            this.StrengthSavingThrowValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavingThrowsLabelsContainer
            // 
            this.SavingThrowsLabelsContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.SavingThrowsLabelsContainer.Controls.Add(this.StrengthSavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Controls.Add(this.DexteritySavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Controls.Add(this.ConstitutionSavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Controls.Add(this.IntelligenceSavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Controls.Add(this.WisdomSavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Controls.Add(this.CharismaSavingThrowLabelText);
            this.SavingThrowsLabelsContainer.Location = new System.Drawing.Point(62, 8);
            this.SavingThrowsLabelsContainer.Name = "SavingThrowsLabelsContainer";
            this.SavingThrowsLabelsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SavingThrowsLabelsContainer.Size = new System.Drawing.Size(128, 112);
            this.SavingThrowsLabelsContainer.TabIndex = 9;
            // 
            // SkillsContainer
            // 
            this.SkillsContainer.BackColor = System.Drawing.Color.LightGray;
            this.SkillsContainer.Controls.Add(this.SurvivalExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.StealthExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.SleightOfHandExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.ReligionExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.PersuasionExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.PerformanceExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.PerceptionExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.NatureExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.MedicineExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.InvestigationExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.IntimidationExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.InsightExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.HistoryExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.DeceptionExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.AthleticsExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.ArcanaExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.AnimalHandlingExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.AcrobaticsExpertiseCheckbox);
            this.SkillsContainer.Controls.Add(this.SurvivalProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.StealthProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.SleightOfHandProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.ReligionProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.PersuasionProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.PerformanceProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.PerceptionProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.NatureProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.MedicineProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.InvestigationProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.IntimidationProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.InsightProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.HistoryProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.DeceptionProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.AthleticsProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.ArcanaProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.AnimalHandlingProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.AcrobaticsProficiencyCheckbox);
            this.SkillsContainer.Controls.Add(this.SkillsValuesContainer);
            this.SkillsContainer.Controls.Add(this.SkillsLabelsContainer);
            this.SkillsContainer.Location = new System.Drawing.Point(118, 286);
            this.SkillsContainer.Name = "SkillsContainer";
            this.SkillsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SkillsContainer.Size = new System.Drawing.Size(199, 333);
            this.SkillsContainer.TabIndex = 77;
            // 
            // SurvivalExpertiseCheckbox
            // 
            this.SurvivalExpertiseCheckbox.AutoSize = true;
            this.SurvivalExpertiseCheckbox.Location = new System.Drawing.Point(5, 304);
            this.SurvivalExpertiseCheckbox.Name = "SurvivalExpertiseCheckbox";
            this.SurvivalExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SurvivalExpertiseCheckbox.TabIndex = 51;
            this.SurvivalExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.SurvivalExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.SurvivalExpertiseCheckbox_CheckedChanged);
            // 
            // StealthExpertiseCheckbox
            // 
            this.StealthExpertiseCheckbox.AutoSize = true;
            this.StealthExpertiseCheckbox.Location = new System.Drawing.Point(5, 287);
            this.StealthExpertiseCheckbox.Name = "StealthExpertiseCheckbox";
            this.StealthExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.StealthExpertiseCheckbox.TabIndex = 50;
            this.StealthExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.StealthExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.StealthExpertiseCheckbox_CheckedChanged);
            // 
            // SleightOfHandExpertiseCheckbox
            // 
            this.SleightOfHandExpertiseCheckbox.AutoSize = true;
            this.SleightOfHandExpertiseCheckbox.Location = new System.Drawing.Point(5, 270);
            this.SleightOfHandExpertiseCheckbox.Name = "SleightOfHandExpertiseCheckbox";
            this.SleightOfHandExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SleightOfHandExpertiseCheckbox.TabIndex = 49;
            this.SleightOfHandExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.SleightOfHandExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.SleightOfHandExpertiseCheckbox_CheckedChanged);
            // 
            // ReligionExpertiseCheckbox
            // 
            this.ReligionExpertiseCheckbox.AutoSize = true;
            this.ReligionExpertiseCheckbox.Location = new System.Drawing.Point(5, 253);
            this.ReligionExpertiseCheckbox.Name = "ReligionExpertiseCheckbox";
            this.ReligionExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ReligionExpertiseCheckbox.TabIndex = 48;
            this.ReligionExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.ReligionExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.ReligionExpertiseCheckbox_CheckedChanged);
            // 
            // PersuasionExpertiseCheckbox
            // 
            this.PersuasionExpertiseCheckbox.AutoSize = true;
            this.PersuasionExpertiseCheckbox.Location = new System.Drawing.Point(5, 236);
            this.PersuasionExpertiseCheckbox.Name = "PersuasionExpertiseCheckbox";
            this.PersuasionExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PersuasionExpertiseCheckbox.TabIndex = 47;
            this.PersuasionExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.PersuasionExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.PersuasionExpertiseCheckbox_CheckedChanged);
            // 
            // PerformanceExpertiseCheckbox
            // 
            this.PerformanceExpertiseCheckbox.AutoSize = true;
            this.PerformanceExpertiseCheckbox.Location = new System.Drawing.Point(5, 219);
            this.PerformanceExpertiseCheckbox.Name = "PerformanceExpertiseCheckbox";
            this.PerformanceExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PerformanceExpertiseCheckbox.TabIndex = 46;
            this.PerformanceExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.PerformanceExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.PerformanceExpertiseCheckbox_CheckedChanged);
            // 
            // PerceptionExpertiseCheckbox
            // 
            this.PerceptionExpertiseCheckbox.AutoSize = true;
            this.PerceptionExpertiseCheckbox.Location = new System.Drawing.Point(5, 202);
            this.PerceptionExpertiseCheckbox.Name = "PerceptionExpertiseCheckbox";
            this.PerceptionExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PerceptionExpertiseCheckbox.TabIndex = 45;
            this.PerceptionExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.PerceptionExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.PerceptionExpertiseCheckbox_CheckedChanged);
            // 
            // NatureExpertiseCheckbox
            // 
            this.NatureExpertiseCheckbox.AutoSize = true;
            this.NatureExpertiseCheckbox.Location = new System.Drawing.Point(5, 185);
            this.NatureExpertiseCheckbox.Name = "NatureExpertiseCheckbox";
            this.NatureExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.NatureExpertiseCheckbox.TabIndex = 44;
            this.NatureExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.NatureExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.NatureExpertiseCheckbox_CheckedChanged);
            // 
            // MedicineExpertiseCheckbox
            // 
            this.MedicineExpertiseCheckbox.AutoSize = true;
            this.MedicineExpertiseCheckbox.Location = new System.Drawing.Point(5, 168);
            this.MedicineExpertiseCheckbox.Name = "MedicineExpertiseCheckbox";
            this.MedicineExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.MedicineExpertiseCheckbox.TabIndex = 43;
            this.MedicineExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.MedicineExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.MedicineExpertiseCheckbox_CheckedChanged);
            // 
            // InvestigationExpertiseCheckbox
            // 
            this.InvestigationExpertiseCheckbox.AutoSize = true;
            this.InvestigationExpertiseCheckbox.Location = new System.Drawing.Point(5, 151);
            this.InvestigationExpertiseCheckbox.Name = "InvestigationExpertiseCheckbox";
            this.InvestigationExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.InvestigationExpertiseCheckbox.TabIndex = 42;
            this.InvestigationExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.InvestigationExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.InvestigationExpertiseCheckbox_CheckedChanged);
            // 
            // IntimidationExpertiseCheckbox
            // 
            this.IntimidationExpertiseCheckbox.AutoSize = true;
            this.IntimidationExpertiseCheckbox.Location = new System.Drawing.Point(5, 134);
            this.IntimidationExpertiseCheckbox.Name = "IntimidationExpertiseCheckbox";
            this.IntimidationExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.IntimidationExpertiseCheckbox.TabIndex = 41;
            this.IntimidationExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.IntimidationExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.IntimidationExpertiseCheckbox_CheckedChanged);
            // 
            // InsightExpertiseCheckbox
            // 
            this.InsightExpertiseCheckbox.AutoSize = true;
            this.InsightExpertiseCheckbox.Location = new System.Drawing.Point(5, 117);
            this.InsightExpertiseCheckbox.Name = "InsightExpertiseCheckbox";
            this.InsightExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.InsightExpertiseCheckbox.TabIndex = 40;
            this.InsightExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.InsightExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.InsightExpertiseCheckbox_CheckedChanged);
            // 
            // HistoryExpertiseCheckbox
            // 
            this.HistoryExpertiseCheckbox.AutoSize = true;
            this.HistoryExpertiseCheckbox.Location = new System.Drawing.Point(5, 100);
            this.HistoryExpertiseCheckbox.Name = "HistoryExpertiseCheckbox";
            this.HistoryExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.HistoryExpertiseCheckbox.TabIndex = 39;
            this.HistoryExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.HistoryExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.HistoryExpertiseCheckbox_CheckedChanged);
            // 
            // DeceptionExpertiseCheckbox
            // 
            this.DeceptionExpertiseCheckbox.AutoSize = true;
            this.DeceptionExpertiseCheckbox.Location = new System.Drawing.Point(5, 83);
            this.DeceptionExpertiseCheckbox.Name = "DeceptionExpertiseCheckbox";
            this.DeceptionExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.DeceptionExpertiseCheckbox.TabIndex = 38;
            this.DeceptionExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.DeceptionExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.DeceptionExpertiseCheckbox_CheckedChanged);
            // 
            // AthleticsExpertiseCheckbox
            // 
            this.AthleticsExpertiseCheckbox.AutoSize = true;
            this.AthleticsExpertiseCheckbox.Location = new System.Drawing.Point(5, 66);
            this.AthleticsExpertiseCheckbox.Name = "AthleticsExpertiseCheckbox";
            this.AthleticsExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AthleticsExpertiseCheckbox.TabIndex = 37;
            this.AthleticsExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.AthleticsExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.AthleticsExpertiseCheckbox_CheckedChanged);
            // 
            // ArcanaExpertiseCheckbox
            // 
            this.ArcanaExpertiseCheckbox.AutoSize = true;
            this.ArcanaExpertiseCheckbox.Location = new System.Drawing.Point(5, 49);
            this.ArcanaExpertiseCheckbox.Name = "ArcanaExpertiseCheckbox";
            this.ArcanaExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ArcanaExpertiseCheckbox.TabIndex = 36;
            this.ArcanaExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.ArcanaExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.ArcanaExpertiseCheckbox_CheckedChanged);
            // 
            // AnimalHandlingExpertiseCheckbox
            // 
            this.AnimalHandlingExpertiseCheckbox.AutoSize = true;
            this.AnimalHandlingExpertiseCheckbox.Location = new System.Drawing.Point(5, 32);
            this.AnimalHandlingExpertiseCheckbox.Name = "AnimalHandlingExpertiseCheckbox";
            this.AnimalHandlingExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AnimalHandlingExpertiseCheckbox.TabIndex = 35;
            this.AnimalHandlingExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.AnimalHandlingExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.AnimalHandlingExpertiseCheckbox_CheckedChanged);
            // 
            // AcrobaticsExpertiseCheckbox
            // 
            this.AcrobaticsExpertiseCheckbox.AutoSize = true;
            this.AcrobaticsExpertiseCheckbox.Location = new System.Drawing.Point(5, 15);
            this.AcrobaticsExpertiseCheckbox.Name = "AcrobaticsExpertiseCheckbox";
            this.AcrobaticsExpertiseCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AcrobaticsExpertiseCheckbox.TabIndex = 34;
            this.AcrobaticsExpertiseCheckbox.UseVisualStyleBackColor = true;
            this.AcrobaticsExpertiseCheckbox.CheckedChanged += new System.EventHandler(this.AcrobaticsExpertiseCheckbox_CheckedChanged);
            // 
            // SurvivalProficiencyCheckbox
            // 
            this.SurvivalProficiencyCheckbox.AutoSize = true;
            this.SurvivalProficiencyCheckbox.Location = new System.Drawing.Point(20, 304);
            this.SurvivalProficiencyCheckbox.Name = "SurvivalProficiencyCheckbox";
            this.SurvivalProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SurvivalProficiencyCheckbox.TabIndex = 33;
            this.SurvivalProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.SurvivalProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.SurvivalProficiencyCheckbox_CheckedChanged);
            // 
            // StealthProficiencyCheckbox
            // 
            this.StealthProficiencyCheckbox.AutoSize = true;
            this.StealthProficiencyCheckbox.Location = new System.Drawing.Point(20, 287);
            this.StealthProficiencyCheckbox.Name = "StealthProficiencyCheckbox";
            this.StealthProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.StealthProficiencyCheckbox.TabIndex = 32;
            this.StealthProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.StealthProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.StealthProficiencyCheckbox_CheckedChanged);
            // 
            // SleightOfHandProficiencyCheckbox
            // 
            this.SleightOfHandProficiencyCheckbox.AutoSize = true;
            this.SleightOfHandProficiencyCheckbox.Location = new System.Drawing.Point(20, 270);
            this.SleightOfHandProficiencyCheckbox.Name = "SleightOfHandProficiencyCheckbox";
            this.SleightOfHandProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.SleightOfHandProficiencyCheckbox.TabIndex = 31;
            this.SleightOfHandProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.SleightOfHandProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.SleightOfHandProficiencyCheckbox_CheckedChanged);
            // 
            // ReligionProficiencyCheckbox
            // 
            this.ReligionProficiencyCheckbox.AutoSize = true;
            this.ReligionProficiencyCheckbox.Location = new System.Drawing.Point(20, 253);
            this.ReligionProficiencyCheckbox.Name = "ReligionProficiencyCheckbox";
            this.ReligionProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ReligionProficiencyCheckbox.TabIndex = 30;
            this.ReligionProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.ReligionProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.ReligionProficiencyCheckbox_CheckedChanged);
            // 
            // PersuasionProficiencyCheckbox
            // 
            this.PersuasionProficiencyCheckbox.AutoSize = true;
            this.PersuasionProficiencyCheckbox.Location = new System.Drawing.Point(20, 236);
            this.PersuasionProficiencyCheckbox.Name = "PersuasionProficiencyCheckbox";
            this.PersuasionProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PersuasionProficiencyCheckbox.TabIndex = 29;
            this.PersuasionProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.PersuasionProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.PersuasionProficiencyCheckbox_CheckedChanged);
            // 
            // PerformanceProficiencyCheckbox
            // 
            this.PerformanceProficiencyCheckbox.AutoSize = true;
            this.PerformanceProficiencyCheckbox.Location = new System.Drawing.Point(20, 219);
            this.PerformanceProficiencyCheckbox.Name = "PerformanceProficiencyCheckbox";
            this.PerformanceProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PerformanceProficiencyCheckbox.TabIndex = 28;
            this.PerformanceProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.PerformanceProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.PerformanceProficiencyCheckbox_CheckedChanged);
            // 
            // PerceptionProficiencyCheckbox
            // 
            this.PerceptionProficiencyCheckbox.AutoSize = true;
            this.PerceptionProficiencyCheckbox.Location = new System.Drawing.Point(20, 202);
            this.PerceptionProficiencyCheckbox.Name = "PerceptionProficiencyCheckbox";
            this.PerceptionProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.PerceptionProficiencyCheckbox.TabIndex = 27;
            this.PerceptionProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.PerceptionProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.PerceptionProficiencyCheckbox_CheckedChanged);
            // 
            // NatureProficiencyCheckbox
            // 
            this.NatureProficiencyCheckbox.AutoSize = true;
            this.NatureProficiencyCheckbox.Location = new System.Drawing.Point(20, 185);
            this.NatureProficiencyCheckbox.Name = "NatureProficiencyCheckbox";
            this.NatureProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.NatureProficiencyCheckbox.TabIndex = 26;
            this.NatureProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.NatureProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.NatureProficiencyCheckbox_CheckedChanged);
            // 
            // MedicineProficiencyCheckbox
            // 
            this.MedicineProficiencyCheckbox.AutoSize = true;
            this.MedicineProficiencyCheckbox.Location = new System.Drawing.Point(20, 168);
            this.MedicineProficiencyCheckbox.Name = "MedicineProficiencyCheckbox";
            this.MedicineProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.MedicineProficiencyCheckbox.TabIndex = 25;
            this.MedicineProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.MedicineProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.MedicineProficiencyCheckbox_CheckedChanged);
            // 
            // InvestigationProficiencyCheckbox
            // 
            this.InvestigationProficiencyCheckbox.AutoSize = true;
            this.InvestigationProficiencyCheckbox.Location = new System.Drawing.Point(20, 151);
            this.InvestigationProficiencyCheckbox.Name = "InvestigationProficiencyCheckbox";
            this.InvestigationProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.InvestigationProficiencyCheckbox.TabIndex = 24;
            this.InvestigationProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.InvestigationProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.InvestigationProficiencyCheckbox_CheckedChanged);
            // 
            // IntimidationProficiencyCheckbox
            // 
            this.IntimidationProficiencyCheckbox.AutoSize = true;
            this.IntimidationProficiencyCheckbox.Location = new System.Drawing.Point(20, 134);
            this.IntimidationProficiencyCheckbox.Name = "IntimidationProficiencyCheckbox";
            this.IntimidationProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.IntimidationProficiencyCheckbox.TabIndex = 23;
            this.IntimidationProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.IntimidationProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.IntimidationProficiencyCheckbox_CheckedChanged);
            // 
            // InsightProficiencyCheckbox
            // 
            this.InsightProficiencyCheckbox.AutoSize = true;
            this.InsightProficiencyCheckbox.Location = new System.Drawing.Point(20, 117);
            this.InsightProficiencyCheckbox.Name = "InsightProficiencyCheckbox";
            this.InsightProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.InsightProficiencyCheckbox.TabIndex = 22;
            this.InsightProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.InsightProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.InsightProficiencyCheckbox_CheckedChanged);
            // 
            // HistoryProficiencyCheckbox
            // 
            this.HistoryProficiencyCheckbox.AutoSize = true;
            this.HistoryProficiencyCheckbox.Location = new System.Drawing.Point(20, 100);
            this.HistoryProficiencyCheckbox.Name = "HistoryProficiencyCheckbox";
            this.HistoryProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.HistoryProficiencyCheckbox.TabIndex = 21;
            this.HistoryProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.HistoryProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.HistoryProficiencyCheckbox_CheckedChanged);
            // 
            // DeceptionProficiencyCheckbox
            // 
            this.DeceptionProficiencyCheckbox.AutoSize = true;
            this.DeceptionProficiencyCheckbox.Location = new System.Drawing.Point(20, 83);
            this.DeceptionProficiencyCheckbox.Name = "DeceptionProficiencyCheckbox";
            this.DeceptionProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.DeceptionProficiencyCheckbox.TabIndex = 20;
            this.DeceptionProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.DeceptionProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.DeceptionProficiencyCheckbox_CheckedChanged);
            // 
            // AthleticsProficiencyCheckbox
            // 
            this.AthleticsProficiencyCheckbox.AutoSize = true;
            this.AthleticsProficiencyCheckbox.Location = new System.Drawing.Point(20, 66);
            this.AthleticsProficiencyCheckbox.Name = "AthleticsProficiencyCheckbox";
            this.AthleticsProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AthleticsProficiencyCheckbox.TabIndex = 19;
            this.AthleticsProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.AthleticsProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.AthleticsProficiencyCheckbox_CheckedChanged);
            // 
            // ArcanaProficiencyCheckbox
            // 
            this.ArcanaProficiencyCheckbox.AutoSize = true;
            this.ArcanaProficiencyCheckbox.Location = new System.Drawing.Point(20, 49);
            this.ArcanaProficiencyCheckbox.Name = "ArcanaProficiencyCheckbox";
            this.ArcanaProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.ArcanaProficiencyCheckbox.TabIndex = 18;
            this.ArcanaProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.ArcanaProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.ArcanaProficiencyCheckbox_CheckedChanged);
            // 
            // AnimalHandlingProficiencyCheckbox
            // 
            this.AnimalHandlingProficiencyCheckbox.AutoSize = true;
            this.AnimalHandlingProficiencyCheckbox.Location = new System.Drawing.Point(20, 32);
            this.AnimalHandlingProficiencyCheckbox.Name = "AnimalHandlingProficiencyCheckbox";
            this.AnimalHandlingProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AnimalHandlingProficiencyCheckbox.TabIndex = 17;
            this.AnimalHandlingProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.AnimalHandlingProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.AnimalHandlingProficiencyCheckbox_CheckedChanged);
            // 
            // AcrobaticsProficiencyCheckbox
            // 
            this.AcrobaticsProficiencyCheckbox.AutoSize = true;
            this.AcrobaticsProficiencyCheckbox.Location = new System.Drawing.Point(20, 15);
            this.AcrobaticsProficiencyCheckbox.Name = "AcrobaticsProficiencyCheckbox";
            this.AcrobaticsProficiencyCheckbox.Size = new System.Drawing.Size(15, 14);
            this.AcrobaticsProficiencyCheckbox.TabIndex = 16;
            this.AcrobaticsProficiencyCheckbox.UseVisualStyleBackColor = true;
            this.AcrobaticsProficiencyCheckbox.CheckedChanged += new System.EventHandler(this.AcrobaticsProficiencyCheckbox_CheckedChanged);
            // 
            // SkillsValuesContainer
            // 
            this.SkillsValuesContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SkillsValuesContainer.Controls.Add(this.SurvivalValueText);
            this.SkillsValuesContainer.Controls.Add(this.StealthValueText);
            this.SkillsValuesContainer.Controls.Add(this.SleightOfHandValueText);
            this.SkillsValuesContainer.Controls.Add(this.ReligionValueText);
            this.SkillsValuesContainer.Controls.Add(this.PersuasionValueText);
            this.SkillsValuesContainer.Controls.Add(this.PerformanceValueText);
            this.SkillsValuesContainer.Controls.Add(this.PerceptionValueText);
            this.SkillsValuesContainer.Controls.Add(this.NatureValueText);
            this.SkillsValuesContainer.Controls.Add(this.MedicineValueText);
            this.SkillsValuesContainer.Controls.Add(this.InvestigationValueText);
            this.SkillsValuesContainer.Controls.Add(this.IntimidationValueText);
            this.SkillsValuesContainer.Controls.Add(this.InsightValueText);
            this.SkillsValuesContainer.Controls.Add(this.HistoryValueText);
            this.SkillsValuesContainer.Controls.Add(this.DeceptionValueText);
            this.SkillsValuesContainer.Controls.Add(this.AthleticsValueText);
            this.SkillsValuesContainer.Controls.Add(this.ArcanaValueText);
            this.SkillsValuesContainer.Controls.Add(this.AnimalHandlingValueText);
            this.SkillsValuesContainer.Controls.Add(this.AcrobaticsValueText);
            this.SkillsValuesContainer.Location = new System.Drawing.Point(38, 8);
            this.SkillsValuesContainer.Name = "SkillsValuesContainer";
            this.SkillsValuesContainer.Size = new System.Drawing.Size(31, 317);
            this.SkillsValuesContainer.TabIndex = 15;
            // 
            // SurvivalValueText
            // 
            this.SurvivalValueText.BackColor = System.Drawing.Color.Transparent;
            this.SurvivalValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurvivalValueText.Location = new System.Drawing.Point(0, 295);
            this.SurvivalValueText.Name = "SurvivalValueText";
            this.SurvivalValueText.Size = new System.Drawing.Size(31, 15);
            this.SurvivalValueText.TabIndex = 82;
            this.SurvivalValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StealthValueText
            // 
            this.StealthValueText.BackColor = System.Drawing.Color.Transparent;
            this.StealthValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StealthValueText.Location = new System.Drawing.Point(0, 278);
            this.StealthValueText.Name = "StealthValueText";
            this.StealthValueText.Size = new System.Drawing.Size(31, 15);
            this.StealthValueText.TabIndex = 82;
            this.StealthValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SleightOfHandValueText
            // 
            this.SleightOfHandValueText.BackColor = System.Drawing.Color.Transparent;
            this.SleightOfHandValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SleightOfHandValueText.Location = new System.Drawing.Point(0, 260);
            this.SleightOfHandValueText.Name = "SleightOfHandValueText";
            this.SleightOfHandValueText.Size = new System.Drawing.Size(31, 15);
            this.SleightOfHandValueText.TabIndex = 82;
            this.SleightOfHandValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReligionValueText
            // 
            this.ReligionValueText.BackColor = System.Drawing.Color.Transparent;
            this.ReligionValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReligionValueText.Location = new System.Drawing.Point(0, 244);
            this.ReligionValueText.Name = "ReligionValueText";
            this.ReligionValueText.Size = new System.Drawing.Size(31, 15);
            this.ReligionValueText.TabIndex = 82;
            this.ReligionValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersuasionValueText
            // 
            this.PersuasionValueText.BackColor = System.Drawing.Color.Transparent;
            this.PersuasionValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersuasionValueText.Location = new System.Drawing.Point(0, 227);
            this.PersuasionValueText.Name = "PersuasionValueText";
            this.PersuasionValueText.Size = new System.Drawing.Size(31, 15);
            this.PersuasionValueText.TabIndex = 82;
            this.PersuasionValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerformanceValueText
            // 
            this.PerformanceValueText.BackColor = System.Drawing.Color.Transparent;
            this.PerformanceValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformanceValueText.Location = new System.Drawing.Point(0, 209);
            this.PerformanceValueText.Name = "PerformanceValueText";
            this.PerformanceValueText.Size = new System.Drawing.Size(31, 15);
            this.PerformanceValueText.TabIndex = 82;
            this.PerformanceValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PerceptionValueText
            // 
            this.PerceptionValueText.BackColor = System.Drawing.Color.Transparent;
            this.PerceptionValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerceptionValueText.Location = new System.Drawing.Point(0, 193);
            this.PerceptionValueText.Name = "PerceptionValueText";
            this.PerceptionValueText.Size = new System.Drawing.Size(31, 15);
            this.PerceptionValueText.TabIndex = 82;
            this.PerceptionValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NatureValueText
            // 
            this.NatureValueText.BackColor = System.Drawing.Color.Transparent;
            this.NatureValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NatureValueText.Location = new System.Drawing.Point(0, 176);
            this.NatureValueText.Name = "NatureValueText";
            this.NatureValueText.Size = new System.Drawing.Size(31, 15);
            this.NatureValueText.TabIndex = 82;
            this.NatureValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicineValueText
            // 
            this.MedicineValueText.BackColor = System.Drawing.Color.Transparent;
            this.MedicineValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineValueText.Location = new System.Drawing.Point(0, 159);
            this.MedicineValueText.Name = "MedicineValueText";
            this.MedicineValueText.Size = new System.Drawing.Size(31, 15);
            this.MedicineValueText.TabIndex = 82;
            this.MedicineValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InvestigationValueText
            // 
            this.InvestigationValueText.BackColor = System.Drawing.Color.Transparent;
            this.InvestigationValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvestigationValueText.Location = new System.Drawing.Point(0, 142);
            this.InvestigationValueText.Name = "InvestigationValueText";
            this.InvestigationValueText.Size = new System.Drawing.Size(31, 15);
            this.InvestigationValueText.TabIndex = 82;
            this.InvestigationValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntimidationValueText
            // 
            this.IntimidationValueText.BackColor = System.Drawing.Color.Transparent;
            this.IntimidationValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntimidationValueText.Location = new System.Drawing.Point(0, 125);
            this.IntimidationValueText.Name = "IntimidationValueText";
            this.IntimidationValueText.Size = new System.Drawing.Size(31, 15);
            this.IntimidationValueText.TabIndex = 82;
            this.IntimidationValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InsightValueText
            // 
            this.InsightValueText.BackColor = System.Drawing.Color.Transparent;
            this.InsightValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsightValueText.Location = new System.Drawing.Point(0, 108);
            this.InsightValueText.Name = "InsightValueText";
            this.InsightValueText.Size = new System.Drawing.Size(31, 15);
            this.InsightValueText.TabIndex = 82;
            this.InsightValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryValueText
            // 
            this.HistoryValueText.BackColor = System.Drawing.Color.Transparent;
            this.HistoryValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryValueText.Location = new System.Drawing.Point(0, 91);
            this.HistoryValueText.Name = "HistoryValueText";
            this.HistoryValueText.Size = new System.Drawing.Size(31, 15);
            this.HistoryValueText.TabIndex = 82;
            this.HistoryValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeceptionValueText
            // 
            this.DeceptionValueText.BackColor = System.Drawing.Color.Transparent;
            this.DeceptionValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeceptionValueText.Location = new System.Drawing.Point(0, 74);
            this.DeceptionValueText.Name = "DeceptionValueText";
            this.DeceptionValueText.Size = new System.Drawing.Size(31, 15);
            this.DeceptionValueText.TabIndex = 82;
            this.DeceptionValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AthleticsValueText
            // 
            this.AthleticsValueText.BackColor = System.Drawing.Color.Transparent;
            this.AthleticsValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AthleticsValueText.Location = new System.Drawing.Point(0, 57);
            this.AthleticsValueText.Name = "AthleticsValueText";
            this.AthleticsValueText.Size = new System.Drawing.Size(31, 15);
            this.AthleticsValueText.TabIndex = 82;
            this.AthleticsValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArcanaValueText
            // 
            this.ArcanaValueText.BackColor = System.Drawing.Color.Transparent;
            this.ArcanaValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArcanaValueText.Location = new System.Drawing.Point(0, 40);
            this.ArcanaValueText.Name = "ArcanaValueText";
            this.ArcanaValueText.Size = new System.Drawing.Size(31, 15);
            this.ArcanaValueText.TabIndex = 82;
            this.ArcanaValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnimalHandlingValueText
            // 
            this.AnimalHandlingValueText.BackColor = System.Drawing.Color.Transparent;
            this.AnimalHandlingValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalHandlingValueText.Location = new System.Drawing.Point(0, 23);
            this.AnimalHandlingValueText.Name = "AnimalHandlingValueText";
            this.AnimalHandlingValueText.Size = new System.Drawing.Size(31, 15);
            this.AnimalHandlingValueText.TabIndex = 82;
            this.AnimalHandlingValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AcrobaticsValueText
            // 
            this.AcrobaticsValueText.BackColor = System.Drawing.Color.Transparent;
            this.AcrobaticsValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcrobaticsValueText.Location = new System.Drawing.Point(0, 6);
            this.AcrobaticsValueText.Name = "AcrobaticsValueText";
            this.AcrobaticsValueText.Size = new System.Drawing.Size(31, 15);
            this.AcrobaticsValueText.TabIndex = 82;
            this.AcrobaticsValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillsLabelsContainer
            // 
            this.SkillsLabelsContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.SkillsLabelsContainer.Controls.Add(this.ChaTipFour);
            this.SkillsLabelsContainer.Controls.Add(this.ChaTipThree);
            this.SkillsLabelsContainer.Controls.Add(this.ChaTipTwo);
            this.SkillsLabelsContainer.Controls.Add(this.ChaTipOne);
            this.SkillsLabelsContainer.Controls.Add(this.StrTipOne);
            this.SkillsLabelsContainer.Controls.Add(this.IntTipFive);
            this.SkillsLabelsContainer.Controls.Add(this.IntTipFour);
            this.SkillsLabelsContainer.Controls.Add(this.IntTipThree);
            this.SkillsLabelsContainer.Controls.Add(this.IntTipTwo);
            this.SkillsLabelsContainer.Controls.Add(this.IntTipOne);
            this.SkillsLabelsContainer.Controls.Add(this.WisTipFive);
            this.SkillsLabelsContainer.Controls.Add(this.WisTipFour);
            this.SkillsLabelsContainer.Controls.Add(this.WisTipThree);
            this.SkillsLabelsContainer.Controls.Add(this.WisTipTwo);
            this.SkillsLabelsContainer.Controls.Add(this.WisTipOne);
            this.SkillsLabelsContainer.Controls.Add(this.DexTipThree);
            this.SkillsLabelsContainer.Controls.Add(this.DexTipTwo);
            this.SkillsLabelsContainer.Controls.Add(this.DexTipOne);
            this.SkillsLabelsContainer.Controls.Add(this.AcrobaticsLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.AnimalHandlingLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.ArcanaLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.AthleticsLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.DeceptionLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.HistoryLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.InsightLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.IntimidationLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.InvestigationLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.MedicineLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.NatureLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.PerceptionLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.PerformanceLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.PersuasionLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.ReligionLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.SleightOfHandLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.StealthLabelText);
            this.SkillsLabelsContainer.Controls.Add(this.SurvivalLabelText);
            this.SkillsLabelsContainer.Location = new System.Drawing.Point(62, 8);
            this.SkillsLabelsContainer.Name = "SkillsLabelsContainer";
            this.SkillsLabelsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SkillsLabelsContainer.Size = new System.Drawing.Size(128, 317);
            this.SkillsLabelsContainer.TabIndex = 9;
            // 
            // ChaTipFour
            // 
            this.ChaTipFour.AutoSize = true;
            this.ChaTipFour.ForeColor = System.Drawing.Color.White;
            this.ChaTipFour.Location = new System.Drawing.Point(70, 228);
            this.ChaTipFour.Name = "ChaTipFour";
            this.ChaTipFour.Size = new System.Drawing.Size(31, 13);
            this.ChaTipFour.TabIndex = 63;
            this.ChaTipFour.Text = "(Cha)";
            // 
            // ChaTipThree
            // 
            this.ChaTipThree.AutoSize = true;
            this.ChaTipThree.ForeColor = System.Drawing.Color.White;
            this.ChaTipThree.Location = new System.Drawing.Point(78, 211);
            this.ChaTipThree.Name = "ChaTipThree";
            this.ChaTipThree.Size = new System.Drawing.Size(31, 13);
            this.ChaTipThree.TabIndex = 62;
            this.ChaTipThree.Text = "(Cha)";
            // 
            // ChaTipTwo
            // 
            this.ChaTipTwo.AutoSize = true;
            this.ChaTipTwo.ForeColor = System.Drawing.Color.White;
            this.ChaTipTwo.Location = new System.Drawing.Point(74, 126);
            this.ChaTipTwo.Name = "ChaTipTwo";
            this.ChaTipTwo.Size = new System.Drawing.Size(31, 13);
            this.ChaTipTwo.TabIndex = 61;
            this.ChaTipTwo.Text = "(Cha)";
            // 
            // ChaTipOne
            // 
            this.ChaTipOne.AutoSize = true;
            this.ChaTipOne.ForeColor = System.Drawing.Color.White;
            this.ChaTipOne.Location = new System.Drawing.Point(65, 75);
            this.ChaTipOne.Name = "ChaTipOne";
            this.ChaTipOne.Size = new System.Drawing.Size(31, 13);
            this.ChaTipOne.TabIndex = 60;
            this.ChaTipOne.Text = "(Cha)";
            // 
            // StrTipOne
            // 
            this.StrTipOne.AutoSize = true;
            this.StrTipOne.ForeColor = System.Drawing.Color.White;
            this.StrTipOne.Location = new System.Drawing.Point(58, 58);
            this.StrTipOne.Name = "StrTipOne";
            this.StrTipOne.Size = new System.Drawing.Size(26, 13);
            this.StrTipOne.TabIndex = 59;
            this.StrTipOne.Text = "(Str)";
            // 
            // IntTipFive
            // 
            this.IntTipFive.AutoSize = true;
            this.IntTipFive.ForeColor = System.Drawing.Color.White;
            this.IntTipFive.Location = new System.Drawing.Point(55, 245);
            this.IntTipFive.Name = "IntTipFive";
            this.IntTipFive.Size = new System.Drawing.Size(26, 13);
            this.IntTipFive.TabIndex = 58;
            this.IntTipFive.Text = "(Int)";
            // 
            // IntTipFour
            // 
            this.IntTipFour.AutoSize = true;
            this.IntTipFour.ForeColor = System.Drawing.Color.White;
            this.IntTipFour.Location = new System.Drawing.Point(50, 177);
            this.IntTipFour.Name = "IntTipFour";
            this.IntTipFour.Size = new System.Drawing.Size(26, 13);
            this.IntTipFour.TabIndex = 57;
            this.IntTipFour.Text = "(Int)";
            // 
            // IntTipThree
            // 
            this.IntTipThree.AutoSize = true;
            this.IntTipThree.ForeColor = System.Drawing.Color.White;
            this.IntTipThree.Location = new System.Drawing.Point(77, 143);
            this.IntTipThree.Name = "IntTipThree";
            this.IntTipThree.Size = new System.Drawing.Size(26, 13);
            this.IntTipThree.TabIndex = 56;
            this.IntTipThree.Text = "(Int)";
            // 
            // IntTipTwo
            // 
            this.IntTipTwo.AutoSize = true;
            this.IntTipTwo.ForeColor = System.Drawing.Color.White;
            this.IntTipTwo.Location = new System.Drawing.Point(51, 92);
            this.IntTipTwo.Name = "IntTipTwo";
            this.IntTipTwo.Size = new System.Drawing.Size(26, 13);
            this.IntTipTwo.TabIndex = 55;
            this.IntTipTwo.Text = "(Int)";
            // 
            // IntTipOne
            // 
            this.IntTipOne.AutoSize = true;
            this.IntTipOne.ForeColor = System.Drawing.Color.White;
            this.IntTipOne.Location = new System.Drawing.Point(50, 41);
            this.IntTipOne.Name = "IntTipOne";
            this.IntTipOne.Size = new System.Drawing.Size(26, 13);
            this.IntTipOne.TabIndex = 54;
            this.IntTipOne.Text = "(Int)";
            // 
            // WisTipFive
            // 
            this.WisTipFive.AutoSize = true;
            this.WisTipFive.ForeColor = System.Drawing.Color.White;
            this.WisTipFive.Location = new System.Drawing.Point(54, 296);
            this.WisTipFive.Name = "WisTipFive";
            this.WisTipFive.Size = new System.Drawing.Size(31, 13);
            this.WisTipFive.TabIndex = 53;
            this.WisTipFive.Text = "(Wis)";
            // 
            // WisTipFour
            // 
            this.WisTipFour.AutoSize = true;
            this.WisTipFour.ForeColor = System.Drawing.Color.White;
            this.WisTipFour.Location = new System.Drawing.Point(68, 194);
            this.WisTipFour.Name = "WisTipFour";
            this.WisTipFour.Size = new System.Drawing.Size(31, 13);
            this.WisTipFour.TabIndex = 52;
            this.WisTipFour.Text = "(Wis)";
            // 
            // WisTipThree
            // 
            this.WisTipThree.AutoSize = true;
            this.WisTipThree.ForeColor = System.Drawing.Color.White;
            this.WisTipThree.Location = new System.Drawing.Point(61, 160);
            this.WisTipThree.Name = "WisTipThree";
            this.WisTipThree.Size = new System.Drawing.Size(31, 13);
            this.WisTipThree.TabIndex = 51;
            this.WisTipThree.Text = "(Wis)";
            // 
            // WisTipTwo
            // 
            this.WisTipTwo.AutoSize = true;
            this.WisTipTwo.ForeColor = System.Drawing.Color.White;
            this.WisTipTwo.Location = new System.Drawing.Point(49, 109);
            this.WisTipTwo.Name = "WisTipTwo";
            this.WisTipTwo.Size = new System.Drawing.Size(31, 13);
            this.WisTipTwo.TabIndex = 50;
            this.WisTipTwo.Text = "(Wis)";
            // 
            // WisTipOne
            // 
            this.WisTipOne.AutoSize = true;
            this.WisTipOne.ForeColor = System.Drawing.Color.White;
            this.WisTipOne.Location = new System.Drawing.Point(95, 24);
            this.WisTipOne.Name = "WisTipOne";
            this.WisTipOne.Size = new System.Drawing.Size(31, 13);
            this.WisTipOne.TabIndex = 49;
            this.WisTipOne.Text = "(Wis)";
            // 
            // DexTipThree
            // 
            this.DexTipThree.AutoSize = true;
            this.DexTipThree.ForeColor = System.Drawing.Color.White;
            this.DexTipThree.Location = new System.Drawing.Point(51, 278);
            this.DexTipThree.Name = "DexTipThree";
            this.DexTipThree.Size = new System.Drawing.Size(31, 13);
            this.DexTipThree.TabIndex = 48;
            this.DexTipThree.Text = "(Dex)";
            // 
            // DexTipTwo
            // 
            this.DexTipTwo.AutoSize = true;
            this.DexTipTwo.ForeColor = System.Drawing.Color.White;
            this.DexTipTwo.Location = new System.Drawing.Point(88, 261);
            this.DexTipTwo.Name = "DexTipTwo";
            this.DexTipTwo.Size = new System.Drawing.Size(31, 13);
            this.DexTipTwo.TabIndex = 47;
            this.DexTipTwo.Text = "(Dex)";
            // 
            // DexTipOne
            // 
            this.DexTipOne.AutoSize = true;
            this.DexTipOne.ForeColor = System.Drawing.Color.White;
            this.DexTipOne.Location = new System.Drawing.Point(66, 7);
            this.DexTipOne.Name = "DexTipOne";
            this.DexTipOne.Size = new System.Drawing.Size(31, 13);
            this.DexTipOne.TabIndex = 46;
            this.DexTipOne.Text = "(Dex)";
            // 
            // ExtraBonusesContainer
            // 
            this.ExtraBonusesContainer.BackColor = System.Drawing.Color.LightGray;
            this.ExtraBonusesContainer.Controls.Add(this.ExtraBonusesHeaderContainer);
            this.ExtraBonusesContainer.Controls.Add(this.ExtraBonusesValuesContainer);
            this.ExtraBonusesContainer.Location = new System.Drawing.Point(8, 625);
            this.ExtraBonusesContainer.Name = "ExtraBonusesContainer";
            this.ExtraBonusesContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ExtraBonusesContainer.Size = new System.Drawing.Size(309, 222);
            this.ExtraBonusesContainer.TabIndex = 78;
            // 
            // ExtraBonusesHeaderContainer
            // 
            this.ExtraBonusesHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ExtraBonusesHeaderContainer.Controls.Add(this.ExtraBonusesBonusLabelText);
            this.ExtraBonusesHeaderContainer.Controls.Add(this.ExtraBonusesNameLabelText);
            this.ExtraBonusesHeaderContainer.Controls.Add(this.ExtraBonusesAffectedValueLabelText);
            this.ExtraBonusesHeaderContainer.Location = new System.Drawing.Point(8, 32);
            this.ExtraBonusesHeaderContainer.Name = "ExtraBonusesHeaderContainer";
            this.ExtraBonusesHeaderContainer.Size = new System.Drawing.Size(293, 23);
            this.ExtraBonusesHeaderContainer.TabIndex = 92;
            // 
            // ExtraBonusesBonusLabelText
            // 
            this.ExtraBonusesBonusLabelText.AutoSize = true;
            this.ExtraBonusesBonusLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraBonusesBonusLabelText.Location = new System.Drawing.Point(238, 5);
            this.ExtraBonusesBonusLabelText.Name = "ExtraBonusesBonusLabelText";
            this.ExtraBonusesBonusLabelText.Size = new System.Drawing.Size(36, 13);
            this.ExtraBonusesBonusLabelText.TabIndex = 91;
            this.ExtraBonusesBonusLabelText.Text = "Bonus";
            // 
            // ExtraBonusesNameLabelText
            // 
            this.ExtraBonusesNameLabelText.AutoSize = true;
            this.ExtraBonusesNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraBonusesNameLabelText.Location = new System.Drawing.Point(64, 5);
            this.ExtraBonusesNameLabelText.Name = "ExtraBonusesNameLabelText";
            this.ExtraBonusesNameLabelText.Size = new System.Drawing.Size(35, 13);
            this.ExtraBonusesNameLabelText.TabIndex = 89;
            this.ExtraBonusesNameLabelText.Text = "Name";
            // 
            // ExtraBonusesAffectedValueLabelText
            // 
            this.ExtraBonusesAffectedValueLabelText.AutoSize = true;
            this.ExtraBonusesAffectedValueLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraBonusesAffectedValueLabelText.Location = new System.Drawing.Point(150, 5);
            this.ExtraBonusesAffectedValueLabelText.Name = "ExtraBonusesAffectedValueLabelText";
            this.ExtraBonusesAffectedValueLabelText.Size = new System.Drawing.Size(74, 13);
            this.ExtraBonusesAffectedValueLabelText.TabIndex = 90;
            this.ExtraBonusesAffectedValueLabelText.Text = "Affected Value";
            // 
            // ExtraBonusesValuesContainer
            // 
            this.ExtraBonusesValuesContainer.BackColor = System.Drawing.Color.White;
            this.ExtraBonusesValuesContainer.Controls.Add(this.ExtraBonusesGridView);
            this.ExtraBonusesValuesContainer.Controls.Add(this.ExtraBonusesLabelContainer);
            this.ExtraBonusesValuesContainer.Location = new System.Drawing.Point(9, 9);
            this.ExtraBonusesValuesContainer.Name = "ExtraBonusesValuesContainer";
            this.ExtraBonusesValuesContainer.Size = new System.Drawing.Size(292, 205);
            this.ExtraBonusesValuesContainer.TabIndex = 0;
            // 
            // ExtraBonusesGridView
            // 
            this.ExtraBonusesGridView.AllowUserToResizeColumns = false;
            this.ExtraBonusesGridView.AllowUserToResizeRows = false;
            this.ExtraBonusesGridView.BackgroundColor = System.Drawing.Color.White;
            this.ExtraBonusesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExtraBonusesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExtraBonusesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExtraBonusesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExtraBonusesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExtraBonusesGridView.ColumnHeadersVisible = false;
            this.ExtraBonusesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.BonusName,
            this.AffectedValue,
            this.Bonus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExtraBonusesGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExtraBonusesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ExtraBonusesGridView.EnableHeadersVisualStyles = false;
            this.ExtraBonusesGridView.Location = new System.Drawing.Point(0, 46);
            this.ExtraBonusesGridView.MultiSelect = false;
            this.ExtraBonusesGridView.Name = "ExtraBonusesGridView";
            this.ExtraBonusesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExtraBonusesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ExtraBonusesGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ExtraBonusesGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ExtraBonusesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ExtraBonusesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ExtraBonusesGridView.ShowEditingIcon = false;
            this.ExtraBonusesGridView.Size = new System.Drawing.Size(292, 159);
            this.ExtraBonusesGridView.TabIndex = 89;
            this.ExtraBonusesGridView.TabStop = false;
            this.ExtraBonusesGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExtraBonusesGridView_CellValueChanged);
            this.ExtraBonusesGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.ExtraBonusesGridView_CurrentCellDirtyStateChanged);
            // 
            // ExtraBonusesLabelContainer
            // 
            this.ExtraBonusesLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExtraBonusesLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExtraBonusesLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ExtraBonusesLabelContainer.Controls.Add(this.ExtraBonusesLabelText);
            this.ExtraBonusesLabelContainer.Location = new System.Drawing.Point(-1, 0);
            this.ExtraBonusesLabelContainer.Name = "ExtraBonusesLabelContainer";
            this.ExtraBonusesLabelContainer.Size = new System.Drawing.Size(293, 23);
            this.ExtraBonusesLabelContainer.TabIndex = 88;
            // 
            // ExtraBonusesLabelText
            // 
            this.ExtraBonusesLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraBonusesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraBonusesLabelText.Location = new System.Drawing.Point(-2, 0);
            this.ExtraBonusesLabelText.Name = "ExtraBonusesLabelText";
            this.ExtraBonusesLabelText.Size = new System.Drawing.Size(295, 23);
            this.ExtraBonusesLabelText.TabIndex = 8;
            this.ExtraBonusesLabelText.Text = "EXTRA BONUSES";
            this.ExtraBonusesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterNameLevelContainer
            // 
            this.CharacterNameLevelContainer.BackColor = System.Drawing.Color.LightGray;
            this.CharacterNameLevelContainer.Controls.Add(this.CharacterLevelValueContainer);
            this.CharacterNameLevelContainer.Controls.Add(this.CharacterNameValueContainer);
            this.CharacterNameLevelContainer.Controls.Add(this.CharacterLevelLabelContainer);
            this.CharacterNameLevelContainer.Controls.Add(this.CharacterNameLabelContainer);
            this.CharacterNameLevelContainer.Location = new System.Drawing.Point(8, 13);
            this.CharacterNameLevelContainer.Name = "CharacterNameLevelContainer";
            this.CharacterNameLevelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CharacterNameLevelContainer.Size = new System.Drawing.Size(309, 75);
            this.CharacterNameLevelContainer.TabIndex = 0;
            this.CharacterNameLevelContainer.TabStop = true;
            // 
            // CharacterLevelValueContainer
            // 
            this.CharacterLevelValueContainer.BackColor = System.Drawing.Color.White;
            this.CharacterLevelValueContainer.Controls.Add(this.CharacterLevelValueTextBox);
            this.CharacterLevelValueContainer.Location = new System.Drawing.Point(233, 30);
            this.CharacterLevelValueContainer.Name = "CharacterLevelValueContainer";
            this.CharacterLevelValueContainer.Size = new System.Drawing.Size(68, 36);
            this.CharacterLevelValueContainer.TabIndex = 13;
            // 
            // CharacterLevelValueTextBox
            // 
            this.CharacterLevelValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterLevelValueTextBox.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLevelValueTextBox.Location = new System.Drawing.Point(0, 3);
            this.CharacterLevelValueTextBox.Name = "CharacterLevelValueTextBox";
            this.CharacterLevelValueTextBox.Size = new System.Drawing.Size(68, 30);
            this.CharacterLevelValueTextBox.TabIndex = 1;
            this.CharacterLevelValueTextBox.TabStop = false;
            this.CharacterLevelValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterLevelValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CharacterLevelValueTextBox_KeyDown);
            this.CharacterLevelValueTextBox.Leave += new System.EventHandler(this.CharacterLevelValueTextBox_Leave);
            // 
            // CharacterNameValueContainer
            // 
            this.CharacterNameValueContainer.BackColor = System.Drawing.Color.White;
            this.CharacterNameValueContainer.Controls.Add(this.CharacterNameValueTextBox);
            this.CharacterNameValueContainer.Location = new System.Drawing.Point(8, 30);
            this.CharacterNameValueContainer.Name = "CharacterNameValueContainer";
            this.CharacterNameValueContainer.Size = new System.Drawing.Size(215, 36);
            this.CharacterNameValueContainer.TabIndex = 12;
            // 
            // CharacterNameValueTextBox
            // 
            this.CharacterNameValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CharacterNameValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterNameValueTextBox.Location = new System.Drawing.Point(4, 8);
            this.CharacterNameValueTextBox.Name = "CharacterNameValueTextBox";
            this.CharacterNameValueTextBox.Size = new System.Drawing.Size(208, 20);
            this.CharacterNameValueTextBox.TabIndex = 0;
            this.CharacterNameValueTextBox.TabStop = false;
            this.CharacterNameValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CharacterNameValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CharacterNameValueTextBox_KeyDown);
            this.CharacterNameValueTextBox.Leave += new System.EventHandler(this.CharacterNameValueTextBox_Leave);
            // 
            // CharacterLevelLabelContainer
            // 
            this.CharacterLevelLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.CharacterLevelLabelContainer.Controls.Add(this.LevelLabelText);
            this.CharacterLevelLabelContainer.Location = new System.Drawing.Point(233, 8);
            this.CharacterLevelLabelContainer.Name = "CharacterLevelLabelContainer";
            this.CharacterLevelLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CharacterLevelLabelContainer.Size = new System.Drawing.Size(68, 23);
            this.CharacterLevelLabelContainer.TabIndex = 11;
            // 
            // CharacterNameLabelContainer
            // 
            this.CharacterNameLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.CharacterNameLabelContainer.Controls.Add(this.CharacterNameLabelText);
            this.CharacterNameLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.CharacterNameLabelContainer.Name = "CharacterNameLabelContainer";
            this.CharacterNameLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CharacterNameLabelContainer.Size = new System.Drawing.Size(215, 23);
            this.CharacterNameLabelContainer.TabIndex = 10;
            // 
            // CharacterInfoContainer
            // 
            this.CharacterInfoContainer.BackColor = System.Drawing.Color.LightGray;
            this.CharacterInfoContainer.Controls.Add(this.ExpValueContainer);
            this.CharacterInfoContainer.Controls.Add(this.ExpLabelContainer);
            this.CharacterInfoContainer.Controls.Add(this.AlignmentValueContainer);
            this.CharacterInfoContainer.Controls.Add(this.AlignmentLabelContainer);
            this.CharacterInfoContainer.Controls.Add(this.BackgroundValueContainer);
            this.CharacterInfoContainer.Controls.Add(this.RaceValueContainer);
            this.CharacterInfoContainer.Controls.Add(this.BackgroundLabelContainer);
            this.CharacterInfoContainer.Controls.Add(this.ClassValueContainer);
            this.CharacterInfoContainer.Controls.Add(this.RaceLabelContainer);
            this.CharacterInfoContainer.Controls.Add(this.ClassLabelContainer);
            this.CharacterInfoContainer.Location = new System.Drawing.Point(324, 13);
            this.CharacterInfoContainer.Name = "CharacterInfoContainer";
            this.CharacterInfoContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CharacterInfoContainer.Size = new System.Drawing.Size(486, 75);
            this.CharacterInfoContainer.TabIndex = 80;
            // 
            // ExpValueContainer
            // 
            this.ExpValueContainer.BackColor = System.Drawing.Color.White;
            this.ExpValueContainer.Controls.Add(this.ExpValueTextBox);
            this.ExpValueContainer.Location = new System.Drawing.Point(410, 30);
            this.ExpValueContainer.Name = "ExpValueContainer";
            this.ExpValueContainer.Size = new System.Drawing.Size(68, 36);
            this.ExpValueContainer.TabIndex = 20;
            // 
            // ExpValueTextBox
            // 
            this.ExpValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpValueTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpValueTextBox.Location = new System.Drawing.Point(0, 10);
            this.ExpValueTextBox.Name = "ExpValueTextBox";
            this.ExpValueTextBox.Size = new System.Drawing.Size(68, 16);
            this.ExpValueTextBox.TabIndex = 1;
            this.ExpValueTextBox.TabStop = false;
            this.ExpValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExpValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpValueTextBox_KeyDown);
            this.ExpValueTextBox.Leave += new System.EventHandler(this.ExpValueTextBox_Leave);
            // 
            // ExpLabelContainer
            // 
            this.ExpLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ExpLabelContainer.Controls.Add(this.ExpLabelText);
            this.ExpLabelContainer.Location = new System.Drawing.Point(410, 8);
            this.ExpLabelContainer.Name = "ExpLabelContainer";
            this.ExpLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ExpLabelContainer.Size = new System.Drawing.Size(68, 23);
            this.ExpLabelContainer.TabIndex = 19;
            // 
            // ExpLabelText
            // 
            this.ExpLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpLabelText.Location = new System.Drawing.Point(0, 0);
            this.ExpLabelText.Name = "ExpLabelText";
            this.ExpLabelText.Size = new System.Drawing.Size(68, 23);
            this.ExpLabelText.TabIndex = 2;
            this.ExpLabelText.Text = "EXP";
            this.ExpLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlignmentValueContainer
            // 
            this.AlignmentValueContainer.BackColor = System.Drawing.Color.White;
            this.AlignmentValueContainer.Controls.Add(this.AlignmentValueTextBox);
            this.AlignmentValueContainer.Location = new System.Drawing.Point(288, 43);
            this.AlignmentValueContainer.Name = "AlignmentValueContainer";
            this.AlignmentValueContainer.Size = new System.Drawing.Size(116, 24);
            this.AlignmentValueContainer.TabIndex = 18;
            // 
            // AlignmentValueTextBox
            // 
            this.AlignmentValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlignmentValueTextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentValueTextBox.Location = new System.Drawing.Point(0, 5);
            this.AlignmentValueTextBox.Name = "AlignmentValueTextBox";
            this.AlignmentValueTextBox.Size = new System.Drawing.Size(116, 14);
            this.AlignmentValueTextBox.TabIndex = 1;
            this.AlignmentValueTextBox.TabStop = false;
            this.AlignmentValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AlignmentValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AlignmentValueTextBox_KeyDown);
            this.AlignmentValueTextBox.Leave += new System.EventHandler(this.AlignmentValueTextBox_Leave);
            // 
            // AlignmentLabelContainer
            // 
            this.AlignmentLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.AlignmentLabelContainer.Controls.Add(this.AlignmentLabelText);
            this.AlignmentLabelContainer.Location = new System.Drawing.Point(202, 43);
            this.AlignmentLabelContainer.Name = "AlignmentLabelContainer";
            this.AlignmentLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.AlignmentLabelContainer.Size = new System.Drawing.Size(90, 24);
            this.AlignmentLabelContainer.TabIndex = 17;
            // 
            // AlignmentLabelText
            // 
            this.AlignmentLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlignmentLabelText.Location = new System.Drawing.Point(0, 0);
            this.AlignmentLabelText.Name = "AlignmentLabelText";
            this.AlignmentLabelText.Size = new System.Drawing.Size(87, 24);
            this.AlignmentLabelText.TabIndex = 1;
            this.AlignmentLabelText.Text = "ALIGNMENT";
            this.AlignmentLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackgroundValueContainer
            // 
            this.BackgroundValueContainer.BackColor = System.Drawing.Color.White;
            this.BackgroundValueContainer.Controls.Add(this.BackgroundValueTextBox);
            this.BackgroundValueContainer.Location = new System.Drawing.Point(288, 8);
            this.BackgroundValueContainer.Name = "BackgroundValueContainer";
            this.BackgroundValueContainer.Size = new System.Drawing.Size(116, 24);
            this.BackgroundValueContainer.TabIndex = 16;
            // 
            // BackgroundValueTextBox
            // 
            this.BackgroundValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackgroundValueTextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundValueTextBox.Location = new System.Drawing.Point(0, 5);
            this.BackgroundValueTextBox.Name = "BackgroundValueTextBox";
            this.BackgroundValueTextBox.Size = new System.Drawing.Size(116, 14);
            this.BackgroundValueTextBox.TabIndex = 1;
            this.BackgroundValueTextBox.TabStop = false;
            this.BackgroundValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackgroundValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackgroundValueTextBox_KeyDown);
            this.BackgroundValueTextBox.Leave += new System.EventHandler(this.BackgroundValueTextBox_Leave);
            // 
            // RaceValueContainer
            // 
            this.RaceValueContainer.BackColor = System.Drawing.Color.White;
            this.RaceValueContainer.Controls.Add(this.RaceValueTextBox);
            this.RaceValueContainer.Location = new System.Drawing.Point(55, 43);
            this.RaceValueContainer.Name = "RaceValueContainer";
            this.RaceValueContainer.Size = new System.Drawing.Size(141, 24);
            this.RaceValueContainer.TabIndex = 16;
            // 
            // RaceValueTextBox
            // 
            this.RaceValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RaceValueTextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceValueTextBox.Location = new System.Drawing.Point(0, 5);
            this.RaceValueTextBox.Name = "RaceValueTextBox";
            this.RaceValueTextBox.Size = new System.Drawing.Size(141, 14);
            this.RaceValueTextBox.TabIndex = 1;
            this.RaceValueTextBox.TabStop = false;
            this.RaceValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RaceValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaceValueTextBox_KeyDown);
            this.RaceValueTextBox.Leave += new System.EventHandler(this.RaceValueTextBox_Leave);
            // 
            // BackgroundLabelContainer
            // 
            this.BackgroundLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundLabelContainer.Controls.Add(this.BackgroundLabelText);
            this.BackgroundLabelContainer.Location = new System.Drawing.Point(202, 8);
            this.BackgroundLabelContainer.Name = "BackgroundLabelContainer";
            this.BackgroundLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.BackgroundLabelContainer.Size = new System.Drawing.Size(90, 24);
            this.BackgroundLabelContainer.TabIndex = 15;
            // 
            // BackgroundLabelText
            // 
            this.BackgroundLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundLabelText.Location = new System.Drawing.Point(0, 0);
            this.BackgroundLabelText.Name = "BackgroundLabelText";
            this.BackgroundLabelText.Size = new System.Drawing.Size(87, 24);
            this.BackgroundLabelText.TabIndex = 1;
            this.BackgroundLabelText.Text = "BACKGROUND";
            this.BackgroundLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassValueContainer
            // 
            this.ClassValueContainer.BackColor = System.Drawing.Color.White;
            this.ClassValueContainer.Controls.Add(this.ClassValueTextBox);
            this.ClassValueContainer.Location = new System.Drawing.Point(55, 8);
            this.ClassValueContainer.Name = "ClassValueContainer";
            this.ClassValueContainer.Size = new System.Drawing.Size(141, 24);
            this.ClassValueContainer.TabIndex = 14;
            // 
            // ClassValueTextBox
            // 
            this.ClassValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassValueTextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassValueTextBox.Location = new System.Drawing.Point(0, 5);
            this.ClassValueTextBox.Name = "ClassValueTextBox";
            this.ClassValueTextBox.Size = new System.Drawing.Size(141, 14);
            this.ClassValueTextBox.TabIndex = 1;
            this.ClassValueTextBox.TabStop = false;
            this.ClassValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ClassValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClassValueTextBox_KeyDown);
            this.ClassValueTextBox.Leave += new System.EventHandler(this.ClassValueTextBox_Leave);
            // 
            // RaceLabelContainer
            // 
            this.RaceLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.RaceLabelContainer.Controls.Add(this.RaceLabelText);
            this.RaceLabelContainer.Location = new System.Drawing.Point(8, 43);
            this.RaceLabelContainer.Name = "RaceLabelContainer";
            this.RaceLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.RaceLabelContainer.Size = new System.Drawing.Size(48, 24);
            this.RaceLabelContainer.TabIndex = 15;
            // 
            // RaceLabelText
            // 
            this.RaceLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceLabelText.Location = new System.Drawing.Point(0, 0);
            this.RaceLabelText.Name = "RaceLabelText";
            this.RaceLabelText.Size = new System.Drawing.Size(48, 24);
            this.RaceLabelText.TabIndex = 1;
            this.RaceLabelText.Text = "RACE";
            this.RaceLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClassLabelContainer
            // 
            this.ClassLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ClassLabelContainer.Controls.Add(this.ClassLabelText);
            this.ClassLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.ClassLabelContainer.Name = "ClassLabelContainer";
            this.ClassLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ClassLabelContainer.Size = new System.Drawing.Size(48, 24);
            this.ClassLabelContainer.TabIndex = 12;
            // 
            // BattleStatsContainer
            // 
            this.BattleStatsContainer.BackColor = System.Drawing.Color.LightGray;
            this.BattleStatsContainer.Controls.Add(this.SpeedValueContainer);
            this.BattleStatsContainer.Controls.Add(this.SpeedLabelContainer);
            this.BattleStatsContainer.Controls.Add(this.InitiativeValueContainer);
            this.BattleStatsContainer.Controls.Add(this.InitiativeLabelContainer);
            this.BattleStatsContainer.Controls.Add(this.ArmorClassValueContainer);
            this.BattleStatsContainer.Controls.Add(this.ArmorClassLabelContainer);
            this.BattleStatsContainer.Location = new System.Drawing.Point(324, 106);
            this.BattleStatsContainer.Name = "BattleStatsContainer";
            this.BattleStatsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.BattleStatsContainer.Size = new System.Drawing.Size(237, 75);
            this.BattleStatsContainer.TabIndex = 81;
            // 
            // SpeedValueContainer
            // 
            this.SpeedValueContainer.BackColor = System.Drawing.Color.White;
            this.SpeedValueContainer.Controls.Add(this.SpeedValueTextBox);
            this.SpeedValueContainer.Location = new System.Drawing.Point(159, 30);
            this.SpeedValueContainer.Name = "SpeedValueContainer";
            this.SpeedValueContainer.Size = new System.Drawing.Size(70, 36);
            this.SpeedValueContainer.TabIndex = 16;
            // 
            // SpeedValueTextBox
            // 
            this.SpeedValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpeedValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedValueTextBox.Location = new System.Drawing.Point(0, 5);
            this.SpeedValueTextBox.Name = "SpeedValueTextBox";
            this.SpeedValueTextBox.Size = new System.Drawing.Size(70, 26);
            this.SpeedValueTextBox.TabIndex = 2;
            this.SpeedValueTextBox.TabStop = false;
            this.SpeedValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SpeedLabelContainer
            // 
            this.SpeedLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.SpeedLabelContainer.Controls.Add(this.SpeedLabelText);
            this.SpeedLabelContainer.Location = new System.Drawing.Point(159, 8);
            this.SpeedLabelContainer.Name = "SpeedLabelContainer";
            this.SpeedLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SpeedLabelContainer.Size = new System.Drawing.Size(70, 23);
            this.SpeedLabelContainer.TabIndex = 15;
            // 
            // SpeedLabelText
            // 
            this.SpeedLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabelText.Location = new System.Drawing.Point(0, 0);
            this.SpeedLabelText.Name = "SpeedLabelText";
            this.SpeedLabelText.Size = new System.Drawing.Size(70, 23);
            this.SpeedLabelText.TabIndex = 0;
            this.SpeedLabelText.Text = "SPEED";
            this.SpeedLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitiativeValueContainer
            // 
            this.InitiativeValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.InitiativeValueContainer.Controls.Add(this.InitiativeValueText);
            this.InitiativeValueContainer.Location = new System.Drawing.Point(84, 30);
            this.InitiativeValueContainer.Name = "InitiativeValueContainer";
            this.InitiativeValueContainer.Size = new System.Drawing.Size(69, 36);
            this.InitiativeValueContainer.TabIndex = 14;
            // 
            // InitiativeValueText
            // 
            this.InitiativeValueText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitiativeValueText.Location = new System.Drawing.Point(0, 0);
            this.InitiativeValueText.Name = "InitiativeValueText";
            this.InitiativeValueText.Size = new System.Drawing.Size(69, 33);
            this.InitiativeValueText.TabIndex = 82;
            this.InitiativeValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InitiativeLabelContainer
            // 
            this.InitiativeLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.InitiativeLabelContainer.Controls.Add(this.InitiativeLabelText);
            this.InitiativeLabelContainer.Location = new System.Drawing.Point(84, 8);
            this.InitiativeLabelContainer.Name = "InitiativeLabelContainer";
            this.InitiativeLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.InitiativeLabelContainer.Size = new System.Drawing.Size(69, 23);
            this.InitiativeLabelContainer.TabIndex = 13;
            // 
            // InitiativeLabelText
            // 
            this.InitiativeLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitiativeLabelText.Location = new System.Drawing.Point(0, 0);
            this.InitiativeLabelText.Name = "InitiativeLabelText";
            this.InitiativeLabelText.Size = new System.Drawing.Size(69, 23);
            this.InitiativeLabelText.TabIndex = 0;
            this.InitiativeLabelText.Text = "INITIATIVE";
            this.InitiativeLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArmorClassValueContainer
            // 
            this.ArmorClassValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ArmorClassValueContainer.Controls.Add(this.ArmorClassValueText);
            this.ArmorClassValueContainer.Location = new System.Drawing.Point(8, 30);
            this.ArmorClassValueContainer.Name = "ArmorClassValueContainer";
            this.ArmorClassValueContainer.Size = new System.Drawing.Size(70, 36);
            this.ArmorClassValueContainer.TabIndex = 12;
            // 
            // ArmorClassValueText
            // 
            this.ArmorClassValueText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorClassValueText.Location = new System.Drawing.Point(0, 0);
            this.ArmorClassValueText.Name = "ArmorClassValueText";
            this.ArmorClassValueText.Size = new System.Drawing.Size(70, 36);
            this.ArmorClassValueText.TabIndex = 81;
            this.ArmorClassValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArmorClassLabelContainer
            // 
            this.ArmorClassLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ArmorClassLabelContainer.Controls.Add(this.ArmorClassLabelText);
            this.ArmorClassLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.ArmorClassLabelContainer.Name = "ArmorClassLabelContainer";
            this.ArmorClassLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ArmorClassLabelContainer.Size = new System.Drawing.Size(70, 23);
            this.ArmorClassLabelContainer.TabIndex = 10;
            // 
            // ArmorClassLabelText
            // 
            this.ArmorClassLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorClassLabelText.Location = new System.Drawing.Point(0, 0);
            this.ArmorClassLabelText.Name = "ArmorClassLabelText";
            this.ArmorClassLabelText.Size = new System.Drawing.Size(70, 23);
            this.ArmorClassLabelText.TabIndex = 0;
            this.ArmorClassLabelText.Text = "AC";
            this.ArmorClassLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HitPointsContainer
            // 
            this.HitPointsContainer.BackColor = System.Drawing.Color.LightGray;
            this.HitPointsContainer.Controls.Add(this.ReceiveDamageButton);
            this.HitPointsContainer.Controls.Add(this.AddTemporaryHitPointsButton);
            this.HitPointsContainer.Controls.Add(this.CurrentHitPointsValueContainer);
            this.HitPointsContainer.Controls.Add(this.CurrentHitPointsLabelContainer);
            this.HitPointsContainer.Controls.Add(this.MaxHitPointsValueContainer);
            this.HitPointsContainer.Controls.Add(this.MaxHitPointsLabelContainer);
            this.HitPointsContainer.Controls.Add(this.HealHitPointsButton);
            this.HitPointsContainer.Controls.Add(this.ResetCurrentHitPointsButton);
            this.HitPointsContainer.Location = new System.Drawing.Point(324, 187);
            this.HitPointsContainer.Name = "HitPointsContainer";
            this.HitPointsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.HitPointsContainer.Size = new System.Drawing.Size(237, 152);
            this.HitPointsContainer.TabIndex = 82;
            // 
            // ReceiveDamageButton
            // 
            this.ReceiveDamageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(183)))), ((int)(((byte)(183)))));
            this.ReceiveDamageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReceiveDamageButton.Location = new System.Drawing.Point(123, 93);
            this.ReceiveDamageButton.Name = "ReceiveDamageButton";
            this.ReceiveDamageButton.Size = new System.Drawing.Size(106, 23);
            this.ReceiveDamageButton.TabIndex = 52;
            this.ReceiveDamageButton.Text = "Receive Damage";
            this.ReceiveDamageButton.UseVisualStyleBackColor = false;
            this.ReceiveDamageButton.Click += new System.EventHandler(this.ReceiveDamageButton_Click);
            // 
            // AddTemporaryHitPointsButton
            // 
            this.AddTemporaryHitPointsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(189)))), ((int)(((byte)(204)))));
            this.AddTemporaryHitPointsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTemporaryHitPointsButton.Location = new System.Drawing.Point(9, 122);
            this.AddTemporaryHitPointsButton.Name = "AddTemporaryHitPointsButton";
            this.AddTemporaryHitPointsButton.Size = new System.Drawing.Size(106, 23);
            this.AddTemporaryHitPointsButton.TabIndex = 53;
            this.AddTemporaryHitPointsButton.Text = "Add Temporary HP";
            this.AddTemporaryHitPointsButton.UseVisualStyleBackColor = false;
            this.AddTemporaryHitPointsButton.Click += new System.EventHandler(this.AddTemporaryHitPointsButton_Click);
            // 
            // CurrentHitPointsValueContainer
            // 
            this.CurrentHitPointsValueContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentHitPointsValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CurrentHitPointsValueContainer.Controls.Add(this.CurrentHitPointsValueText);
            this.CurrentHitPointsValueContainer.Location = new System.Drawing.Point(94, 30);
            this.CurrentHitPointsValueContainer.Name = "CurrentHitPointsValueContainer";
            this.CurrentHitPointsValueContainer.Size = new System.Drawing.Size(135, 57);
            this.CurrentHitPointsValueContainer.TabIndex = 14;
            // 
            // CurrentHitPointsValueText
            // 
            this.CurrentHitPointsValueText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentHitPointsValueText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CurrentHitPointsValueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentHitPointsValueText.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentHitPointsValueText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentHitPointsValueText.Location = new System.Drawing.Point(0, 13);
            this.CurrentHitPointsValueText.Name = "CurrentHitPointsValueText";
            this.CurrentHitPointsValueText.Size = new System.Drawing.Size(135, 29);
            this.CurrentHitPointsValueText.TabIndex = 0;
            this.CurrentHitPointsValueText.TabStop = false;
            this.CurrentHitPointsValueText.Text = "";
            this.CurrentHitPointsValueText.WordWrap = false;
            this.CurrentHitPointsValueText.Click += new System.EventHandler(this.CurrentHitPointsValueText_Click);
            // 
            // CurrentHitPointsLabelContainer
            // 
            this.CurrentHitPointsLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.CurrentHitPointsLabelContainer.Controls.Add(this.CurrentHitPointsLabelText);
            this.CurrentHitPointsLabelContainer.Location = new System.Drawing.Point(94, 8);
            this.CurrentHitPointsLabelContainer.Name = "CurrentHitPointsLabelContainer";
            this.CurrentHitPointsLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CurrentHitPointsLabelContainer.Size = new System.Drawing.Size(135, 23);
            this.CurrentHitPointsLabelContainer.TabIndex = 13;
            // 
            // CurrentHitPointsLabelText
            // 
            this.CurrentHitPointsLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentHitPointsLabelText.Location = new System.Drawing.Point(0, 0);
            this.CurrentHitPointsLabelText.Name = "CurrentHitPointsLabelText";
            this.CurrentHitPointsLabelText.Size = new System.Drawing.Size(135, 23);
            this.CurrentHitPointsLabelText.TabIndex = 0;
            this.CurrentHitPointsLabelText.Text = "CURRENT HP";
            this.CurrentHitPointsLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxHitPointsValueContainer
            // 
            this.MaxHitPointsValueContainer.BackColor = System.Drawing.Color.White;
            this.MaxHitPointsValueContainer.Controls.Add(this.MaxHitPointsValueTextBox);
            this.MaxHitPointsValueContainer.Location = new System.Drawing.Point(8, 30);
            this.MaxHitPointsValueContainer.Name = "MaxHitPointsValueContainer";
            this.MaxHitPointsValueContainer.Size = new System.Drawing.Size(80, 57);
            this.MaxHitPointsValueContainer.TabIndex = 12;
            // 
            // MaxHitPointsValueTextBox
            // 
            this.MaxHitPointsValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaxHitPointsValueTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHitPointsValueTextBox.Location = new System.Drawing.Point(0, 16);
            this.MaxHitPointsValueTextBox.Name = "MaxHitPointsValueTextBox";
            this.MaxHitPointsValueTextBox.Size = new System.Drawing.Size(80, 26);
            this.MaxHitPointsValueTextBox.TabIndex = 2;
            this.MaxHitPointsValueTextBox.TabStop = false;
            this.MaxHitPointsValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxHitPointsValueTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MaxHitPointsValueTextBox_KeyDown);
            this.MaxHitPointsValueTextBox.Leave += new System.EventHandler(this.MaxHitPointsValueTextBox_Leave);
            // 
            // MaxHitPointsLabelContainer
            // 
            this.MaxHitPointsLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.MaxHitPointsLabelContainer.Controls.Add(this.MaxHitPointsLabelText);
            this.MaxHitPointsLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.MaxHitPointsLabelContainer.Name = "MaxHitPointsLabelContainer";
            this.MaxHitPointsLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.MaxHitPointsLabelContainer.Size = new System.Drawing.Size(80, 23);
            this.MaxHitPointsLabelContainer.TabIndex = 10;
            // 
            // MaxHitPointsLabelText
            // 
            this.MaxHitPointsLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxHitPointsLabelText.Location = new System.Drawing.Point(0, 0);
            this.MaxHitPointsLabelText.Name = "MaxHitPointsLabelText";
            this.MaxHitPointsLabelText.Size = new System.Drawing.Size(80, 23);
            this.MaxHitPointsLabelText.TabIndex = 0;
            this.MaxHitPointsLabelText.Text = "MAX HP";
            this.MaxHitPointsLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HitDiceContainer
            // 
            this.HitDiceContainer.BackColor = System.Drawing.Color.LightGray;
            this.HitDiceContainer.Controls.Add(this.RefillHitDiceButton);
            this.HitDiceContainer.Controls.Add(this.RemainingHitDiceValueContainer);
            this.HitDiceContainer.Controls.Add(this.TotalHitDiceValueContainer);
            this.HitDiceContainer.Controls.Add(this.RemainingHitDiceLabelContainer);
            this.HitDiceContainer.Controls.Add(this.DeathSavesValueContainer);
            this.HitDiceContainer.Controls.Add(this.TotalHitDiceLabelContainer);
            this.HitDiceContainer.Controls.Add(this.HitDiceValueContainer);
            this.HitDiceContainer.Controls.Add(this.HitDiceLabelContainer);
            this.HitDiceContainer.Location = new System.Drawing.Point(324, 345);
            this.HitDiceContainer.Name = "HitDiceContainer";
            this.HitDiceContainer.Padding = new System.Windows.Forms.Padding(5);
            this.HitDiceContainer.Size = new System.Drawing.Size(237, 139);
            this.HitDiceContainer.TabIndex = 83;
            // 
            // RefillHitDiceButton
            // 
            this.RefillHitDiceButton.Location = new System.Drawing.Point(8, 95);
            this.RefillHitDiceButton.Name = "RefillHitDiceButton";
            this.RefillHitDiceButton.Size = new System.Drawing.Size(89, 36);
            this.RefillHitDiceButton.TabIndex = 52;
            this.RefillHitDiceButton.Text = "Refill Hit Dices";
            this.RefillHitDiceButton.UseVisualStyleBackColor = true;
            // 
            // RemainingHitDiceValueContainer
            // 
            this.RemainingHitDiceValueContainer.BackColor = System.Drawing.Color.White;
            this.RemainingHitDiceValueContainer.Controls.Add(this.RemainingHitDiceValueTextBox);
            this.RemainingHitDiceValueContainer.Location = new System.Drawing.Point(169, 31);
            this.RemainingHitDiceValueContainer.Name = "RemainingHitDiceValueContainer";
            this.RemainingHitDiceValueContainer.Padding = new System.Windows.Forms.Padding(5);
            this.RemainingHitDiceValueContainer.Size = new System.Drawing.Size(60, 23);
            this.RemainingHitDiceValueContainer.TabIndex = 15;
            // 
            // RemainingHitDiceValueTextBox
            // 
            this.RemainingHitDiceValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemainingHitDiceValueTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingHitDiceValueTextBox.Location = new System.Drawing.Point(0, 3);
            this.RemainingHitDiceValueTextBox.Name = "RemainingHitDiceValueTextBox";
            this.RemainingHitDiceValueTextBox.Size = new System.Drawing.Size(60, 16);
            this.RemainingHitDiceValueTextBox.TabIndex = 4;
            this.RemainingHitDiceValueTextBox.TabStop = false;
            this.RemainingHitDiceValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalHitDiceValueContainer
            // 
            this.TotalHitDiceValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TotalHitDiceValueContainer.Controls.Add(this.TotalHitDiceValueText);
            this.TotalHitDiceValueContainer.Location = new System.Drawing.Point(105, 31);
            this.TotalHitDiceValueContainer.Name = "TotalHitDiceValueContainer";
            this.TotalHitDiceValueContainer.Padding = new System.Windows.Forms.Padding(5);
            this.TotalHitDiceValueContainer.Size = new System.Drawing.Size(58, 23);
            this.TotalHitDiceValueContainer.TabIndex = 14;
            // 
            // TotalHitDiceValueText
            // 
            this.TotalHitDiceValueText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHitDiceValueText.Location = new System.Drawing.Point(-2, 0);
            this.TotalHitDiceValueText.Name = "TotalHitDiceValueText";
            this.TotalHitDiceValueText.Size = new System.Drawing.Size(60, 23);
            this.TotalHitDiceValueText.TabIndex = 82;
            this.TotalHitDiceValueText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemainingHitDiceLabelContainer
            // 
            this.RemainingHitDiceLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.RemainingHitDiceLabelContainer.Controls.Add(this.RemainingHitDiceLabelText);
            this.RemainingHitDiceLabelContainer.Location = new System.Drawing.Point(169, 8);
            this.RemainingHitDiceLabelContainer.Name = "RemainingHitDiceLabelContainer";
            this.RemainingHitDiceLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.RemainingHitDiceLabelContainer.Size = new System.Drawing.Size(59, 23);
            this.RemainingHitDiceLabelContainer.TabIndex = 14;
            // 
            // RemainingHitDiceLabelText
            // 
            this.RemainingHitDiceLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingHitDiceLabelText.Location = new System.Drawing.Point(0, 0);
            this.RemainingHitDiceLabelText.Name = "RemainingHitDiceLabelText";
            this.RemainingHitDiceLabelText.Size = new System.Drawing.Size(60, 23);
            this.RemainingHitDiceLabelText.TabIndex = 3;
            this.RemainingHitDiceLabelText.Text = "Remaining";
            this.RemainingHitDiceLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeathSavesValueContainer
            // 
            this.DeathSavesValueContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DeathSavesValueContainer.Controls.Add(this.FailureDeathSaveCheckBoxThree);
            this.DeathSavesValueContainer.Controls.Add(this.FailureDeathSaveCheckBoxTwo);
            this.DeathSavesValueContainer.Controls.Add(this.FailureDeathSaveCheckBoxOne);
            this.DeathSavesValueContainer.Controls.Add(this.SuccessDeathSaveCheckBoxThree);
            this.DeathSavesValueContainer.Controls.Add(this.SuccessDeathSaveCheckBoxTwo);
            this.DeathSavesValueContainer.Controls.Add(this.SuccessDeathSaveCheckBoxOne);
            this.DeathSavesValueContainer.Controls.Add(this.DeathSavesLabelContainer);
            this.DeathSavesValueContainer.Controls.Add(this.SuccessDeathSaveLabelText);
            this.DeathSavesValueContainer.Controls.Add(this.FailureDeathSaveLabelText);
            this.DeathSavesValueContainer.Location = new System.Drawing.Point(105, 60);
            this.DeathSavesValueContainer.Name = "DeathSavesValueContainer";
            this.DeathSavesValueContainer.Size = new System.Drawing.Size(124, 71);
            this.DeathSavesValueContainer.TabIndex = 14;
            // 
            // FailureDeathSaveCheckBoxThree
            // 
            this.FailureDeathSaveCheckBoxThree.AutoSize = true;
            this.FailureDeathSaveCheckBoxThree.Location = new System.Drawing.Point(101, 51);
            this.FailureDeathSaveCheckBoxThree.Name = "FailureDeathSaveCheckBoxThree";
            this.FailureDeathSaveCheckBoxThree.Size = new System.Drawing.Size(15, 14);
            this.FailureDeathSaveCheckBoxThree.TabIndex = 85;
            this.FailureDeathSaveCheckBoxThree.UseVisualStyleBackColor = true;
            // 
            // FailureDeathSaveCheckBoxTwo
            // 
            this.FailureDeathSaveCheckBoxTwo.AutoSize = true;
            this.FailureDeathSaveCheckBoxTwo.Location = new System.Drawing.Point(77, 51);
            this.FailureDeathSaveCheckBoxTwo.Name = "FailureDeathSaveCheckBoxTwo";
            this.FailureDeathSaveCheckBoxTwo.Size = new System.Drawing.Size(15, 14);
            this.FailureDeathSaveCheckBoxTwo.TabIndex = 84;
            this.FailureDeathSaveCheckBoxTwo.UseVisualStyleBackColor = true;
            // 
            // FailureDeathSaveCheckBoxOne
            // 
            this.FailureDeathSaveCheckBoxOne.AutoSize = true;
            this.FailureDeathSaveCheckBoxOne.Location = new System.Drawing.Point(54, 51);
            this.FailureDeathSaveCheckBoxOne.Name = "FailureDeathSaveCheckBoxOne";
            this.FailureDeathSaveCheckBoxOne.Size = new System.Drawing.Size(15, 14);
            this.FailureDeathSaveCheckBoxOne.TabIndex = 61;
            this.FailureDeathSaveCheckBoxOne.UseVisualStyleBackColor = true;
            // 
            // SuccessDeathSaveCheckBoxThree
            // 
            this.SuccessDeathSaveCheckBoxThree.AutoSize = true;
            this.SuccessDeathSaveCheckBoxThree.Location = new System.Drawing.Point(101, 29);
            this.SuccessDeathSaveCheckBoxThree.Name = "SuccessDeathSaveCheckBoxThree";
            this.SuccessDeathSaveCheckBoxThree.Size = new System.Drawing.Size(15, 14);
            this.SuccessDeathSaveCheckBoxThree.TabIndex = 60;
            this.SuccessDeathSaveCheckBoxThree.UseVisualStyleBackColor = true;
            // 
            // SuccessDeathSaveCheckBoxTwo
            // 
            this.SuccessDeathSaveCheckBoxTwo.AutoSize = true;
            this.SuccessDeathSaveCheckBoxTwo.Location = new System.Drawing.Point(77, 29);
            this.SuccessDeathSaveCheckBoxTwo.Name = "SuccessDeathSaveCheckBoxTwo";
            this.SuccessDeathSaveCheckBoxTwo.Size = new System.Drawing.Size(15, 14);
            this.SuccessDeathSaveCheckBoxTwo.TabIndex = 59;
            this.SuccessDeathSaveCheckBoxTwo.UseVisualStyleBackColor = true;
            // 
            // SuccessDeathSaveCheckBoxOne
            // 
            this.SuccessDeathSaveCheckBoxOne.AutoSize = true;
            this.SuccessDeathSaveCheckBoxOne.Location = new System.Drawing.Point(54, 29);
            this.SuccessDeathSaveCheckBoxOne.Name = "SuccessDeathSaveCheckBoxOne";
            this.SuccessDeathSaveCheckBoxOne.Size = new System.Drawing.Size(15, 14);
            this.SuccessDeathSaveCheckBoxOne.TabIndex = 58;
            this.SuccessDeathSaveCheckBoxOne.UseVisualStyleBackColor = true;
            // 
            // DeathSavesLabelContainer
            // 
            this.DeathSavesLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.DeathSavesLabelContainer.Controls.Add(this.DeathSavesLabelText);
            this.DeathSavesLabelContainer.Location = new System.Drawing.Point(0, 1);
            this.DeathSavesLabelContainer.Name = "DeathSavesLabelContainer";
            this.DeathSavesLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.DeathSavesLabelContainer.Size = new System.Drawing.Size(124, 23);
            this.DeathSavesLabelContainer.TabIndex = 14;
            // 
            // DeathSavesLabelText
            // 
            this.DeathSavesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeathSavesLabelText.Location = new System.Drawing.Point(0, 0);
            this.DeathSavesLabelText.Name = "DeathSavesLabelText";
            this.DeathSavesLabelText.Size = new System.Drawing.Size(124, 23);
            this.DeathSavesLabelText.TabIndex = 2;
            this.DeathSavesLabelText.Text = "DEATH SAVES";
            this.DeathSavesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalHitDiceLabelContainer
            // 
            this.TotalHitDiceLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.TotalHitDiceLabelContainer.Controls.Add(this.TotalHitDiceLabelText);
            this.TotalHitDiceLabelContainer.Location = new System.Drawing.Point(105, 8);
            this.TotalHitDiceLabelContainer.Name = "TotalHitDiceLabelContainer";
            this.TotalHitDiceLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.TotalHitDiceLabelContainer.Size = new System.Drawing.Size(58, 23);
            this.TotalHitDiceLabelContainer.TabIndex = 13;
            // 
            // TotalHitDiceLabelText
            // 
            this.TotalHitDiceLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHitDiceLabelText.Location = new System.Drawing.Point(0, 0);
            this.TotalHitDiceLabelText.Name = "TotalHitDiceLabelText";
            this.TotalHitDiceLabelText.Size = new System.Drawing.Size(58, 23);
            this.TotalHitDiceLabelText.TabIndex = 2;
            this.TotalHitDiceLabelText.Text = "Total";
            this.TotalHitDiceLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HitDiceValueContainer
            // 
            this.HitDiceValueContainer.BackColor = System.Drawing.Color.White;
            this.HitDiceValueContainer.Controls.Add(this.HitDiceValueTextBox);
            this.HitDiceValueContainer.Location = new System.Drawing.Point(8, 30);
            this.HitDiceValueContainer.Name = "HitDiceValueContainer";
            this.HitDiceValueContainer.Size = new System.Drawing.Size(89, 59);
            this.HitDiceValueContainer.TabIndex = 12;
            // 
            // HitDiceValueTextBox
            // 
            this.HitDiceValueTextBox.AcceptsReturn = true;
            this.HitDiceValueTextBox.AcceptsTab = true;
            this.HitDiceValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HitDiceValueTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitDiceValueTextBox.Location = new System.Drawing.Point(0, 17);
            this.HitDiceValueTextBox.Name = "HitDiceValueTextBox";
            this.HitDiceValueTextBox.Size = new System.Drawing.Size(89, 24);
            this.HitDiceValueTextBox.TabIndex = 3;
            this.HitDiceValueTextBox.TabStop = false;
            this.HitDiceValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HitDiceLabelContainer
            // 
            this.HitDiceLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.HitDiceLabelContainer.Controls.Add(this.HitDiceLabelText);
            this.HitDiceLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.HitDiceLabelContainer.Name = "HitDiceLabelContainer";
            this.HitDiceLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.HitDiceLabelContainer.Size = new System.Drawing.Size(89, 23);
            this.HitDiceLabelContainer.TabIndex = 10;
            // 
            // HitDiceLabelText
            // 
            this.HitDiceLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitDiceLabelText.Location = new System.Drawing.Point(0, 0);
            this.HitDiceLabelText.Name = "HitDiceLabelText";
            this.HitDiceLabelText.Size = new System.Drawing.Size(89, 23);
            this.HitDiceLabelText.TabIndex = 1;
            this.HitDiceLabelText.Text = "HIT DICE";
            this.HitDiceLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeaponsContainer
            // 
            this.WeaponsContainer.BackColor = System.Drawing.Color.LightGray;
            this.WeaponsContainer.Controls.Add(this.WeaponsHeaderContainer);
            this.WeaponsContainer.Controls.Add(this.WeaponsValuesContainer);
            this.WeaponsContainer.Location = new System.Drawing.Point(324, 490);
            this.WeaponsContainer.Name = "WeaponsContainer";
            this.WeaponsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.WeaponsContainer.Size = new System.Drawing.Size(237, 176);
            this.WeaponsContainer.TabIndex = 84;
            // 
            // WeaponsHeaderContainer
            // 
            this.WeaponsHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.WeaponsHeaderContainer.Controls.Add(this.WeaponsNameLabelText);
            this.WeaponsHeaderContainer.Controls.Add(this.WeaponsAttackBonusLabelText);
            this.WeaponsHeaderContainer.Controls.Add(this.WeaponsDamageLabelText);
            this.WeaponsHeaderContainer.Location = new System.Drawing.Point(9, 32);
            this.WeaponsHeaderContainer.Name = "WeaponsHeaderContainer";
            this.WeaponsHeaderContainer.Size = new System.Drawing.Size(219, 23);
            this.WeaponsHeaderContainer.TabIndex = 92;
            // 
            // WeaponsValuesContainer
            // 
            this.WeaponsValuesContainer.BackColor = System.Drawing.Color.White;
            this.WeaponsValuesContainer.Controls.Add(this.WeaponsLabelContainer);
            this.WeaponsValuesContainer.Location = new System.Drawing.Point(9, 9);
            this.WeaponsValuesContainer.Name = "WeaponsValuesContainer";
            this.WeaponsValuesContainer.Size = new System.Drawing.Size(219, 158);
            this.WeaponsValuesContainer.TabIndex = 0;
            // 
            // WeaponsLabelContainer
            // 
            this.WeaponsLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WeaponsLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WeaponsLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.WeaponsLabelContainer.Controls.Add(this.WeaponsLabelText);
            this.WeaponsLabelContainer.Location = new System.Drawing.Point(0, 0);
            this.WeaponsLabelContainer.Name = "WeaponsLabelContainer";
            this.WeaponsLabelContainer.Size = new System.Drawing.Size(219, 23);
            this.WeaponsLabelContainer.TabIndex = 88;
            // 
            // WeaponsLabelText
            // 
            this.WeaponsLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeaponsLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponsLabelText.Location = new System.Drawing.Point(0, 0);
            this.WeaponsLabelText.Name = "WeaponsLabelText";
            this.WeaponsLabelText.Size = new System.Drawing.Size(219, 23);
            this.WeaponsLabelText.TabIndex = 8;
            this.WeaponsLabelText.Text = "WEAPONS";
            this.WeaponsLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArmorContainer
            // 
            this.ArmorContainer.BackColor = System.Drawing.Color.LightGray;
            this.ArmorContainer.Controls.Add(this.ArmorHeaderContainer);
            this.ArmorContainer.Controls.Add(this.ArmorValuesContainer);
            this.ArmorContainer.Location = new System.Drawing.Point(324, 672);
            this.ArmorContainer.Name = "ArmorContainer";
            this.ArmorContainer.Padding = new System.Windows.Forms.Padding(5);
            this.ArmorContainer.Size = new System.Drawing.Size(237, 175);
            this.ArmorContainer.TabIndex = 85;
            // 
            // ArmorHeaderContainer
            // 
            this.ArmorHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ArmorHeaderContainer.Controls.Add(this.ArmorNameLabelText);
            this.ArmorHeaderContainer.Controls.Add(this.ArmorTypeLabelText);
            this.ArmorHeaderContainer.Controls.Add(this.ArmorACBonusLabelText);
            this.ArmorHeaderContainer.Location = new System.Drawing.Point(9, 32);
            this.ArmorHeaderContainer.Name = "ArmorHeaderContainer";
            this.ArmorHeaderContainer.Size = new System.Drawing.Size(220, 23);
            this.ArmorHeaderContainer.TabIndex = 92;
            // 
            // ArmorNameLabelText
            // 
            this.ArmorNameLabelText.AutoSize = true;
            this.ArmorNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorNameLabelText.Location = new System.Drawing.Point(4, 5);
            this.ArmorNameLabelText.Name = "ArmorNameLabelText";
            this.ArmorNameLabelText.Size = new System.Drawing.Size(35, 13);
            this.ArmorNameLabelText.TabIndex = 58;
            this.ArmorNameLabelText.Text = "Name";
            // 
            // ArmorTypeLabelText
            // 
            this.ArmorTypeLabelText.AutoSize = true;
            this.ArmorTypeLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorTypeLabelText.Location = new System.Drawing.Point(118, 5);
            this.ArmorTypeLabelText.Name = "ArmorTypeLabelText";
            this.ArmorTypeLabelText.Size = new System.Drawing.Size(29, 13);
            this.ArmorTypeLabelText.TabIndex = 59;
            this.ArmorTypeLabelText.Text = "Type";
            // 
            // ArmorACBonusLabelText
            // 
            this.ArmorACBonusLabelText.AutoSize = true;
            this.ArmorACBonusLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorACBonusLabelText.Location = new System.Drawing.Point(183, 5);
            this.ArmorACBonusLabelText.Name = "ArmorACBonusLabelText";
            this.ArmorACBonusLabelText.Size = new System.Drawing.Size(19, 13);
            this.ArmorACBonusLabelText.TabIndex = 60;
            this.ArmorACBonusLabelText.Text = "AC";
            // 
            // ArmorValuesContainer
            // 
            this.ArmorValuesContainer.BackColor = System.Drawing.Color.White;
            this.ArmorValuesContainer.Controls.Add(this.ArmorLabelContainer);
            this.ArmorValuesContainer.Location = new System.Drawing.Point(9, 9);
            this.ArmorValuesContainer.Name = "ArmorValuesContainer";
            this.ArmorValuesContainer.Size = new System.Drawing.Size(220, 158);
            this.ArmorValuesContainer.TabIndex = 0;
            // 
            // ArmorLabelContainer
            // 
            this.ArmorLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ArmorLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ArmorLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.ArmorLabelContainer.Controls.Add(this.ArmorLabelText);
            this.ArmorLabelContainer.Location = new System.Drawing.Point(-1, 0);
            this.ArmorLabelContainer.Name = "ArmorLabelContainer";
            this.ArmorLabelContainer.Size = new System.Drawing.Size(221, 23);
            this.ArmorLabelContainer.TabIndex = 88;
            // 
            // ArmorLabelText
            // 
            this.ArmorLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArmorLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorLabelText.Location = new System.Drawing.Point(1, 0);
            this.ArmorLabelText.Name = "ArmorLabelText";
            this.ArmorLabelText.Size = new System.Drawing.Size(220, 23);
            this.ArmorLabelText.TabIndex = 8;
            this.ArmorLabelText.Text = "ARMOR";
            this.ArmorLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterAppearanceContainer
            // 
            this.CharacterAppearanceContainer.BackColor = System.Drawing.Color.LightGray;
            this.CharacterAppearanceContainer.Controls.Add(this.CharacterAppearanceImage);
            this.CharacterAppearanceContainer.Location = new System.Drawing.Point(567, 106);
            this.CharacterAppearanceContainer.Name = "CharacterAppearanceContainer";
            this.CharacterAppearanceContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CharacterAppearanceContainer.Size = new System.Drawing.Size(243, 233);
            this.CharacterAppearanceContainer.TabIndex = 86;
            // 
            // InventoryContainer
            // 
            this.InventoryContainer.BackColor = System.Drawing.Color.LightGray;
            this.InventoryContainer.Controls.Add(this.InventoryHeaderContainer);
            this.InventoryContainer.Controls.Add(this.InventoryValuesContainer);
            this.InventoryContainer.Controls.Add(this.PlatinumPiecesValueContainer);
            this.InventoryContainer.Controls.Add(this.GoldPiecesValueContainer);
            this.InventoryContainer.Controls.Add(this.PlatinumPiecesLabelContainer);
            this.InventoryContainer.Controls.Add(this.SilverPiecesValueContainer);
            this.InventoryContainer.Controls.Add(this.GoldPiecesLabelContainer);
            this.InventoryContainer.Controls.Add(this.CopperPiecesValueContainer);
            this.InventoryContainer.Controls.Add(this.SilverPiecesLabelContainer);
            this.InventoryContainer.Controls.Add(this.CoppierPiecesLabelContainer);
            this.InventoryContainer.Location = new System.Drawing.Point(567, 527);
            this.InventoryContainer.Name = "InventoryContainer";
            this.InventoryContainer.Padding = new System.Windows.Forms.Padding(5);
            this.InventoryContainer.Size = new System.Drawing.Size(243, 321);
            this.InventoryContainer.TabIndex = 87;
            // 
            // InventoryHeaderContainer
            // 
            this.InventoryHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.InventoryHeaderContainer.Controls.Add(this.InventoryNameLabelText);
            this.InventoryHeaderContainer.Controls.Add(this.InventoryQuantityLabelText);
            this.InventoryHeaderContainer.Location = new System.Drawing.Point(8, 92);
            this.InventoryHeaderContainer.Name = "InventoryHeaderContainer";
            this.InventoryHeaderContainer.Size = new System.Drawing.Size(227, 23);
            this.InventoryHeaderContainer.TabIndex = 94;
            // 
            // InventoryNameLabelText
            // 
            this.InventoryNameLabelText.AutoSize = true;
            this.InventoryNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryNameLabelText.Location = new System.Drawing.Point(4, 5);
            this.InventoryNameLabelText.Name = "InventoryNameLabelText";
            this.InventoryNameLabelText.Size = new System.Drawing.Size(35, 13);
            this.InventoryNameLabelText.TabIndex = 58;
            this.InventoryNameLabelText.Text = "Name";
            // 
            // InventoryQuantityLabelText
            // 
            this.InventoryQuantityLabelText.AutoSize = true;
            this.InventoryQuantityLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryQuantityLabelText.Location = new System.Drawing.Point(172, 5);
            this.InventoryQuantityLabelText.Name = "InventoryQuantityLabelText";
            this.InventoryQuantityLabelText.Size = new System.Drawing.Size(47, 13);
            this.InventoryQuantityLabelText.TabIndex = 60;
            this.InventoryQuantityLabelText.Text = "Quantity";
            // 
            // InventoryValuesContainer
            // 
            this.InventoryValuesContainer.BackColor = System.Drawing.Color.White;
            this.InventoryValuesContainer.Controls.Add(this.InventoryLabelContainer);
            this.InventoryValuesContainer.Location = new System.Drawing.Point(8, 69);
            this.InventoryValuesContainer.Name = "InventoryValuesContainer";
            this.InventoryValuesContainer.Size = new System.Drawing.Size(227, 243);
            this.InventoryValuesContainer.TabIndex = 93;
            // 
            // InventoryLabelContainer
            // 
            this.InventoryLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InventoryLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InventoryLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.InventoryLabelContainer.Controls.Add(this.InventoryLabelText);
            this.InventoryLabelContainer.Location = new System.Drawing.Point(0, 0);
            this.InventoryLabelContainer.Name = "InventoryLabelContainer";
            this.InventoryLabelContainer.Size = new System.Drawing.Size(227, 23);
            this.InventoryLabelContainer.TabIndex = 88;
            // 
            // InventoryLabelText
            // 
            this.InventoryLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InventoryLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabelText.Location = new System.Drawing.Point(0, 0);
            this.InventoryLabelText.Name = "InventoryLabelText";
            this.InventoryLabelText.Size = new System.Drawing.Size(227, 23);
            this.InventoryLabelText.TabIndex = 8;
            this.InventoryLabelText.Text = "INVENTORY";
            this.InventoryLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlatinumPiecesValueContainer
            // 
            this.PlatinumPiecesValueContainer.BackColor = System.Drawing.Color.White;
            this.PlatinumPiecesValueContainer.Controls.Add(this.PlatinumPiecesValueTextBox);
            this.PlatinumPiecesValueContainer.Location = new System.Drawing.Point(183, 30);
            this.PlatinumPiecesValueContainer.Name = "PlatinumPiecesValueContainer";
            this.PlatinumPiecesValueContainer.Size = new System.Drawing.Size(52, 33);
            this.PlatinumPiecesValueContainer.TabIndex = 18;
            // 
            // PlatinumPiecesValueTextBox
            // 
            this.PlatinumPiecesValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlatinumPiecesValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatinumPiecesValueTextBox.Location = new System.Drawing.Point(0, 6);
            this.PlatinumPiecesValueTextBox.Name = "PlatinumPiecesValueTextBox";
            this.PlatinumPiecesValueTextBox.Size = new System.Drawing.Size(52, 20);
            this.PlatinumPiecesValueTextBox.TabIndex = 3;
            this.PlatinumPiecesValueTextBox.TabStop = false;
            this.PlatinumPiecesValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoldPiecesValueContainer
            // 
            this.GoldPiecesValueContainer.BackColor = System.Drawing.Color.White;
            this.GoldPiecesValueContainer.Controls.Add(this.GoldPiecesValueTextBox);
            this.GoldPiecesValueContainer.Location = new System.Drawing.Point(125, 30);
            this.GoldPiecesValueContainer.Name = "GoldPiecesValueContainer";
            this.GoldPiecesValueContainer.Size = new System.Drawing.Size(52, 33);
            this.GoldPiecesValueContainer.TabIndex = 18;
            // 
            // GoldPiecesValueTextBox
            // 
            this.GoldPiecesValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldPiecesValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldPiecesValueTextBox.Location = new System.Drawing.Point(0, 6);
            this.GoldPiecesValueTextBox.Name = "GoldPiecesValueTextBox";
            this.GoldPiecesValueTextBox.Size = new System.Drawing.Size(52, 20);
            this.GoldPiecesValueTextBox.TabIndex = 3;
            this.GoldPiecesValueTextBox.TabStop = false;
            this.GoldPiecesValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlatinumPiecesLabelContainer
            // 
            this.PlatinumPiecesLabelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(166)))), ((int)(((byte)(169)))));
            this.PlatinumPiecesLabelContainer.Controls.Add(this.PlatinumPiecesLabelText);
            this.PlatinumPiecesLabelContainer.Location = new System.Drawing.Point(183, 8);
            this.PlatinumPiecesLabelContainer.Name = "PlatinumPiecesLabelContainer";
            this.PlatinumPiecesLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.PlatinumPiecesLabelContainer.Size = new System.Drawing.Size(52, 23);
            this.PlatinumPiecesLabelContainer.TabIndex = 17;
            // 
            // PlatinumPiecesLabelText
            // 
            this.PlatinumPiecesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatinumPiecesLabelText.Location = new System.Drawing.Point(0, 0);
            this.PlatinumPiecesLabelText.Name = "PlatinumPiecesLabelText";
            this.PlatinumPiecesLabelText.Size = new System.Drawing.Size(52, 23);
            this.PlatinumPiecesLabelText.TabIndex = 90;
            this.PlatinumPiecesLabelText.Text = "PP";
            this.PlatinumPiecesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SilverPiecesValueContainer
            // 
            this.SilverPiecesValueContainer.BackColor = System.Drawing.Color.White;
            this.SilverPiecesValueContainer.Controls.Add(this.SilverPiecesValueTextBox);
            this.SilverPiecesValueContainer.Location = new System.Drawing.Point(66, 30);
            this.SilverPiecesValueContainer.Name = "SilverPiecesValueContainer";
            this.SilverPiecesValueContainer.Size = new System.Drawing.Size(52, 33);
            this.SilverPiecesValueContainer.TabIndex = 18;
            // 
            // SilverPiecesValueTextBox
            // 
            this.SilverPiecesValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SilverPiecesValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilverPiecesValueTextBox.Location = new System.Drawing.Point(0, 6);
            this.SilverPiecesValueTextBox.Name = "SilverPiecesValueTextBox";
            this.SilverPiecesValueTextBox.Size = new System.Drawing.Size(52, 20);
            this.SilverPiecesValueTextBox.TabIndex = 3;
            this.SilverPiecesValueTextBox.TabStop = false;
            this.SilverPiecesValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoldPiecesLabelContainer
            // 
            this.GoldPiecesLabelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(171)))), ((int)(((byte)(61)))));
            this.GoldPiecesLabelContainer.Controls.Add(this.GoldPiecesLabelText);
            this.GoldPiecesLabelContainer.Location = new System.Drawing.Point(125, 8);
            this.GoldPiecesLabelContainer.Name = "GoldPiecesLabelContainer";
            this.GoldPiecesLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.GoldPiecesLabelContainer.Size = new System.Drawing.Size(52, 23);
            this.GoldPiecesLabelContainer.TabIndex = 17;
            // 
            // GoldPiecesLabelText
            // 
            this.GoldPiecesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldPiecesLabelText.Location = new System.Drawing.Point(0, 0);
            this.GoldPiecesLabelText.Name = "GoldPiecesLabelText";
            this.GoldPiecesLabelText.Size = new System.Drawing.Size(52, 23);
            this.GoldPiecesLabelText.TabIndex = 89;
            this.GoldPiecesLabelText.Text = "GP";
            this.GoldPiecesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CopperPiecesValueContainer
            // 
            this.CopperPiecesValueContainer.BackColor = System.Drawing.Color.White;
            this.CopperPiecesValueContainer.Controls.Add(this.CopperPiecesValueTextBox);
            this.CopperPiecesValueContainer.Location = new System.Drawing.Point(8, 30);
            this.CopperPiecesValueContainer.Name = "CopperPiecesValueContainer";
            this.CopperPiecesValueContainer.Size = new System.Drawing.Size(52, 33);
            this.CopperPiecesValueContainer.TabIndex = 16;
            // 
            // CopperPiecesValueTextBox
            // 
            this.CopperPiecesValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CopperPiecesValueTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopperPiecesValueTextBox.Location = new System.Drawing.Point(0, 6);
            this.CopperPiecesValueTextBox.Name = "CopperPiecesValueTextBox";
            this.CopperPiecesValueTextBox.Size = new System.Drawing.Size(52, 20);
            this.CopperPiecesValueTextBox.TabIndex = 3;
            this.CopperPiecesValueTextBox.TabStop = false;
            this.CopperPiecesValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SilverPiecesLabelContainer
            // 
            this.SilverPiecesLabelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(164)))), ((int)(((byte)(174)))));
            this.SilverPiecesLabelContainer.Controls.Add(this.SilverPiecesLabelText);
            this.SilverPiecesLabelContainer.Location = new System.Drawing.Point(66, 8);
            this.SilverPiecesLabelContainer.Name = "SilverPiecesLabelContainer";
            this.SilverPiecesLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.SilverPiecesLabelContainer.Size = new System.Drawing.Size(52, 23);
            this.SilverPiecesLabelContainer.TabIndex = 17;
            // 
            // SilverPiecesLabelText
            // 
            this.SilverPiecesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilverPiecesLabelText.Location = new System.Drawing.Point(0, 0);
            this.SilverPiecesLabelText.Name = "SilverPiecesLabelText";
            this.SilverPiecesLabelText.Size = new System.Drawing.Size(52, 23);
            this.SilverPiecesLabelText.TabIndex = 88;
            this.SilverPiecesLabelText.Text = "SP";
            this.SilverPiecesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoppierPiecesLabelContainer
            // 
            this.CoppierPiecesLabelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(146)))), ((int)(((byte)(121)))));
            this.CoppierPiecesLabelContainer.Controls.Add(this.CoppierPiecesLabelText);
            this.CoppierPiecesLabelContainer.Location = new System.Drawing.Point(8, 8);
            this.CoppierPiecesLabelContainer.Name = "CoppierPiecesLabelContainer";
            this.CoppierPiecesLabelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.CoppierPiecesLabelContainer.Size = new System.Drawing.Size(52, 23);
            this.CoppierPiecesLabelContainer.TabIndex = 15;
            // 
            // CoppierPiecesLabelText
            // 
            this.CoppierPiecesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoppierPiecesLabelText.Location = new System.Drawing.Point(0, 0);
            this.CoppierPiecesLabelText.Name = "CoppierPiecesLabelText";
            this.CoppierPiecesLabelText.Size = new System.Drawing.Size(52, 23);
            this.CoppierPiecesLabelText.TabIndex = 0;
            this.CoppierPiecesLabelText.Text = "CP";
            this.CoppierPiecesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LanguageProficienciesContainer
            // 
            this.LanguageProficienciesContainer.BackColor = System.Drawing.Color.LightGray;
            this.LanguageProficienciesContainer.Controls.Add(this.LanguageProficienciesHeaderContainer);
            this.LanguageProficienciesContainer.Controls.Add(this.LanguageProficienciesValuesContainer);
            this.LanguageProficienciesContainer.Location = new System.Drawing.Point(567, 345);
            this.LanguageProficienciesContainer.Name = "LanguageProficienciesContainer";
            this.LanguageProficienciesContainer.Padding = new System.Windows.Forms.Padding(5);
            this.LanguageProficienciesContainer.Size = new System.Drawing.Size(243, 176);
            this.LanguageProficienciesContainer.TabIndex = 88;
            // 
            // LanguageProficienciesHeaderContainer
            // 
            this.LanguageProficienciesHeaderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.LanguageProficienciesHeaderContainer.Controls.Add(this.LanguageProficienciesTypeLabelText);
            this.LanguageProficienciesHeaderContainer.Controls.Add(this.LanguageProficienciesNameLabelText);
            this.LanguageProficienciesHeaderContainer.Location = new System.Drawing.Point(9, 32);
            this.LanguageProficienciesHeaderContainer.Name = "LanguageProficienciesHeaderContainer";
            this.LanguageProficienciesHeaderContainer.Size = new System.Drawing.Size(226, 23);
            this.LanguageProficienciesHeaderContainer.TabIndex = 92;
            // 
            // LanguageProficienciesTypeLabelText
            // 
            this.LanguageProficienciesTypeLabelText.AutoSize = true;
            this.LanguageProficienciesTypeLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageProficienciesTypeLabelText.Location = new System.Drawing.Point(11, 5);
            this.LanguageProficienciesTypeLabelText.Name = "LanguageProficienciesTypeLabelText";
            this.LanguageProficienciesTypeLabelText.Size = new System.Drawing.Size(29, 13);
            this.LanguageProficienciesTypeLabelText.TabIndex = 59;
            this.LanguageProficienciesTypeLabelText.Text = "Type";
            // 
            // LanguageProficienciesNameLabelText
            // 
            this.LanguageProficienciesNameLabelText.AutoSize = true;
            this.LanguageProficienciesNameLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageProficienciesNameLabelText.Location = new System.Drawing.Point(155, 5);
            this.LanguageProficienciesNameLabelText.Name = "LanguageProficienciesNameLabelText";
            this.LanguageProficienciesNameLabelText.Size = new System.Drawing.Size(35, 13);
            this.LanguageProficienciesNameLabelText.TabIndex = 58;
            this.LanguageProficienciesNameLabelText.Text = "Name";
            // 
            // LanguageProficienciesValuesContainer
            // 
            this.LanguageProficienciesValuesContainer.BackColor = System.Drawing.Color.White;
            this.LanguageProficienciesValuesContainer.Controls.Add(this.LanguageProficienciesLabelContainer);
            this.LanguageProficienciesValuesContainer.Location = new System.Drawing.Point(9, 9);
            this.LanguageProficienciesValuesContainer.Name = "LanguageProficienciesValuesContainer";
            this.LanguageProficienciesValuesContainer.Size = new System.Drawing.Size(226, 158);
            this.LanguageProficienciesValuesContainer.TabIndex = 0;
            // 
            // LanguageProficienciesLabelContainer
            // 
            this.LanguageProficienciesLabelContainer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LanguageProficienciesLabelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LanguageProficienciesLabelContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.LanguageProficienciesLabelContainer.Controls.Add(this.LanguageProficienciesLabelText);
            this.LanguageProficienciesLabelContainer.Location = new System.Drawing.Point(-1, 0);
            this.LanguageProficienciesLabelContainer.Name = "LanguageProficienciesLabelContainer";
            this.LanguageProficienciesLabelContainer.Size = new System.Drawing.Size(227, 23);
            this.LanguageProficienciesLabelContainer.TabIndex = 88;
            // 
            // LanguageProficienciesLabelText
            // 
            this.LanguageProficienciesLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageProficienciesLabelText.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanguageProficienciesLabelText.Location = new System.Drawing.Point(0, 0);
            this.LanguageProficienciesLabelText.Name = "LanguageProficienciesLabelText";
            this.LanguageProficienciesLabelText.Size = new System.Drawing.Size(227, 23);
            this.LanguageProficienciesLabelText.TabIndex = 8;
            this.LanguageProficienciesLabelText.Text = "LANGUAGES AND PROFICIENCIES";
            this.LanguageProficienciesLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Checkbox.DataPropertyName = "IsEquipped";
            this.Checkbox.HeaderText = "Checkbox";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Checkbox.Width = 21;
            // 
            // BonusName
            // 
            this.BonusName.DataPropertyName = "bonusName";
            this.BonusName.HeaderText = "BonusName";
            this.BonusName.Name = "BonusName";
            this.BonusName.Width = 115;
            // 
            // AffectedValue
            // 
            this.AffectedValue.DataPropertyName = "affectedValue";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AffectedValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.AffectedValue.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.AffectedValue.HeaderText = "AffectedValue";
            this.AffectedValue.Name = "AffectedValue";
            this.AffectedValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Bonus
            // 
            this.Bonus.DataPropertyName = "bonus";
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            this.Bonus.Width = 35;
            // 
            // Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 860);
            this.Controls.Add(this.LanguageProficienciesContainer);
            this.Controls.Add(this.InventoryContainer);
            this.Controls.Add(this.CharacterAppearanceContainer);
            this.Controls.Add(this.ArmorContainer);
            this.Controls.Add(this.WeaponsContainer);
            this.Controls.Add(this.HitDiceContainer);
            this.Controls.Add(this.HitPointsContainer);
            this.Controls.Add(this.BattleStatsContainer);
            this.Controls.Add(this.CharacterInfoContainer);
            this.Controls.Add(this.CharacterNameLevelContainer);
            this.Controls.Add(this.ExtraBonusesContainer);
            this.Controls.Add(this.SkillsContainer);
            this.Controls.Add(this.SavingThrowsContainer);
            this.Controls.Add(this.ProficiencyContainer);
            this.Controls.Add(this.InspirationContainer);
            this.Controls.Add(this.AbilityScoresContainer);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sheet";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DnD 5e Interactive Sheet";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Sheet_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterAppearanceImage)).EndInit();
            this.AbilityScoresContainer.ResumeLayout(false);
            this.CharismaLabelContainer.ResumeLayout(false);
            this.CharismaContainer.ResumeLayout(false);
            this.CharismaContainer.PerformLayout();
            this.CharismaModifierContainer.ResumeLayout(false);
            this.WisdomLabelContainer.ResumeLayout(false);
            this.WisdomContainer.ResumeLayout(false);
            this.WisdomContainer.PerformLayout();
            this.WisdomModifierContainer.ResumeLayout(false);
            this.IntelligenceLabelContainer.ResumeLayout(false);
            this.IntelligenceContainer.ResumeLayout(false);
            this.IntelligenceContainer.PerformLayout();
            this.IntelligenceModifierContainer.ResumeLayout(false);
            this.ConstitutionLabelContainer.ResumeLayout(false);
            this.ConstitutionContainer.ResumeLayout(false);
            this.ConstitutionContainer.PerformLayout();
            this.ConstitutionModifierContainer.ResumeLayout(false);
            this.DexterityLabelContainer.ResumeLayout(false);
            this.DexterityContainer.ResumeLayout(false);
            this.DexterityContainer.PerformLayout();
            this.DexterityModifierContainer.ResumeLayout(false);
            this.StrengthLabelContainer.ResumeLayout(false);
            this.StrengthContainer.ResumeLayout(false);
            this.StrengthContainer.PerformLayout();
            this.StrengthModifierContainer.ResumeLayout(false);
            this.InspirationContainer.ResumeLayout(false);
            this.InspirationValueContainer.ResumeLayout(false);
            this.InspirationValueContainer.PerformLayout();
            this.InspirationLabelContainer.ResumeLayout(false);
            this.ProficiencyContainer.ResumeLayout(false);
            this.ProficiencyValueContainer.ResumeLayout(false);
            this.ProficiencyLabelContainer.ResumeLayout(false);
            this.SavingThrowsContainer.ResumeLayout(false);
            this.SavingThrowsContainer.PerformLayout();
            this.SavingThrowsValuesContainer.ResumeLayout(false);
            this.SavingThrowsLabelsContainer.ResumeLayout(false);
            this.SavingThrowsLabelsContainer.PerformLayout();
            this.SkillsContainer.ResumeLayout(false);
            this.SkillsContainer.PerformLayout();
            this.SkillsValuesContainer.ResumeLayout(false);
            this.SkillsLabelsContainer.ResumeLayout(false);
            this.SkillsLabelsContainer.PerformLayout();
            this.ExtraBonusesContainer.ResumeLayout(false);
            this.ExtraBonusesHeaderContainer.ResumeLayout(false);
            this.ExtraBonusesHeaderContainer.PerformLayout();
            this.ExtraBonusesValuesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExtraBonusesGridView)).EndInit();
            this.ExtraBonusesLabelContainer.ResumeLayout(false);
            this.CharacterNameLevelContainer.ResumeLayout(false);
            this.CharacterLevelValueContainer.ResumeLayout(false);
            this.CharacterLevelValueContainer.PerformLayout();
            this.CharacterNameValueContainer.ResumeLayout(false);
            this.CharacterNameValueContainer.PerformLayout();
            this.CharacterLevelLabelContainer.ResumeLayout(false);
            this.CharacterNameLabelContainer.ResumeLayout(false);
            this.CharacterInfoContainer.ResumeLayout(false);
            this.ExpValueContainer.ResumeLayout(false);
            this.ExpValueContainer.PerformLayout();
            this.ExpLabelContainer.ResumeLayout(false);
            this.AlignmentValueContainer.ResumeLayout(false);
            this.AlignmentValueContainer.PerformLayout();
            this.AlignmentLabelContainer.ResumeLayout(false);
            this.BackgroundValueContainer.ResumeLayout(false);
            this.BackgroundValueContainer.PerformLayout();
            this.RaceValueContainer.ResumeLayout(false);
            this.RaceValueContainer.PerformLayout();
            this.BackgroundLabelContainer.ResumeLayout(false);
            this.ClassValueContainer.ResumeLayout(false);
            this.ClassValueContainer.PerformLayout();
            this.RaceLabelContainer.ResumeLayout(false);
            this.ClassLabelContainer.ResumeLayout(false);
            this.BattleStatsContainer.ResumeLayout(false);
            this.SpeedValueContainer.ResumeLayout(false);
            this.SpeedValueContainer.PerformLayout();
            this.SpeedLabelContainer.ResumeLayout(false);
            this.InitiativeValueContainer.ResumeLayout(false);
            this.InitiativeLabelContainer.ResumeLayout(false);
            this.ArmorClassValueContainer.ResumeLayout(false);
            this.ArmorClassLabelContainer.ResumeLayout(false);
            this.HitPointsContainer.ResumeLayout(false);
            this.CurrentHitPointsValueContainer.ResumeLayout(false);
            this.CurrentHitPointsLabelContainer.ResumeLayout(false);
            this.MaxHitPointsValueContainer.ResumeLayout(false);
            this.MaxHitPointsValueContainer.PerformLayout();
            this.MaxHitPointsLabelContainer.ResumeLayout(false);
            this.HitDiceContainer.ResumeLayout(false);
            this.RemainingHitDiceValueContainer.ResumeLayout(false);
            this.RemainingHitDiceValueContainer.PerformLayout();
            this.TotalHitDiceValueContainer.ResumeLayout(false);
            this.RemainingHitDiceLabelContainer.ResumeLayout(false);
            this.DeathSavesValueContainer.ResumeLayout(false);
            this.DeathSavesValueContainer.PerformLayout();
            this.DeathSavesLabelContainer.ResumeLayout(false);
            this.TotalHitDiceLabelContainer.ResumeLayout(false);
            this.HitDiceValueContainer.ResumeLayout(false);
            this.HitDiceValueContainer.PerformLayout();
            this.HitDiceLabelContainer.ResumeLayout(false);
            this.WeaponsContainer.ResumeLayout(false);
            this.WeaponsHeaderContainer.ResumeLayout(false);
            this.WeaponsHeaderContainer.PerformLayout();
            this.WeaponsValuesContainer.ResumeLayout(false);
            this.WeaponsLabelContainer.ResumeLayout(false);
            this.ArmorContainer.ResumeLayout(false);
            this.ArmorHeaderContainer.ResumeLayout(false);
            this.ArmorHeaderContainer.PerformLayout();
            this.ArmorValuesContainer.ResumeLayout(false);
            this.ArmorLabelContainer.ResumeLayout(false);
            this.CharacterAppearanceContainer.ResumeLayout(false);
            this.InventoryContainer.ResumeLayout(false);
            this.InventoryHeaderContainer.ResumeLayout(false);
            this.InventoryHeaderContainer.PerformLayout();
            this.InventoryValuesContainer.ResumeLayout(false);
            this.InventoryLabelContainer.ResumeLayout(false);
            this.PlatinumPiecesValueContainer.ResumeLayout(false);
            this.PlatinumPiecesValueContainer.PerformLayout();
            this.GoldPiecesValueContainer.ResumeLayout(false);
            this.GoldPiecesValueContainer.PerformLayout();
            this.PlatinumPiecesLabelContainer.ResumeLayout(false);
            this.SilverPiecesValueContainer.ResumeLayout(false);
            this.SilverPiecesValueContainer.PerformLayout();
            this.GoldPiecesLabelContainer.ResumeLayout(false);
            this.CopperPiecesValueContainer.ResumeLayout(false);
            this.CopperPiecesValueContainer.PerformLayout();
            this.SilverPiecesLabelContainer.ResumeLayout(false);
            this.CoppierPiecesLabelContainer.ResumeLayout(false);
            this.LanguageProficienciesContainer.ResumeLayout(false);
            this.LanguageProficienciesHeaderContainer.ResumeLayout(false);
            this.LanguageProficienciesHeaderContainer.PerformLayout();
            this.LanguageProficienciesValuesContainer.ResumeLayout(false);
            this.LanguageProficienciesLabelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CharacterNameLabelText;
        private System.Windows.Forms.Label ClassLabelText;
        private System.Windows.Forms.Label LevelLabelText;
        private System.Windows.Forms.Label StrengthLabelText;
        private System.Windows.Forms.Label InspirationLabelText;
        private System.Windows.Forms.Label StrengthSavingThrowLabelText;
        private System.Windows.Forms.Label DexteritySavingThrowLabelText;
        private System.Windows.Forms.Label ConstitutionSavingThrowLabelText;
        private System.Windows.Forms.Label IntelligenceSavingThrowLabelText;
        private System.Windows.Forms.Label WisdomSavingThrowLabelText;
        private System.Windows.Forms.Label CharismaSavingThrowLabelText;
        private System.Windows.Forms.PictureBox CharacterAppearanceImage;
        private System.Windows.Forms.Label HistoryLabelText;
        private System.Windows.Forms.Label DeceptionLabelText;
        private System.Windows.Forms.Label AthleticsLabelText;
        private System.Windows.Forms.Label ArcanaLabelText;
        private System.Windows.Forms.Label AnimalHandlingLabelText;
        private System.Windows.Forms.Label AcrobaticsLabelText;
        private System.Windows.Forms.Label PerceptionLabelText;
        private System.Windows.Forms.Label NatureLabelText;
        private System.Windows.Forms.Label MedicineLabelText;
        private System.Windows.Forms.Label InvestigationLabelText;
        private System.Windows.Forms.Label IntimidationLabelText;
        private System.Windows.Forms.Label InsightLabelText;
        private System.Windows.Forms.Label SurvivalLabelText;
        private System.Windows.Forms.Label StealthLabelText;
        private System.Windows.Forms.Label SleightOfHandLabelText;
        private System.Windows.Forms.Label ReligionLabelText;
        private System.Windows.Forms.Label PersuasionLabelText;
        private System.Windows.Forms.Label PerformanceLabelText;
        private System.Windows.Forms.Button ResetCurrentHitPointsButton;
        private System.Windows.Forms.Button HealHitPointsButton;
        private System.Windows.Forms.Label SuccessDeathSaveLabelText;
        private System.Windows.Forms.Label FailureDeathSaveLabelText;
        private System.Windows.Forms.Label WeaponsNameLabelText;
        private System.Windows.Forms.Label WeaponsAttackBonusLabelText;
        private System.Windows.Forms.Label WeaponsDamageLabelText;
        private System.Windows.Forms.Panel StrengthContainer;
        private System.Windows.Forms.Panel StrengthLabelContainer;
        private System.Windows.Forms.Panel ConstitutionLabelContainer;
        private System.Windows.Forms.Label ConstitutionLabelText;
        private System.Windows.Forms.Panel ConstitutionContainer;
        private System.Windows.Forms.Panel DexterityLabelContainer;
        private System.Windows.Forms.Label DexterityLabelText;
        private System.Windows.Forms.Panel DexterityContainer;
        private System.Windows.Forms.Panel CharismaLabelContainer;
        private System.Windows.Forms.Label CharismaLabelText;
        private System.Windows.Forms.Panel CharismaContainer;
        private System.Windows.Forms.Panel WisdomLabelContainer;
        private System.Windows.Forms.Label WisdomLabelText;
        private System.Windows.Forms.Panel WisdomContainer;
        private System.Windows.Forms.Panel IntelligenceLabelContainer;
        private System.Windows.Forms.Label IntelligenceLabelText;
        private System.Windows.Forms.Panel IntelligenceContainer;
        private System.Windows.Forms.Panel InspirationValueContainer;
        private System.Windows.Forms.Panel InspirationLabelContainer;
        private System.Windows.Forms.Panel ProficiencyValueContainer;
        private System.Windows.Forms.Panel ProficiencyLabelContainer;
        private System.Windows.Forms.Label ProficiencyLabelText;
        private System.Windows.Forms.Panel SavingThrowsValuesContainer;
        private System.Windows.Forms.Panel SavingThrowsLabelsContainer;
        private Panel StrengthModifierContainer;
        private Panel CharismaModifierContainer;
        private Panel WisdomModifierContainer;
        private Panel IntelligenceModifierContainer;
        private Panel ConstitutionModifierContainer;
        private Panel DexterityModifierContainer;
        private Panel SkillsValuesContainer;
        private Panel SkillsLabelsContainer;
        private Label DexTipTwo;
        private Label DexTipOne;
        private Label DexTipThree;
        private Label WisTipFive;
        private Label WisTipFour;
        private Label WisTipThree;
        private Label WisTipTwo;
        private Label WisTipOne;
        private Label ChaTipFour;
        private Label ChaTipThree;
        private Label ChaTipTwo;
        private Label ChaTipOne;
        private Label StrTipOne;
        private Label IntTipFive;
        private Label IntTipFour;
        private Label IntTipThree;
        private Label IntTipTwo;
        private Label IntTipOne;
        private Panel ExtraBonusesValuesContainer;
        private Label ExtraBonusesBonusLabelText;
        private Label ExtraBonusesAffectedValueLabelText;
        private Label ExtraBonusesNameLabelText;
        private Panel ExtraBonusesLabelContainer;
        private Label ExtraBonusesLabelText;
        private Panel ExtraBonusesHeaderContainer;
        private Panel CharacterLevelLabelContainer;
        private Panel CharacterNameLabelContainer;
        private Panel CharacterLevelValueContainer;
        private Panel CharacterNameValueContainer;
        private TextBox CharacterNameValueTextBox;
        private TextBox CharacterLevelValueTextBox;
        private Label ProficiencyBonusValueText;
        private Label StrengthModifierValueText;
        private Label DexterityModifierValueText;
        private Label ConstitutionModifierValueText;
        private Label IntelligenceModifierValueText;
        private Label WisdomModifierValueText;
        private Label CharismaModifierValueText;
        private TextBox DexterityValueTextBox;
        private TextBox ConstitutionValueTextBox;
        private TextBox WisdomValueTextBox;
        private TextBox IntelligenceValueTextBox;
        private TextBox CharismaValueTextBox;
        private TextBox InspirationValueTextBox;
        private Panel ClassValueContainer;
        private TextBox ClassValueTextBox;
        private Panel ClassLabelContainer;
        private Panel AlignmentValueContainer;
        private TextBox AlignmentValueTextBox;
        private Panel AlignmentLabelContainer;
        private Label AlignmentLabelText;
        private Panel BackgroundValueContainer;
        private TextBox BackgroundValueTextBox;
        private Panel RaceValueContainer;
        private TextBox RaceValueTextBox;
        private Panel BackgroundLabelContainer;
        private Label BackgroundLabelText;
        private Panel RaceLabelContainer;
        private Label RaceLabelText;
        private Panel ExpValueContainer;
        private TextBox ExpValueTextBox;
        private Panel ExpLabelContainer;
        private Label ExpLabelText;
        private Panel SpeedValueContainer;
        private Panel SpeedLabelContainer;
        private Label SpeedLabelText;
        private Panel InitiativeValueContainer;
        private Panel InitiativeLabelContainer;
        private Label InitiativeLabelText;
        private Panel ArmorClassValueContainer;
        private Panel ArmorClassLabelContainer;
        private Label ArmorClassLabelText;
        private TextBox SpeedValueTextBox;
        private Panel CurrentHitPointsLabelContainer;
        private Label CurrentHitPointsLabelText;
        private Panel MaxHitPointsValueContainer;
        private Panel MaxHitPointsLabelContainer;
        private Label MaxHitPointsLabelText;
        private Button ReceiveDamageButton;
        private Button AddTemporaryHitPointsButton;
        private TextBox MaxHitPointsValueTextBox;
        private Panel RemainingHitDiceValueContainer;
        private Panel TotalHitDiceValueContainer;
        private Panel RemainingHitDiceLabelContainer;
        private Label RemainingHitDiceLabelText;
        private Panel DeathSavesValueContainer;
        private Panel DeathSavesLabelContainer;
        private Label DeathSavesLabelText;
        private Panel TotalHitDiceLabelContainer;
        private Label TotalHitDiceLabelText;
        private Panel HitDiceValueContainer;
        private Panel HitDiceLabelContainer;
        private Label HitDiceLabelText;
        private CheckBox FailureDeathSaveCheckBoxThree;
        private CheckBox FailureDeathSaveCheckBoxTwo;
        private CheckBox FailureDeathSaveCheckBoxOne;
        private CheckBox SuccessDeathSaveCheckBoxThree;
        private CheckBox SuccessDeathSaveCheckBoxTwo;
        private CheckBox SuccessDeathSaveCheckBoxOne;
        private TextBox HitDiceValueTextBox;
        private TextBox RemainingHitDiceValueTextBox;
        private Label TotalHitDiceValueText;
        private Button RefillHitDiceButton;
        private Panel WeaponsHeaderContainer;
        private Panel WeaponsValuesContainer;
        private Panel WeaponsLabelContainer;
        private Label WeaponsLabelText;
        private Panel ArmorHeaderContainer;
        private Label ArmorNameLabelText;
        private Label ArmorTypeLabelText;
        private Label ArmorACBonusLabelText;
        private Panel ArmorValuesContainer;
        private Panel ArmorLabelContainer;
        private Label ArmorLabelText;
        private Panel PlatinumPiecesValueContainer;
        private Panel GoldPiecesValueContainer;
        private Panel PlatinumPiecesLabelContainer;
        private Panel SilverPiecesValueContainer;
        private Panel GoldPiecesLabelContainer;
        private Panel CopperPiecesValueContainer;
        private Panel SilverPiecesLabelContainer;
        private Panel CoppierPiecesLabelContainer;
        private Label CoppierPiecesLabelText;
        private Label PlatinumPiecesLabelText;
        private Label GoldPiecesLabelText;
        private TextBox CopperPiecesValueTextBox;
        private Label SilverPiecesLabelText;
        private TextBox PlatinumPiecesValueTextBox;
        private TextBox GoldPiecesValueTextBox;
        private TextBox SilverPiecesValueTextBox;
        private Panel InventoryHeaderContainer;
        private Label InventoryNameLabelText;
        private Label InventoryQuantityLabelText;
        private Panel InventoryValuesContainer;
        private Panel InventoryLabelContainer;
        private Label InventoryLabelText;
        private Panel LanguageProficienciesHeaderContainer;
        private Label LanguageProficienciesNameLabelText;
        private Panel LanguageProficienciesValuesContainer;
        private Panel LanguageProficienciesLabelContainer;
        private Label LanguageProficienciesLabelText;
        private Label LanguageProficienciesTypeLabelText;
        private TextBox StrengthValueTextBox;
        public Label ArmorClassValueText;
        public Label SurvivalValueText;
        public Label StealthValueText;
        public Label SleightOfHandValueText;
        public Label ReligionValueText;
        public Label PersuasionValueText;
        public Label PerformanceValueText;
        public Label PerceptionValueText;
        public Label NatureValueText;
        public Label MedicineValueText;
        public Label InvestigationValueText;
        public Label IntimidationValueText;
        public Label InsightValueText;
        public Label HistoryValueText;
        public Label DeceptionValueText;
        public Label AthleticsValueText;
        public Label ArcanaValueText;
        public Label AnimalHandlingValueText;
        public Label AcrobaticsValueText;
        public Panel AbilityScoresContainer;
        public Panel InspirationContainer;
        public Panel ProficiencyContainer;
        public Panel SavingThrowsContainer;
        public Panel SkillsContainer;
        public Panel ExtraBonusesContainer;
        public Panel CharacterNameLevelContainer;
        public Panel CharacterInfoContainer;
        public Panel BattleStatsContainer;
        public Panel HitPointsContainer;
        public Panel HitDiceContainer;
        public Panel WeaponsContainer;
        public Panel ArmorContainer;
        public Panel CharacterAppearanceContainer;
        public Panel InventoryContainer;
        public Panel LanguageProficienciesContainer;
        public CheckBox SurvivalExpertiseCheckbox;
        public CheckBox StealthExpertiseCheckbox;
        public CheckBox SleightOfHandExpertiseCheckbox;
        public CheckBox ReligionExpertiseCheckbox;
        public CheckBox PersuasionExpertiseCheckbox;
        public CheckBox PerformanceExpertiseCheckbox;
        public CheckBox PerceptionExpertiseCheckbox;
        public CheckBox NatureExpertiseCheckbox;
        public CheckBox MedicineExpertiseCheckbox;
        public CheckBox InvestigationExpertiseCheckbox;
        public CheckBox IntimidationExpertiseCheckbox;
        public CheckBox InsightExpertiseCheckbox;
        public CheckBox HistoryExpertiseCheckbox;
        public CheckBox DeceptionExpertiseCheckbox;
        public CheckBox AthleticsExpertiseCheckbox;
        public CheckBox ArcanaExpertiseCheckbox;
        public CheckBox AnimalHandlingExpertiseCheckbox;
        public CheckBox AcrobaticsExpertiseCheckbox;
        public CheckBox SurvivalProficiencyCheckbox;
        public CheckBox StealthProficiencyCheckbox;
        public CheckBox SleightOfHandProficiencyCheckbox;
        public CheckBox ReligionProficiencyCheckbox;
        public CheckBox PersuasionProficiencyCheckbox;
        public CheckBox PerformanceProficiencyCheckbox;
        public CheckBox PerceptionProficiencyCheckbox;
        public CheckBox NatureProficiencyCheckbox;
        public CheckBox MedicineProficiencyCheckbox;
        public CheckBox InvestigationProficiencyCheckbox;
        public CheckBox IntimidationProficiencyCheckbox;
        public CheckBox InsightProficiencyCheckbox;
        public CheckBox HistoryProficiencyCheckbox;
        public CheckBox DeceptionProficiencyCheckbox;
        public CheckBox AthleticsProficiencyCheckbox;
        public CheckBox ArcanaProficiencyCheckbox;
        public CheckBox AnimalHandlingProficiencyCheckbox;
        public CheckBox AcrobaticsProficiencyCheckbox;
        public Label CharismaSavingThrowValueText;
        public Label WisdomSavingThrowValueText;
        public Label IntelligenceSavingThrowValueText;
        public Label ConstitutionSavingThrowValueText;
        public Label DexteritySavingThrowValueText;
        public Label StrengthSavingThrowValueText;
        public CheckBox StrengthSavingThrowProficiencyCheckbox;
        public CheckBox CharismaSavingThrowProficiencyCheckbox;
        public CheckBox WisdomSavingThrowProficiencyCheckbox;
        public CheckBox IntelligenceSavingThrowProficiencyCheckbox;
        public CheckBox ConstitutionSavingThrowProficiencyCheckbox;
        public CheckBox DexteritySavingThrowProficiencyCheckbox;
        public Label InitiativeValueText;
        private Panel CurrentHitPointsValueContainer;
        public RichTextBox CurrentHitPointsValueText;
        public DataGridView ExtraBonusesGridView;
        private DataGridViewCheckBoxColumn Checkbox;
        private DataGridViewTextBoxColumn BonusName;
        private DataGridViewComboBoxColumn AffectedValue;
        private DataGridViewTextBoxColumn Bonus;
    }
}


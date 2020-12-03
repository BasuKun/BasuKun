using DnDSheet.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet
{
    public partial class Sheet : Form
    {
        public static Sheet Instance;

        public Sheet()
        {
            Instance = this;
            InitializeComponent();
            CurrentHitPointsValueText.SelectionAlignment = HorizontalAlignment.Center;
            SkillsLibrary.PopulateSkillsDictionary();
            SavingThrowsLibrary.PopulateSavingThrowsDictionary();
            CanHealButtonBeUsed();
            CanReceiveDamageBeUsed();

            var bindingList = new BindingList<ExtraBonus>(ExtraBonusList.list);
            var source = new BindingSource(bindingList, null);
            ExtraBonusesGridView.DataSource = source;
            (ExtraBonusesGridView.Columns["affectedValue"] as DataGridViewComboBoxColumn).DataSource = Enum.GetValues(typeof(AffectedValues.values));
            ExtraBonusesGridView.CurrentCell = null;
        }

        private void OnButtonPress(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // 
        // MOUSE CLICKS
        // 
        private void Sheet_MouseClick(object sender, MouseEventArgs e)
        {
            CloseAllHPPopups();

            this.ActiveControl = null;
        }

        // 
        // STRENGTH ABILITY SCORE
        // 
        private void StrengthValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(StrengthValueTextBox.Text, out int result))
            {
                StrengthAbilityScore.SetValue(StrengthValueTextBox.Text);

                StrengthModifierValueText.Text = null;
                if (StrengthAbilityScore.strengthModifier >= 0)
                {
                    StrengthModifierValueText.Text = "+";
                }
                StrengthModifierValueText.Text += StrengthAbilityScore.strengthModifier.ToString();
            }
        }
        private void StrengthValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // DEXTERITY ABILITY SCORE
        // 
        private void DexterityValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(DexterityValueTextBox.Text, out int result))
            {
                DexterityAbilityScore.SetValue(DexterityValueTextBox.Text);

                DexterityModifierValueText.Text = null;
                if (DexterityAbilityScore.dexterityModifier >= 0)
                {
                    DexterityModifierValueText.Text = "+";
                }
                DexterityModifierValueText.Text += DexterityAbilityScore.dexterityModifier.ToString();
            }
        }
        private void DexterityValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // CONSTITUTION ABILITY SCORE
        // 
        private void ConstitutionValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(ConstitutionValueTextBox.Text, out int result))
            {
                ConstitutionAbilityScore.SetValue(ConstitutionValueTextBox.Text);

                ConstitutionModifierValueText.Text = null;
                if (ConstitutionAbilityScore.constitutionModifier >= 0)
                {
                    ConstitutionModifierValueText.Text = "+";
                }
                ConstitutionModifierValueText.Text += ConstitutionAbilityScore.constitutionModifier.ToString();
            }
        }
        private void ConstitutionValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // INTELLIGENCE ABILITY SCORE
        // 
        private void IntelligenceValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(IntelligenceValueTextBox.Text, out int result))
            {
                IntelligenceAbilityScore.SetValue(IntelligenceValueTextBox.Text);

                IntelligenceModifierValueText.Text = null;
                if (IntelligenceAbilityScore.intelligenceModifier >= 0)
                {
                    IntelligenceModifierValueText.Text = "+";
                }
                IntelligenceModifierValueText.Text += IntelligenceAbilityScore.intelligenceModifier.ToString();
            }
        }
        private void IntelligenceValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // WISDOM ABILITY SCORE
        // 
        private void WisdomValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(WisdomValueTextBox.Text, out int result))
            {
                WisdomAbilityScore.SetValue(WisdomValueTextBox.Text);

                WisdomModifierValueText.Text = null;
                if (WisdomAbilityScore.wisdomModifier >= 0)
                {
                    WisdomModifierValueText.Text = "+";
                }
                WisdomModifierValueText.Text += WisdomAbilityScore.wisdomModifier.ToString();
            }
        }
        private void WisdomValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // CHARISMA ABILITY SCORE
        // 
        private void CharismaValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(CharismaValueTextBox.Text, out int result))
            {
                CharismaAbilityScore.SetValue(CharismaValueTextBox.Text);

                CharismaModifierValueText.Text = null;
                if (CharismaAbilityScore.charismaModifier >= 0)
                {
                    CharismaModifierValueText.Text = "+";
                }
                CharismaModifierValueText.Text += CharismaAbilityScore.charismaModifier.ToString();
            }
        }
        private void CharismaValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // NAME
        // 
        private void CharacterNameValueTextBox_Leave(object sender, EventArgs e)
        {
            CharacterInfo.characterName = CharacterNameValueTextBox.Text;
        }
        private void CharacterNameValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // LEVEL
        // 
        private void CharacterLevelValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(CharacterLevelValueTextBox.Text, out int result))
            {
                CharacterInfo.level = int.Parse(CharacterLevelValueTextBox.Text);
                CharacterInfo.SetProficiencyBonus();
                ProficiencyBonusValueText.Text = "+" + CharacterInfo.proficiencyBonus.ToString();
            }
        }
        private void CharacterLevelValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // CLASS
        // 
        private void ClassValueTextBox_Leave(object sender, EventArgs e)
        {
            CharacterInfo.characterClass = ClassValueTextBox.Text;
        }
        private void ClassValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // RACE
        // 
        private void RaceValueTextBox_Leave(object sender, EventArgs e)
        {
            CharacterInfo.characterRace = RaceValueTextBox.Text;
        }
        private void RaceValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // BACKGROUND
        // 
        private void BackgroundValueTextBox_Leave(object sender, EventArgs e)
        {
            CharacterInfo.characterBackground = BackgroundValueTextBox.Text;
        }
        private void BackgroundValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // ALIGNMENT
        // 
        private void AlignmentValueTextBox_Leave(object sender, EventArgs e)
        {
            CharacterInfo.characterAlignment = AlignmentValueTextBox.Text;
        }
        private void AlignmentValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // EXP
        // 
        private void ExpValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(ExpValueTextBox.Text, out int result))
            {
                CharacterInfo.experiencePoints = int.Parse(ExpValueTextBox.Text);
            }
        }
        private void ExpValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // INSPIRATION
        // 
        private void InspirationValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(InspirationValueTextBox.Text, out int result))
            {
                CharacterInfo.inspiration = int.Parse(InspirationValueTextBox.Text);
            }
        }
        private void InspirationValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // SKILLS CHECKBOXES
        // 
        private void AcrobaticsExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Acrobatics"].UpdateText();
        }
        private void AcrobaticsProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Acrobatics"].UpdateText();
        }
        private void AnimalHandlingExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Animal_Handling"].UpdateText();
        }
        private void AnimalHandlingProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Animal_Handling"].UpdateText();
        }
        private void ArcanaExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Arcana"].UpdateText();
        }
        private void ArcanaProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Arcana"].UpdateText();
        }
        private void AthleticsExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Athletics"].UpdateText();
        }
        private void AthleticsProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Athletics"].UpdateText();
        }
        private void DeceptionExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Deception"].UpdateText();
        }
        private void DeceptionProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Deception"].UpdateText();
        }
        private void HistoryExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["History"].UpdateText();
        }
        private void HistoryProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["History"].UpdateText();
        }
        private void InsightExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Insight"].UpdateText();
        }
        private void InsightProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Insight"].UpdateText();
        }
        private void IntimidationExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Intimidation"].UpdateText();
        }
        private void IntimidationProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Intimidation"].UpdateText();
        }
        private void InvestigationExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Investigation"].UpdateText();
        }
        private void InvestigationProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Investigation"].UpdateText();
        }
        private void MedicineExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Medicine"].UpdateText();
        }
        private void MedicineProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Medicine"].UpdateText();
        }
        private void NatureExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Nature"].UpdateText();
        }
        private void NatureProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Nature"].UpdateText();
        }
        private void PerceptionExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Perception"].UpdateText();
        }
        private void PerceptionProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Perception"].UpdateText();
        }
        private void PerformanceExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Performance"].UpdateText();
        }
        private void PerformanceProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Performance"].UpdateText();
        }
        private void PersuasionExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Persuasion"].UpdateText();
        }
        private void PersuasionProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Persuasion"].UpdateText();
        }
        private void ReligionExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Religion"].UpdateText();
        }
        private void ReligionProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Religion"].UpdateText();
        }
        private void SleightOfHandExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Sleight_Of_Hand"].UpdateText();
        }
        private void SleightOfHandProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Sleight_Of_Hand"].UpdateText();
        }
        private void StealthExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Stealth"].UpdateText();
        }
        private void StealthProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Stealth"].UpdateText();
        }
        private void SurvivalExpertiseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Survival"].UpdateText();
        }
        private void SurvivalProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SkillsLibrary.SkillsDictionary["Survival"].UpdateText();
        }

        // 
        // SAVING THROWS CHECKBOXES
        // 
        private void StrengthSavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["STR_Saving_Throw"].UpdateText();
        }
        private void DexteritySavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["DEX_Saving_Throw"].UpdateText();
        }
        private void ConstitutionSavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["CON_Saving_Throw"].UpdateText();
        }
        private void IntelligenceSavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["INT_Saving_Throw"].UpdateText();
        }
        private void WisdomSavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["WIS_Saving_Throw"].UpdateText();
        }
        private void CharismaSavingThrowProficiencyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SavingThrowsLibrary.SavingThrowsDictionary["CHA_Saving_Throw"].UpdateText();
        }

        // 
        // MAX HP
        // 
        private void MaxHitPointsValueTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(MaxHitPointsValueTextBox.Text, out int result))
            {
                HitPoints.SetMaxHitPoints(MaxHitPointsValueTextBox.Text);
            }
            if (HitPoints.curHitPoints == 0 || HitPoints.curHitPoints > HitPoints.maxHitPoints)
            {
                HitPoints.curHitPoints = HitPoints.maxHitPoints;
                HitPoints.UpdateCurrentHitPointsText();
            }
            CanHealButtonBeUsed();
            CanReceiveDamageBeUsed();
        }
        private void MaxHitPointsValueTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            OnButtonPress(e);
        }

        // 
        // HP BUTTONS
        // 
        private void HealHitPointsButton_Click(object sender, EventArgs e)
        {
            CloseAllHPPopups();

            var onHealHPClickButton = new OnHealHPClickButton();
            onHealHPClickButton.Show(this);
            onHealHPClickButton.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);

            this.ActiveControl = null;
        }
        private void ReceiveDamageButton_Click(object sender, EventArgs e)
        {
            CloseAllHPPopups();

            var onReceiveDamageClickButton = new OnReceiveDamageClickButton();
            onReceiveDamageClickButton.Show(this);
            onReceiveDamageClickButton.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);

            this.ActiveControl = null;
        }
        private void ResetCurrentHitPointsButton_Click(object sender, EventArgs e)
        {
            HitPoints.curHitPoints = HitPoints.maxHitPoints;
            HitPoints.tempHitPoints = 0;
            HitPoints.UpdateCurrentHitPointsText();
            CloseAllHPPopups();
            CanHealButtonBeUsed();
            CanReceiveDamageBeUsed();

            this.ActiveControl = null;
        }
        private void AddTemporaryHitPointsButton_Click(object sender, EventArgs e)
        {
            CloseAllHPPopups();

            var onAddTemporaryHPClickButton = new OnAddTemporaryHPClickButton();
            onAddTemporaryHPClickButton.Show(this);
            onAddTemporaryHPClickButton.Location = new Point(Cursor.Position.X + 5, Cursor.Position.Y + 5);

            this.ActiveControl = null;
        }
        private void CurrentHitPointsValueText_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        public void CanHealButtonBeUsed()
        {
            if (HitPoints.curHitPoints >= HitPoints.maxHitPoints)
            {
                HealHitPointsButton.Enabled = false;
                HealHitPointsButton.BackColor = Color.DarkGray;
            }
            else
            {
                HealHitPointsButton.Enabled = true;
                HealHitPointsButton.BackColor = Color.FromArgb(172, 201, 169);
            }
        }
        public void CanReceiveDamageBeUsed()
        {
            if (HitPoints.curHitPoints <= 0)
            {
                ReceiveDamageButton.Enabled = false;
                ReceiveDamageButton.BackColor = Color.DarkGray;
            }
            else
            {
                ReceiveDamageButton.Enabled = true;
                ReceiveDamageButton.BackColor = Color.FromArgb(206, 183, 183);
            }
        }
        private void CloseAllHPPopups()
        {
            if (Application.OpenForms.OfType<OnHealHPClickButton>().Count() == 1)
                Application.OpenForms.OfType<OnHealHPClickButton>().First().Close();
            if (Application.OpenForms.OfType<OnReceiveDamageClickButton>().Count() == 1)
                Application.OpenForms.OfType<OnReceiveDamageClickButton>().First().Close();
            if (Application.OpenForms.OfType<OnAddTemporaryHPClickButton>().Count() == 1)
                Application.OpenForms.OfType<OnAddTemporaryHPClickButton>().First().Close();
        }

        private void ExtraBonusesGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ExtraBonusList.list[e.RowIndex].ApplyBonus();
                ExtraBonusesGridView.CurrentCell = null;
            }
        }

        private void ExtraBonusesGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ExtraBonusesGridView.CurrentCell is DataGridViewComboBoxCell || ExtraBonusesGridView.CurrentCell is DataGridViewCheckBoxCell)
            {
                ExtraBonusesGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}

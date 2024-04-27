using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet.SubForms
{
    public partial class OnHealHPClickButton : Form
    {
        public OnHealHPClickButton()
        {
            InitializeComponent();
        }

        private void HealHPAmountTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAmountToHeal();
        }

        private void HealHPPopupOKButton_Click(object sender, EventArgs e)
        {
            HealHP();
        }

        private void HealHPAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateAmountToHeal();
                HealHP();
            }
        }

        private void UpdateAmountToHeal()
        {
            HitPoints.amountToHeal = 0;
            if (int.TryParse(HealHPAmountTextBox.Text, out int result))
            {
                HitPoints.amountToHeal = result;
            }
        }

        private void HealHP()
        {
            HitPoints.curHitPoints += HitPoints.amountToHeal;
            if (HitPoints.curHitPoints > HitPoints.maxHitPoints)
            {
                HitPoints.curHitPoints = HitPoints.maxHitPoints;
            }

            HitPoints.UpdateCurrentHitPointsText();
            Sheet.Instance.CanHealButtonBeUsed();
            Sheet.Instance.CanReceiveDamageBeUsed();
            Application.OpenForms.OfType<OnHealHPClickButton>().First().Close();
        }
    }
}

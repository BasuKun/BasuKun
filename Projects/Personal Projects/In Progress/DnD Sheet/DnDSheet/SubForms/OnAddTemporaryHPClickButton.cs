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
    public partial class OnAddTemporaryHPClickButton : Form
    {
        public OnAddTemporaryHPClickButton()
        {
            InitializeComponent();
        }

        private void AddTemporaryHPAmountTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAmountToReceive();
        }

        private void AddTemporaryHPAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateAmountToReceive();
                AddTemporaryHP();
            }
        }

        private void UpdateAmountToReceive()
        {
            HitPoints.amountToAddTemp = 0;
            if (int.TryParse(AddTemporaryHPAmountTextBox.Text, out int result))
            {
                HitPoints.amountToAddTemp = result;
            }
        }

        private void AddTemporaryHP()
        {
            HitPoints.tempHitPoints = HitPoints.amountToAddTemp;

            HitPoints.UpdateCurrentHitPointsText();
            Sheet.Instance.CanHealButtonBeUsed();
            Sheet.Instance.CanReceiveDamageBeUsed();
            Application.OpenForms.OfType<OnAddTemporaryHPClickButton>().First().Close();
        }

        private void AddTemporaryHPPopupOKButton_Click(object sender, EventArgs e)
        {
            AddTemporaryHP();
        }
    }
}

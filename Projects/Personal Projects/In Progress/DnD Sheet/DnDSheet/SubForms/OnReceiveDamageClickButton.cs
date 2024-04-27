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
    public partial class OnReceiveDamageClickButton : Form
    {
        public OnReceiveDamageClickButton()
        {
            InitializeComponent();
        }

        private void ReceiveDamageAmountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateAmountToBeDealt();
                ReceiveDamage();
            }
        }

        private void ReceiveDamagePopupOKButton_Click(object sender, EventArgs e)
        {
            ReceiveDamage();
        }

        private void ReceiveDamageAmountTextBox_Leave(object sender, EventArgs e)
        {
            UpdateAmountToBeDealt();
        }

        private void UpdateAmountToBeDealt()
        {
            HitPoints.amountToBeDealt = 0;
            if (int.TryParse(ReceiveDamageAmountTextBox.Text, out int result))
            {
                HitPoints.amountToBeDealt = result;
            }
        }

        private void ReceiveDamage()
        {
            if (HitPoints.tempHitPoints > 0)
            {
                int leftoverDamage = HitPoints.amountToBeDealt - HitPoints.tempHitPoints;
                HitPoints.tempHitPoints -= HitPoints.amountToBeDealt;

                if (leftoverDamage > 0)
                {
                    HitPoints.tempHitPoints = 0;
                    HitPoints.curHitPoints -= leftoverDamage;
                }
            }
            else
            {
                HitPoints.curHitPoints -= HitPoints.amountToBeDealt;
            }

            if (HitPoints.curHitPoints < 0)
            {
                HitPoints.curHitPoints = 0;
            }

            HitPoints.UpdateCurrentHitPointsText();
            Sheet.Instance.CanHealButtonBeUsed();
            Sheet.Instance.CanReceiveDamageBeUsed();
            Application.OpenForms.OfType<OnReceiveDamageClickButton>().First().Close();
        }
    }
}


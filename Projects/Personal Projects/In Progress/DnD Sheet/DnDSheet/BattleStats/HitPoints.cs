using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSheet
{
    public static class HitPoints
    {
        public static int maxHitPoints { get; set; }
        public static int curHitPoints { get; set; }
        public static int tempHitPoints { get; set; }
        public static int amountToHeal { get; set; }
        public static int amountToBeDealt { get; set; }
        public static int amountToAddTemp { get; set; }

        public static void SetMaxHitPoints(string value)
        {
            maxHitPoints = int.Parse(value);
        }

        public static void UpdateCurrentHitPointsText()
        {
            Sheet.Instance.CurrentHitPointsValueText.Clear();
            Sheet.Instance.CurrentHitPointsValueText.SelectionColor = Color.Black;
            Sheet.Instance.CurrentHitPointsValueText.SelectionFont = new Font("Calibri", 18, FontStyle.Bold);
            Sheet.Instance.CurrentHitPointsValueText.AppendText(curHitPoints.ToString());

            if (tempHitPoints > 0)
            {
                Sheet.Instance.CurrentHitPointsValueText.SelectionColor = Color.FromArgb(71, 102, 137);
                Sheet.Instance.CurrentHitPointsValueText.SelectionFont = new Font("Calibri", 13, FontStyle.Bold);
                Sheet.Instance.CurrentHitPointsValueText.AppendText(" (+" + tempHitPoints.ToString() + ")");
            }
            Sheet.Instance.CurrentHitPointsValueText.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}

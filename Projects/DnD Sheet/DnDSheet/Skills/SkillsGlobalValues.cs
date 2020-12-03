using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSheet
{
    public static class SkillsGlobalValues
    {
        public static int globalBonus { get; set; }
        public static List<ExtraBonus> globalExtraBonuses = new List<ExtraBonus>();

        public static void setGlobalBonus()
        {
            globalBonus = 0;
            foreach (var extraBonus in globalExtraBonuses)
            {
                if (!extraBonus.isEquipped) continue;

                int.TryParse(extraBonus.bonus, out int result);
                globalBonus += result;
            }

            foreach (var skill in SkillsLibrary.SkillsDictionary)
            {
                skill.Value.UpdateText();
            }
        }
    }
}

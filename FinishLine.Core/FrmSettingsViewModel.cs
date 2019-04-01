using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class FrmSettingsViewModel
    {
        public int RoundLength { get; set; }
        public int RoundCount { get; set; }
        public int NumberOfWinners { get; set; }

        public void SaveSettings()
        {
            Race.RoundLength = RoundLength;
            Race.RoundCount = RoundCount;
            Race.NumberOfWinners = NumberOfWinners;
        }

        public void GetSettings()
        {
            RoundLength = Race.RoundLength;
            RoundCount = Race.RoundCount;
            NumberOfWinners = Race.NumberOfWinners;
        }


    }


}

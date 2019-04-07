using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, ktora je na pozadi formulara pre nastavenia a zbiera a preposiela data
    /// </summary>
    public class FrmSettingsViewModel
    {
        public int RoundLength { get; set; }
        public int RoundCount { get; set; }
        public int NumberOfWinners { get; set; }

        public Race Race { get; private set; }

        public FrmSettingsViewModel(Race race)
        {
            Race = race;
        }

        /// <summary>
        /// Metoda na ulozenie nastaveni
        /// </summary>
        public void SaveSettings()
        {
            Race.RoundLength = RoundLength;
            Race.RoundCount = RoundCount;
            Race.NumberOfWinners = NumberOfWinners;
        }

        /// <summary>
        /// Metoda na vratenie nastaveni do frm
        /// </summary>
        public void GetSettings()
        {
            RoundLength = Race.RoundLength;
            RoundCount = Race.RoundCount;
            NumberOfWinners = Race.NumberOfWinners;
        }


    }


}

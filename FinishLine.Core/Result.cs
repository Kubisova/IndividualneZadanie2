using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, ktora reprezentuje vysledok pretekara
    /// </summary>
    public class Result
    {
        [System.ComponentModel.DisplayName("Poradie")]
        public int Ranking { get; set; }

        [System.ComponentModel.DisplayName("Štartovacie číslo")]
        public int RacerNumber { get; set; }

        [System.ComponentModel.DisplayName("Odbehnuté kolo")]
        public int LastFinishedRound { get; set; } = 0;

        [System.ComponentModel.DisplayName("Meno")]
        public string RacerName { get; set; }

        [System.ComponentModel.DisplayName("Celkový čas")]
        public TimeSpan ResultTime { get; set; }
    }
}

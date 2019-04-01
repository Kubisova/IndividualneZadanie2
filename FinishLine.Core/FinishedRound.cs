using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class FinishedRound
    {
        [System.ComponentModel.DisplayName("Štartovacie číslo")]
        public int RacerNumber { get; set; }
        [System.ComponentModel.DisplayName("Čas kola")]
        public DateTime FinishedRoundTime { get; set; }
        [System.ComponentModel.DisplayName("Číslo kola")]
        public int FinishedRoundNumber { get; set; } = 0;
        [System.ComponentModel.DisplayName("Meno")]
        public string RacerName { get; set; }
        [System.ComponentModel.DisplayName("Odbehnuté za")]
        public TimeSpan RoundTime { get; set; }


    }
}

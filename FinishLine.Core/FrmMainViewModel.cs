using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, ktora je na pozadi hlavneho formulara a zbiera a preposiela data
    /// </summary>
    public class FrmMainViewModel
    {
        public int RacerNumber { get; set; }

        public void StartRace()
        {
            Race.StartRace();
        }

        public void EndRace()
        {
            Race.EndRace();
        }

        public void RegisterFinishedRound()
        {
            if (!RacerRepository.IsStartNumberUsed(RacerNumber))
            {
                throw new ArgumentException("Pretekár s takýmto štartovacím číslom nie je zaregistrovaný.");
            }

            if (Race.RaceStartTime == DateTime.MinValue)
            {
                throw new ArgumentException("Preteky sa ešte nezačali. Je potrebné ich najskôr odštartovať.");
            }

            if (Race.RaceEndTime!= DateTime.MinValue)
            {
                throw new ArgumentException("Preteky sa už skončili.");
            }

            Race.RegisterFinishedRound(RacerNumber);
        }

        public void SaveToFile(string directoryPath)
        {
            DataLayer.DirectoryPath = directoryPath;
            DataLayer.SaveToJson(RacerRepository.Racers, Race.Results, Race.FinishedRounds);
            DataLayer.SaveSettingsToTxt(Race.RoundLength, Race.RoundCount, Race.NumberOfWinners, Race.RaceStartTime, RacerRepository.LastStartNumber, Race.RaceEndTime);
        }

        public void LoadFromFile(string directoryPath)
        {
            DataLayer.DirectoryPath = directoryPath;
            DataLayer.LoadRacersFromJson();
            DataLayer.LoadResultsFromJson();
            DataLayer.LoadFinishedRoundsFromJson();
            DataLayer.LoadFromTxt();
        }

    }
}

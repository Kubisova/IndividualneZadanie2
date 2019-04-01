using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class FrmMainViewModel
    {
        public int RacerNumber { get; set; }

        public void StartRace()
        {
            Race.StartRace();
        }

        public void RegisterFinishedRound()
        {
            Race.RegisterFinishedRound(RacerNumber);
        }

        public void SaveToFile(string directoryPath)
        {
            FileHelper.DirectoryPath = directoryPath;
            FileHelper.SaveToJson(RacerRepository.Racers, Race.Results, Race.FinishedRounds);
            FileHelper.SaveSettingsToTxt(Race.RoundLength, Race.RoundCount, Race.NumberOfWinners, Race.RaceStartTime, RacerRepository.LastStartNumber);
        }

        public void LoadFromFile(string directoryPath)
        {
            FileHelper.DirectoryPath = directoryPath;
            FileHelper.LoadRacersFromJson();
            FileHelper.LoadResultsFromJson();
            FileHelper.LoadFinishedRoundsFromJson();
            FileHelper.LoadFromTxt();
        }
    }
}

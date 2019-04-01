using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinishLine.Core.Helpers;
using Newtonsoft.Json;

namespace FinishLine.Core
{
    public static class FileHelper
    {
        public static string DirectoryPath { get; set; }

        public static void SaveToJson(BindingList<Racer> racers, BindingList<Result> results, BindingList<FinishedRound> finishedRounds)
        {
            try
            {
                File.WriteAllText(GetFullPath("Racers.json"), JsonConvert.SerializeObject(racers));
                File.WriteAllText(GetFullPath("Results.json"), JsonConvert.SerializeObject(results));
                File.WriteAllText(GetFullPath("FinishedRounds.json"), JsonConvert.SerializeObject(finishedRounds));
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }

        public static void SaveSettingsToTxt(int roundLength, int roundCount, int numberOfWinners, DateTime raceStartTime,int lastStartNumber)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(GetFullPath("Settings.txt")))
                {
                    sw.WriteLine(roundLength);
                    sw.WriteLine(roundCount);
                    sw.WriteLine(numberOfWinners);
                    sw.WriteLine(raceStartTime);
                    sw.WriteLine(lastStartNumber);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }

        public static string GetFullPath(string fileName)
        {
            return Path.Combine(DirectoryPath, fileName);
        }

        public static void LoadRacersFromJson()
        {
            BindingList<Racer> racers = JsonConvert.DeserializeObject < BindingList<Racer>>(File.ReadAllText(GetFullPath("Racers.json")));
        }

        public static void LoadResultsFromJson()
        {
            BindingList<Result> results = JsonConvert.DeserializeObject<BindingList<Result>>(File.ReadAllText(GetFullPath("Results.json")));
        }

        public static void LoadFinishedRoundsFromJson()
        {
            BindingList<Racer> finishedRounds = JsonConvert.DeserializeObject<BindingList<Racer>>(File.ReadAllText(GetFullPath("FinishedRounds.json")));
        }

        public static void LoadFromTxt()
        {

        }
    }
}

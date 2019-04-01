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
    /// <summary>
    /// Trieda, ktora umoznuje a zabezpecuje pracu s datami (uklada a cita ich zo suborov)
    /// </summary>
    public static class DataLayer
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

        public static void SaveSettingsToTxt(int roundLength, int roundCount, int numberOfWinners, DateTime raceStartTime,int lastStartNumber, DateTime raceEndTime)
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
                    sw.WriteLine(raceEndTime);

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
            try
            {
                BindingList<Racer> racers = JsonConvert.DeserializeObject<BindingList<Racer>>(File.ReadAllText(GetFullPath("Racers.json")));
                RacerRepository.Racers = racers;
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }

        public static void LoadResultsFromJson()
        {
            try
            {
                BindingList<Result> results = JsonConvert.DeserializeObject<BindingList<Result>>(File.ReadAllText(GetFullPath("Results.json")));
                Race.Results = results;
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }

        public static void LoadFinishedRoundsFromJson()
        {
            try
            {
                BindingList<FinishedRound> finishedRounds = JsonConvert.DeserializeObject<BindingList<FinishedRound>>(File.ReadAllText(GetFullPath("FinishedRounds.json")));
                Race.FinishedRounds = finishedRounds;
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }

        public static void LoadFromTxt()
        {
            try
            {
                string[] settings = File.ReadAllLines(GetFullPath("Settings.txt"));
                Race.RoundLength = int.Parse(settings[0]);
                Race.RoundCount = int.Parse(settings[1]);
                Race.NumberOfWinners = int.Parse(settings[2]);
                Race.RaceStartTime = DateTime.Parse(settings[3]);
                RacerRepository.LastStartNumber = int.Parse(settings[4]);
                Race.RaceEndTime = DateTime.Parse(settings[5]);


            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }
    }
}

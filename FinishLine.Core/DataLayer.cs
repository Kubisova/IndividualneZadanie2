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

        /// <summary>
        /// Metoda, ktora ulozi data do jsona (data, ktore su ako objekty)
        /// </summary>
        /// <param name="racers">pretekari</param>
        /// <param name="results">vysledky</param>
        /// <param name="finishedRounds">odbehnute kola</param>
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

        /// <summary>
        /// Metoda, ktora ulozi nastavenia do txt
        /// </summary>
        /// <param name="roundLength">dlzka kola</param>
        /// <param name="roundCount">pocet kol</param>
        /// <param name="numberOfWinners">pocet vitazov</param>
        /// <param name="raceStartTime">zaciatok pretekov</param>
        /// <param name="lastStartNumber">posledne startovacie cislo</param>
        /// <param name="raceEndTime">koniec pretekov</param>
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
        /// <summary>
        /// Metoda, ktora vrati cestu, kam ulozit data
        /// </summary>
        /// <param name="fileName">nazov suboru</param>
        /// <returns>cestu</returns>
        public static string GetFullPath(string fileName)
        {
            return Path.Combine(DirectoryPath, fileName);
        }

        /// <summary>
        /// Metoda, ktora nacita pretekarov z jsona
        /// </summary>
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

        /// <summary>
        /// Metoda, ktora nacita vysledky z jsona
        /// </summary>
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

        /// <summary>
        /// Metoda, ktora nacita odbehnute kola z jsona
        /// </summary>
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

        /// <summary>
        /// Metoda, ktora nacita nastavenia z txt
        /// </summary>
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

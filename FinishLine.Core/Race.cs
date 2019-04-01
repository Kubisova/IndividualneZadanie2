using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, v ktorej sa uskutocnuju a vyhodnocuju preteky
    /// </summary>
    public static class Race
    {
        public static int RoundLength { get; set; } = 1;
        public static int RoundCount { get; set; } = 3;
        public static int NumberOfWinners { get; set; } = 3;

        public static DateTime RaceStartTime { get; set; }
        public static DateTime RaceEndTime { get; set; }

        public static BindingList<FinishedRound> FinishedRounds { get; set; } = new BindingList<FinishedRound>();
        public static BindingList<Result> Results { get; set; } = new BindingList<Result>();

        /// <summary>
        /// Metoda, ktora odstartuje preteky
        /// </summary>
        public static void StartRace()
        {
            RaceStartTime = DateTime.Now;
        }

        /// <summary>
        /// Metoda, ktora skonci preteky
        /// </summary>
        public static void EndRace()
        {
            RaceEndTime = DateTime.Now;
        }

        /// <summary>
        /// Metoda, ktora zaznamena odbehnute kolo
        /// </summary>
        /// <param name="racerNumber">startovacie cislo pretekara</param>
        public static void RegisterFinishedRound(int racerNumber)
        {
            FinishedRound finishedRound = new FinishedRound();

            finishedRound.FinishedRoundTime = DateTime.Now;
            int lastFinishedRoundNumber = GetHighestRacersFinishedRound(racerNumber);
            finishedRound.FinishedRoundNumber = ++lastFinishedRoundNumber;
            finishedRound.RacerNumber = racerNumber;
            finishedRound.RacerName = GetRacerNameByStartNumber(racerNumber);
            finishedRound.RoundTime = finishedRound.FinishedRoundTime - RaceStartTime;

            FinishedRounds.Add(finishedRound);
            RefreshResults();
        }

        /// <summary>
        /// Metoda, ktora vrati pretekara s danym startovacim cislom
        /// </summary>
        /// <param name="startNumber">startovacie cislo pretekara</param>
        /// <returns>meno pretekara</returns>
        public static string GetRacerNameByStartNumber(int startNumber)
        {
            Racer racer = RacerRepository.GetRacerByStartNumber(startNumber);
            return racer.Name;
        }

        /// <summary>
        /// Metoda, ktora zisti a refresne celkove vysledky
        /// </summary>
        public static void RefreshResults()
        {
            Results.Clear();
            int highestFinishedRound = FinishedRounds.Max(x => x.FinishedRoundNumber);
            for (int i = highestFinishedRound; i > 0; i--)
            {
                List<Result> tempResults = new List<Result>();

                foreach (var finishedRound in FinishedRounds)
                {
                    bool isRacerInResults = HasRacerFinishedHigherRound(finishedRound);
                    if (finishedRound.FinishedRoundNumber == i && !isRacerInResults && finishedRound.FinishedRoundNumber <= RoundCount)  // && finishedRound.FinishedRoundNumber <= RoundCount
                    {
                        Result result = GetResult(finishedRound);
                        tempResults.Add(result);
                    }
                }

                List<Result> sortedList = tempResults.OrderBy(r => r.ResultTime).ToList();

                for (int j = 0; j < sortedList.Count; j++)
                {
                    Results.Add(sortedList[j]);
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati vysledok na zaklade posledneho odbehnuteho kola
        /// </summary>
        /// <param name="highestFinishedRound">posledne/najvyssie odbehnute kolo</param>
        /// <returns>vysledok</returns>
        public static Result GetResult(FinishedRound highestFinishedRound)
        {
            Result result = new Result
            {
                LastFinishedRound = highestFinishedRound.FinishedRoundNumber,
                RacerNumber = highestFinishedRound.RacerNumber,
                RacerName = highestFinishedRound.RacerName,
                ResultTime = highestFinishedRound.FinishedRoundTime - RaceStartTime
            };

            return result;
        }

        /// <summary>
        /// Metoda, ktora vrati info, ci pretekar odbehol uz vyssie kolo
        /// </summary>
        /// <param name="finishedRound">odbehnute kolo</param>
        /// <returns>true alebo false</returns>
        public static bool HasRacerFinishedHigherRound(FinishedRound finishedRound)
        {
            Result result = Results.FirstOrDefault(r => r.RacerNumber == finishedRound.RacerNumber);
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Metoda, ktora vrati najvyssie/posledne odbehnute kolo pretekara s danym startovacim cislom
        /// </summary>
        /// <param name="startNumber">startovacie cislo</param>
        /// <returns></returns>
        public static int GetHighestRacersFinishedRound(int startNumber)
        {
            int highestFinishedRound = 0;
            List <FinishedRound> finishedRoundsList = FinishedRounds.ToList();
            List<FinishedRound> allFinishedRacersRounds = finishedRoundsList.FindAll(r => r.RacerNumber == startNumber);
            if (allFinishedRacersRounds.Count > 0)
            {
                highestFinishedRound = allFinishedRacersRounds.Max(r => r.FinishedRoundNumber);
            }

            return highestFinishedRound;
        }
    }
}

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
    public class Race
    {
        public int RoundLength { get; set; } = 1;
        public int RoundCount { get; set; } = 50;
        public int NumberOfWinners { get; set; } = 3;
        public const int NUMBER_OF_RUNNERS = 999;

        public DateTime RaceStartTime { get; set; }
        public DateTime RaceEndTime { get; set; }

        public bool HasStarted { get; set;}
        public bool HasEnded { get; set; }

        public BindingList<FinishedRound> FinishedRounds { get; set; } = new BindingList<FinishedRound>();
        public BindingList<Result> Results { get; set; } = new BindingList<Result>();

        /// <summary>
        /// Metoda, ktora odstartuje preteky
        /// </summary>
        public void StartRace()
        {
            RaceStartTime = DateTime.Now;
            HasStarted = true;
        }

        /// <summary>
        /// Metoda, ktora skonci preteky
        /// </summary>
        public void EndRace()
        {
            RaceEndTime = DateTime.Now;
            HasEnded = true;
        }

        /// <summary>
        /// Metoda, ktora zaznamena odbehnute kolo
        /// </summary>
        /// <param name="racerNumber">startovacie cislo pretekara</param>
        public void RegisterFinishedRound(int racerNumber, RacerRepository racerRepository)
        {
            FinishedRound finishedRound = new FinishedRound();

            finishedRound.FinishedRoundTime = DateTime.Now;
            int lastFinishedRoundNumber = GetHighestRacersFinishedRound(racerNumber);
            finishedRound.FinishedRoundNumber = ++lastFinishedRoundNumber;
            finishedRound.RacerNumber = racerNumber;
            finishedRound.RacerName = GetRacerNameByStartNumber(racerNumber, racerRepository);
            finishedRound.RoundTime = finishedRound.FinishedRoundTime - RaceStartTime; 

            FinishedRounds.Add(finishedRound);
            RefreshResults();
        }

        /// <summary>
        /// Metoda, ktora vrati pretekara s danym startovacim cislom
        /// </summary>
        /// <param name="startNumber">startovacie cislo pretekara</param>
        /// <returns>meno pretekara</returns>
        public string GetRacerNameByStartNumber(int startNumber, RacerRepository racerRepository)
        {
            Racer racer = racerRepository.GetRacerByStartNumber(startNumber);
            return racer.Name;
        }

        /// <summary>
        /// Metoda, ktora zisti a refresne celkove vysledky
        /// </summary>
        public void RefreshResults()
        {
            Results.Clear();
            int highestFinishedRound = FinishedRounds.Max(x => x.FinishedRoundNumber);
            int ranking = 0;
            for (int i = highestFinishedRound; i > 0; i--)
            {
                List<Result> tempResults = new List<Result>();

                foreach (var finishedRound in FinishedRounds)
                {
                    bool isRacerInResults = HasRacerFinishedHigherRound(finishedRound);
                    if (finishedRound.FinishedRoundNumber == i && !isRacerInResults && finishedRound.FinishedRoundNumber <= RoundCount)
                    {
                        Result result = GetResult(finishedRound);
                        tempResults.Add(result);
                    }
                }

                List<Result> sortedList = tempResults.OrderBy(r => r.ResultTime).ToList();

                for (int j = 0; j < sortedList.Count; j++)
                {
                    sortedList[j].Ranking = ++ranking;
                    Results.Add(sortedList[j]);
                }
            }
        }

        /// <summary>
        /// Metoda, ktora vrati vysledok na zaklade posledneho odbehnuteho kola
        /// </summary>
        /// <param name="highestFinishedRound">posledne/najvyssie odbehnute kolo</param>
        /// <returns>vysledok</returns>
        public Result GetResult(FinishedRound highestFinishedRound)
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
        public bool HasRacerFinishedHigherRound(FinishedRound finishedRound)
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
        public int GetHighestRacersFinishedRound(int startNumber)
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

        /// <summary>
        /// Metoda, ktora vrati zaciatok pretekov ako string
        /// </summary>
        /// <returns></returns>
        public string RaceStartTimeToString()
        {
            return RaceStartTime.ToLongTimeString();
        }

        /// <summary>
        /// metoda, ktora vrati koniec pretekov ako string
        /// </summary>
        /// <returns></returns>
        public string RaceEndTimeToString()
        {
            return RaceEndTime.ToLongTimeString();
        }
    }
}

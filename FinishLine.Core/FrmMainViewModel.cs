using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda na pozadi hlavneho formulara zbiera a preposiela data dalej alebo naspat
    /// </summary>
    public class FrmMainViewModel
    {
        public int RacerNumber { get; set; }
        public Race Race { get; private set; }
        public RacerRepository RacerRepository { get; private set; }

        public FrmMainViewModel(Race race, RacerRepository racerRepository)
        {
            Race = race;
            RacerRepository = racerRepository;
        }

        /// <summary>
        /// Metoda, ktora vola metodu na odstartovanie pretekov
        /// </summary>
        public void StartRace()
        {
            if (Race.HasStarted)
            {
                throw new ArgumentException("Nie je možné znova odštartovať preteky.");
            }
            if (RacerRepository.Racers.Count == 0)
            {
                throw new ArgumentException("Nie je možné odštartovať preteky - nie sú zaregistrovaní žiadny pretekári.");
            }

            Race.StartRace();
        }

        /// <summary>
        /// Metoda, ktora vola metodu na ukoncenie pretekov
        /// </summary>
        public void EndRace()
        {
            if (Race.HasEnded)
            {
                throw new ArgumentException("Nie je možné znova ukončiť preteky.");
            }

            Race.EndRace();
        }

        /// <summary>
        /// Metoda, ktora ak je vsetko ok tak vola metodu na zaznamenanie odbehnuteho kola
        /// </summary>
        public void RegisterFinishedRound()
        {
            if (!RacerRepository.IsStartNumberUsed(RacerNumber))
            {
                throw new ArgumentException("Pretekár s takýmto štartovacím číslom nie je zaregistrovaný.");
            }

            if (!Race.HasStarted)
            {
                throw new ArgumentException("Preteky sa ešte nezačali. Je potrebné ich najskôr odštartovať.");
            }

            if (Race.HasEnded)
            {
                throw new ArgumentException("Preteky sa už skončili.");
            }

            Race.RegisterFinishedRound(RacerNumber, RacerRepository);
        }

        /// <summary>
        /// Metoda, ktora posiela cestu a vola metody na ulozenie dat
        /// </summary>
        /// <param name="directoryPath">cesta kam ulozit</param>
        public void SaveToFile(string directoryPath)
        {
            DataLayer.DirectoryPath = directoryPath;
            DataLayer.SaveToJson(Race, RacerRepository);
        }

        /// <summary>
        /// Metoda, ktora posiela cestu a vola metody na nacitanie dat
        /// </summary>
        /// <param name="directoryPath">cesta odkial nacitat</param>
        public void LoadFromFile(string directoryPath)
        {
            DataLayer.DirectoryPath = directoryPath;

            Race = DataLayer.LoadRaceFromJson();
            RacerRepository = DataLayer.LoadRaceRepositoryFromJson();
        }

        /// <summary>
        /// Metoda, ktora vrati cas zacatia pretekov ako string
        /// </summary>
        /// <returns></returns>
        public string GetRaceStartTimeString()
        {
            return Race.RaceStartTimeToString();
        }

        /// <summary>
        /// Metoda, ktora vrati cas konca pretekov ako string
        /// </summary>
        /// <returns></returns>
        public string GetRaceEndTimeString()
        {
            return Race.RaceEndTimeToString();
        }

        
    }
}

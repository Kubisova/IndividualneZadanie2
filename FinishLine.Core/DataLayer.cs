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
        public const string NAME_OF_FILE_FOR_RACE = "Race.json";
        public const string NAME_OF_FILE_FOR_RACERREPOSITORY = "RacerRepository.json";

        /// <summary>
        /// Metoda, ktora ulozi data do jsona
        /// </summary>
        /// <param name="race">pretek</param>
        /// <param name="raceRepozitory">repozitar pretekarov</param>
        public static void SaveToJson(Race race, RacerRepository racerRepository)
        {
            try
            {
                File.WriteAllText(GetFullPath(NAME_OF_FILE_FOR_RACE), JsonConvert.SerializeObject(race));
                File.WriteAllText(GetFullPath(NAME_OF_FILE_FOR_RACERREPOSITORY), JsonConvert.SerializeObject(racerRepository));
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
        public static Race LoadRaceFromJson()
        {
            try
            {
                Race race = JsonConvert.DeserializeObject<Race>(File.ReadAllText(GetFullPath(NAME_OF_FILE_FOR_RACE)));
                return race;
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
        public static RacerRepository LoadRaceRepositoryFromJson()
        {
            try
            {
                RacerRepository racerRepository = JsonConvert.DeserializeObject<RacerRepository>(File.ReadAllText(GetFullPath(NAME_OF_FILE_FOR_RACERREPOSITORY)));
                return racerRepository;
            }
            catch (Exception ex)
            {
                ErrorLogger.ErrorLogging(ex);
                throw;
            }
        }
    }
}

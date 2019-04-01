using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, ktora sluzi na vytvorenie pretekara
    /// </summary>
    static class RacerFactory
    {
        /// <summary>
        /// Metoda, ktora vytvori pretekara
        /// </summary>
        /// <param name="startNumber">startovacie cislo</param>
        /// <param name="name">meno</param>
        /// <param name="age">vek</param>
        /// <param name="gender">pohlavie</param>
        /// <param name="Country">krajina</param>
        /// <returns>vytvoreneho pretekara</returns>
        public static Racer CreateRacer(int startNumber, string name, int age, Gender gender, string Country)
        {
            Racer racer = new Racer(startNumber, name, age, gender, Country);
            return racer;
        }
    }
}

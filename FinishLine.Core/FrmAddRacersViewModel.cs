using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, ktora je na pozadi formulara pre pridanie a editaciu pretekara a zbiera a preposiela data
    /// </summary>
    public class FrmAddRacersViewModel
    {
        public int StartNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }

        public bool IsEdit { get; set; }
        public int OldStartNumber { get; set; }
        public int NextStartNumber { get; set; }

        /// <summary>
        /// Metoda, ktora vola metodu na pridanie pretekara a zistuje ci su zadane udaje spravne
        /// </summary>
        public void AddRacer()
        {
            if (StartNumber == 0 || Name == "" || Age == 0 ||Gender == Gender.NotEntered)
            {
                throw new ArgumentException("Nie sú vyplnené všetky potrebné údaje alebo sú nesprávne vyplnené!");
            }

            if (RacerRepository.IsStartNumberUsed(StartNumber))
            {
                throw new ArgumentException("Zadané štartovacie číslo už bolo pridelené!");
            }

            RacerRepository.Add(StartNumber, Name, Age, Gender, Country);
        }

        /// <summary>
        /// Metoda, ktora vola metodu na editovanie pretekara a zistuje ci su zadane udaje spravne
        /// </summary>
        public void EditRacer()
        {
            if (StartNumber == 0 || Name == "" || Age == 0 ||Gender == Gender.NotEntered)
            {
                throw new ArgumentException("Nie sú vyplnené všetky potrebné údaje alebo sú nespávne vyplnené!");
            }

            if (StartNumber!=OldStartNumber)
            {
                if (RacerRepository.IsStartNumberUsed(StartNumber))
                {
                    throw new ArgumentException("Zadané štartovacie číslo už bolo pridelené!");
                }
            }

            RacerRepository.Edit(OldStartNumber, StartNumber, Name, Age, Gender, Country);
        }

        /// <summary>
        /// Metoda, ktora vola metodu na vymazanie pretekara
        /// </summary>
        public void DeleteRacer()
        {
            RacerRepository.Delete(StartNumber);
        }

        /// <summary>
        /// Metoda, ktora nastavi pretekara podla indexu, potrebna pri editacii pretekara
        /// </summary>
        /// <param name="index"></param>
        public void GetRacerByIndex(int index)
        {
            Racer racer = RacerRepository.GetRacerByIndex(index);
            StartNumber = racer.StartNumber;
            OldStartNumber = racer.StartNumber;
            Name = racer.Name;
            Age = racer.Age;
            Gender = racer.Gender;
            Country = racer.Country;
        }

        /// <summary>
        /// Metoda, ktora vola metodu na zistenie nasledujuceho startovacieho cisla
        /// </summary>
        public void GetNextStartNumber()
        {
            NextStartNumber = RacerRepository.GetNextStartNumber();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    /// <summary>
    /// Trieda, v ktorej su ulozeny vsetci pretekari
    /// </summary>
    public class RacerRepository
    {
        public BindingList<Racer> Racers { get; set; } = new BindingList<Racer>();

        /// <summary>
        /// Metoda, ktora prida pretekara do zoznamu pretekarov
        /// </summary>
        /// <param name="startNumber">startovacie cislo</param>
        /// <param name="name">mano</param>
        /// <param name="age">vek</param>
        /// <param name="gender">pohlavie</param>
        /// <param name="country">krajina</param>
        public void Add(int startNumber, string name, int age, Gender gender, string country)
        {
            Racer racer = RacerFactory.CreateRacer(startNumber, name, age, gender, country);
            Racers.Add(racer);
        }

        /// <summary>
        /// Metoda, ktora opravi pretekara v zozname
        /// </summary>
        /// <param name="oldStartNumber">stare startovacie cislo</param>
        /// <param name="startNumber">nove startovacie cislo</param>
        /// <param name="name">meno</param>
        /// <param name="age">vek</param>
        /// <param name="gender">pohlavie</param>
        /// <param name="country">krajina</param>
        public void Edit(int oldStartNumber,int startNumber, string name, int age, Gender gender, string country)
        {
            Racer racer = GetRacerByStartNumber(oldStartNumber);
            racer.StartNumber = startNumber;
            racer.Name = name;
            racer.Age = age;
            racer.Gender = gender;
            racer.Country = country;
        }

        /// <summary>
        /// Metoda, ktora vymaze pretekara s danym startovacim cislom zo zoznamu pretekarov
        /// </summary>
        /// <param name="startNumber">startovacie cislo</param>
        public void Delete(int startNumber)
        {
            int index = 0;
            foreach (var racer in Racers)
            {
                if (racer.StartNumber==startNumber)
                {
                    index = Racers.IndexOf(racer);
                    break;
                }
            }
            Racers.RemoveAt(index);
        }

        /// <summary>
        /// Metoda, ktora vrati pretekara s danym indexom
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>pretekara s danym indexom</returns>
        public Racer GetRacerByIndex(int index)
        {
            Racer racer = Racers[index];
            return racer;
        }

        /// <summary>
        /// Metoda, ktora vrati pretekara s danym startovacim cislom
        /// </summary>
        /// <param name="startNumber">startovacie cislo</param>
        /// <returns>pretekara s danym startovacim cislom</returns>
        public Racer GetRacerByStartNumber(int startNumber)
        {
            Racer racer = null;
            foreach (var r in Racers)
            {
                if (r.StartNumber == startNumber)
                {
                    racer = r;
                    break;
                }
            }
            return racer;
        }

        /// <summary>
        /// Metoda, ktora vrati nasledujuce startovacie cislo
        /// </summary>
        /// <returns>nasledujuce startovacie cislo</returns>
        public int GetNextStartNumber()
        {
            int nextStartNumber = 1;
            while(IsStartNumberUsed(nextStartNumber))
            {
                nextStartNumber++;
            }

            return nextStartNumber;
        }

        /// <summary>
        /// Metoda, ktora zisti, ci dane startovacie cislo je uz pouzite 
        /// </summary>
        /// <param name="startNumber"></param>
        /// <returns> true alebo false</returns>
        public bool IsStartNumberUsed(int startNumber)
        {
            return Racers.Any(r => r.StartNumber == startNumber);
        }
    }
}

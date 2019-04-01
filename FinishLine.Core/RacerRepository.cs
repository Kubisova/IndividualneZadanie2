using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class RacerRepository
    {
        public static BindingList<Racer> Racers { get; set; } = new BindingList<Racer>();
        public static int LastStartNumber { get; set; }

        public static void Add(int startNumber, string name, int age, Gender gender, string country)
        {
            if (startNumber == GetNextStartNumber())
            {
                LastStartNumber = startNumber;
            }

            Racer racer = RacerFactory.CreateRacer(startNumber, name, age, gender, country);
            Racers.Add(racer);
        }

        public static void Edit(int oldStartNumber,int startNumber, string name, int age, Gender gender, string country)
        {
            Racer racer = GetRacerByStartNumber(oldStartNumber);
            racer.StartNumber = startNumber;
            racer.Name = name;
            racer.Age = age;
            racer.Gender = gender;
            racer.Country = country;
        }

        public static void Delete(int startNumber)
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

        public static Racer GetRacerByIndex(int index)
        {
            Racer racer = Racers[index];
            return racer;
        }

        public static Racer GetRacerByStartNumber(int startNumber)
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

        public static int GetNextStartNumber()
        {
            int nextStartNumber = 1;
            if (Racers.Count > 0)
            {
                int tempNumber = LastStartNumber;

                do
                {
                    tempNumber++;
                    nextStartNumber = tempNumber;
                }
                while (Racers.Any(r => r.StartNumber == nextStartNumber));
            }

            return nextStartNumber;
        }

        public static bool IsStartNumberUsed(int startNumber)
        {
            return Racers.Any(r => r.StartNumber == startNumber);
        }
    }
}

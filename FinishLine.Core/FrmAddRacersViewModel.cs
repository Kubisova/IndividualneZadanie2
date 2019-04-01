using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
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

        public void AddRacer()
        {
            if (StartNumber == 0 || Name == "" || Age == 0 )
            {
                throw new ArgumentException("Nie sú vyplnené všetky potrebné údaje alebo sú zle vyplnené!");
            }
            RacerRepository.Add(StartNumber, Name, Age, Gender, Country);
        }

        public void EditRacer()
        {
            if (StartNumber == 0 || Name == "" || Age == 0)
            {
                throw new ArgumentException("Nie sú vyplnené všetky potrebné údaje alebo sú zle vyplnené!");
            }
            RacerRepository.Edit(OldStartNumber, StartNumber, Name, Age, Gender, Country);
        }

        public void DeleteRacer()
        {
            RacerRepository.Delete(StartNumber);
        }

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

        public void GetNextStartNumber()
        {
            NextStartNumber = RacerRepository.GetNextStartNumber();
        }
    }

    
}

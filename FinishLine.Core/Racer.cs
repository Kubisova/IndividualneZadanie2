using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public enum Gender { Male, Female}

    public class Racer
    {

        [System.ComponentModel.DisplayName("Štartovacie číslo")]
        public int StartNumber { get; set; }
        [System.ComponentModel.DisplayName("Meno")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("Vek")]
        public int Age { get; set; }
        [System.ComponentModel.DisplayName("Pohlavie")]
        public Gender Gender { get; set; }
        [System.ComponentModel.DisplayName("Krajina")]
        public string Country { get; set; }

        public Racer(int startNumber, string name, int age, Gender gender, string country)
        {
            StartNumber = startNumber;
            Name = name;
            Age = age;
            Gender = gender;
            Country = country;
        }
    }
}

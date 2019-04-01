using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    static class RacerFactory
    {
        public static Racer CreateRacer(int startNumber, string name, int age, Gender gender, string Country)
        {
            Racer racer = new Racer(startNumber, name, age, gender, Country);
            return racer;
        }
    }
}

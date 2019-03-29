using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    class RacerRepository
    {
        private Dictionary<int, Racer> Racers { get; set; }

        public void AddRacer(int key, Racer racer)
        {
            Racers.Add(key, racer);
        }

        public void DeleteRacer(int key)
        {
            Racers.Remove(key);
        }
    }
}

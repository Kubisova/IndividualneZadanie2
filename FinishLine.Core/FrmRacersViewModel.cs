using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class FrmRacersViewModel
    {
        public Race Race { get; private set; }
        public RacerRepository RacerRepository { get; private set; }

        public FrmRacersViewModel(Race race, RacerRepository racerRepository)
        {
            Race = race;
            RacerRepository = racerRepository;
        }
    }
}

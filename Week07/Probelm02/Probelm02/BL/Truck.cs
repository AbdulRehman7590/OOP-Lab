
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probelm02.BL
{
    class Truck
    {
        private Employee E;
        private Ladder L;
        private HosePipe P;

        public Truck(Employee E, Ladder L, HosePipe P)
        {
            this.E = E;
            this.L = L;
            this.P = P;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probelm02.BL
{
    class HosePipe
    {
        private string Quality;
        private string Shape;
        private float Diameter;
        private float FlowRate;

        public HosePipe (string Quality, string Shape, float Diameter, float FlowRate)
        {
            this.Quality = Quality;
            this.Shape = Shape;
            this.Diameter = Diameter;
            this.FlowRate = FlowRate;
        }
    }
}

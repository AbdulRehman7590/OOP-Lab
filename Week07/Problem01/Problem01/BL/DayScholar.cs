using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class DayScholar : Student
    {
        private int BusNumber;
        private string PickUpPoint;
        private float PickUpDistance;

        public DayScholar(string Name, int Session, bool IsDayScholar, float EntryTestMarks, float HSMarks, int BusNumber, string PickUpPoint, float PickUpDistance) : base(Name, Session, IsDayScholar, EntryTestMarks, HSMarks)
        {
            this.BusNumber = BusNumber;
            this.PickUpPoint = PickUpPoint;
            this.PickUpDistance = PickUpDistance;
        }

        public float GetBusFee()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.BL
{
    class Hostelite : Student
    {
        private int RoomNumber;
        private bool IsFridgeAvailable;
        private bool IsInternetAvailable;

        public Hostelite(string Name, int Session, bool IsDayScholar, float EntryTestMarks, float HSMarks, int RoomNumber, bool IsFridgeAvailable, bool IsInternetAvailable) : base(Name, Session, IsDayScholar, EntryTestMarks, HSMarks)
        {
            this.RoomNumber = RoomNumber;
            this.IsFridgeAvailable = IsFridgeAvailable;
            this.IsInternetAvailable = IsInternetAvailable;
        }

        public float GetHostelFee()
        {
            return 0;
        }
    }
}

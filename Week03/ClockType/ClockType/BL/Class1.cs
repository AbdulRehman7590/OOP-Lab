using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockType.BL
{
    class Clock
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Clock()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        public Clock(int h)
        {
            hours = h;
        }

        public Clock(int h, int m)
        {
            hours = h;
            minutes = m;
        }

        public Clock(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void IncrementSecond()
        {
            seconds++;
        }
        public void IncrementMinutes()
        {
            minutes++;
        }
        public void IncrementHours()
        {
            hours++;
        }

        public void PrintTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }

        public bool IsEqual(int h, int m, int s)
        {
            if(hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEqual(Clock temp)
        {
            if (hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.BL
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
            if (hours == h && minutes == m && seconds == s)
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

        public void ElapseTime()
        {
            int elapse = (this.hours * 3600) + (this.minutes * 60) + this.seconds;
            Formatter(elapse);
        }

        public void RemainingTime()
        {
            int remaining = 86400 - ((this.hours * 3600) + (this.minutes * 60) + this.seconds);
            Formatter(remaining);
        }

        public void Difference(Clock A)
        {
            int time1 = (this.hours * 3600) + (this.minutes * 60) + this.seconds;
            int time2 = (A.hours * 3600) + (A.minutes * 60) + A.seconds;

            int differ;
            if (time2 > time1)
            {
                differ = time2 - time1;
            }
            else
            {
                differ = time1 - time2;
            }

            Formatter(differ);
        }

        public void Formatter(int sec)
        {
            int hours = sec / 3600;
            int minutes = (sec / 60 ) % 60;
            int seconds = sec - ((hours * 3600) + (minutes * 60));

            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }


    }
}

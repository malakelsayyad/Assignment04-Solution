using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DurationClass
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public DurationClass(int hours , int minutes,int seconds )
        { 
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;  
        }

        public DurationClass(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60; 
            Seconds = totalSeconds % 60; 
        }
        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0) 
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is DurationClass duration)
            {
                return Hours == duration.Hours && Minutes == duration.Minutes && Seconds == duration.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }

        public static DurationClass operator +(DurationClass d1, DurationClass d2)
        {
            return new DurationClass(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
        }

        // Add seconds to a duration
        public static DurationClass operator +(DurationClass d, int seconds)
        {
            return new DurationClass(d.Hours, d.Minutes, d.Seconds + seconds);
        }

        public static DurationClass operator +(int seconds, DurationClass d)
        {
            return d + seconds;
        }

       
        public static DurationClass operator -(DurationClass d1, DurationClass d2)
        {
            return new DurationClass(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
        }

       
        public static DurationClass operator ++(DurationClass d)
        {
            return new DurationClass(d.Hours, d.Minutes + 1, d.Seconds);
        }

      
        public static DurationClass operator --(DurationClass d)
        {
            return new DurationClass(d.Hours, d.Minutes - 1, d.Seconds);
        }

        
        public static bool operator ==(DurationClass d1, DurationClass d2)
        {
            return d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds == d2.Seconds;
        }

        public static bool operator !=(DurationClass d1, DurationClass d2)
        {
            return !(d1 == d2);
        }

        public static bool operator <(DurationClass d1, DurationClass d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator >(DurationClass d1, DurationClass d2)
        {
            return d2 < d1;
        }

        public static bool operator <=(DurationClass d1, DurationClass d2)
        {
            return !(d1 > d2);
        }

        public static bool operator >=(DurationClass d1, DurationClass d2)
        {
            return !(d1 < d2);
        }

        public static implicit operator bool(DurationClass d)
        {
            return (d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }

        public static implicit operator DateTime(DurationClass d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}

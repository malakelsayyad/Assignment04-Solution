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
    }
}

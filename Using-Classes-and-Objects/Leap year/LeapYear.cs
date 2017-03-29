using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LeapYear
    {
        private int year;
        public LeapYear(int year)
        {
            this.year=year;
        }
        public string IsLeapYear()
        {
            string result="Common";
            if(DateTime.IsLeapYear(year)) result="Leap";
            return result;
        }
    }
    


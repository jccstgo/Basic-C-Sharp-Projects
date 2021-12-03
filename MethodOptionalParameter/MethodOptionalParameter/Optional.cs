using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParameter
{
    class Optional
    {
        public int LeapYear(int year_1, int year_2=2022)
        {
            bool leap_1 = (year_1 % 4 == 0) && (!(year_1 % 100 == 0) || (year_1 % 400 == 0));//Verify if the fisrt year "year 1" is a leap year
            bool leap_2 = (year_2 % 4 == 0) && (!(year_2 % 100 == 0) || (year_2 % 400 == 0));//Verify if the fisrt year "year 2" is a leap year

            if (leap_1 && leap_2)//Return 1 if year_1 and year_2 are leap
            {
                return 1;
            }
            else if (leap_1)//Return 2 if only year_1 is leap
            {
                return 2;
            }
            else if (leap_2)//Return 3 if only year_2 is leap
            {
                return 3;
            }
            else //Return 4 if no one of the years are leap
            {
                return 4;
            }
        }
    }
}

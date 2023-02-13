using System;

namespace LeapYearService
{
    public class LeapYear
    {
        public int Leap(int year)
        {
            if (year < 9999)
            {
                if(year > 1753)
                {
                    if(year%100 == 0 || year%4 == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}

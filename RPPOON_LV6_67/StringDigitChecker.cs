using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            bool hasDigit = false;
            for(int i = 0; i < 10; i++)
            {
                if (stringToCheck.Contains(i.ToString())) hasDigit = true;
            }
            Console.WriteLine("String has a digit: " + hasDigit);
            return hasDigit;
        }
    }
}

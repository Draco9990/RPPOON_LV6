using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            Console.WriteLine("String has an upper case character: " + (stringToCheck.ToLower() != stringToCheck));
            return stringToCheck.ToLower() != stringToCheck;
        }
    }
}

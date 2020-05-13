using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class StringLowerCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            Console.WriteLine("String has a lower case character: " + (stringToCheck.ToUpper() != stringToCheck));
            return stringToCheck.ToUpper() != stringToCheck;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class StringLengthChecker : StringChecker
    {
        private int length;

        public StringLengthChecker(int length)
        {
            this.length = length;
        }

        protected override bool PerformCheck(string stringToCheck)
        {
            Console.WriteLine("String is at least " + length.ToString() + " characters long: " + (stringToCheck.Length >= length));
            return stringToCheck.Length >= length;
        }
    }
}

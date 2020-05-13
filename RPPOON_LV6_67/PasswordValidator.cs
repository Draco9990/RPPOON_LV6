using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class PasswordValidator
    {
        public StringChecker first;
        public StringChecker last;

        public PasswordValidator(StringChecker first)
        {
            this.first = first;
            this.last = first;
        }

        public void AddCheck(StringChecker next)
        {
            last.SetNext(next);
            last = next;
        }

        public void Check(string password)
        {
            first.Check(password);
        }
    }
}

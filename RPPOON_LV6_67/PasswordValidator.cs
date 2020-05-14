using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_67
{
    class PasswordValidator
    {
        private StringChecker first;
        private StringChecker last;

        public PasswordValidator(StringChecker first)
        {
            this.first = this.last = first;
        }

        public void AddCheck(StringChecker next)
        {
            last.SetNext(next);
            last = next;
        }

        public bool Check(string password)
        {
            return first.Check(password);
        }
    }
}

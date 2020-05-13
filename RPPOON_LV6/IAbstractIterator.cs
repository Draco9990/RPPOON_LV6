using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_1
{
    interface IAbstractIterator
    {
        Note First();
        Note Next();
        bool IsDone { get; }
        Note Current { get; }
    }
}

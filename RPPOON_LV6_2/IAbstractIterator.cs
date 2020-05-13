using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_2
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}

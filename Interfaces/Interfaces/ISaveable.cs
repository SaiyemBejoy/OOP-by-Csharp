using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ISaveable
    {
        List<string> write();
        void read(List<string> savedValues);
    }
}

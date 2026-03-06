using System;
using System.Collections.Generic;
using System.Text;

namespace FilePermission
{
    [Flags]
    enum FilePermission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIF
{
    enum ProgramStatus : byte
    {
        ReadyToSearch = 0,
        Search = 1,
        FileOperation = 2
    }
}

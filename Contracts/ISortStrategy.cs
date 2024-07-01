using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppSource.Contracts
{
    internal interface ISortStrategy
    {
        string Sort(string input);
    }
}

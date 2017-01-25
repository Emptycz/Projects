using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Views.Test
{
    interface ITest
    {
        string Attribute1 { get; set; }
        string Attribute2 { get; set; }

        string NewMethod(string Name, int Number);


    }
}

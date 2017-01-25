using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaceL1
{
    interface IPayingStrategy
    {
        //Metody
        void Pay(Bill bill, int price);
    }
}

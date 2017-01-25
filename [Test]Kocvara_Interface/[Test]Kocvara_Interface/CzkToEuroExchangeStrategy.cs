using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Test_Kocvara_Interface
{
    class CzkToEuroExchangeStrategy : IExchangeStrategy
    {
        public double Exchange(double value)
        {
            double vysledek = value / 27;
            return vysledek;
        }
    }
}

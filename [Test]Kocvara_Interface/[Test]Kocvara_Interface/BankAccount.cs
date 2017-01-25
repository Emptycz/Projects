using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Test_Kocvara_Interface
{
    class BankAccount
    {
       public double AccountBallance { get; set; }


        public Double Convert(IExchangeStrategy exchangeStrategy)
        {
            double vysledek = exchangeStrategy.Exchange(AccountBallance);
            return vysledek;
        }
    }
}

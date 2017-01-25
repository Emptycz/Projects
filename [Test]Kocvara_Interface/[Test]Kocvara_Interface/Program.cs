using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Test_Kocvara_Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount account = new BankAccount();
            //int vypocti = Int32.Parse(Console.ReadLine());
            //account.AccountBallance = vypocti;

            account.AccountBallance = 1000;



            Console.WriteLine("Váš zůstatek na kontě je {0} KČ", account.AccountBallance);
            Console.WriteLine("Váš zůstatek na kontě je {0} EUR", account.Convert(new CzkToEuroExchangeStrategy()));
            Console.WriteLine("Váš zůstatek na kontě je {0} USD", account.Convert(new CzkToDollarExchangeStrategy()));
            Console.WriteLine();
            Console.WriteLine("Váš zůstatek je {0} KČ; {1} EUR; {2} USD ", account.AccountBallance, account.Convert(new CzkToEuroExchangeStrategy()), account.Convert(new CzkToDollarExchangeStrategy()));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaceL1
{
    class Person
    {
       
        private IPayingStrategy _payingStrategy;

        private int _id;
        private string _name;   
        private Bill _bill = new Bill();

        public Person (int id, string name, IPayingStrategy PayingStrategy)
        {
            _id = id;
            _name = name;
            _bill.AccountBalance = 100;
            _payingStrategy = PayingStrategy;

        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public Bill Bill { get { return _bill; } set { _bill = value; } }

        public void BuyItem(int price)
        {
            
            _payingStrategy.Pay(_bill, price);             

        }
    }
}

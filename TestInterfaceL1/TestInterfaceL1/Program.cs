using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterfaceL1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> NotMember = new List<Person>();
            NotMember.Add(new Person(1, "David", new NotMemberPayingStrategy()));
            


            Console.WriteLine(NotMember[0].Id + " " + NotMember[0].Name + " " + NotMember[0].Bill.AccountBalance);


            List<Person> IsMember = new List<Person>();
            IsMember.Add(new Person(2, "Lochneska", new GoldMemberPayingStrategy()));

            Console.WriteLine(IsMember[0].Id + " " + IsMember[0].Name);

            NotMember[0].BuyItem(100);
            IsMember[0].BuyItem(100);

            //Console.WriteLine("Slovo: {0} neco dalsiho {1}", NotMember[0].Id, NotMember[0].Name);
            Console.WriteLine(NotMember[0].Id + " " + NotMember[0].Name + " " + NotMember[0].Bill.AccountBalance);
            Console.WriteLine(IsMember[0].Id + " " + IsMember[0].Name + " " + IsMember[0].Bill.AccountBalance);


        }
    }
}


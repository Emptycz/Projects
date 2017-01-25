using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vytvoření listu pro zvířata
            List<Zvire> zvire = new List<Zvire>();

            //Zapsání zvířat do listu
            zvire.Add(new Zvire("Pes", 120, "Doga", true));
            zvire.Add(new Zvire("Hroch", 200, "Africký", true));
            zvire.Add(new Zvire("Klokan", 120, "Domácí", false));
            zvire.Add(new Zvire("Godzila", 1200, "Podmořská", true));
            zvire.Add(new Zvire("Kralik", 30, "Zakrslý", true));
            zvire.Add(new Zvire("Morče", 40, "Domácí", true));
            zvire.Add(new Zvire("Ježek", 20, "Polní", true));

            //Vytvoření speciálních proměnných
            Zvire nejvetsi = zvire[0];
            Zvire nejmensi = zvire[0];

            //Odeslání dat z listu
            foreach (Zvire z in zvire)
            {
                //Hledání největšího zvířete
                for(int i = 0; i < zvire.Count; i++)
                {
                    if (z.Velikost < zvire[i].Velikost)
                    {
                        nejvetsi = zvire[i];
                    }
                }

                for (int i = 0; i < zvire.Count; i++)
                {
                    if (z.Velikost > zvire[i].Velikost)
                    {
                        nejmensi = zvire[i];
                    }
                }

                //Vypsání tabulky zvířat
                Console.WriteLine();
                Console.WriteLine("Zvire:" + " " + z.Jmeno + " " + "   velikost:" + z.Velikost + "   věk: " + z.Rasa + "  naživu: " + z.Zivot);

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("////////////////////////////////////////////////////////////////");
            Console.WriteLine();

            //Vypsání největšího tvora v tabulce (listu - zvire)
            Console.WriteLine();
            Console.WriteLine("Největší zvíře:");
            Console.WriteLine("Zvire: " + nejvetsi.Jmeno + " " + "    Velikost: " + nejvetsi.Velikost);

            //Vypsání nejmenšího tvora v tabulce (listu - zvire)
            Console.WriteLine();
            Console.WriteLine("Nejmenší zvíře:");
            Console.WriteLine("Zvire: " + nejmensi.Jmeno + " " + "    Velikost: " + nejmensi.Velikost);
            Console.WriteLine();


        }
    }
}

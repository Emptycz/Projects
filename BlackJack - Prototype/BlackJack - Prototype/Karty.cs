using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack___Prototype
{
    class Karty
    {

        public int value;
        public string name;
        public string barva;

        public List<Karty> dejBalik()
        {
            List<Karty> karty = new List<Karty>();
            List<Karty> pouziteKarty = new List<Karty>();
            pouziteKarty.Add(new Karty() { value = 0, name = "0", barva = "Fail" });

            string barvaKarty = "";
            for (int i = 0; i < 4; i++)
            {
                if (i == 0) { barvaKarty = "Srdce"; }
                if (i == 1) { barvaKarty = "Kříže"; }
                if (i == 2) { barvaKarty = "Káry"; }
                if (i == 3) { barvaKarty = "Piky"; }

                karty.Add(new Karty() { value = 1, name = "1", barva = barvaKarty });
                karty.Add(new Karty() { value = 2, name = "2", barva = barvaKarty });
                karty.Add(new Karty() { value = 3, name = "3", barva = barvaKarty });
                karty.Add(new Karty() { value = 4, name = "4", barva = barvaKarty });
                karty.Add(new Karty() { value = 5, name = "5", barva = barvaKarty });
                karty.Add(new Karty() { value = 6, name = "6", barva = barvaKarty });
                karty.Add(new Karty() { value = 7, name = "7", barva = barvaKarty });
                karty.Add(new Karty() { value = 8, name = "8", barva = barvaKarty });
                karty.Add(new Karty() { value = 9, name = "9", barva = barvaKarty });
                karty.Add(new Karty() { value = 10, name = "10", barva = barvaKarty });
                karty.Add(new Karty() { value = 10, name = "Jack", barva = barvaKarty });
                karty.Add(new Karty() { value = 10, name = "Queen", barva = barvaKarty });
                karty.Add(new Karty() { value = 10, name = "King", barva = barvaKarty });
                karty.Add(new Karty() { value = 10, name = "Ace", barva = barvaKarty });
            }

            return karty;
        }

        public static Karty Balik(int index)
        {
            List<Karty> PouziteKarty = new List<Karty>(); 

            Karty k = new Karty();
            List<Karty> karty = k.dejBalik();

            //Random výběr jedné karty (hodnoty)

            List<Karty> card = new List<Karty>();//předdefinování listu pro kartu s chtěným formátem
            Random rn = new Random(); //založení random - pro výběr
            int n = karty.Count; //spočítá balíček karet ze kterého se bude karta brát

            if (!(n == 0)) //pokud má balíček nějaké karty
            {
                int c = rn.Next(0, n); //vybere kartu z existujícího balíčku
                card.Add(new Karty() { value = karty[c].value, name = karty[c].name, barva = karty[c].barva }); //dá hodnoty vybrané karty kartě
                PouziteKarty.Add(karty[c]);
                karty.Remove(karty[c]);

            }
            else
            {
                card.Add(new Karty() { value = 0 }); //pokud už nejsou karty vrátí se s hodnotou nula
            }

            return card[0];
            
            

        }

    }
}

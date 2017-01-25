using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack___Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                List<int> hodnotaKaret = new List<int>();
                List<string> PouziteKarty = new List<string>();
                string br = " ";
                int pocitaniKaret = 1;
                int index = 0;
                int hrat = 1;

                //Připravení karet pro Bankéře 
                List<int> KupieroviKartyHodnota = new List<int>();

                //Přidání potřebných karet bankéře do ruky 
                int banker = Karty.Balik(index).value;
                KupieroviKartyHodnota.Add(banker);
                if (banker <= 10)
                {
                    //Pokud součet karet bankéře je menší jak 10 vezme si novou kartu
                    banker = Karty.Balik(index).value;
                    KupieroviKartyHodnota.Add(banker);
                    banker = KupieroviKartyHodnota[0] + KupieroviKartyHodnota[1];
                    if (banker <= 15)
                    {
                        //Pokud součet karet bankéře je menší jak 15 vezme si novou kartu
                        banker = Karty.Balik(index).value;
                        KupieroviKartyHodnota.Add(banker);
                        banker = KupieroviKartyHodnota[0] + KupieroviKartyHodnota[1] + KupieroviKartyHodnota[2];
                    }
                    if (banker <= 15)
                    //Pokud součet karet bankéře je stále menší jak 15 vezme si novou kartu
                    {
                        banker = Karty.Balik(index).value;
                        KupieroviKartyHodnota.Add(banker);
                        banker = KupieroviKartyHodnota[0] + KupieroviKartyHodnota[1] + KupieroviKartyHodnota[2] + KupieroviKartyHodnota[3];
                    }
                    if (banker <= 15)
                    {
                        banker = Karty.Balik(index).value;
                        KupieroviKartyHodnota.Add(banker);
                        banker = KupieroviKartyHodnota[0] + KupieroviKartyHodnota[1] + KupieroviKartyHodnota[2] + KupieroviKartyHodnota[3] + KupieroviKartyHodnota[4];
                    }
                }

                //Proměnné pro přehled ve hře
                int pcKarty = KupieroviKartyHodnota.Count();
                string karet = "";
                //Vytvářím skloňování pro slovo "karta"
                if (pcKarty == 1)
                {
                    karet = " kartu";
                }
                else if (pcKarty == 2)
                {
                    karet = " karty";
                }
                else if (pcKarty == 3)
                {
                    karet = " karty";
                }
                else if (pcKarty == 4)
                {
                    karet = " karty";
                }
                else if (pcKarty == 5)
                {
                    karet = " karet";
                }

                string verze = "Verze 1.1.0";
                string tutorial = "Pro získání nové karty stistkněte N";
                string pocitacKartyMezera = "                 ";
                string pocitacKarty = pocitacKartyMezera + "Počítač má v ruce " + pcKarty + karet;
                Console.SetCursorPosition((Console.WindowWidth - tutorial.Length) / 2, Console.CursorTop);
                Console.WriteLine(tutorial);
                Console.WriteLine(pocitacKarty);



                while (hrat > 0)
                {

                    {

                        try
                        {


                            Console.WriteLine(Karty.Balik(index).name + " " + (Karty.Balik(index).barva));

                            Karty kupier = Karty.Balik(index);
                            int hrac = Karty.Balik(index).value;

                            //Přidávám hodnotu nové karty hráče do listu jeho karet v této hře
                            if (!(PouziteKarty.Contains(Karty.Balik(index).name)))
                            {
                                PouziteKarty.Add(Karty.Balik(index).name);
                                hodnotaKaret.Add(hrac);
                            }else
                            {
                                Main(args);
                                
                            }
                            //Čtu stisknuté tlačítko
                            ConsoleKeyInfo konec = Console.ReadKey(true);
                            string NovaKarta = "n";

                            //Pokud uživatel stiskl tlačítko pro novou kartu "N", přičte se nová karta k počítátoru a nová karta se připíše do listu 
                            if (konec.KeyChar.ToString().ToLower() == NovaKarta)
                            {
                                pocitaniKaret++;

                                //Generuji nové karty podle počtu stisknutí klávesy "n" 
                                hrac = Karty.Balik(index).value;
                            }
                            else
                            {

                                //Pokud si uživatel nevzal další kartu, vyhodnotí se hra

                                Console.WriteLine(br);
                                Console.WriteLine("Kolik jste měl v ruce karet " + pocitaniKaret);
                                Console.WriteLine("Součet karet kupiéra: " + banker);


                                int hracHodnota = HodnotaHrace(pocitaniKaret, hodnotaKaret);

                                Console.WriteLine("Součet vašich karet je: " + hracHodnota);
                                Console.WriteLine(br);
                                Console.WriteLine(br);
                                int pocetKaret = pocitaniKaret;

                                //Pravidla hry, nastavení, kdy hráč prohraje nebo vyhraje 
                                if (hracHodnota == 21)
                                {
                                    Console.WriteLine("OKO BERE! vyhrál jsi!");
                                    Console.WriteLine(pocitacKartyMezera + verze);
                                    Console.WriteLine(br);
                                    Console.WriteLine(br);
                                    break;
                                }
                                else if (hracHodnota > 21)
                                {
                                    Console.WriteLine("Máš více jak 21 bodů, prohrál jsi!");
                                    Console.WriteLine(pocitacKartyMezera + verze);
                                    Console.WriteLine(br);
                                    Console.WriteLine(br);
                                    break;
                                }
                                else if (hracHodnota < 21)
                                {


                                    if (hracHodnota > banker)
                                    {
                                        Console.WriteLine("Vyhrál jsi!");
                                        Console.WriteLine(pocitacKartyMezera + verze);
                                        Console.WriteLine(br);
                                        Console.WriteLine(br);
                                        break;
                                    }
                                    else if (hracHodnota == banker)
                                    {
                                        Console.WriteLine("Je to remíza!");
                                        Console.WriteLine(pocitacKartyMezera + verze);
                                        Console.WriteLine(br);
                                        Console.WriteLine(br);
                                        break;
                                    }
                                    else if (hracHodnota < banker)
                                    {
                                        Console.WriteLine("Prohrál jsi, kupiér měl lepší karty!");
                                        Console.WriteLine(pocitacKartyMezera + verze);
                                        Console.WriteLine(br);
                                        Console.WriteLine(br);
                                        break;

                                    }

                                }

                            }

                        }


                        catch (Exception e)
                        {
                            Console.WriteLine("Nastala neočekávaná chyba: " + e);
                        }

                    }
                }
                Console.WriteLine("Chcete hrát novou hru? [y-n]");

                } while (Console.ReadLine().ToLower() == "y") ;
        }


        //Metoda, která zjistí počet karet uložených v listu (počet karet hráče) a sečte jejich hodnotu
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocitaniKaret"></param>
        /// <param name="hodnotaKaret"></param>
        /// <returns></returns>
        public static int HodnotaHrace(int pocitaniKaret, List<int> hodnotaKaret)
        {

            int pom = 0;

            for (int a = 0; a < hodnotaKaret.Count; a++)
            {
                pom += hodnotaKaret[a];                

            }


            return pom;

        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    class Zvire
    {

        private string _jmeno;
        private int _velikost;
        private string _rasa;
        private bool _zivot;


        public Zvire(string jmeno, int velikost, string rasa, bool zivot)
        {

            _jmeno = jmeno;
            _velikost = velikost;
            _rasa = rasa;
            _zivot = zivot;

        }

        public string Jmeno { get { return _jmeno; } set { _jmeno = value; } }
        public int Velikost { get { return _velikost; } set { _velikost = value; } }
        public string Rasa { get { return _rasa; } set { _rasa = value; } }
        public bool Zivot { get { return _zivot; } set { _zivot = value; } }

    }
}

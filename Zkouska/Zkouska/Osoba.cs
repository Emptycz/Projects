using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zkouska
{
    class Osoba
    {

        private string _Jmeno;
        private string _Prijmeni;
        private int _DatumNarozeni;
        private string _Pohlavi;
        private bool _Status;

        public Osoba (string jmeno, string prijmeni, int datumNarozeni, string pohlavi, bool status)
        {
            _Jmeno = jmeno;
            _Prijmeni = prijmeni;
            _DatumNarozeni = datumNarozeni;
            _Pohlavi = pohlavi;
            _Status = status;
                
        }

        public string Jmeno { get { return _Jmeno; } set { _Jmeno = value; } }
        public string Prijmeni { get { return _Prijmeni; } set { _Prijmeni = value; } }
        public int DatumNarozeni { get { return _DatumNarozeni; } set { _DatumNarozeni = value; } }
        public string Pohlavi { get { return _Pohlavi; } set { _Pohlavi = value; } }
        public bool Status { get { return _Status; } set { _Status = value; } }

    }
}

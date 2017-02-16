using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceOsob
{
    class Persona
    {
        private string _firstName;
        private string _secondName;
        private int _age = new int();
        private string _privateID;
        private int _ID;
        private string _gender;
        private int _yyyy;
        private int NewGender;
        private DateTime _today = DateTime.Today;

        public Persona(string firstName, string secondName, string privateID, int gender)
        {

            _firstName = firstName;
            _secondName = secondName;
            _privateID = privateID;

            /*
            string DD = _privateID.Substring(_privateID.Length - 2);
            string MM = _privateID.Substring(_privateID.Length - 4);
            string YY = _privateID.Substring(_privateID.Length - 6);
            */

            int yy = int.Parse(_privateID.Substring(0, 2)) + 1900;
            int mm = int.Parse(_privateID.Substring(2, 2));
            int dd = int.Parse(_privateID.Substring(4, 2));
/*
            int dd = Int32.Parse(DD);
            int mm = Int32.Parse(MM);
            int yy = Int32.Parse(YY);
            */
            if (yy > 20)
            {
                _yyyy = 1900 + yy;
            }else
            {
                _yyyy = 2000 + yy;
            }

            //convert to string so you can extract pieces
            string strnbr = _privateID;

            //Get year, month, day values
            int year;
            year = int.Parse(strnbr.Substring(0, 2)) + 1900;

            if (year < 1920)
            {
                year = int.Parse(strnbr.Substring(0, 2)) + 2000;
            }

            int month = int.Parse(strnbr.Substring(2, 2));
            int day = int.Parse(strnbr.Substring(4, 2));

            //construct the date of birth
            DateTime dateOfBirth = new DateTime(year, month, day);

            //Difference between date of birth and today in days
            int daysOld = (DateTime.Today - dateOfBirth).Days;

            //if you want whole years
            DateTime slidingDate = dateOfBirth;
            while (slidingDate <= DateTime.Today)
            {
                slidingDate = slidingDate.AddYears(1);
                _age++;
            }

            //loop will add one too many years
           _age -= 1;

            NewGender = gender;
            if (NewGender != 0)
            {
                if (NewGender == 1)
                {
                    _gender = "Muž";
                }
                else if (NewGender == 2)
                {
                    _gender = "Dívka";
                }
                else if (NewGender > 2)
                {
                    _gender = "Shemale";
                }

            }
            else
            {
                _gender = "UNKNOWN";
            }

        }

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string SecondName { get { return _secondName; } set { _secondName = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string PrivateID { get { return _privateID; } set { _privateID = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public int ID { get { return _ID; } set { _ID = value; } }

    }
}

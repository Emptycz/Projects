using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceOsob.Entity
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PrivateID { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime TimeStamp { get; set; }

        public int Done { get; set; }
        public TodoItem()
        {
        }

        public override string ToString()
        {

            return "ID" + ID + " || Křestní jméno: " + FirstName + " " + SecondName + " || Věk: " + Age + " || Rodné číslo: " + PrivateID  + " || Pohlaví: " + Gender;
        }
    }
}

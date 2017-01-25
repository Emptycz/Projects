using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App5
{
    public partial class NewContact : ContentPage
    {
        public NewContact()
        {
            InitializeComponent();
        }

        public void novyKontakt (object sender, EventArgs e) {

            List<Osoba> osoby = new List<Osoba>();

            string FirstName = firstname.Text;
            string LastName = lastname.Text;
            string PreAge = age.Text;
            int Age = Int32.Parse(PreAge);

            osoby.Add(new Osoba(FirstName, LastName, Age));
                      
        }
    }
}

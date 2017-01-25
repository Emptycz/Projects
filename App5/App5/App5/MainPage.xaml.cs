using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<Osoba> Osoby = new List<Osoba>();

              
        }


        
            Command showPageCommand(Page page)
        {
                return new Command((() =>
                {
                    Navigation.PushAsync(page);
                }));


            }
        


    }
}

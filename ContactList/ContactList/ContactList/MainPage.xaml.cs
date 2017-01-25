using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ContactList
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void SendSMS_OnClicked(object sender, EventArgs e)
        {
            Device.OpenUri("tel\\:" + number);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DragDropExample
{
    public partial class Circle : ContentPage
    {
        public Circle(Circle c)
        {
            InitializeComponent();
            this.circleUI.Height = c.circleUI.Height;
            this.circleUI.Width = c.circleUI.Height;
            this.circleUI.Fill = c.circleUI.Fill;
        }
    }
}

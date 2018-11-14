using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GirlsWhoCodeDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var random = new Random();
            var randX = random.Next(-300, 300);
            var randY = random.Next(-300, 300);
            box.TranslateTo(randX, randY, 250, Easing.CubicIn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LyricGeniusApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
     private void btnCreate_Clicked(object sender, EventArgs e)
        {
           
               Navigation.PushAsync (new SignUp());
            

        } //end login clicked

        private void Log_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new LogIn());


        } //end login clicked
    }
}

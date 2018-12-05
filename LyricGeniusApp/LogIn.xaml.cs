using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LyricGeniusApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void Login_Clicked(object sender, EventArgs e)
        {
            bool isUserEmpty, isPwdEmpty;
            isUserEmpty = String.IsNullOrEmpty(entUser.Text);
            isPwdEmpty = String.IsNullOrEmpty(entPassword.Text);

            if (isUserEmpty || isPwdEmpty)
            {
               
            }
            else
            {
                
                Navigation.PushAsync(new GamePage());
            } 
        }
    }
}
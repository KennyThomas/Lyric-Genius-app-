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
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            bool isUserEmpty, isPwdEmpty;
            isUserEmpty = String.IsNullOrEmpty(entUser.Text);
            isPwdEmpty = String.IsNullOrEmpty(entPassword.Text);

            if (isUserEmpty || isPwdEmpty)
            {
                
            }
            else
            {
                Application.Current.Properties["user_id "] = entUser;
                Application.Current.Properties["user_Password "] = entPassword;
                Application.Current.SavePropertiesAsync();
                Navigation.PushAsync(new GamePage());
            } 

        }
    }
}
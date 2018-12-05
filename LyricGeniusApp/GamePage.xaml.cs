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
	public partial class GamePage : ContentPage
	{
		public GamePage ()
		{
			InitializeComponent ();
		}

        private void Play_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new DifficultySelect ());


        } //end login clicked

        private void LogOut_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new MainPage());


        } //end login clicked

        private void ViewScore_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new ScorePage());


        } //end login clicked
    }
}
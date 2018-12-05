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
	public partial class DifficultySelect : ContentPage
	{
		public DifficultySelect ()
		{
			InitializeComponent ();
		}
        private void Easy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Easy());
            }
        private void Medium_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Medium());
        }
        private void Hard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Hard());
        }
    }
    }
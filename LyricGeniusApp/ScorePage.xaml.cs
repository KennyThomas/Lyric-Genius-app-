using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LyricGeniusApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ScorePage : ContentPage
	{
		public ScorePage ()
		{
           
			InitializeComponent ();
            var TopScores = File.ReadLines("scorelog.txt")
    .Select(Easyscore => int.Parse(Easyscore))
    .OrderByDescending(score => score)
    .Take(10);



            EasyScores.Text = "Your score for the easy level is " + Easyscore;
		}

        public string Easyscore { get; }

        private void selection_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new GamePage());


        } //end login clicked
    }
}
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
	public partial class Hard : ContentPage
	{
        int score = 0;
        public Hard()
        {
            InitializeComponent();
        }



        private void Q1_Clicked(object sender, EventArgs e)
        {

            String Q1 = "stone";

            if (Answer1.Text == Q1)
            {
                LblMessage.Text = "Correct answer!";
                ++score;
                score.ToString();
                Score.Text = "your score is " + score;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q2_Clicked(object sender, EventArgs e)
        {
            String Q2 = "100";

            if (Answer2.Text == Q2)
            {
                LblMessage.Text = "Correct answer!";
                ++score;
                Score.Text = "your score is " + score;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q3_Clicked(object sender, EventArgs e)
        {
            String Q3 = "dark";

            if (Answer3.Text == Q3)
            {
                LblMessage.Text = "Correct answer!";
                ++score;
                Score.Text = "your score is " + score;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q4_Clicked(object sender, EventArgs e)
        {
            String Q4 = "symphony";

            if (Answer4.Text == Q4)
            {
                LblMessage.Text = "Correct answer!";
                ++score;
                Score.Text = "your score is " + score;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }


        private void Q5_Clicked(object sender, EventArgs e)
        {
            String Q5 = "sunflower";

            if (Answer5.Text == Q5)
            {
                LblMessage.Text = "Correct answer!";
                ++score;
                Score.Text = "your score is " + score;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }


        private void finish_Clicked(object sender, EventArgs e)
        {


            int[] SaveScore;
            SaveScore = new int[10];

            SaveScore[0] = score;
            FinalScore.Text = "Your final score is " + SaveScore[0];
        }
    }
}

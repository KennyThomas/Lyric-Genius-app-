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


    public partial class Easy : ContentPage
    {



        int Easyscore = 0;
        public Easy()
        {
            InitializeComponent();
        }



        private void Q1_Clicked(object sender, EventArgs e)
        {

            String Q1 = "Tiger";





            if (Answer1.Text == Q1)
            {
                LblMessage.Text = "Correct answer!";
                ++Easyscore;
                Easyscore.ToString();
                Score.Text = "your score is " + Easyscore;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q2_Clicked(object sender, EventArgs e)
        {
            String Q2 = "500";

            if (Answer2.Text == Q2)
            {
                LblMessage.Text = "Correct answer!";
                ++Easyscore;
                Score.Text = "your score is " + Easyscore;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q3_Clicked(object sender, EventArgs e)
        {
            String Q3 = "love";

            if (Answer3.Text == Q3)
            {
                LblMessage.Text = "Correct answer!";
                ++Easyscore;
                Score.Text = "your score is " + Easyscore;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }

        private void Q4_Clicked(object sender, EventArgs e)
        {
            String Q4 = "All Star";

            if (Answer4.Text == Q4)
            {
                LblMessage.Text = "Correct answer!";
                ++Easyscore;
                Score.Text = "your score is " + Easyscore;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }


        private void Q5_Clicked(object sender, EventArgs e)
        {
            String Q5 = "wall";

            if (Answer5.Text == Q5)
            {
                LblMessage.Text = "Correct answer!";
                ++Easyscore;
                Score.Text = "your score is " + Easyscore;

            }
            else
            {
                LblMessage.Text = "incorrect answer please try again";
            }
        }


        private void finish_Clicked(object sender, EventArgs e)
        {

            string fileName = @"scorelog.txt";
            using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.ReadWrite))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(Easyscore);
            }
            int[] SaveScore;
            SaveScore = new int[10];

            SaveScore[0] = Easyscore;
            FinalScore.Text = "Your final score is " + SaveScore[0];


        }
        private void BackPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());

        }
    }
}
    
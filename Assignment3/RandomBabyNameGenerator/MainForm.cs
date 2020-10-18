using System;
using System.Windows.Forms;

namespace RandomBabyNameGenerator
{
    public partial class MainForm : Form
    {
        string[] boyBabyNameList = { "Adam", "Alexxander", "Anthony", "John", "Leo", "William", "Thomas", "Jack", "Henry" };
        string[] girlBabyNameList = { "Anna", "Ariana", "Charlotte", "Elizabeth", "Emily", "Olivia", "Sofia", "Victoria", "Scarlett", "Lucy", "Lily" };

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateBoyNameButton_Click(object sender, EventArgs e)
        {
            int randomNumber = GenerateRandomNumber(boyBabyNameList.Length);
            boyNameLabel.Text = boyBabyNameList[randomNumber];
        }

        private int GenerateRandomNumber(int maxValue)
        {
            Random random = new Random();
            return random.Next(0, maxValue);
        }

        private void GenerateGirlNameButton_Click(object sender, EventArgs e)
        {
            int randomNumber = GenerateRandomNumber(girlBabyNameList.Length);
            girlNameLabel.Text = girlBabyNameList[randomNumber];
        }
    }
}

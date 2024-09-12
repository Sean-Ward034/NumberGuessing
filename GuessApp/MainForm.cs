// MainForm.cs
using System;
using System.Windows.Forms;

namespace GuessApp
{
    public partial class MainForm : Form
    {
        private int randomNumber;
        private int attempts;

        public MainForm()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            attempts = 0;
            lblFeedback.Text = "Guess a number between 1 and 100.";
            txtGuess.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(txtGuess.Text, out userGuess))
            {
                attempts++;
                if (userGuess < randomNumber)
                {
                    lblFeedback.Text = "Too low! Try again.";
                }
                else if (userGuess > randomNumber)
                {
                    lblFeedback.Text = "Too high! Try again.";
                }
                else
                {
                    lblFeedback.Text = $"Correct! You guessed the number in {attempts} attempts.";
                }
            }
            else
            {
                lblFeedback.Text = "Please enter a valid number.";
            }
            txtGuess.Clear();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int rounds = 10;
        public long timePerRound = 6; 
        string[] PCchoice = { "rock", "paper", "scissor", "rock", "scissor", "paper" };
        public int randomNumber;
        string command;
        Random rnd = new Random();
        string playerChoice;
        int playerWins = 0;
        int PCWins = 0;

        int counterOfRounds = 1;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            playerChoice = "none";
            lblTimer.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picturieForPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picturieForPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picturieForPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timePerRound--;
            lblTimer.Text = Convert.ToString(timePerRound);
            if (timePerRound < 1)
            {

                timer.Enabled = false; 

                timePerRound = 6;
                randomNumber = rnd.Next(0, 5);
                command = PCchoice[randomNumber];
                switch (command)
                {
                    case "rock":
                        picturieForPC.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        picturieForPC.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        picturieForPC.Image = Properties.Resources.scissors;
                        break;
                    default:
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    decisionEngine();
                }
            }
        }

        private void checkGame()
        {
            if (playerChoice == "rock" && command == "paper")
            {
                MessageBox.Show("PC спечели този рунд. :(");
                PCWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "rock")
            {
                MessageBox.Show("Ураа. Ти спечели този рунд!");
                playerWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "paper" && command == "scissor")
            {
                MessageBox.Show("PC спечели този рунд. :(");
                PCWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "scissor" && command == "paper")
            {
                MessageBox.Show("Ураа. Ти спечели този рунд!");
                playerWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "scissor" && command == "rock")
            {
                MessageBox.Show("PC спечели този рунд. :(");
                PCWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "rock" && command == "scissor")
            {
                MessageBox.Show("Ураа. Ти спечели този рунд!");
                playerWins++;
                rounds--;
                counterOfRounds++;
                nextRound();
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Упсс ти не направи своя избор. Опитай пак като направиш своя избор!");
                nextRound();
            }
            else
            {
                MessageBox.Show("В този рунд сте равни.");
                counterOfRounds++;
                nextRound();
            }

            if (counterOfRounds == 11)
            {
                lblTimer.Visible = false;
                timePerRound = 1000000000;
                lblTimer.Text = Convert.ToString(timePerRound);


                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Играта приключи!");
                sb.AppendLine("");
                sb.AppendLine("Резултатите от играта:");
                sb.AppendLine("Твоите спечелени рундове: " + playerWins);
                sb.AppendLine("Спечелените рундове на PC-то: " + PCWins);
                sb.AppendLine("Това означава че....");
                sb.AppendLine("");

                if (playerWins > PCWins)
                {
                    sb.AppendLine("Поздравления ти спчечели!");
                }
                else if (PCWins > playerWins)
                {
                    sb.AppendLine("За съжеление PC-то спчечели! Опитай пак. :)");
                }
                else if (PCWins == playerWins)
                {
                    sb.AppendLine("Играта завърши наравно! Опитай пак! :)");
                }

                MessageBox.Show(sb.ToString());
                this.Close();
            }

            lblRounds.Text = "Рунд: " + counterOfRounds;
        }

        private void decisionEngine()
        {
            if (playerWins > PCWins)
            {
                winsAndLoses.Text = winsAndLoses.Text + " спечели играта";
            }
            else
            {
                winsAndLoses.Text = "PC спчелеи играта";
            }
        }

        private void nextRound()
        {
            playerChoice = "none";
            picturieForPlayer.Image = Properties.Resources.myQ;
            timer.Enabled = true;
            picturieForPC.Image = Properties.Resources.myQ;
            picturieForPC.Image = Properties.Resources.myQ;

            winsAndLoses.Text = "Играч: " + playerWins + " - " + "PC: " + PCWins;
        }

        private void btnRolls_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("От посочените бутони играча трябва да избере един от трите хода.");
            sb.AppendLine("Времето за избор е 5 секунди.");
            sb.AppendLine("След избора на играча се генерира избор и на компютъра на случаен принцип.");
            sb.AppendLine("Ако играча не направи избор рундовете не се увеличават.");
            sb.AppendLine("След това се избира победител на база на ходовете.");
            sb.AppendLine("В реално време се визуализират точките на играча и PC-то, както и оставащите рундове.");
            sb.AppendLine("Рундовете са 10 на брой.");

            MessageBox.Show(sb.ToString());
        }

        private void lblRounds_Click(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

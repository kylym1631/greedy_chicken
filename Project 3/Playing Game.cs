using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class PlayingGame : Form
    {
        public int goal,curDice = 0,ScorePlayer1 = 0, ScorePlayer2 = 0, ScorePlayer3 = 0, ScorePlayer4 = 0, BankPlayer1 = 0, BankPlayer2 = 0, BankPlayer3 = 0, BankPlayer4 = 0,curScore =0,numPeo,playerTurn = 1;
        public string namePlayer, namePlayer1, namePlayer2, namePlayer3, namePlayer4,curNamePlayer;
        public Color colorPlayer, colorPlayer1, colorPlayer2, colorPlayer3, colorPlayer4;
        public PlayingGame(int goal, int numPeo,string namePlayer1, string namePlayer2, string namePlayer3, string namePlayer4,Color colorPlayer1, Color colorPlayer2, Color colorPlayer3, Color colorPlayer4)
        {
            this.numPeo = numPeo;
            this.goal = goal;
            this.namePlayer1 = namePlayer1;
            this.namePlayer2 = namePlayer2;
            this.namePlayer3 = namePlayer3;
            this.namePlayer4 = namePlayer4;

            this.CenterToScreen();
            InitializeComponent();
            labPlayerName1.Text = namePlayer1;
            labPlayerName2.Text = namePlayer2;
            labPlayerName3.Text = namePlayer3;
            labPlayerName4.Text = namePlayer4;

            panPlayerBig1.BackColor = colorPlayer1;
            panPlayerBig2.BackColor = colorPlayer2;
            panPlayerBig3.BackColor = colorPlayer3;
            panPlayerBig4.BackColor = colorPlayer4;

            this.colorPlayer1 = colorPlayer1;
            this.colorPlayer2 = colorPlayer2;
            this.colorPlayer3 = colorPlayer3;
            this.colorPlayer4 = colorPlayer4;

            butRoll.BackColor = colorPlayer1;
            butSave.BackColor = colorPlayer1;

            if (numPeo == 2)
            {
                panPlayerBig3.Visible = false;
                panPlayerBig4.Visible = false;
            }
            else if (numPeo == 3)
            {
                panPlayerBig4.Visible = false;
            }

            labTurn.Text = "Now " + namePlayer1 + " 's turn";
            butSave.Enabled = false;
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            void changeTurn(int numPl)
            {

                if (playerTurn < numPl)
                {
                    playerTurn++;
                }
                else
                {
                    playerTurn = 1;
                }
       
            }

            changeTurn(numPeo);

            void convertScore(Label labelPlayerScore)
            {
                curScore += Convert.ToInt32(labelPlayerScore.Text);
                labelPlayerScore.Text = curScore.ToString();
            }
           
            switch (playerTurn)
            {
                case 1:
                    curNamePlayer = namePlayer1;
                    colorPlayer = colorPlayer1;
                    if (numPeo == 2)
                    {
                        convertScore(labPlayerScore2);
                    }
                    else if (numPeo == 3)
                    {
                        convertScore(labPlayerScore3);
                    }
                    else if (numPeo == 4)
                    {
                        convertScore(labPlayerScore4);
                    }
                    break;
                case 2:
                    convertScore(labPlayerScore1);
                    curNamePlayer = namePlayer2;
                    colorPlayer = colorPlayer2;
                    break;
                case 3:
                    convertScore(labPlayerScore2);
                    curNamePlayer = namePlayer3;
                    colorPlayer = colorPlayer3;
                    break;
                case 4:
                    convertScore(labPlayerScore3);
                    curNamePlayer = namePlayer4;
                    colorPlayer = colorPlayer4;
                    break;
                default:
                    break;
            }
            butRoll.BackColor = colorPlayer;
            butSave.BackColor = colorPlayer;



            labTurn.Text = "Now " + curNamePlayer + " 's turn";
            labPlayerBank1.Text = 0.ToString();
            labPlayerBank2.Text = 0.ToString();
            labPlayerBank3.Text = 0.ToString();
            labPlayerBank4.Text = 0.ToString();

            ScorePlayer1 = Convert.ToInt32(labPlayerScore1.Text);
            ScorePlayer2 = Convert.ToInt32(labPlayerScore2.Text);
            ScorePlayer3 = Convert.ToInt32(labPlayerScore3.Text);
            ScorePlayer4 = Convert.ToInt32(labPlayerScore4.Text);
            if (ScorePlayer1 >= goal || ScorePlayer2 >= goal || ScorePlayer3 >= goal || ScorePlayer4 >= goal)
            {
                string winScore = "";
                if (ScorePlayer1 >= goal)
                {
                    winScore = namePlayer1;
                }
                else if (ScorePlayer2 >= goal)
                {
                    winScore = namePlayer2;
                }
                else if (ScorePlayer3 >= goal)
                {
                    winScore = namePlayer3;
                }
                else if (ScorePlayer4 >= goal)
                {
                    winScore = namePlayer4;
                }
                MessageBox.Show("Game is over, winner is " + winScore);
                butRoll.Enabled = false;
                butSave.Enabled = false;
            }
            curScore = 0;
            butSave.Enabled = false;
        }

        private void PlayingGame_Load(object sender, EventArgs e)
        {

        }

        private void butRoll_Click(object sender, EventArgs e)
        {
            labSorry.Visible = false;
            Random rndDice = new Random();
            curDice = rndDice.Next(1, 6);

            switch (curDice)
            {
                case 1:
                    pbDice.Image = Properties.Resources.dice1;
                    break;
                case 2:
                    pbDice.Image = Properties.Resources.dice2;
                    break;
                case 3:
                    pbDice.Image = Properties.Resources.dice3;
                    break;
                case 4:
                    pbDice.Image = Properties.Resources.dice4;
                    break;
                case 5:
                    pbDice.Image = Properties.Resources.dice5;
                    break;
                case 6:
                    pbDice.Image = Properties.Resources.dice6;
                    break;
                default:
                    break;
            }
            if (curDice == 1)
            {
                curScore = 0;
                butSave.Enabled = true;
                butSave.PerformClick();
                butSave.Enabled = false;
                labSorry.Visible = true;
            }
            else
            {
                curScore += curDice;
                butSave.Enabled = true;
            }

            switch (playerTurn)
            {
                case 1:
                    labPlayerBank1.Text =curScore.ToString();
                    break;
                case 2:
                    labPlayerBank2.Text = curScore.ToString();
                    break;
                case 3:
                    labPlayerBank3.Text =curScore.ToString();
                    break;
                case 4:
                    labPlayerBank4.Text =curScore.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}

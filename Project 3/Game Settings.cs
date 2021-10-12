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
    public partial class GameSettings : Form
    {
        public Color colorPlayer1 = Color.Red, colorPlayer2 = Color.Gold, colorPlayer3 = Color.Lime, colorPlayer4 = Color.DeepSkyBlue;
        public string namePlayer1, namePlayer2, namePlayer3, namePlayer4;
        public int numPeo,goal;
        public bool gameClose;
        public GameSettings()
        {
            InitializeComponent();
        }
        private void butCon_Click(object sender, EventArgs e)
        {
            if (tbNumPeo.Text.Trim() == "" || tbGoal.Text.Trim() == "")
            {
                MessageBox.Show("Please write valid numbers");
            }
            else
            {
                numPeo = Convert.ToInt32(tbNumPeo.Text);
                goal = Convert.ToInt32(tbGoal.Text);
                if (numPeo > 4 || numPeo < 2)
                {
                    MessageBox.Show("Number of players must be from 2 to 4");
                }
                else if (goal < 10 || goal > 1000)
                {
                    MessageBox.Show("Goal of the game between 10 and 1000");
                }
                else
                {
                    gbNames.Enabled = true;
                    gbSettings.Enabled = false;
                    if (numPeo == 2)
                    {
                        gbPlayer3.Enabled = false;
                        gbPlayer4.Enabled = false;
                    }
                    else if (numPeo == 3)
                    {
                        gbPlayer4.Enabled = false;

                    }
                    
                }

            }


        }
        private void butStart_Click(object sender, EventArgs e)
        {
            namePlayer1 = tbPlayer1.Text;
            namePlayer2 = tbPlayer2.Text;
            namePlayer3 = tbPlayer3.Text;
            namePlayer4 = tbPlayer4.Text;

            void mbShowErr()
            {
                MessageBox.Show("Please write players' names correctly");
            }

            void  players2()
            {
                if (namePlayer1 == "" || namePlayer2 == "")
                {
                    mbShowErr();
                }
                else
                {
                    this.Hide();
                    PlayingGame pG = new PlayingGame(goal,numPeo,namePlayer1,namePlayer2,namePlayer3,namePlayer4,colorPlayer1,colorPlayer2,colorPlayer3,colorPlayer4);
                    pG.ShowDialog();
                    this.Close();
                }
            }
            
            void players3()
            {
                if (gbPlayer3.Enabled == true && namePlayer3 == "")
                {
                    mbShowErr();
                }
                else
                {
                    players2();
                }
            }
            
            void players4()
            {
                if (gbPlayer4.Enabled == true && namePlayer4 == "")
                {
                    mbShowErr();
                }
                else
                {
                    players3();
                }
            }

            players4();
            
          
            
        }

        
        

        private void GameSettings_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
        public void changeColor(ColorDialog cd, Button bP)
        {
            DialogResult colorResult = cd.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                bP.BackColor = cd.Color;
            }
        }
        private void butPlayer1_Click(object sender, EventArgs e)
        {
            changeColor(colorDialog1, butPlayer1);
            colorPlayer1 = colorDialog1.Color;
        }


        private void butPlayer2_Click(object sender, EventArgs e)
        {
            changeColor(colorDialog2, butPlayer2);
            colorPlayer2 = colorDialog2.Color;
        }

        private void butPlayer3_Click(object sender, EventArgs e)
        {
            changeColor(colorDialog3, butPlayer3);
            colorPlayer3 = colorDialog3.Color;
        }

        private void butPlayer4_Click(object sender, EventArgs e)
        {
            changeColor(colorDialog4, butPlayer4);
            colorPlayer4 = colorDialog4.Color;
        }
    }
}

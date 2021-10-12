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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSettings gH = new GameSettings();
            gH.ShowDialog();
            this.Close();
        }
    }
}

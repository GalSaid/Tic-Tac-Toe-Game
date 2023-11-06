using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_toe
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            change_form(1); //Change to the main form with 1 player against the cpu
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            change_form(2);//change to the main form with 2 players
        }

        private void change_form(int playersNum)
        {
            TicTacToe t= new TicTacToe(playersNum);
            this.Hide();
            t.ShowDialog();
            this.Close();
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}

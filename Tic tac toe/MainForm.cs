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
    public partial class TicTacToe : Form
    {
        public enum Player { X, O } //Player 1 is X and player 2 or the cpu or is O
        private Player currentPlayer;
        Random random = new Random();
        private int playerWinCount;
        private int CPUPlayer2WinCount;
        private int playersNum; //2 players or 1 player
        private List<Button> buttonList; //All the Buttons that are free

        public TicTacToe(int playersNum)
        {
            InitializeComponent();
            playerWinCount = 0;
            CPUPlayer2WinCount = 0;
            this.currentPlayer=Player.X;//Player 1 is X and player 2 or the cpu or is O
            this.playersNum = playersNum;
            if (this.playersNum == 2)
                lblCPU.Location = new Point(215, 9);
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e) //In a game against player 1, the computer in his turn marks a circle
        {
            int buttonsCount = buttonList.Count; //free buttons
            if (buttonsCount>0)
            {
                int index= random.Next(buttonsCount);
                currentPlayer = Player.O;
                updateBtnDesign(buttonList[index]);
                CPUTimer.Stop();
                CheckWinner();
                currentPlayer = Player.X;//Passes the turn to the participant
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)//The turn of one of the players, not the cpu
        {
            Button btn=(Button)sender;
            updateBtnDesign(btn);
            CheckWinner();
            if (playersNum == 1) //Passes the turn to the cpu
                CPUTimer.Start();
            else //Passes the turn to the second player
                currentPlayer = currentPlayer == Player.X? Player.O: Player.X;
        }

        private void RestartGame(object sender, EventArgs e) //When the player want to start a new round
        {
            RestartGame();
        }

        private void CheckWinner() //After each round they check if there is a win or if the board is full
        {
            bool winner = false;
            //Horizontal win checker
            if ((button1.Text.Equals(button2.Text) && button2.Text.Equals(button3.Text) && button1.Text != "?") ||
                (button4.Text.Equals(button5.Text) && button5.Text.Equals(button6.Text) && button4.Text != "?") ||
                (button7.Text.Equals(button8.Text) && button8.Text.Equals(button9.Text) && button7.Text != "?"))
                winner = true;
            //Vertical win checker
            else if ((button1.Text.Equals(button4.Text) && button4.Text.Equals(button7.Text) && button1.Text != "?") ||
                    (button2.Text.Equals(button5.Text) && button5.Text.Equals(button8.Text) && button2.Text != "?") ||
                    (button3.Text.Equals(button6.Text) && button6.Text.Equals(button9.Text) && button3.Text != "?"))
                winner = true;
            //Diagonal win checker
            else if ((button1.Text.Equals(button5.Text) && button5.Text.Equals(button9.Text) && button1.Text != "?") ||
                (button3.Text.Equals(button5.Text) && button5.Text.Equals(button7.Text) && button3.Text != "?"))
                winner = true;
            else if (buttonList.Count == 0)//The game finished without winner
            {
                MessageBox.Show("There is no winner in this round!");
                RestartGame();
            }
            if(winner)
            {
                String win;
                if (playersNum == 1)             
                    win = currentPlayer == Player.X ? "Player" : "CPU"; 
                else
                    win = currentPlayer == Player.X ? "Player 1" : "Player 2";
                playerWinCount = currentPlayer==Player.X? playerWinCount+1:playerWinCount;
                CPUPlayer2WinCount=currentPlayer == Player.X ? CPUPlayer2WinCount : CPUPlayer2WinCount+1;
                MessageBox.Show(win+ " wins!");
                RestartGame();// A new round
                UpdateScoreLabelsAfterVictory();
            }
        }
        private void UpdateScoreLabelsAfterVictory() //Update the score of each participant
        {
            if(playersNum==1)
            {
                lblPlayer.Text = "Player wins: " + playerWinCount.ToString();
                lblCPU.Text = "CPU wins: " + CPUPlayer2WinCount.ToString();
            }
            else
            {
                lblPlayer.Text = "Player 1 wins: " + playerWinCount.ToString();
                lblCPU.Text = "Player 2 wins: " + CPUPlayer2WinCount.ToString();
            }
        }

        private void RestartGame() // A new round
        {
            buttonList = new List<Button> { button1,button2,button3,button4,button5,button6,button7,button8,button9};
            foreach(Button button in buttonList)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;
            }
        }

        private void TicTacToe_Load(object sender, EventArgs e)//Update the labels according to the number of players
        {
            if(playersNum==2)
            {
                this.WindowState = FormWindowState.Normal;
                lblCPU.Text = "Player 2 wins: ";
                lblPlayer.Text = "Player 1 wins: ";
            }  
        }
        private void updateBtnDesign(Button btn)//Change the design after the player or the cpu choose button
        {
            btn.Text = currentPlayer.ToString();
            btn.Enabled = false;
            btn.BackColor = currentPlayer == Player.X ? Color.FromArgb(0, 192, 0) : Color.FromArgb(128, 128, 255); ;
            buttonList.Remove(btn);
        }

        private void btnBack_Click(object sender, EventArgs e) //Return to the initial screen
        {
            StartForm s= new StartForm();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }
    }
}

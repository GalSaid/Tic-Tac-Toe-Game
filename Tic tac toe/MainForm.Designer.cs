namespace Tic_tac_toe
{
    partial class TicTacToe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPlayer.Location = new System.Drawing.Point(3, 9);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(129, 25);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player wins:";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCPU.Location = new System.Drawing.Point(322, 9);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(113, 25);
            this.lblCPU.TabIndex = 1;
            this.lblCPU.Text = "CPU wins:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(55, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 107);
            this.button1.TabIndex = 2;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(301, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 107);
            this.button3.TabIndex = 5;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(178, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 107);
            this.button2.TabIndex = 6;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button7.Location = new System.Drawing.Point(55, 286);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 107);
            this.button7.TabIndex = 10;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button9.Location = new System.Drawing.Point(301, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 107);
            this.button9.TabIndex = 11;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button8.Location = new System.Drawing.Point(178, 286);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 107);
            this.button8.TabIndex = 12;
            this.button8.Text = "?";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button6.Location = new System.Drawing.Point(301, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 107);
            this.button6.TabIndex = 5;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(178, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 107);
            this.button5.TabIndex = 6;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(55, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 107);
            this.button4.TabIndex = 13;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(144, 399);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(178, 51);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.RestartGame);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(374, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 33);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblPlayer);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Tic Tac Toe Game";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer CPUTimer;
        private System.Windows.Forms.Button btnBack;
    }
}


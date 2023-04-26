namespace Tic_Tac_Toe
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.championWin = new System.Windows.Forms.Label();
            this.currentPlayerSymbolLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(75, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 63);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Location = new System.Drawing.Point(151, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 63);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Location = new System.Drawing.Point(151, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 63);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Location = new System.Drawing.Point(75, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 63);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Location = new System.Drawing.Point(151, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 63);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button6.Location = new System.Drawing.Point(75, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 63);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button7.Location = new System.Drawing.Point(228, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 63);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button9.Location = new System.Drawing.Point(228, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 63);
            this.button9.TabIndex = 11;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button11.Location = new System.Drawing.Point(228, 81);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 63);
            this.button11.TabIndex = 9;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // championWin
            // 
            this.championWin.AutoSize = true;
            this.championWin.Location = new System.Drawing.Point(72, 31);
            this.championWin.Name = "championWin";
            this.championWin.Size = new System.Drawing.Size(107, 13);
            this.championWin.TabIndex = 14;
            this.championWin.Text = "It\'s Your Turn player: ";
            // 
            // currentPlayerSymbolLabel
            // 
            this.currentPlayerSymbolLabel.AutoSize = true;
            this.currentPlayerSymbolLabel.Location = new System.Drawing.Point(174, 31);
            this.currentPlayerSymbolLabel.Name = "currentPlayerSymbolLabel";
            this.currentPlayerSymbolLabel.Size = new System.Drawing.Size(0, 13);
            this.currentPlayerSymbolLabel.TabIndex = 15;
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Location = new System.Drawing.Point(75, 296);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(10, 13);
            this.winnerLabel.TabIndex = 16;
            this.winnerLabel.Text = " ";
            // 
            // retryButton
            // 
            this.retryButton.Location = new System.Drawing.Point(204, 311);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(96, 45);
            this.retryButton.TabIndex = 17;
            this.retryButton.Text = "R e t r y";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.currentPlayerSymbolLabel);
            this.Controls.Add(this.championWin);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe Game by mbuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label championWin;
        private System.Windows.Forms.Label currentPlayerSymbolLabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Button retryButton;
    }
}


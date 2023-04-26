using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        char currentPlayer = 'x';
        int totalButtonClicks = 0;

        public Form1()
        {
            InitializeComponent();
            currentPlayerSymbolLabel.Text = currentPlayer.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Text == "")
            {
                clickedButton.Text = currentPlayer.ToString();
                totalButtonClicks++;

                if (checkIsWinner())
                {
                    winnerLabel.Text = "You Won";
                    DisableAllButtons();
                    return;
                }

                if (totalButtonClicks == 9)
                {
                    winnerLabel.Text = "Tie";
                    DisableAllButtons();
                    return;
                }

                if (currentPlayer == 'x')
                {
                    currentPlayer = 'o';
                }
                else
                {
                    currentPlayer = 'x';
                }

                currentPlayerSymbolLabel.Text = currentPlayer.ToString();
            }
        }

        private void DisableAllButtons()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }


        bool checkIsWinner()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button11.Text)
            {
                if(currentPlayerSymbolLabel.Text == "x")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button11.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.Blue;
                    button11.BackColor = Color.Blue;
                }

                return true;
            }

            if (button3.Text != "" && button3.Text == button4.Text && button4.Text == button9.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button3.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Blue;
                    button9.BackColor = Color.Blue;
                }

                return true;
            }

            if (button5.Text != "" && button5.Text == button6.Text && button6.Text == button7.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button5.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                }
                else
                {
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Blue;
                }

                return true;
            }

            if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button6.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button6.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Blue;
                    button4.BackColor = Color.Blue;
                    button6.BackColor = Color.Blue;
                }

                return true;
            }

            if (button2.Text != "" && button2.Text == button3.Text && button3.Text == button5.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button3.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Blue;
                    button2.BackColor = Color.Blue;
                    button5.BackColor = Color.Blue;
                }

                return true;
            }

            if (button7.Text != "" && button7.Text == button9.Text && button9.Text == button11.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button7.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                    button11.BackColor = Color.Green;
                }
                else
                {
                    button7.BackColor = Color.Blue;
                    button9.BackColor = Color.Blue;
                    button11.BackColor = Color.Blue;
                }

                return true;
            }

            if (button1.Text != "" && button1.Text == button3.Text && button3.Text == button7.Text)
            {

                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button1.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                }
                else
                {
                    button1.BackColor = Color.Blue;
                    button3.BackColor = Color.Blue;
                    button7.BackColor = Color.Blue;
                }
                return true;
            }

            if (button6.Text != "" && button6.Text == button3.Text && button3.Text == button11.Text)
            {
                if (currentPlayerSymbolLabel.Text == "x")
                {
                    button6.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    button11.BackColor = Color.Green;
                }
                else
                {
                    button6.BackColor = Color.Blue;
                    button3.BackColor = Color.Blue;
                    button11.BackColor = Color.Blue;
                }

                return true;
            }

            return false;
        }
    }
}

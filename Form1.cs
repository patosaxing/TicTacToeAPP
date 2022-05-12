using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeAPI
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusOne;

        void Enable_False()
        {
            btn1Tic.Enabled = false;
            btn2Tic.Enabled = false;
            btn3Tic.Enabled = false;
            btn4Tic.Enabled = false;
            btn5Tic.Enabled = false;
            btn6Tic.Enabled = false;
            btn7Tic.Enabled = false;
            btn8Tic.Enabled = false;
            btn9Tic.Enabled = false;
        }

        void score()
        {
            //If X is selected ==============================================================================================
            if(btn1Tic.Text == "X" && btn2Tic.Text == "X" && btn3Tic.Text == "X")
            {
                btn1Tic.BackColor = System.Drawing.Color.PowderBlue;
                btn2Tic.BackColor = System.Drawing.Color.PowderBlue;
                btn3Tic.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn1Tic.Text == "X" && btn4Tic.Text == "X" && btn7Tic.Text == "X")
            {
                btn1Tic.BackColor = System.Drawing.Color.SpringGreen;
                btn4Tic.BackColor = System.Drawing.Color.SpringGreen;
                btn7Tic.BackColor = System.Drawing.Color.SpringGreen;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn1Tic.Text == "X" && btn5Tic.Text == "X" && btn9Tic.Text == "X")
            {
                btn1Tic.BackColor = System.Drawing.Color.MediumPurple;
                btn5Tic.BackColor = System.Drawing.Color.MediumPurple;
                btn7Tic.BackColor = System.Drawing.Color.MediumPurple;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn3Tic.Text == "X" && btn5Tic.Text == "X" && btn7Tic.Text == "X")
            {
                btn3Tic.BackColor = System.Drawing.Color.AliceBlue;
                btn5Tic.BackColor = System.Drawing.Color.AliceBlue;
                btn7Tic.BackColor = System.Drawing.Color.AliceBlue;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn2Tic.Text == "X" && btn5Tic.Text == "X" && btn8Tic.Text == "X")
            {
                btn2Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn5Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn8Tic.BackColor = System.Drawing.Color.DarkOliveGreen;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn3Tic.Text == "X" && btn6Tic.Text == "X" && btn9Tic.Text == "X")
            {
                btn2Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn5Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn8Tic.BackColor = System.Drawing.Color.DarkOliveGreen;

                MessageBox.Show("The Winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            //If O is selected ==============================================================================================
            if (btn1Tic.Text == "O" && btn2Tic.Text == "O" && btn3Tic.Text == "O")
            {
                btn1Tic.BackColor = System.Drawing.Color.AliceBlue;
                btn2Tic.BackColor = System.Drawing.Color.AliceBlue;
                btn3Tic.BackColor = System.Drawing.Color.AliceBlue;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn1Tic.Text == "O" && btn4Tic.Text == "O" && btn7Tic.Text == "O")
            {
                btn1Tic.BackColor = System.Drawing.Color.Crimson;
                btn4Tic.BackColor = System.Drawing.Color.Crimson;
                btn7Tic.BackColor = System.Drawing.Color.Crimson;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn1Tic.Text == "O" && btn5Tic.Text == "O" && btn7Tic.Text == "O")
            {
                btn1Tic.BackColor = System.Drawing.Color.Red;
                btn5Tic.BackColor = System.Drawing.Color.Red;
                btn7Tic.BackColor = System.Drawing.Color.Red;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn3Tic.Text == "O" && btn5Tic.Text == "O" && btn7Tic.Text == "O")
            {
                btn3Tic.BackColor = System.Drawing.Color.LightGray;
                btn5Tic.BackColor = System.Drawing.Color.LightGray;
                btn7Tic.BackColor = System.Drawing.Color.LightGray;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn2Tic.Text == "O" && btn5Tic.Text == "O" && btn8Tic.Text == "O")
            {
                btn2Tic.BackColor = System.Drawing.Color.LawnGreen;
                btn5Tic.BackColor = System.Drawing.Color.LawnGreen;
                btn8Tic.BackColor = System.Drawing.Color.LawnGreen;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }

            if (btn3Tic.Text == "O" && btn6Tic.Text == "O" && btn9Tic.Text == "O")
            {
                btn3Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn6Tic.BackColor = System.Drawing.Color.DarkOliveGreen;
                btn9Tic.BackColor = System.Drawing.Color.DarkOliveGreen;

                MessageBox.Show("The Winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusOne = int.Parse(lblPlayerY.Text);
                lblPlayerY.Text = Convert.ToString(plusOne + 1);
                Enable_False();
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1Tic_Click(object sender, EventArgs e)
        {
            if(checker == false)
            {
                btn1Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn1Tic.Text = "O";
                checker = false;
            }

            score();
            btn1Tic.Enabled = false;
        }

        private void btn2Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn2Tic.Text = "O";
                checker = false;
            }

            score();
            btn2Tic.Enabled = false;
        }

        private void btn3Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn3Tic.Text = "O";
                checker = false;
            }

            score();
            btn3Tic.Enabled = false;
        }

        private void btn4Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn4Tic.Text = "O";
                checker = false;
            }

            score();
            btn4Tic.Enabled = false;
        }

        private void btn5Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn5Tic.Text = "O";
                checker = false;
            }

            score();
            btn5Tic.Enabled = false;
        }

        private void btn6Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn6Tic.Text = "O";
                checker = false;
            }

            score();
            btn6Tic.Enabled = false;
        }

        private void btn7Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn7Tic.Text = "O";
                checker = false;
            }

            score();
            btn7Tic.Enabled = false;
        }

        private void btn8Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn8Tic.Text = "O";
                checker = false;
            }

            score();
            btn8Tic.Enabled = false;
        }

        private void btn9Tic_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9Tic.Text = "X";
                checker = true;
            }
            else
            {
                btn9Tic.Text = "O";
                checker = false;
            }

            score();
            btn9Tic.Enabled = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try { 
                btn1Tic.Enabled = true;
                btn2Tic.Enabled = true;
                btn3Tic.Enabled = true;
                btn4Tic.Enabled = true;
                btn5Tic.Enabled = true;
                btn6Tic.Enabled = true;
                btn7Tic.Enabled = true;
                btn8Tic.Enabled = true;
                btn9Tic.Enabled = true;

                btn1Tic.Text = "";
                btn2Tic.Text = "";
                btn3Tic.Text = "";
                btn4Tic.Text = "";
                btn5Tic.Text = "";
                btn6Tic.Text = "";
                btn7Tic.Text = "";
                btn8Tic.Text = "";
                btn9Tic.Text = "";

                lblScoreX.Text = "0";
                lblScoreY.Text = "0";

                btn1Tic.BackColor = Color.WhiteSmoke;
                btn2Tic.BackColor = Color.WhiteSmoke;
                btn3Tic.BackColor = Color.WhiteSmoke;
                btn4Tic.BackColor = Color.WhiteSmoke;
                btn5Tic.BackColor = Color.WhiteSmoke;
                btn6Tic.BackColor = Color.WhiteSmoke;
                btn7Tic.BackColor = Color.WhiteSmoke;
                btn8Tic.BackColor = Color.WhiteSmoke;
                btn9Tic.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try 
            { 
                btn1Tic.Enabled = true;
                btn2Tic.Enabled = true;
                btn3Tic.Enabled = true;
                btn4Tic.Enabled = true;
                btn5Tic.Enabled = true;
                btn6Tic.Enabled = true;
                btn7Tic.Enabled = true;
                btn8Tic.Enabled = true;
                btn9Tic.Enabled = true;

                btn1Tic.Text = "";
                btn2Tic.Text = "";
                btn3Tic.Text = "";
                btn4Tic.Text = "";
                btn5Tic.Text = "";
                btn6Tic.Text = "";
                btn7Tic.Text = "";
                btn8Tic.Text = "";
                btn9Tic.Text = "";

                btnNewGame.Enabled = true;

                btn1Tic.BackColor = Color.WhiteSmoke;
                btn2Tic.BackColor = Color.WhiteSmoke;
                btn3Tic.BackColor = Color.WhiteSmoke;
                btn4Tic.BackColor = Color.WhiteSmoke;
                btn5Tic.BackColor = Color.WhiteSmoke;
                btn6Tic.BackColor = Color.WhiteSmoke;
                btn7Tic.BackColor = Color.WhiteSmoke;
                btn8Tic.BackColor = Color.WhiteSmoke;
                btn9Tic.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

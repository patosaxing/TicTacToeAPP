namespace TicTacToeAPI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn1Tic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2Tic = new System.Windows.Forms.Button();
            this.btn3Tic = new System.Windows.Forms.Button();
            this.btn4Tic = new System.Windows.Forms.Button();
            this.btn5Tic = new System.Windows.Forms.Button();
            this.btn6Tic = new System.Windows.Forms.Button();
            this.btn7Tic = new System.Windows.Forms.Button();
            this.btn8Tic = new System.Windows.Forms.Button();
            this.btn9Tic = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPlayerY = new System.Windows.Forms.Label();
            this.lblScoreX = new System.Windows.Forms.Label();
            this.lblScoreY = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 89);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn9Tic);
            this.panel2.Controls.Add(this.btn8Tic);
            this.panel2.Controls.Add(this.btn7Tic);
            this.panel2.Controls.Add(this.btn6Tic);
            this.panel2.Controls.Add(this.btn5Tic);
            this.panel2.Controls.Add(this.btn4Tic);
            this.panel2.Controls.Add(this.btn3Tic);
            this.panel2.Controls.Add(this.btn2Tic);
            this.panel2.Controls.Add(this.btn1Tic);
            this.panel2.Location = new System.Drawing.Point(34, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 380);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(531, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 380);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblScoreY);
            this.panel4.Controls.Add(this.lblScoreX);
            this.panel4.Controls.Add(this.lblPlayerY);
            this.panel4.Controls.Add(this.lblPlayerX);
            this.panel4.Location = new System.Drawing.Point(18, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 180);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNewGame);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Location = new System.Drawing.Point(18, 200);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 168);
            this.panel5.TabIndex = 4;
            // 
            // btn1Tic
            // 
            this.btn1Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn1Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Tic.Location = new System.Drawing.Point(12, 14);
            this.btn1Tic.Name = "btn1Tic";
            this.btn1Tic.Size = new System.Drawing.Size(136, 107);
            this.btn1Tic.TabIndex = 0;
            this.btn1Tic.UseVisualStyleBackColor = false;
            this.btn1Tic.Click += new System.EventHandler(this.btn1Tic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // btn2Tic
            // 
            this.btn2Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn2Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Tic.Location = new System.Drawing.Point(167, 14);
            this.btn2Tic.Name = "btn2Tic";
            this.btn2Tic.Size = new System.Drawing.Size(136, 107);
            this.btn2Tic.TabIndex = 1;
            this.btn2Tic.UseVisualStyleBackColor = false;
            this.btn2Tic.Click += new System.EventHandler(this.btn2Tic_Click);
            // 
            // btn3Tic
            // 
            this.btn3Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn3Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Tic.Location = new System.Drawing.Point(321, 14);
            this.btn3Tic.Name = "btn3Tic";
            this.btn3Tic.Size = new System.Drawing.Size(136, 107);
            this.btn3Tic.TabIndex = 2;
            this.btn3Tic.UseVisualStyleBackColor = false;
            this.btn3Tic.Click += new System.EventHandler(this.btn3Tic_Click);
            // 
            // btn4Tic
            // 
            this.btn4Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn4Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Tic.Location = new System.Drawing.Point(12, 137);
            this.btn4Tic.Name = "btn4Tic";
            this.btn4Tic.Size = new System.Drawing.Size(136, 107);
            this.btn4Tic.TabIndex = 3;
            this.btn4Tic.UseVisualStyleBackColor = false;
            this.btn4Tic.Click += new System.EventHandler(this.btn4Tic_Click);
            // 
            // btn5Tic
            // 
            this.btn5Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn5Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Tic.Location = new System.Drawing.Point(167, 137);
            this.btn5Tic.Name = "btn5Tic";
            this.btn5Tic.Size = new System.Drawing.Size(136, 107);
            this.btn5Tic.TabIndex = 4;
            this.btn5Tic.UseVisualStyleBackColor = false;
            this.btn5Tic.Click += new System.EventHandler(this.btn5Tic_Click);
            // 
            // btn6Tic
            // 
            this.btn6Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn6Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6Tic.Location = new System.Drawing.Point(321, 137);
            this.btn6Tic.Name = "btn6Tic";
            this.btn6Tic.Size = new System.Drawing.Size(136, 107);
            this.btn6Tic.TabIndex = 5;
            this.btn6Tic.UseVisualStyleBackColor = false;
            this.btn6Tic.Click += new System.EventHandler(this.btn6Tic_Click);
            // 
            // btn7Tic
            // 
            this.btn7Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn7Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7Tic.Location = new System.Drawing.Point(12, 261);
            this.btn7Tic.Name = "btn7Tic";
            this.btn7Tic.Size = new System.Drawing.Size(136, 107);
            this.btn7Tic.TabIndex = 6;
            this.btn7Tic.UseVisualStyleBackColor = false;
            this.btn7Tic.Click += new System.EventHandler(this.btn7Tic_Click);
            // 
            // btn8Tic
            // 
            this.btn8Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn8Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Tic.Location = new System.Drawing.Point(167, 261);
            this.btn8Tic.Name = "btn8Tic";
            this.btn8Tic.Size = new System.Drawing.Size(136, 107);
            this.btn8Tic.TabIndex = 7;
            this.btn8Tic.UseVisualStyleBackColor = false;
            this.btn8Tic.Click += new System.EventHandler(this.btn8Tic_Click);
            // 
            // btn9Tic
            // 
            this.btn9Tic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn9Tic.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9Tic.Location = new System.Drawing.Point(321, 261);
            this.btn9Tic.Name = "btn9Tic";
            this.btn9Tic.Size = new System.Drawing.Size(136, 107);
            this.btn9Tic.TabIndex = 8;
            this.btn9Tic.UseVisualStyleBackColor = false;
            this.btn9Tic.Click += new System.EventHandler(this.btn9Tic_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(7, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 59);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(181, 95);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 59);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGame.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(7, 16);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(342, 63);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.Font = new System.Drawing.Font("Franklin Gothic Medium", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerX.Location = new System.Drawing.Point(3, 8);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(183, 48);
            this.lblPlayerX.TabIndex = 1;
            this.lblPlayerX.Text = "Player X:";
            // 
            // lblPlayerY
            // 
            this.lblPlayerY.AutoSize = true;
            this.lblPlayerY.Font = new System.Drawing.Font("Franklin Gothic Medium", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerY.Location = new System.Drawing.Point(3, 95);
            this.lblPlayerY.Name = "lblPlayerY";
            this.lblPlayerY.Size = new System.Drawing.Size(182, 48);
            this.lblPlayerY.TabIndex = 2;
            this.lblPlayerY.Text = "Player Y:";
            // 
            // lblScoreX
            // 
            this.lblScoreX.AutoSize = true;
            this.lblScoreX.BackColor = System.Drawing.Color.SeaShell;
            this.lblScoreX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreX.Font = new System.Drawing.Font("Franklin Gothic Medium", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreX.Location = new System.Drawing.Point(181, 16);
            this.lblScoreX.Name = "lblScoreX";
            this.lblScoreX.Size = new System.Drawing.Size(39, 40);
            this.lblScoreX.TabIndex = 3;
            this.lblScoreX.Text = "0";
            this.lblScoreX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreY
            // 
            this.lblScoreY.AutoSize = true;
            this.lblScoreY.BackColor = System.Drawing.Color.SeaShell;
            this.lblScoreY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoreY.Font = new System.Drawing.Font("Franklin Gothic Medium", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreY.Location = new System.Drawing.Point(181, 103);
            this.lblScoreY.Name = "lblScoreY";
            this.lblScoreY.Size = new System.Drawing.Size(39, 40);
            this.lblScoreY.TabIndex = 4;
            this.lblScoreY.Text = "0";
            this.lblScoreY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(951, 530);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn9Tic;
        private System.Windows.Forms.Button btn8Tic;
        private System.Windows.Forms.Button btn7Tic;
        private System.Windows.Forms.Button btn6Tic;
        private System.Windows.Forms.Button btn5Tic;
        private System.Windows.Forms.Button btn4Tic;
        private System.Windows.Forms.Button btn3Tic;
        private System.Windows.Forms.Button btn2Tic;
        private System.Windows.Forms.Button btn1Tic;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblScoreY;
        private System.Windows.Forms.Label lblScoreX;
        private System.Windows.Forms.Label lblPlayerY;
        private System.Windows.Forms.Label lblPlayerX;
    }
}


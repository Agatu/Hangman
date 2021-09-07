
namespace Hangman
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDescription = new System.Windows.Forms.Label();
            this.btnStarGame = new System.Windows.Forms.Button();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelGuessType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHint = new System.Windows.Forms.Button();
            this.labelHintText = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.labelTriesLeft = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.labelScoreInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(130, 96);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(453, 32);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Guess the capital of one of the countries.";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // btnStarGame
            // 
            this.btnStarGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStarGame.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStarGame.Location = new System.Drawing.Point(38, 24);
            this.btnStarGame.Name = "btnStarGame";
            this.btnStarGame.Size = new System.Drawing.Size(706, 66);
            this.btnStarGame.TabIndex = 3;
            this.btnStarGame.Text = "Start game";
            this.btnStarGame.UseVisualStyleBackColor = true;
            this.btnStarGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCapital.Location = new System.Drawing.Point(304, 141);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(24, 37);
            this.labelCapital.TabIndex = 4;
            this.labelCapital.Text = " ";
            this.labelCapital.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCapital.Click += new System.EventHandler(this.labelCapital_Click);
            // 
            // labelGuessType
            // 
            this.labelGuessType.AutoSize = true;
            this.labelGuessType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGuessType.Location = new System.Drawing.Point(38, 274);
            this.labelGuessType.Name = "labelGuessType";
            this.labelGuessType.Size = new System.Drawing.Size(164, 32);
            this.labelGuessType.TabIndex = 5;
            this.labelGuessType.Text = "Guess a letter:";
            this.labelGuessType.Click += new System.EventHandler(this.labelGuessType_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(304, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 39);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHint
            // 
            this.btnHint.Enabled = false;
            this.btnHint.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHint.Location = new System.Drawing.Point(38, 203);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(154, 34);
            this.btnHint.TabIndex = 10;
            this.btnHint.Text = "Take a hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // labelHintText
            // 
            this.labelHintText.AutoSize = true;
            this.labelHintText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHintText.Location = new System.Drawing.Point(217, 203);
            this.labelHintText.Name = "labelHintText";
            this.labelHintText.Size = new System.Drawing.Size(285, 30);
            this.labelHintText.TabIndex = 11;
            this.labelHintText.Text = "this will cost you some points";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(651, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(93, 40);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelTriesLeft
            // 
            this.labelTriesLeft.AutoSize = true;
            this.labelTriesLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTriesLeft.Location = new System.Drawing.Point(38, 462);
            this.labelTriesLeft.Name = "labelTriesLeft";
            this.labelTriesLeft.Size = new System.Drawing.Size(109, 32);
            this.labelTriesLeft.TabIndex = 13;
            this.labelTriesLeft.Text = "Tries left:";
            this.labelTriesLeft.Click += new System.EventHandler(this.labelTriesLeft_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCounter.Location = new System.Drawing.Point(167, 436);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(56, 65);
            this.labelCounter.TabIndex = 14;
            this.labelCounter.Text = "6";
            this.labelCounter.Click += new System.EventHandler(this.labelCounter_Click);
            // 
            // labelScoreInfo
            // 
            this.labelScoreInfo.AutoSize = true;
            this.labelScoreInfo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScoreInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelScoreInfo.Location = new System.Drawing.Point(147, 527);
            this.labelScoreInfo.Name = "labelScoreInfo";
            this.labelScoreInfo.Size = new System.Drawing.Size(33, 40);
            this.labelScoreInfo.TabIndex = 17;
            this.labelScoreInfo.Text = "  ";
            this.labelScoreInfo.Click += new System.EventHandler(this.labelScoreInfo_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 608);
            this.Controls.Add(this.labelScoreInfo);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelTriesLeft);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelHintText);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelGuessType);
            this.Controls.Add(this.labelCapital);
            this.Controls.Add(this.btnStarGame);
            this.Controls.Add(this.labelDescription);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Game";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button btnStarGame;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.Label labelGuessType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Label labelHintText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label labelTriesLeft;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label labelScoreInfo;
    }
}


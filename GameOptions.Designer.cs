
namespace Hangman
{
    partial class GameOptions
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
            this.labelChooseOption = new System.Windows.Forms.Label();
            this.buttonChooseLetter = new System.Windows.Forms.Button();
            this.buttonChooseWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseOption
            // 
            this.labelChooseOption.AutoSize = true;
            this.labelChooseOption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChooseOption.Location = new System.Drawing.Point(125, 23);
            this.labelChooseOption.Name = "label1";
            this.labelChooseOption.Size = new System.Drawing.Size(359, 32);
            this.labelChooseOption.TabIndex = 0;
            this.labelChooseOption.Text = "Choose what you want to guess:";
            // 
            // buttonChooseLetter
            // 
            this.buttonChooseLetter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseLetter.Location = new System.Drawing.Point(44, 64);
            this.buttonChooseLetter.Name = "button1";
            this.buttonChooseLetter.Size = new System.Drawing.Size(267, 53);
            this.buttonChooseLetter.TabIndex = 1;
            this.buttonChooseLetter.Text = " single letter";
            this.buttonChooseLetter.UseVisualStyleBackColor = true;
            this.buttonChooseLetter.Click += new System.EventHandler(this.buttonChooseLetter_Click);
            // 
            // buttonChooseWord
            // 
            this.buttonChooseWord.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseWord.Location = new System.Drawing.Point(317, 64);
            this.buttonChooseWord.Name = "button2";
            this.buttonChooseWord.Size = new System.Drawing.Size(267, 53);
            this.buttonChooseWord.TabIndex = 2;
            this.buttonChooseWord.Text = "whole word(s)";
            this.buttonChooseWord.UseVisualStyleBackColor = true;
            this.buttonChooseWord.Click += new System.EventHandler(this.buttonChooseWord_Click);
            // 
            // GameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 160);
            this.Controls.Add(this.buttonChooseWord);
            this.Controls.Add(this.buttonChooseLetter);
            this.Controls.Add(this.labelChooseOption);
            this.MaximizeBox = false;
            this.Name = "GameOptions";
            this.Text = "GameOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseOption;
        private System.Windows.Forms.Button buttonChooseLetter;
        private System.Windows.Forms.Button buttonChooseWord;
    }
}
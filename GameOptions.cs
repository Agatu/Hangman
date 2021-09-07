using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hangman
{
    public enum GameMode
    {
        letterMode,
        wordMode
    }

    public partial class GameOptions : Form
    {
        /// <summary>
        /// Enum representing game mode choosen by user.
        /// </summary>
        public GameMode opt = GameMode.letterMode;


        public GameOptions()
        {
            InitializeComponent();
        }

        public void buttonChooseLetter_Click(object sender, EventArgs e)
        {

            opt = GameMode.letterMode;
            this.Close();

        }

        public void buttonChooseWord_Click(object sender, EventArgs e)
        {
            opt = GameMode.wordMode;
            this.Close();

        }

    }
}

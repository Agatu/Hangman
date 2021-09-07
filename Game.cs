using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Game : Form
    {
        int i = 0;
        string target;
        string capital;
        string country;
        char guessLetter;
        string guessWord;
        bool hit = false;
        bool hint = false;
        int counter;
        GameOptions gopts = new GameOptions();


        public Game()
        {
            InitializeComponent();

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelCapital_Click(object sender, EventArgs e)
        {

        }

        private void labelGuessType_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            btnOK.Enabled = true;
            hint = false;
            btnHint.Enabled = true;
            labelHintText.Text = "this will cost you some points";
            labelCounter.Text = "6";
            counter = Int32.Parse(labelCounter.Text);
            labelScoreInfo.Text = "";
            gopts.ShowDialog();
            try
            {
                string path = @"..\..\..\countries_and_capitals.txt";
                StreamReader sr = new StreamReader(path);

                while (sr.ReadLine() != null)
                    i++;
                sr.Dispose();
                sr = new StreamReader(path);
                Random r = new Random();
                for (int k = 0; k < r.Next(1, i - 1); k++)
                    target = sr.ReadLine();
                string[] words = target.Split("|");
                country = words[0].Trim();
                capital = words[1].Trim();

                if (gopts.opt == GameMode.letterMode)
                {
                    textBox1.MaxLength = 1;
                }
                else
                {
                    labelGuessType.Text = "Guess a whole word(s)";
                    textBox1.MaxLength = 50;
                }

                Mask();
                sr.Dispose();
            }
            catch (Exception ev)
            {
                Console.WriteLine(ev.Message);
            }

        }


        private void Mask()
        {
            labelCapital.Text = "";
            for (i = 0; i < capital.Length; i++)
                labelCapital.Text = labelCapital.Text.Insert(i, "-");
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            ShowHint();
          

        }

        private void ShowHint()
        {
            counter = Int32.Parse(labelCounter.Text);

            if (counter > 1)
            {
                CounterChange();
                labelHintText.Text = "This is the capital of " + country;
                hint = true;
                hit = false;
                btnHint.Enabled = false;
            }
            else
            {
                MessageBox.Show("You do not have enough points to take a hint");
            }

        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            counter = Int32.Parse(labelCounter.Text);

            try
            {
                if (textBox1.Enabled)
                {
                    if (gopts.opt == GameMode.letterMode)
                    {
                        guessLetter = textBox1.Text[0];

                        for (i = 0; i < capital.Length; i++)
                        {

                            if (Char.ToUpper(capital[i]) == Char.ToUpper(guessLetter))
                            {

                                hit = true;
                                labelCapital.Text = labelCapital.Text.Remove(i, 1);
                                labelCapital.Text = labelCapital.Text.Insert(i, guessLetter.ToString().ToUpper());

                            }
                        }

                    }

                    else
                    {
                        guessWord = textBox1.Text;

                        if (capital.ToUpper() == guessWord.ToUpper())
                        {
                            hit = true;
                            labelCapital.Text = guessWord.ToString().ToUpper();
                        }

                    }
                    textBox1.Text = "";

                    CounterChange();

                    if (labelCapital.Text.ToUpper() == capital.ToUpper())
                        WonGame();
                   
                    if (counter == 0)
                        LostGame();
                    hit = false;

                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                MessageBox.Show("Enter a letter");
            }
       
        }
        
        private void CounterChange()
        {
            counter = Int32.Parse(labelCounter.Text);

            if (!hit)
            {

                if (gopts.opt == GameMode.letterMode)
                {
                    if (counter > 0)
                    {
                        counter--;
                    }
                }
                else if (gopts.opt == GameMode.wordMode)
                {
                    if (counter >= 2)
                        counter -= 2;
                    else
                    {
                        MessageBox.Show("You do not have enough points to try a whole word");
                    }
                }
                labelCounter.Text = counter.ToString();
                
            }

        }

        private void LostGame()
        {
            labelScoreInfo.Text = "Game over - You lost!";
            textBox1.Enabled = false;
            btnOK.Enabled = false;
        }

        private void WonGame()
        {
            labelScoreInfo.Text = "Congratulations - You won!";
            textBox1.Enabled = false;
            btnOK.Enabled = false;
        }

        private void labelCounter_Click(object sender, EventArgs e)
        {

        }

        private void labelTriesLeft_Click(object sender, EventArgs e)
        {

        }

        private void pictureGallows_Click(object sender, EventArgs e)
        {

        }

        private void labelScoreInfo_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }   
}


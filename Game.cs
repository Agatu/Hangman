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
        int counter;
        GameOptions gopts = new GameOptions();


        public Game()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            label7.Text = "6";
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
                    label3.Text = "Guess a whole word(s)";
                    textBox1.MaxLength = 50;
                }

                Mask();
                CountryMask();
                sr.Dispose();
            }
            catch (Exception ev)
            {
                Console.WriteLine(ev.Message);
            }
        }


        private void Mask()
        {
            label2.Text = "";
            for (i = 0; i < capital.Length; i++)
                label2.Text = label2.Text.Insert(i, "-");
        }

        private void CountryMask()
        {
            label5.Text = "";
            for (i = 0; i < capital.Length; i++)
                label5.Text = label5.Text.Insert(i, " ");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "This is the capital of " + country;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gopts.opt == GameMode.letterMode)
            {
                guessLetter = textBox1.Text[0];

                for (i = 0; i < capital.Length; i++)
                {
                    if (Char.ToUpper(capital[i]) == Char.ToUpper(guessLetter))
                    {
                        hit = true;
                        label2.Text = label2.Text.Remove(i, 1);
                        label2.Text = label2.Text.Insert(i, guessLetter.ToString().ToUpper());

                    }

                }
                textBox1.Text = "";
            }
            else
            {
                guessWord = textBox1.Text;

                if (capital.ToUpper() == guessWord.ToUpper())
                {
                    hit = true;
                    label2.Text = guessWord.ToString().ToUpper();
                }

                textBox1.Text = "";
            }

            if (label2.Text.ToUpper() == capital.ToUpper())
                WonGame();


            // Counter of tries left
            if (!hit)
            {
                counter = Int32.Parse(label7.Text);
                if (gopts.opt == GameMode.letterMode)
                {
                    counter--;
                }
                else if (gopts.opt == GameMode.wordMode)
                {
                    counter -= 2;
                }
                label7.Text = counter.ToString();

            }

            if (counter == 0)
                LostGame();
            hit = false;

        }

        public void LostGame()
        {
            label8.Text = "Game over - You lost! :(";
        }

        private void WonGame()
        {
            label8.Text = "Congratulations - You won! :)";
        }

    }
}


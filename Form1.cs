using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Array for the more code alphabet.
            //Array for the mores code alphabet represented by ASCII, each line is 10 ASCII digits.
            //Characters from 96+ were not needed because no morsecode exists for them.
            //Characters with no morese code below 95 have been left blank.
            string[] Morse =
                {
                    "", "", "", "", "", "", "", "", "", "", //0-9
                    "", "", "", "", "", "", "", "", "", "", //10-19
                    "", "", "", "", "", "", "", "", "", "", //20-29
                    "", "", "  ", "-·-·--", "·-··-·", "", "···-··-", "", "·-···", "·----·", //30-39
                    "-·--·", "-·--·-", "-..-", "·-·-·", "--··--", "-····-", "·-·-·-", "-··-·", "-----", ".----",  //40-49
                    "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "---...", "-.-.-.",  //50-59
                    "", "-...-", "", "..--..", ".--.-.",  ".-", "-...", "-.-.", "-..", ".", //60-69
                    "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", //70-79
                    ".--.", "--.-", ".-.",  "...", "-", "..-", "...-", ".--", "-..-", "-.--", //80-89
                    "--..", "", "", "", "","··--·-",  //90-95
                };
            String Message = "";

            //Encoding code.
            if (rbnEncode.Checked)
            {
                //Repeates for every letter entered.
                foreach (char c in txtInput.Text.ToUpper())
                {
                    //Converts letters to ASCII then takes the first ASCII number away to start from 0.
                    Message = Message + " " + Morse[System.Convert.ToInt32(c)];
                }
            }

            //Decoding code. 
            else
            {
                //Converts the input into an array of the words entered.
                string[] words = txtInput.Text.Split(' ');
                for (int i=0; i < words.Length; i++)
                {
                    try
                    {
                        //Checks for spaces and fixes the output.
                        if (words[i] == "")
                        {
                            Message = Message + " ";
                        }
                        else
                        {
                            //Searchs the array for input and converts the position to the ASCII letter.
                            int index1 = Array.IndexOf(Morse, words[i].ToUpper());
                            char character = (char)index1;
                            string text = character.ToString();
                            Message = Message + text;
                        }
                    }
                    catch
                    {
                        Message = Message;
                    }
                }
            }
            //Output Code
            txtOutput.Text = Message;
        }
        private void switchIt()
        {
            if (rbnEncode.Checked)
            {
                //Swaps the labels around.
                grbInput.Text = "Input Text";
                grbOutput.Text = "Output Morse code";
            }
            else
            {
                //Swaps the labels around.
                grbInput.Text = "Input Morse Code";
                grbOutput.Text = "Output Text";
            }
            //Wipes text boxes
            txtInput.Text = null;
            txtOutput.Text = null;
        }


        //Used to play audio for the code.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //By default txtoutput always has the morse in it.
            Char[] MorseToPlay = txtOutput.Text.ToCharArray();
            
            //Just incase it is in the input box.
            if (rbnDecode.Checked)
            {
                MorseToPlay = txtInput.Text.ToCharArray();
            }

            //Runs for as many characters there are.
            for (int i = 0; i < MorseToPlay.Length; i++)
            {
                //Plays dot sound.
                if (MorseToPlay[i] == '.')
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Short);
                    player.Play();
                }

                //Plays dash sound.
                else if (MorseToPlay[i] == '-')
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Long);
                    player.Play();
                }

                //Executes as a longer wait for a space
                else
                {
                    System.Threading.Thread.Sleep(1000);
                }

                //Leaves pause inbetween each one.
                System.Threading.Thread.Sleep(900);
            }
        }
        //used to trigger label change.
        private void rbnEncode_CheckedChanged_1(object sender, EventArgs e)
        {
            switchIt(); 
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            switchIt();
        }
    }
}
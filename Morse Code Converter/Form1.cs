//Sabrina Turney
//C# I
//Program 8-10: Morse Code Converter
//This program takes the entered user text and replaces the text with the Morse Code equivalent.

//Last edited: 09/26/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Morse_Code_Converter
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void ConvertButton_Click_1(object sender, EventArgs e)
        {

            //Array for all the letters, numbers, and characters able to be used.
            char[] englishChars =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4',
                '5', '6', '7', '8', '9', '0', ' ', ',', '.', '?'
            };

            //Now that we have the array for the plain English, we create a new string
            //array for the morse code equivalents (this was time-consuming, holy moly).
            string[] morseCodeChars =
            {
               ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",
                ".---", "-.-", ".-..", "--", "-.", "---", ".---.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----",
                "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                "-----", " ", "--..--", ".-.-.-", "..--.."
             };
            //And my fingers died there.

           


            //Next step is to take the user entered text:
            string userInputText = userInputTextBox.Text;
            

            //Then we make sure we can read the characters, since P != p
            userInputText = userInputText.ToLower();
            
            //Lsatly, we assign those characters to a char array using the built in function: 
            char[] chars = userInputText.ToCharArray();
            

            //After, just store the results in a new variable so we can attach our morse to it.
            string str = "";


            //"For" loop begins here to loop through our string of characters and the letters/numbers + morse code arrays. 
            for (int i = 0; i < chars.Length; i++)
            {
                //First we loop the numbers and letters array.
                for (int t = 0; t < englishChars.Length; t++)
                {
                    
                    //IMPORTANT: We make sure the next step will work by making sure our array matches our string values
                    //nested in an if block.
                    if (englishChars[t] == chars[i])
                    {
                        //if everything works, we then set the user entered text with our morse code array. 
                        str = morseCodeChars[t];
                    }
                }
                //Easy part- Display that to the user: 
                morseCodeOutput.Text += str;
            }

        }

        //Clear the form if the user wants to enter something else:
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            //Easy peasy- We just clear the fields for input and output
            //Just setting them to empty strings.
            morseCodeOutput.Text = "";
            userInputTextBox.Text = "";
        }

        //My favorite part of every program- An easy way out.
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            //closes the program :)
            this.Close();
        }
    }
}
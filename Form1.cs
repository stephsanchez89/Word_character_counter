using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
                        string text = textBox1.Text;
                        int wordCount = 0, index = 0;

                        // skip whitespace until first word
                        while (index < text.Length && char.IsWhiteSpace(text[index]))
                            index++;

                        while (index < text.Length)
                        {
                            // check if current char is part of a word
                            while (index < text.Length && !char.IsWhiteSpace(text[index]))
                                index++;

                            wordCount++;

                            // skip whitespace until next word
                            while (index < text.Length && char.IsWhiteSpace(text[index]))
                                index++;*/

            // }

            //label1.Text = "Word Count: " + wordCount + " Character Count: " + index;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int wordCount = 0, index = 0;

            // skip whitespace until first word
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // check if current char is part of a word
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // skip whitespace until next word
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            label1.Text = "Word Count: " + wordCount + " Character Count: " + index;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            String inp_word, out_pigTranslate; /*Variable Declaration*/
            inp_word = txtInput.Text; /*Reads the input from textbox and stores in variable inp_word*/

            /*Using string methods, the first letter is removed and then added at the end of the word with the word "ay", and then stores in variable out_pigTranslate*/
            out_pigTranslate = inp_word.Substring(1) + inp_word.Substring(0, 1) + "ay"; 

            lblOutput.Text = "The pig Latin version is " + out_pigTranslate; /*Displays output in the lblOutput object*/

        }
    }
}

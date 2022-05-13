using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KidsCalculator
{
    public partial class Form2 : Form
    {
        /*CONSTRUCTOR OF FORM 2 THAT ACCEPTS THE OPERATION AND SYMBOL BASED FROM CLICKED BUTTON*/
        public Form2(string operation, string symbol)
        {
            InitializeComponent();
            lblOperation.Text = operation;
            lblSymbol.Text = symbol;
        }

        /*IF EXIT BUTTON IS CLICKED, A DIALOG BOX IS SHOWN CONFIRMING EXIT.*/
        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /*IF MENU BUTTON IS CLICKED, FORM 2 WILL BE HIDDEN AND FORM 1 WILL BE VISIBLE*/
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        /*CALCULATES THE VALUES ENTERED BASED FROM USER INPUT AND OPERATION SELECTED*/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*PARSES INPUT FROM TEXTBOXES TO INTEGER, ASSIGNS IT TO AN INTEGER VARIABLE
             AND EVALUATES THE SYMBOL TO PERFORM THE CORRESPONDING OPERATION FOR THE NUMBERS*/
            try
            {
                int number1 = Int32.Parse(txtNum1.Text);
                int number2 = Int32.Parse(txtNum2.Text);
                float answer = 0;
                string symbol = lblSymbol.Text;
                switch (symbol)
                {
                    case "+": answer = number1 + number2;
                              lblAnswer.Text = answer.ToString();
                              break;
                    case "-": answer = number1 - number2;
                              lblAnswer.Text = answer.ToString();
                              break;
                    case "X": answer = number1 * number2;
                              lblAnswer.Text = answer.ToString();
                              break;
                    case "÷": answer = number1 / number2;
                              lblAnswer.Text = answer.ToString();
                              break;
                    default: new Exception(); break;
                }
            }
            /*IF ERROR ENCOUNTERED, SAY, EMPTY INPUT, AN ERROR MESSAGE IS DISPLAYED*/
            catch(Exception)
            {
                string message = "There seems to be an invalid entry from your input. Kindly correct and try again.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        /*WHEN THE CLEAR BUTTON IS CLICKED, THE TEXTBOXES AND ANSWER ARE CLEARED*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            lblAnswer.Text = null;
        }
    }
}

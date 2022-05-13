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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*IF DIVISION IS CLICKED, A NEW INSTANCE OF FORM 2 IS CREATED, PASSING OPERATION AND SYMBOL
         IN WHICH AT THE SAME TIME, FORM 1 WILL BE HIDDEN AND FORM 2 WILL BE SHOWN*/
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Division", "÷");
            frm2.Show();
            this.Hide();
        }

        /*IF DIVISION IS CLICKED, A NEW INSTANCE OF FORM 2 IS CREATED, PASSING OPERATION AND SYMBOL
         IN WHICH AT THE SAME TIME, FORM 1 WILL BE HIDDEN AND FORM 2 WILL BE SHOWN*/
        private void btnDivision_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Division", "÷");
            frm2.Show();
            this.Hide();
        }

        /*IF ADDITION IS CLICKED, A NEW INSTANCE OF FORM 2 IS CREATED, PASSING OPERATION AND SYMBOL
        IN WHICH AT THE SAME TIME, FORM 1 WILL BE HIDDEN AND FORM 2 WILL BE SHOWN*/
        private void btnAddition_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Addition","+");
            frm2.Show();
            this.Hide();                
        }

        /*IF ADDITION IS CLICKED, A NEW INSTANCE OF FORM 2 IS CREATED, PASSING OPERATION AND SYMBOL
        IN WHICH AT THE SAME TIME, FORM 1 WILL BE HIDDEN AND FORM 2 WILL BE SHOWN*/
        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Subtraction", "-");
            frm2.Show();
            this.Hide();
        }

        /*IF MULTIPLICATION IS CLICKED, A NEW INSTANCE OF FORM 2 IS CREATED, PASSING OPERATION AND SYMBOL
        IN WHICH AT THE SAME TIME, FORM 1 WILL BE HIDDEN AND FORM 2 WILL BE SHOWN*/
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("Multiplication", "X");
            frm2.Show();
            this.Hide();
        }
    }
}

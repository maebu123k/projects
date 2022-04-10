using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        //GLOBAL VARIABLE
        int input;

        public Form1()
        {
            InitializeComponent();
        }

        //PERFORMS GENERATION OF PRIME NUMBERS FROM 2 TO THE USER INPUT NUMBER
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //THIS IS A VALIDATION TO CHECK IF THE USER INPUT IS EMPTY
            try
            {
                input = Int32.Parse(txtInput.Text);
            }
            catch
            {
                //ERROR MESSAGE IS DISPLAYED IF INPUT IS EMPTY
                MessageBox.Show("Input cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //DECLARATION OF LIST
            List<int> numbers = new List<int>();

            //POPULATING THE LIST numbers WITH VALUES FROM 2 TO USER INPUT
            for (int x = 2; x <= input; x++)
            {
                numbers.Add(x);
            }

            //DECLARATION OF LIST THAT WILL HANDLE THE PRIME NUMBERS
            List<int> primes = new List<int>();

            //CALLS THE FUNCTION FindAll, PASSES THE numbers LIST
            //TO GET THE PRIME NUMBERS AND STORES IT IN THE primes LIST
            primes = FindAll(numbers);

            //ADDS THE PRIME NUMBERS IN THE LIST BOX
            for (int y = 0; y < primes.Count; y++)
            {
                lstPrime.Items.Add(primes.ElementAt(y));
            }
        }

        //THE METHOD TO GET FOR THE PRIME NUMBERS
        private List<int> FindAll(List<int> ls)
        {
            //DECLARE LIST THAT CONTAINS THE PRIME NUMBERS
            List<int> primenumbers = new List<int>();

            //RETRIEVES EACH NUMBERS FROM THE PASSED LIST TO EVALUATE
            for (int i = ls.ElementAt(0); i <= input; i++)
            {
                int counter = 0;

                //TEST THE NUMBER TO DIVIDE FROM THE CURRENT VALUE OF i
                //DOWN TO 1 AND SEE IF THE REMAINDER IS 0.
                for (int num = i; num >=1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }

                //IF THERE ARE TWO MODULUS OPERATION WITH 0 REMAINDER, 
                //THE NUMBER IS A PRIME NUMBER AND WILL BE ADDED TO THE LIST
                if (counter == 2)
                {
                    primenumbers.Add(i);
                }
            }
            return primenumbers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ercia_Jun_Lab6_Exer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Variables
        double price = 0;
        int quantity = 0;
        double line_total = 0;
        double overall_total = 0;

        //Set the initial values of textboxes Price and Order Total
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrice.Text = "$";
            txtPrice.SelectionStart = 1;
            txtOrderTotal.Text = "$0.00";
        }

        //This ensures that each time that the Price is changed
        //a dollar sign is appended
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                txtPrice.Text = "$";
                txtPrice.SelectionStart = 1;
            }
        }

        //Perform this method if the Exit option from Menu is clicked
        //A messagebox will be displayed with 2 buttons: Yes or No
        //If user presses Yes, the program will terminate
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this application?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();

        }

        //This code adds a new part to the combo box
        private void addPartToComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newpart = cmboDescription.Text;
            //If the item to be added is blank or already existing in the list
            //Display an error messagebox
            if ((cmboDescription.Items.Contains(newpart)) || (newpart == ""))
            {
                string message = "The added part cannot be blank or already existing";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            //Adds the new part in the combo box
            //and clears out the combo box selection afterwards
            else
            {
                cmboDescription.Items.Add(newpart);
                cmboDescription.Text = "";
            }
        }

        //This code deletes the currently selected part from the combo box
        private void deletePartFromComboBoxCtrlDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string existingpart = cmboDescription.Text;
            //If there is no selected part, an error messagebox is displayed
            if (existingpart == "")
            {
                string message = "The remove part cannot be blank";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            //The item is deleted
            //and the combo selection is set to blank
            else
            {
                cmboDescription.Items.Remove(existingpart);
                cmboDescription.Text = "";
            }
        }

        //Adds the populated combo box, price and quantity in the list box
        private void addPartToListBoxCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Performs adding of values if the validation passes
            if (ValidData() == true)
            {
                //Compute for the line total
                line_total = Math.Round(price * quantity, 2);

                //Compute for the overall total
                overall_total = Math.Round(overall_total + line_total, 2);

                //Adds the items in the list box
                lstItems.Items.Add(cmboDescription.Text + " - Price: " + txtPrice.Text + " - Qty: " + txtQuantity.Text + " - Line Total: $" + String.Format("{0:0.00}", line_total));
                
                //Displays the updated overall total
                txtOrderTotal.Text = "$" + String.Format("{0:0.00}", overall_total);

                //Resets the field values
                txtPrice.Text = "$";
                txtPrice.SelectionStart = 1;
                txtQuantity.Text = "";
                cmboDescription.Text = "";

                //Sets the focus in the combo box
                cmboDescription.Focus();
            }
        }

        //function validData that validates if the item to be added
        //to the combo box does not exists
        private bool ValidData()
        {
            bool valid_data = true;

            //Checks if the current value of the combobox is from the existing list
            //and not empty or typed, else an error message will be displayed.
            if (cmboDescription.SelectedIndex == -1)
            {
                string message = "Please choose among the exising options.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                //Sets the boolean flag to false since error is encountered
                valid_data = false;
            }

            //Checks the values of Sales Price and Quantity if they are greater than zero
            //or is empty
            try
            {
                //Convert the input Price and Quantity from string to integer
                price = float.Parse(txtPrice.Text.Substring(1));
                quantity = Int32.Parse(txtQuantity.Text);

                //If the price or quantity is negative
                //display an error message
                if ((price < 0) || (quantity < 0))
                {
                    string message = "Value of Sales Price/Quantity should be greater than 0.";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                    //Sets the boolean flag to false since error is encountered
                    valid_data = false;
                }
            }
            //If the input is empty, a message box will be displayed
            catch (FormatException)
            {
                string message = "Value of Sales Price/Quantity should not be empty.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                //Sets the boolean flag to false since error is encountered
                valid_data = false;
            }
            return valid_data;
        }

        //This clears out the list box
        //A warning message will be displayed to confirm deletion of list
        private void clearPartListBoxCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This action is irreversible. Please confirm that you want to clear the ListBox.";
            string title = "Are you sure?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            //If the user confirms, perform clearing of list
            //as well as resetting of variables and text fields
            if (result == DialogResult.Yes)
            {
                overall_total = 0;
                txtOrderTotal.Text = "$" + String.Format("{0:0.00}", overall_total);
                txtPrice.Text = "$";
                txtPrice.SelectionStart = 1;
                txtQuantity.Text = "";
                cmboDescription.Text = "";
                cmboDescription.Focus();
                lstItems.Items.Clear();
            }
        }

        //This counts the number of lines in the list box
        //and displays in a form of message box
        private void countPartsInListBoxCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string count = lstItems.Items.Count.ToString();
            string message = "There are " + count + " items in the list.";
            string title = "Number of items";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        //Perform this to show details about the program
        //Displays a messagebox showing name, date and time
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Jun Ercia\n" + DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            string title = "About";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
        }

        //The context menu Add Part To List Box simply calls
        //the method Add Part To List Box from the Main Menu
        //to perform adding part to listbox
        private void addPartToListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPartToListBoxCtrlAToolStripMenuItem_Click(cmboDescription, e);
        }

        //The context menu Exit simply calls
        //the method Exit from the Main Menu
        //to perform terminating of program
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }
    }
}

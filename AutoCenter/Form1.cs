using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is the action performed when the Auto Sales Button is clicked
        private void autosalesButton_Click(object sender, EventArgs e)
        {
            //When the button is clicked, displays the appropriate message in the label.
            informationLabel.Text = "Family Wagon, immaculate condition " + "\n$12,995.";
        }

        //This is the action performed when the Exit Button is clicked
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Terminates the program
        }

        //This is the action performed when the Service Center Button is clicked
        private void servicecenterButton_Click(object sender, EventArgs e)
        {
            //When the button is clicked, displays the appropriate message in the label.
            informationLabel.Text = "Lube, oil, filter " + "\n$25.99.";
        }

        //This is the action performed when the Detail Shop Button is clicked
        private void detailshopButton_Click(object sender, EventArgs e)
        {
            //When the button is clicked, displays the appropriate message in the label.
            informationLabel.Text = "Complete detail " + "\n$79.95 for most cars.";
        }

        //This is the action performed when the Employment Opportunities Button is clicked
        private void employmentopportunitiesButton_Click(object sender, EventArgs e)
        {
            //When the button is clicked, displays the appropriate message in the label.
            informationLabel.Text = "Sales position contact " + "\nMr. Mann " + "\n551-2134 x 475";
        }
    }
}

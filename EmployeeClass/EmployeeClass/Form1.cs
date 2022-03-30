using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(String.Format("{0}\t\t{1}\t{2}\t{3}", "Name", "ID Number", "Department", "Position"));
            listBox1.Items.Add(String.Format("{0}\t{1}\t\t{2}\t{3}", "Susan Meyers", "47899", "Accounting","Vice President"));
            listBox1.Items.Add(String.Format("{0}\t{1}\t\t{2}\t\t{3}", "Mark Jones", "39119", "IT", "Programmer"));
            listBox1.Items.Add(String.Format("{0}\t{1}\t\t{2}\t{3}", "Joy Rogers", "81774", "Manufacturing", "Engineering"));

        }
    }
}

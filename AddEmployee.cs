using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualPart
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public string FullName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Name
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string LastName
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string Age
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string AgeWorking
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string JobTitle
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        private void BOk_Click(object sender, EventArgs e)
        { 
            Close(); 
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


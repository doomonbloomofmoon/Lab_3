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
    public partial class CreateWorker : Form
    {
        public CreateWorker()
        {
            InitializeComponent();
        }

        public string Familiya
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Imuya
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string Otchestvo
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string Vozrast
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string Staj
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public string Doljnost
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


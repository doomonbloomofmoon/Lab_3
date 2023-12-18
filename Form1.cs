using Lab_2_indTask;
using System.Windows.Forms;

namespace IndividualPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddNote_Click(object sender, EventArgs e)
        {
            AddEmployee FormForAddEmployee = new AddEmployee();
            FormForAddEmployee.ShowDialog();

            if (FormForAddEmployee.FullName != "")
            {
                textBox1.Text = FormForAddEmployee.FullName;
                textBox2.Text = FormForAddEmployee.Name;
                textBox3.Text = FormForAddEmployee.LastName;
                textBox4.Text = FormForAddEmployee.Age;
                textBox5.Text = FormForAddEmployee.AgeWorking;
                textBox6.Text = FormForAddEmployee.JobTitle;

                Employee worker = new Employee(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
                worker.WorkExperience = Convert.ToInt32(textBox5.Text);
                worker.Position = textBox6.Text;
                
                string line = worker.FullName + "," 
                    + worker.Name + "," 
                    + worker.LastName + "," 
                    + worker.Age.ToString() + "," 
                    + worker.WorkExperience.ToString() + "," 
                    + worker.Position;
                listBox1.Items.Add(line);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString(); 
                string[] lines = selectedItem.Split(',');
                textBox1.Text = lines[0]; textBox2.Text = lines[1];
                textBox3.Text = lines[2]; textBox4.Text = lines[3];
                textBox5.Text = lines[4]; textBox6.Text = lines[5];
            }
            else 
            {
                textBox1.Text = "";
                textBox2.Text = textBox1.Text;
                textBox3.Text = textBox2.Text;
                textBox4.Text = textBox3.Text;
                textBox5.Text = textBox5.Text;
                textBox6.Text = textBox6.Text;
            }
        }

        private void ButtonExitFromProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Подтверждение действия", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) Application.Exit();
        }
    }
}
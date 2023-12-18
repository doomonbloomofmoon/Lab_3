using Lab_2_indTask;
using System.Windows.Forms;

namespace IndividualPart
{
    public partial class Form1 : Form
    {
        List<Worker> list = new List<Worker>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            CreateWorker cwForm = new CreateWorker();
            cwForm.ShowDialog();
            if (cwForm.Familiya != "")
            {
                txt1.Text = cwForm.Familiya;
                txt2.Text = cwForm.Imuya;
                txt3.Text = cwForm.Otchestvo;
                txt4.Text = cwForm.Vozrast;
                txt5.Text = cwForm.Staj;
                txt6.Text = cwForm.Doljnost;
                Worker worker = new Worker(txt1.Text, txt2.Text, txt3.Text, Convert.ToInt32(txt4.Text));
                worker.WorkExperience = Convert.ToInt32(txt5.Text);
                worker.Position = txt6.Text;
                list.Add(worker);
                string line = worker.FullName["Фамилия"] + "," + worker.FullName["Имя"] + "," + worker.FullName["Отчество"] + "," + worker.Age.ToString() + "," + worker.WorkExperience.ToString() + "," + worker.Position;
                listBox1.Items.Add(line);
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                String selected = listBox1.SelectedItem.ToString(); 
                String[] fields = selected.Split(',');
                txt1.Text = fields[0];
                txt2.Text = fields[1];
                txt3.Text = fields[2];
                txt4.Text = fields[3];
                txt5.Text = fields[4];
                txt6.Text = fields[5];
            }
            else 
            {
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                txt6.Text = "";
            }
        }
    }
}
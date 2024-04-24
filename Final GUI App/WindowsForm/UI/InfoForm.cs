using LMSlibrary.Bl;
using LMSlibrary.DL.DB;
using LMSlibrary.DLInterfaces;
using LMSlibrary.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IStudent student = new StudentDL(Utility.GetConnectionstring());
            Customer cus = new Customer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            student.AddStudent(cus);
            MessageBox.Show("Student's Info Added!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}

using LMSlibrary.Bl;
using LMSlibrary.DL;
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
    public partial class UpdateStuForm : Form
    {
        public UpdateStuForm()
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
            student.UpdateInfo(textBox1.Text, textBox2.Text);
            MessageBox.Show("Updated Successfully!");
            textBox1.Text = "";
            textBox2.Text = "";
            UpdateStuForm_Load(sender,  e);
        }

        private void UpdateStuForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("MbileNo");
            dt.Columns.Add("Email");
            IStudent student = new StudentDL(Utility.GetConnectionstring());
            List<Customer> c = student.GetInfo();
            foreach (Customer cus in c)
            {
                dt.Rows.Add(cus.GetName() , cus.GetGender() , cus.GetNumber() , cus.GetEmail());
            }
            dataGridView1.DataSource = dt;
        }
    }
}

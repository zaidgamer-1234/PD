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
            ICustomer student = new CustomerDB(Utility.GetConnectionstring());
           
            if (student.UpdateGender(textBox2.Text,SignIn.GetUserUserName()) && student.UpdateName(textBox1.Text,SignIn.GetUserUserName()) && student.UpdateMobileNumber(textBox3.Text,SignIn.GetUserUserName()))
            {
               

                MessageBox.Show("Student's Info Added!");
                InfoForm_Load(sender, e);
            }
           
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";



        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

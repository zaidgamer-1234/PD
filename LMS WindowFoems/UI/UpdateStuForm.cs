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
            ICustomer student = new CustomerDB(Utility.GetConnectionstring());
            student.UpdateMobileNumber(textBox2.Text , SignIn.GetUserUserName());
            MessageBox.Show("Updated Successfully!");
            textBox2.Text = "";
            UpdateStuForm_Load(sender,  e);
        }

        private void UpdateStuForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}

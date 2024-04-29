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
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMuser admin = new MuserDbStore(Utility.GetConnectionstring());
            admin.UpdatePassword(SignIn.GetUserUserName(), textBox2.Text);
            MessageBox.Show("Account Updated!");
            textBox2.Text = "";
           // UpdateProfile_Load(sender,  e);
        
        }
    }
}

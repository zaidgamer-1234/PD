using LMSlibrary.DL;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrudForm crudForm = new CrudForm();
            this.Hide();
            crudForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowAccountsForm crudForm = new ShowAccountsForm();
            this.Hide();
            crudForm.ShowDialog();
;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateProfile p = new UpdateProfile();
            this.Hide();
            p.ShowDialog();
        }
    }
}

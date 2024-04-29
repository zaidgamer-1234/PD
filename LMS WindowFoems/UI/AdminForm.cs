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

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DeleteCustomerAccount d = new DeleteCustomerAccount();
            this.Hide();
            d.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BorrowedBooksForm b = new BorrowedBooksForm();
            this.Hide();
            b.ShowDialog();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            this.Hide();
            customerInfo.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewFeedBack viewFeedBack = new ViewFeedBack();
            this.Hide();
            viewFeedBack.ShowDialog();
        }
    }
}

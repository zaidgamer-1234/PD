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
    public partial class CustomerInfo : Form
    {
        public CustomerInfo()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            ICustomer user = new CustomerDB(Utility.GetConnectionstring());


            dt.Columns.Add("Gender");
            dt.Columns.Add("Mobile Number");
            List<Customer> muser = user.GetCustomers();

            foreach (Customer m in muser)
            {

                dt.Rows.Add(m.GetPassword(), m.GetRole());

            }
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }
    }
}

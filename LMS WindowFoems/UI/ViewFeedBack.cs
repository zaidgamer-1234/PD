using LMSlibrary.DL.DB;
using LMSlibrary.DLInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMSlibrary.Utility;

namespace WindowsForm.UI
{
    public partial class ViewFeedBack : Form
    {
        DataTable dataTable=new DataTable();
        public ViewFeedBack()
        {
            InitializeComponent();
            dataTable.Columns.Add("Sr.");
            dataTable.Columns.Add("Feedback");
            ICustomer CustomerDB = new CustomerDB(Utility.GetConnectionstring());
            List<string> strings = CustomerDB.GetFeedback();
            int i = 1;
            foreach(string s in strings)
            {
                if(s==null)
                {
                    break;
                }
                dataTable.Rows.Add(i, s);
                i++;
            }
            dataGridView1.DataSource=dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

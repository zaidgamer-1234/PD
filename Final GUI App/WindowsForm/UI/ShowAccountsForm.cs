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
    public partial class ShowAccountsForm : Form
    {
        public ShowAccountsForm()
        {
            InitializeComponent();
        }

        private void ShowAccountsForm_Load(object sender, EventArgs e)
        {
             IMuser user = new MuserDbStore(Utility.GetConnectionstring());
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Username");
            dt.Columns.Add("Password");
            dt.Columns.Add("Role");
            List<Muser> muser = user.GetMuserList();
            foreach (Muser m in muser) 
            {
                dt.Rows.Add(m.GetUsername(), m.GetPassword(), m.GetRole());
            }
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            admin.RemoveAcc(textBox1.Text);
            MessageBox.Show("User Account Deleted!");
            textBox1.Text = "";
            ShowAccountsForm_Load( sender,  e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }
    }
}

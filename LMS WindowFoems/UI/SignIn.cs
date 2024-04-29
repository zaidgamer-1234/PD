using LMSlibrary.Bl;
using LMSlibrary.DL.DB;
using LMSlibrary.DL.FH;
using LMSlibrary.DLInterfaces;
using LMSlibrary.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm.UI
{
    public partial class SignIn : Form
    {

        private static string UserUserName;
        public static void SetUserUserName(string userUserName)
        {
            UserUserName = userUserName;
        }
        public static string GetUserUserName() { return UserUserName; }
        public SignIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            form.ShowDialog();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "E:\\zaid\\semester 2\\Projects\\Data.txt";

             IMuser user = new MuserDbStore(Utility.GetConnectionstring());
            //IMuser user = new MuserFHstore(path);

            Muser muser = new Muser(textBox1.Text, textBox2.Text);
           muser =  user.SignIn(muser);
            if(muser != null && muser.isAdmin())
            {
                SetUserUserName(muser.GetUsername());
                MessageBox.Show("Admin login");
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.ShowDialog();
            }
            else if(muser != null && muser.isCustomer())
            {
                SetUserUserName(muser.GetUsername());

                MessageBox.Show("Student login");
                StudentForm studentForm = new StudentForm();
                this.Hide();
                studentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User does not exist!");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "E:\\zaid\\semester 2\\Projects\\Data.txt";
            IMuser muser = new MuserFHstore(path);
            //IMuser muser = new MuserDbStore(Utility.GetConnectionstring());
            Muser user = null;
            if(textBox3.Text == "admin")
            {
                user = new Admin(textBox1.Text, textBox2.Text, "admin");
            }
            else if(textBox3.Text == "student")
            {
                user = new Admin(textBox1.Text, textBox2.Text, "student");
            }

            // muser.SignUp(user);
            muser.SignUp(user);
            MessageBox.Show("User added");

                
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

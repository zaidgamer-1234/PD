using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.UI;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                SignUp signUp = new SignUp();
                signUp.ShowDialog();
                Visible = false;
            }
            else if(checkBox2.Checked == true)
            {
                SignIn signIn = new SignIn();   
                signIn.ShowDialog();
                Visible = false;
            }
        }
    }
}

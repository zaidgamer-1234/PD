using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsForm.UI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowStuBooksForm showStuBooksForm = new ShowStuBooksForm();
            this.Hide();
            showStuBooksForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateStuForm update = new UpdateStuForm();
            this.Hide();
            update.ShowDialog();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BorrowbookForm borrowbookForm = new BorrowbookForm();
            this.Hide();
            borrowbookForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            this.Hide();
            infoForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AddFeedback form1 = new AddFeedback();
            this.Hide();
            form1.ShowDialog();}
    }
}

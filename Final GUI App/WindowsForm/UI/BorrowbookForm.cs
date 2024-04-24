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
    public partial class BorrowbookForm : Form
    {
        public BorrowbookForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.ShowDialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            IStudent student = new StudentDL(Utility.GetConnectionstring());
            student.BorrowBook(textBox1.Text);
            MessageBox.Show("Book is borrowed!");
            textBox1.Text = "";
        }

        private void BorrowbookForm_Load(object sender, EventArgs e)
        {

        }
    }
}

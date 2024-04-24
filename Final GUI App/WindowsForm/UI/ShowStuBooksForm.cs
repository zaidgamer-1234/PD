using LMSlibrary.Bl;
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
    public partial class ShowStuBooksForm : Form
    {
        public ShowStuBooksForm()
        {
            InitializeComponent();
        }

        private void ShowStuBooksForm_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.ShowDialog();
        }

        private void ShowStuBooksForm_Load_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookTitle");
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Edition");
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            List<Book> book = admin.GetBooksInfo();
            foreach (Book bookItem in book)
            {
                dt.Rows.Add(bookItem.GetBookTitle(), bookItem.GetBookISbn(), bookItem.GetEdition());
            }
            dataGridView1.DataSource = dt;
        }
    }
}

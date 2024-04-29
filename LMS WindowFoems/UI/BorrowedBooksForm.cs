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
    public partial class BorrowedBooksForm : Form
    {
        public BorrowedBooksForm()
        {
            InitializeComponent();
        }

        private void BorrowedBooksForm_Load(object sender, EventArgs e)
        {
            IBook book= new BookDL(Utility.GetConnectionstring());
            DataTable dt = new DataTable();

            dt.Columns.Add("Title");
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Edition");
            dt.Columns.Add("Status");
            dt.Columns.Add("Author");
            dt.Columns.Add("Author Cnic");
            List<Book> books = book.GetBorrowedBooks();
            foreach (Book m in books)
            {
                dt.Rows.Add(m.GetBookTitle() , m.GetBookISbn() , m.GetEdition() , m.GetStatus() , m.GetBookAuthor().GetName() , m.GetBookAuthor().GetCnic());
            }
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm a = new AdminForm();
            this.Hide();
            a.ShowDialog();
        }
    }
}

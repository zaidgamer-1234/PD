using LMSlibrary.Bl;
using LMSlibrary.DL;
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
    public partial class CrudForm : Form
    {
        public CrudForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            Book book = new Book(textBox1.Text , textBox2.Text , textBox3.Text);
            if(book != null)
            {
                admin.AddBook(book);
                MessageBox.Show("Successfully Added!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                CrudForm_Load(sender, e);
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            admin.UpdateBook(textBox3.Text , textBox1.Text);
            MessageBox.Show("Book Updated!");
            textBox3.Text = "";
            CrudForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            admin.RemoveBook(textBox1.Text);
            MessageBox.Show("Book Deleted!");
            textBox1.Text = "";
            CrudForm_Load(sender, e);
        }

        private void CrudForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BookTitle");
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Edition");
            IAdmin admin = new AdminDL(Utility.GetConnectionstring());
            List<Book> book = admin.GetBooksInfo();
            foreach(Book bookItem in book) 
            {
                dt.Rows.Add(bookItem.GetBookTitle(), bookItem.GetBookISbn(), bookItem.GetEdition());
            }
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }
    }
}

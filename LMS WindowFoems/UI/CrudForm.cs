using LMSlibrary.Bl;
using LMSlibrary.DL;
using LMSlibrary.DL.DB;
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
            IBook admin = new BookDL(Utility.GetConnectionstring());
            Book book = new Book(textBox1.Text , textBox2.Text , textBox3.Text,comboBox1.Text,textBox4.Text,textBox5.Text);
            if(book != null)
            {
                admin.AddBook(book);
                MessageBox.Show("Successfully Added!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                CrudForm_Load(sender, e);
            }


        }


        private void button3_Click(object sender, EventArgs e)
        {
            IBook admin = new BookDL(Utility.GetConnectionstring());
            admin.UpdateBookTitle(textBox2.Text , textBox1.Text);
            MessageBox.Show("Book Title Updated!");
            textBox3.Text = "";
            CrudForm_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IBook admin = new BookDL(Utility.GetConnectionstring());
            admin.RemoveBook(textBox2.Text);
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
            dt.Columns.Add("Status");
            dt.Columns.Add("AuthorName");
            dt.Columns.Add("AuthorCnic");
            IBook admin = new BookDL(Utility.GetConnectionstring());
            List<Book> book = admin.GetAllBooks();
            foreach(Book bookItem in book) 
            {
                dt.Rows.Add(bookItem.GetBookTitle(), bookItem.GetBookISbn(), bookItem.GetEdition() , bookItem.GetStatus() , bookItem.GetBookAuthor().GetName(), bookItem.GetBookAuthor().GetCnic());
            }
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IBook admin = new BookDL(Utility.GetConnectionstring());
            admin.UpdateBookEdition(textBox2.Text, textBox3.Text);
            MessageBox.Show("Book Edition sUpdated!");
            textBox3.Text = "";
            CrudForm_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

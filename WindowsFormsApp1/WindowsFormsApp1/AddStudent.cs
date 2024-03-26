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

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printStdents();
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection sql = new SqlConnection(conn);
            sql.Open();
            string query = "insert into student values(@Fname, @Lname,@Contact,@Email,@RegistrationNumber,@Status)";
            SqlCommand sqlCommand = new SqlCommand(query, sql);
            sqlCommand.Parameters.AddWithValue("@Fname",textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@Lname", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@Contact",textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@Email",textBox5.Text);
            sqlCommand.Parameters.AddWithValue("@RegistrationNumber", textBox4.Text);
            sqlCommand.Parameters.AddWithValue("@Status",textBox6.Text);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Student Successfully inserted");
            printStdents();

        }
        private void printStdents()
        {
            string conn = " Data Source = ABDULHANANPC\\SQLEXPRESS11; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection sql = new SqlConnection(conn);
            sql.Open();
            string query = "Select * from Student";
            SqlCommand sqlCommand = new SqlCommand( query, sql);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            reader.Close();
            sql.Close();
        }
    }
}

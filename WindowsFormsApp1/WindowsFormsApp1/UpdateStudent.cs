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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            SqlConnection sql = new SqlConnection(conn);
            sql.Open();
            string Fname = textBox1.Text;
            string roll = textBox7.Text;
            string Lname = textBox2.Text;
            string contact = textBox3.Text;
            string Registration= textBox4.Text;
            string Email = textBox5.Text;
            string query = "update Student set FirstName = '" + Fname + "',LastName = '" + Lname + "',Contact = " + contact + ",Email = '" + Email + "',RegistrationNumber = '" + Registration + "' WHERE RegistrationNumber ='" + roll + "' ;";
            SqlCommand sqlCommand = new SqlCommand(query, sql);

            sqlCommand.ExecuteNonQuery();
            sql.Close();
            MessageBox.Show("Student Successfully updated");
            printStdents();
           
        }
        private void printStdents()
        {
            string conn = " Data Source = ABDULHANANPC\\SQLEXPRESS11; Initial Catalog = ProjectB; Integrated Security = True";
            SqlConnection sql = new SqlConnection(conn);
            sql.Open();
            string query = "Select * from Student";
            SqlCommand sqlCommand = new SqlCommand(query, sql);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            reader.Close();
            sql.Close();
        }
    }
}

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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete_Load(object sender, EventArgs e)
        {
            
            printStudents();
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string data = maskedTextBox1.Text;
            string query = "Delete from Student where RegistrationNumber='"+data+"'";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Student Deleted Successfully");
            printStudents();
        }
        private void printStudents()
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Select * from Student";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            sqlDataReader.Close();
            sqlConnection.Close();
        }
    }         
}

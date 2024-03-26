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
    public partial class CLO : Form
    {
        public CLO()
        {
            InitializeComponent();
        }

        private void CLO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Insert into CLO(Name,DateCreated,DateUpdated) Values(@Name,GETDATE(),GETDATE());";
            SqlConnection sqlConnection= new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sql = new SqlCommand(query, sqlConnection);
            sql.Parameters.AddWithValue("Name",textBox1.Text);
            sql.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("CLO Added Suceesfully");
            printCLOs();

        }
        private void printCLOs()
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Select * from CLO;";
            SqlConnection sqlConnection = new SqlConnection( conn );
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            reader.Close();
            sqlConnection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string ans = textBox1.Text;
            string query = "Update CLO Set DateUpdated=GETDATE() where Name = '"+ans+"'";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("CLO Updated Suceesfully");
            printCLOs() ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string ans = textBox1.Text;
            string query = "Delete from CLO where Name='"+ans+"'";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("CLO Deleted Suceesfully");
            printCLOs() ;

        }
    }
}

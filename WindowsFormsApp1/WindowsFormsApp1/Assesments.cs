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
    public partial class Assesments : Form
    {
        public Assesments()
        {
            InitializeComponent();
            showAssessments();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Insert into Assessment(Title,DateCreated,TotalMarks,TotalWeightage) values(@Title,GETDATE(),@TotalMarks,@TotalWeightage) ";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Title", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@TotalMarks",textBox3.Text);
            sqlCommand.Parameters.AddWithValue("@TotalWeightage", textBox2.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();MessageBox.Show("Assessment Added Sucessfully");
            showAssessments();

        }
        private void showAssessments()
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Select * from Assessment";
            SqlConnection sqlConnection = new SqlConnection( conn );
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();  
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            reader.Close();
            sqlConnection.Close() ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string title = textBox1.Text;
            string totalM = textBox3.Text;
            string totalW = textBox2.Text;
            string query = "Update Assessment set Title ='"+title+ "',TotalMarks = '"+totalM+"',TotalWeightage='"+totalW+"'where Title ='"+title+"'";
            SqlConnection sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand( query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close(); MessageBox.Show("Assessment Updated Sucessfully");
            showAssessments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string conn = "Data Source=ABDULHANANPC\\SQLEXPRESS11;Initial Catalog=ProjectB;Integrated Security=True";
            string query = "Delete from Assessment where Title ='"+title+"'";
            SqlConnection sqlConnection = new SqlConnection( conn);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Assessment Deleted Sucessfully");
            showAssessments();
        }

        private void button4_Click(object sender, EventArgs e)
        {
;
        }
    }
}

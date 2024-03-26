using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new CLO();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Rubric();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myForm = new Assesments();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var myForm = new Rubric_Level();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var myForm = new Evaluation();
            myForm.WindowState = FormWindowState.Normal;
            myForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

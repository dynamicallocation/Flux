using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        string connectionString = @"Data Source=sql.cs.luc.edu;Persist Security Info=True;User ID=doszczapinski;Password=p49923";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                MessageBox.Show("please fill");
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand sqlCmd = new SqlCommand("AddNewEmployee", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@firstName", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lastName", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@uid", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@position", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ssn", textBox5.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added!");
                    Clear();

                    
                }

            }
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

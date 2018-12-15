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
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=sql.cs.luc.edu;Persist Security Info=True;User ID=doszczapinski;Password=p49923";

        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("please fill");
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("You signed up!");
                    Clear();

                    this.Hide();
                    Form1 ss = new Form1();
                    ss.Show();
                }
            }
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }
    }
}

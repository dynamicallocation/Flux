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

namespace Flux
{
    public partial class Signup : Form
    {
        string connectionString = @"Data Source=sql.cs.luc.edu;Persist Security Info=True;User ID=doszczapinski;Password=p49923";

        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Login ss = new Login();
                    ss.Show();
                }
            }
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }
    }
}

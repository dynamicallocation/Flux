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
    public partial class Employee : Form
    {
        string connectionString = @"Data Source=sql.cs.luc.edu;Persist Security Info=True;User ID=doszczapinski;Password=p49923";

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dataSet1.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill");
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand sqlCmd = new SqlCommand("employeeADD", con);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PaidMonthly", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Salary", textBox4.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added!");
                    Clear();
                    
                    this.Hide();
                    Main ss = new Main();
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
            Main ss = new Main();
            ss.Show();
        }
    }
}

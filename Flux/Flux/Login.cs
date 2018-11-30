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
    public partial class Login : Form
    {
        string connectionStrin = @"Data Source=sql.cs.luc.edu;Persist Security Info=True;User ID=doszczapinski;Password=p49923";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup ss = new Signup();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionStrin))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Signup where Username='" + textBox1.Text + "'and Password='" + textBox2.Text + "' ", con);
                DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();

                }
                else
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

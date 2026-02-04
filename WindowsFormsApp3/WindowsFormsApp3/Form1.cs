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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ploteso username dhe password!");
                return;
            }

            string connStr =
                @"Data Source=.\SQLEXPRESS;Initial Catalog=RentalRTA;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string sql = @"
            SELECT 1
            FROM Users
            WHERE RTRIM(username) = @user
              AND RTRIM(password) = @pass";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // KRITIKE: NVARCHAR, jo NCHAR
                    cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = user;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;

                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Logini ishte me sukses");

                        Timer timer = new Timer();
                        timer.Interval = 3000;
                        timer.Tick += (s, ev) =>
                        {
                            timer.Stop();
                            Form2 f2 = new Form2();
                            f2.Show();
                            this.Hide();
                        };
                        timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("Username ose password gabim");
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SignUp s2 = new SignUp();
            s2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
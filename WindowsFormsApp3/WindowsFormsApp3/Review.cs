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
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Review : Form
    {
        string connStr = @"Data Source=DESKTOP-0DQQGFJ\SQLEXPRESS;Initial Catalog=RentalRTA;Integrated Security=True";
        public Review()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Review_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalRTADataSet4.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter1.Fill(this.rentalRTADataSet4.Review);
            // TODO: This line of code loads data into the 'rentalRTADataSet3.Review' table. You can move, or remove it, as needed.
            this.reviewTableAdapter.Fill(this.rentalRTADataSet3.Review);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rating = "";
            string rating2 = "";

            // ===== RATING 1–4 =====
            if (radioButton1.Checked) rating = radioButton1.Text;
            else if (radioButton2.Checked) rating = radioButton2.Text;
            else if (radioButton3.Checked) rating = radioButton3.Text;
            else if (radioButton4.Checked) rating = radioButton4.Text;

            // ===== RATING 5–6 =====
            if (radioButton5.Checked) rating2 = radioButton5.Text;
            else if (radioButton6.Checked) rating2 = radioButton6.Text;

            // ===== VALIDIME =====
            if (rating == "")
            {
                MessageBox.Show("Zgjidh nje opsion per vleresimin e sherbimit!");
                return;
            }

            if (rating2 == "")
            {
                MessageBox.Show("Zgjidh nese do ta sugjeroje RTA!");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Shkruaj nje koment!");
                return;
            }

            // ===== INSERT =====
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Review (Rating, Rating2, Comment) VALUES (@r1,@r2,@c)", con);

                cmd.Parameters.AddWithValue("@r1", rating);
                cmd.Parameters.AddWithValue("@r2", rating2);
                cmd.Parameters.AddWithValue("@c", textBox2.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Faleminderit per vleresimin tuaj! ⭐");

            LoadGrid();
            ClearForm();
        }

        // ===== LOAD GRID =====
        void LoadGrid()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Review", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // ===== CLEAR =====
        void ClearForm()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            textBox2.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
    }


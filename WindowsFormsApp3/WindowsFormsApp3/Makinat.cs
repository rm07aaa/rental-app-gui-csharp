using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Makinat : Form
    {
        string connStr = @"Data Source=DESKTOP-0DQQGFJ\SQLEXPRESS;Initial Catalog=RentalRTA;Integrated Security=True";

        public Makinat()
        {
            InitializeComponent();
        }

        // MOS E PREK
        private void Makinat_Load(object sender, EventArgs e)
        {
            this.makinatTableAdapter.Fill(this.rentalRTADataSet2.Makinat);
        }

        // ================= SHTO =================
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTipMakine.Text == "" || txtGjendja.Text == "")
            {
                MessageBox.Show("Ploteso Tipin dhe Gjendjen!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Makinat (Makina, Gjendja) VALUES (@t,@g)", con);

                cmd.Parameters.AddWithValue("@t", txtTipMakine.Text);
                cmd.Parameters.AddWithValue("@g", txtGjendja.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Makina u shtua me sukses!");
            RefreshGrid();
            ClearInputs();
        }


        // ================= HIQ =================
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDMakina.Text == "")
            {
                MessageBox.Show("Shkruaj ID e makines per fshirje!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Makinat WHERE ID=@id", con);

                cmd.Parameters.AddWithValue("@id", txtIDMakina.Text);

                con.Open();
                int r = cmd.ExecuteNonQuery();
                con.Close();

                if (r > 0)
                    MessageBox.Show("Makina u hoq nga flota!");
                else
                    MessageBox.Show("ID nuk u gjet!");
            }

            RefreshGrid();
            ClearInputs();
        }

        // ================= HELPER =================
        void RefreshGrid()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Makinat", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void ClearInputs()
        {
            txtIDMakina.Clear();
            txtTipMakine.Clear();
            txtGjendja.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}

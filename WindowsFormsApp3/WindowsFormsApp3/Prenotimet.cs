using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Prenotimet : Form
    {
        string connStr = @"Data Source=DESKTOP-0DQQGFJ\SQLEXPRESS;Initial Catalog=RentalRTA;Integrated Security=True";

        public Prenotimet()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // bosh – designer e kerkon
        }

        // ⚠️ MOS E PREK – siç kërkove
        private void Prenotimet_Load(object sender, EventArgs e)
        {
            this.rezervimetTableAdapter.Fill(this.rentalRTADataSet11.Rezervimet);
        }

        // ================= SHTO =================
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmer.Text == "" || txtMakina.Text == "")
            {
                MessageBox.Show("Ploteso te dhenat!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Rezervimet (Emer, Makina, Datal) VALUES (@Emer,@Makina,@Datel)", con);

                cmd.Parameters.AddWithValue("@Emer", txtEmer.Text);
                cmd.Parameters.AddWithValue("@Makina", txtMakina.Text);
                cmd.Parameters.AddWithValue("@Datel", dtpData.Value);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Rezervimi u shtua me sukses!");
            RefreshGrid();
            ClearInputs();
        }

        // ================= HIQ =================
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Shkruaj ID per fshirje!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Rezervimet WHERE ID=@ID", con);

                cmd.Parameters.AddWithValue("@ID", txtID.Text);

                con.Open();
                int r = cmd.ExecuteNonQuery();
                con.Close();

                if (r > 0)
                    MessageBox.Show("Rezervimi u fshi!");
                else
                    MessageBox.Show("ID nuk u gjet!");
            }

            RefreshGrid();
            ClearInputs();
        }

        // ================= KERKO =================
           private void button3_Click(object sender, EventArgs e)
        {
            if (txtKerkoID.Text == "")
            {
                MessageBox.Show("Shkruaj ID e klientit për kërkim!");
                return;
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Rezervimet WHERE ID=@id", con);

                da.SelectCommand.Parameters.AddWithValue("@id", txtKerkoID.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nuk u gjet asnjë klient me këtë ID!", "Gabim",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mbush DataGridView
                dataGridView1.DataSource = dt;

                // Merr te dhenat
                string emer = dt.Rows[0]["Emer"].ToString();
                string makina = dt.Rows[0]["Makina"].ToString();
                string data = Convert.ToDateTime(dt.Rows[0]["Datal"])
                                .ToString("dd/MM/yyyy");

                // Popup
                MessageBox.Show(
                    "Ti sapo kërkove për klientin:\n\n" +
                    "Emër klienti: " + emer + "\n" +
                    "Makina: " + makina + "\n" +
                    "Data e lëshimit: " + data,
                    "Rezultati i kërkimit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // ================= HELPER METHODS =================
        void RefreshGrid()
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rezervimet", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        void ClearInputs()
        {
            txtID.Clear();
            txtEmer.Clear();
            txtMakina.Clear();
            txtKerkoID.Clear();
            dtpData.Value = DateTime.Now;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}

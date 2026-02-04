using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Maint : Form
    {
        public Maint()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Maint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentalRTADataSet6.Makinat' table. You can move, or remove it, as needed.
            this.makinatTableAdapter2.Fill(this.rentalRTADataSet6.Makinat);
            // TODO: This line of code loads data into the 'rentalRTADataSet5.Makinat' table. You can move, or remove it, as needed.
            this.makinatTableAdapter1.Fill(this.rentalRTADataSet5.Makinat);
            // TODO: This line of code loads data into the 'rentalRTADataSet.Makinat' table. You can move, or remove it, as needed.
            this.makinatTableAdapter.Fill(this.rentalRTADataSet.Makinat);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ShowSuccessMessage()
        {
            Form msg = new Form();
            msg.StartPosition = FormStartPosition.CenterScreen;
            msg.FormBorderStyle = FormBorderStyle.FixedDialog;
            msg.ControlBox = false;
            msg.Width = 300;
            msg.Height = 120;
            msg.Text = "Sukses";

            Label lbl = new Label();
            lbl.Text = "Gjendja u perditesua!";
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            msg.Controls.Add(lbl);

            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                msg.Close();
            };

            timer.Start();
            msg.ShowDialog();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Kontroll bosh
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ploteso ID dhe Gjendjen!", "Gabim",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kontroll ID
            if (!int.TryParse(textBox1.Text, out int id))
            {
                MessageBox.Show("ID duhet te jete numer!", "Gabim",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kontroll gjatesi (MAX 10)
            if (textBox2.Text.Length > 10)
            {
                MessageBox.Show("Gjendja nuk mund te jete mbi 10 karaktere!",
                    "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connection string
            string connStr = @"Data Source=DESKTOP-0DQQGFJ\SQLEXPRESS;Initial Catalog=RentalRTA;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string sql = "UPDATE Makinat SET Gjendja = @gjendja WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@gjendja", SqlDbType.NVarChar, 10).Value = textBox2.Text;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    con.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result == 0)
                    {
                        MessageBox.Show("Nuk ekziston makine me kete ID!",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            ShowSuccessMessage();
            // Rifresko DataGridView
            this.makinatTableAdapter.Fill(this.rentalRTADataSet.Makinat);

            // Pastro textbox
            textBox1.Clear();
            textBox2.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

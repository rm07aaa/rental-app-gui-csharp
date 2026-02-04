using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Makinat m2 = new Makinat();
            m2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prenotimet p2 = new Prenotimet();
            p2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Maint m1 = new Maint();
            m1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Review r2 = new Review();
            r2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace otopark_programı
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\otomasyon_otopark.accdb");

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide(); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            this.Hide();

        }

        private void Form7_Load_1(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select * from parkyeri,müsteri where parkyeri.parkalani=müsteri.p and müsteri.durum=0", baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["p"].ToString() == "Alan9")
                {
                    panel1.BackColor = Color.Red;
                    labelPanel1.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan10")
                {
                    panel2.BackColor = Color.Red;
                    lblPanel2.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan11")
                {
                    panel3.BackColor = Color.Red;
                    lblPanel3.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan12")
                {
                    panel4.BackColor = Color.Red;
                    lblPanel4.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan13")
                {
                    panel5.BackColor = Color.Red;
                    lblPanel5.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan14")
                {
                    panel6.BackColor = Color.Red;
                    lblPanel6.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan15")
                {
                    panel7.BackColor = Color.Red;
                    lblPanel7.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan16")
                {
                    panel8.BackColor = Color.Red;
                    lblPanel8.Text = okuyucu["plaka"].ToString();

                }
            }
            baglan.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

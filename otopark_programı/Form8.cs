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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\otomasyon_otopark.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select * from parkyeri,müsteri where parkyeri.parkalani=müsteri.p and müsteri.durum=0", baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["p"].ToString() == "Alan17")
                {
                    panel1.BackColor = Color.Red;
                    labelPanel1.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan18")
                {
                    panel2.BackColor = Color.Red;
                    lblPanel2.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan19")
                {
                    panel3.BackColor = Color.Red;
                    lblPanel3.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan20")
                {
                    panel4.BackColor = Color.Red;
                    lblPanel4.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan21")
                {
                    panel5.BackColor = Color.Red;
                    lblPanel5.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan22")
                {
                    panel6.BackColor = Color.Red;
                    lblPanel6.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan23")
                {
                    panel7.BackColor = Color.Red;
                    lblPanel7.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan24")
                {
                    panel8.BackColor = Color.Red;
                    lblPanel8.Text = okuyucu["plaka"].ToString();

                }
            }
            baglan.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            this.Hide();
        }
    }
}

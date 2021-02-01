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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\otomasyon_otopark.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblHesapla.Hide();
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from müsteri where durum=0",baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["plaka"].ToString());

            }
            baglan.Close();
        }
        DateTime tarih;
        string parkyeri = "";

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblHesapla.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblHesapla.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double aracyikama = 0; ;
            baglan.Open();
            OleDbCommand komut2 = new OleDbCommand("select * from müsteri where durum=0 and plaka LIKE '"+comboBox1.Text+"'",baglan);
            OleDbDataReader okuyucu2 = komut2.ExecuteReader();
            while(okuyucu2.Read())
            {
                lblMarka.Text = okuyucu2["marka"].ToString();
                lblModel.Text = okuyucu2["model"].ToString();
                lblAdi.Text = okuyucu2["adi"].ToString();
                lblSoyadi.Text = okuyucu2["soyadi"].ToString();
                tarih = Convert.ToDateTime(okuyucu2["gsaat"].ToString());
                parkyeri = okuyucu2["p"].ToString();
                lblYikama.Text = okuyucu2["aracyikama"].ToString();

            }
            if(lblYikama.Text=="Var")
            {
                aracyikama = 10;

            }
            else if(lblYikama.Text=="Yok")
            {
                aracyikama = 0;
            }
            baglan.Close();
            System.TimeSpan zaman;
            DateTime sondeger = DateTime.Now;
            zaman = sondeger.Subtract(tarih);
            double saat = Convert.ToDouble(zaman.TotalHours);
            double para =  double.Parse(saat.ToString("0.##"));
            label9.Text = (aracyikama + para).ToString() + " TL";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Plaka Seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult c;
                c = MessageBox.Show("Araç Çıkışı Yapmak İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    baglan.Open();
                    OleDbCommand komut4 = new OleDbCommand("update parkyeri set durum=0 where parkalani='" + parkyeri + "'", baglan);
                    komut4.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    OleDbCommand komut5 = new OleDbCommand("update müsteri set durum=1 where plaka='" + comboBox1.Text + "'", baglan);
                    komut5.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    OleDbCommand komut6 = new OleDbCommand("update gecmis set csaat='" + DateTime.Now + "',fiyat='" + label9.Text + "' where plaka='" + comboBox1.Text + "'", baglan);
                    MessageBox.Show("Araç Çıkışı Yapılmıştır.", "Çıkış İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    komut6.ExecuteNonQuery();
                    baglan.Close();
                    parkyeri = "";
                    lblAdi.Text = "";
                    lblSoyadi.Text = "";
                    lblMarka.Text = "";
                    lblModel.Text = "";
                    lblYikama.Text = "";
                    comboBox1.Text = "";
                    label9.Text = "";
                    comboBox1.Items.Clear();
                    Form5_Load(sender, e);

                }
            
            }
                  
        }
            

        }
    }


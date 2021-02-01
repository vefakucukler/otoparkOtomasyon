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
    public partial class Form3 : Form
    {

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\otomasyon_otopark.accdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from parkyeri where durum=0",baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                comboBox1.Items.Add(okuyucu["parkalani"].ToString());
            }
            baglanti.Close();
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if(txtAdi.Text!=""&&txtSoyadi.Text!=""&&txtMarka.Text!=""&& txtModel.Text!=""&&txtPlaka.Text!=""&&cmbAracyikama.Text!=""&&comboBox1.Text!="")
            {
                
                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("insert into müsteri (p,marka,model,plaka,adi,soyadi,gsaat,durum,aracyikama) values ('" + comboBox1.Text + "','" + txtMarka.Text + "','" + txtModel.Text + "','" + txtPlaka.Text + "','" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + DateTime.Now + "','0','" + cmbAracyikama.Text + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                baglanti.Open();
                OleDbCommand komut3 = new OleDbCommand("update parkyeri set durum='1' where parkalani like'" + comboBox1.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close(); ;
                baglanti.Open();
                OleDbCommand komut4 = new OleDbCommand("insert into gecmis (plaka,adi,soyadi,marka,model,p,aracyikama,gsaat) values ('" + txtPlaka.Text + "','" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtMarka.Text + "','" + txtModel.Text + "','" + comboBox1.Text + "','" + cmbAracyikama.Text + "','" +DateTime.Now + "') ", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Tamamlandı.", "KAYIT TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "";
                txtAdi.Clear();
                txtMarka.Clear();
                txtSoyadi.Clear();
                txtModel.Clear();
                txtPlaka.Clear();
                cmbAracyikama.Text = "";

            }
            else
            {
                MessageBox.Show("Lütfen Bütün Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEkle.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblEkle.Hide();
        }
    }
}

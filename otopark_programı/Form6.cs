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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\otomasyon_otopark.accdb");
        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    
        private void Form6_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from gecmis", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from gecmis", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                tablo.Clear();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select * From gecmis where plaka like '%" + textBox1.Text + "%'", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
        }
    }
}
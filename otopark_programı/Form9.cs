﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\otomasyon_otopark.accdb");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("Select * from parkyeri,müsteri where parkyeri.parkalani=müsteri.p and müsteri.durum=0", baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["p"].ToString() == "Alan25")
                {
                    panel1.BackColor = Color.Red;
                    labelPanel1.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan26")
                {
                    panel2.BackColor = Color.Red;
                    lblPanel2.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan27")
                {
                    panel3.BackColor = Color.Red;
                    lblPanel3.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan28")
                {
                    panel4.BackColor = Color.Red;
                    lblPanel4.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan29")
                {
                    panel5.BackColor = Color.Red;
                    lblPanel5.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan30")
                {
                    panel6.BackColor = Color.Red;
                    lblPanel6.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan31")
                {
                    panel7.BackColor = Color.Red;
                    lblPanel7.Text = okuyucu["plaka"].ToString();

                }
                if (okuyucu["p"].ToString() == "Alan32")
                {
                    panel8.BackColor = Color.Red;
                    lblPanel8.Text = okuyucu["plaka"].ToString();

                }
            }
            baglan.Close();
        }
    }
}

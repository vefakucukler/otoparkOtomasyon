using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark_programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Form3 frm = new Form3();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Form4 frm = new Form4();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pctrbox1.Hide();
            pctrbox2.Hide();
            pctrbox3.Hide();
            lblBizeUlasin.Hide();
            lblGiris.Hide();
            lblCikis.Hide();
            lblListe.Hide();
            lblParkyeri.Hide();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblGiris.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblGiris.Hide();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            lblGiris.Show(); 
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            lblParkyeri.Show();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            lblParkyeri.Hide();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            lblCikis.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            lblCikis.Hide();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            lblListe.Show();
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            lblListe.Hide(); 
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com/vefakucukler");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com/vefakucukler");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/vefakucukler");
        }
        int tiklama = 0;
        private void pictureBox5_Click(object sender, EventArgs e)
        {

            tiklama++;

            for (int i = 0; i < 10000; i++)
            {
                if (tiklama % 2 == 1)
                {
                    pctrbox1.Show();
                    pctrbox2.Show();
                    pctrbox3.Show();
                    lblBizeUlasin.Show();
                }
                else if (tiklama % 2 == 0)
                {
                    pctrbox1.Hide();
                    pctrbox2.Hide();
                    pctrbox3.Hide();
                    lblBizeUlasin.Hide();
                }
            }
        }
    }
}

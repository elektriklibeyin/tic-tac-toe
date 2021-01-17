using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        int k1=3, k2=4, k3=5, k4=6, k5=7, k6=8, k7=9, k8=10, k9=11;
       
        public Form1()
        {
            InitializeComponent();
           
            
    
        }

        private void x1_Click(object sender, EventArgs e)
        {

        }

        private void o1_Click(object sender, EventArgs e)
        {

        }

        private void o2_Click(object sender, EventArgs e)
        {

        }

        private void o3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void m1_Click(object sender, EventArgs e)
        {
            m1.Visible = false;
            if (sayac % 2 == 0)
            {
                o1.Visible = false;
                k1 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k1 = 1; label1.Text = "Sıra 1. oyuncuda"; }
           sayac++;       
        
            if((k1 == k2) && (k1 == k3) || 
               (k4 == k5) && (k4 == k6) || 
               (k7 == k8) && (k7 == k9) || 
               (k1 == k4) && (k1 == k7) || 
               (k2 == k5) && (k2 == k8) ||
               (k3 == k6) && (k3 == k9) ||
               (k1 == k5) && (k1 == k9) ||
               (k3 == k5) && (k3 == k7))
            {
                if (k1 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k1 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void m2_Click(object sender, EventArgs e)
        {
            m2.Visible = false;
            if (sayac % 2 == 0)
            {
                o2.Visible = false;
                k2 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k2 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k2 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k2 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void m3_Click(object sender, EventArgs e)
        {
            m3.Visible = false;
            if (sayac % 2 == 0)
            {
                o3.Visible = false;
                k3 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k3 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k3 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k3 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void m4_Click(object sender, EventArgs e)
        {
            m4.Visible = false;
            if (sayac % 2 == 0)
            {
                
                o4.Visible = false;
                k4 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k4 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k4 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k4 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void m5_Click(object sender, EventArgs e)
        {
            m5.Visible = false;
            if (sayac % 2 == 0)
            {
                o5.Visible = false;
                k5 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k5 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k5 == 1)
                {label1.Text = "Tebrikler 2.Oyuncu kazandı";  MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k5 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }
        

        private void m6_Click(object sender, EventArgs e)
        {
            m6.Visible = false;
            if (sayac % 2 == 0)
            {
                o6.Visible = false;
                k6 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k6 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k6 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k6 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void m8_Click(object sender, EventArgs e)
        {
            m8.Visible = false;
            if (sayac % 2 == 0)
            {
                o8.Visible = false;
                k8 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k8 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k8 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k8 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (sayac % 2 == 0)
            {
                o7.Visible = false;
                k7 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k7 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k7 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k7 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void m9_Click(object sender, EventArgs e)
        {
            m9.Visible = false;
            if (sayac % 2 == 0)
            {
                o9.Visible = false;
                k9 = 2;
                label1.Text = "Sıra 2. oyuncuda ";
            }
            else { k9 = 1; label1.Text = "Sıra 1. oyuncuda"; }
            sayac++;

            if ((k1 == k2) && (k1 == k3) ||
              (k4 == k5) && (k4 == k6) ||
              (k7 == k8) && (k7 == k9) ||
              (k1 == k4) && (k1 == k7) ||
              (k2 == k5) && (k2 == k8) ||
              (k3 == k6) && (k3 == k9) ||
              (k1 == k5) && (k1 == k9) ||
              (k3 == k5) && (k3 == k7))
            {
                if (k9 == 1)
                { label1.Text = "Tebrikler 2.Oyuncu kazandı"; MessageBox.Show("Tebrikler 0 kazandı. ", "xox"); }

                if (k9 == 2)
                { label1.Text = "Tebrikler 1.Oyuncu kazandı"; MessageBox.Show("Tebrikler x kazandı. ", "xox"); }
            }
            else if (sayac == 9)
            {
                label1.Text = "Oyun berabere bitti.";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }

        }
    }
}

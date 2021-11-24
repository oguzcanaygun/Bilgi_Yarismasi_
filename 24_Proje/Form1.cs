using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0,dogru=0,yanlis=0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            label4.Text = BtnB.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            label4.Text = BtnC.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            label4.Text = BtnD.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            
            label4.Text = BtnA.Text;
            if (label4.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
            BtnSonraki.Enabled = true;
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            if (soruno == 1)
            {
                richTextBox1.Text = "Gece gündüz eşitliği (ekinoks) bir yılda kaç kez gerçekleşir?";
                BtnA.Text = "2";
                BtnB.Text = "1";
                BtnC.Text = "0";
                BtnD.Text = "3";
                label2.Text = "2";
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye’nin uluslararası otomatik telefon kod numarası kaçtır?";
                BtnA.Text = "60";
                BtnB.Text = "90";
                BtnC.Text = "20";
                BtnD.Text = "80";
                label2.Text = "90";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Yüzüklerin Efendisi,Hobbit ve Silmarillion gibi fantastik eserleriyle tanınan Orta Dünya Fantastik Evreninin yazarı ve Fantastik Edebiyatın Babası olarak bilinen yazar kimdir?";
                BtnA.Text = "George RR Martin";
                BtnB.Text = "JRR Tolkien";
                BtnC.Text = "Christopher Tolkien";
                BtnD.Text = "Patrick Rothfuss";
                label2.Text = "JRR Tolkien";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Dünyanın en büyük adasının adı nedir ?";
                BtnA.Text = "Türkiye";
                BtnB.Text = "Amerika";
                BtnC.Text = "Grönland";
                BtnD.Text = "Avustralya";
                label2.Text = "Grönland";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Amerika kıtasını 2’ye ayıran önemli su geçidinin adı nedir?";
                BtnA.Text = "Cebeli Tarık Boğazı";
                BtnB.Text = "Kiel Kanalı";
                BtnC.Text = "Panama Kanalı";
                BtnD.Text = "Babül Mendep Boğazı";
                label2.Text = "Panama Kanalı";
                BtnSonraki.Text = "Bitir";
            }
            if (soruno == 6)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                MessageBox.Show("Dogru: "+dogru+" Yanlis: "+yanlis);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EsiniBulv2.Properties;

namespace EsiniBulv2
{
    
    public partial class Form1 : Form
    {

        // 1) Değişkenleri tanımla

        private int gen, yuk, cift, adet, pay = 10, counter, hamlesayisi;
        private Random rnd = new Random();
        private string[] tumResimler;
        private string[] secilmisResimler;
        private List<PictureBox> acikKartlar = new List<PictureBox>();
        private Button btnAgain;
        private Stopwatch sw = new Stopwatch();
        
        


        public Form1(int zorluk)
        {
            InitializeComponent();
            OyunBaslat(zorluk);
            
        }

        private void btnYenidenOyna_Click(object sender, EventArgs e)
        {
            pnlKartlar.Controls.Clear();
            Form1.ActiveForm.Hide();
            GirisEkrani ge = new GirisEkrani();
            ge.Show();
            btnYenidenOyna.Visible = false;
        }

        public void OyunBaslat(int zorluk)
        {
            
            sw.Start();
            timer1.Start();
            int satir = zorluk, sutun = zorluk;
            //Panelde eski oyun izlerini sil. Paneli Sıfırla.
            
            pnlKartlar.Controls.Add(btnYenidenOyna);
            pnlKartlar.Controls.Add(tbxSonuc);
            statusStrip1.Visible = true;
            

            //Degiskenler hesapla;
            adet = satir * sutun;
            cift = adet / 2;
            gen = (pnlKartlar.Width - (sutun - 1) * pay) / sutun;
            yuk = (pnlKartlar.Height - (satir - 1) * pay) / satir;
            counter = 0;
            hamlesayisi = 0;
            // Tüm resimlerin listesini oluştur;

            tumResimler = new string[49];
            tumKartlariOlustur(tumResimler);
            Karistir(tumResimler);


            #region Secilmis resimleri karıştır
            secilmisResimler = new string[adet];
            Array.Copy(tumResimler, secilmisResimler, cift);
            Array.Copy(tumResimler, 0, secilmisResimler, cift, cift);
            Karistir(secilmisResimler);

            #endregion


            // New pb yapıp yeni kartları oluşturcaz.
            PictureBox pb;
            
            for (int i = 0; i < adet; i++)
            {
                pb = new PictureBox();
                pb.Top = i / sutun * (yuk + pay);
                pb.Left = i % sutun * (yuk + pay);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Height = yuk;
                pb.Width = gen;
                pb.Tag = secilmisResimler[i].ToString();
                pnlKartlar.Controls.Add(pb);
                pb.Image = Resources.cardBack;
                pb.Click+=KartAcKapa;
            }


        }

     

        void KartAcKapa(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox) sender;
            hamlesayisi++;
            KartAc(pb);
            Refresh();

            if (acikKartlar.Count == 2)
            {
                
                KartSil();
                KartKapat();

            }

            if (counter == cift)
            {
                timer1.Stop();
                sw.Stop();
                tssStatus.Text = $"Hamle sayısı : {hamlesayisi} Geçen süre : {sw.Elapsed.Minutes}:{sw.Elapsed.Seconds}";
                MessageBox.Show("Oyun bitti!");
                
                btnYenidenOyna.Visible = true;
                tbxSonuc.Visible = true;
                tbxSonuc.Text = $" Geçen süre : {sw.Elapsed.Minutes}:{sw.Elapsed.Seconds}\n Hamle sayısı :{hamlesayisi}";
               
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tssStatus.Text = $"Hamle sayısı : {hamlesayisi} Geçen süre : {sw.Elapsed.Minutes}:{sw.Elapsed.Seconds}";
        }

        private void KartSil()
        {
            
            if (acikKartlar[0].Tag.ToString() == acikKartlar[1].Tag.ToString())
            {
                acikKartlar[0].BackColor=Color.GreenYellow;
                acikKartlar[1].BackColor=Color.GreenYellow;
                Refresh();
                Thread.Sleep(400);
                while (acikKartlar.Count != 0)
                {
                    acikKartlar[0].Hide();
                    acikKartlar.Remove(acikKartlar[0]);
                    
                }
                counter++;

            }
        }

        private void KartKapat()
        {
            while (acikKartlar.Count != 0)
            {
                Thread.Sleep(200);
                acikKartlar[0].Image=Resources.cardBack;
                
                acikKartlar.Remove(acikKartlar[0]);
                

            }
            

        }

        private void KartAc(PictureBox kart)
        {
            if (acikKartlar.Count == 1 && (acikKartlar[0]) == kart)
            {
                return;

            }
            kart.BackColor = Color.Transparent;
            kart.Image = (Image)Resources.ResourceManager.GetObject(kart.Tag.ToString());
            acikKartlar.Add(kart);
        }

        void tumKartlariOlustur(string[] resimlist)
        {
            for (int i = 0; i < 49; i++)
            {
                resimlist[i]=($"_{i}");
            }
        }


        void Karistir(string[] liste)
        {
            int talihliSayi;
            string gecici;

            for (int i = 0; i < liste.Length; i++)
            {
                talihliSayi = rnd.Next(i, liste.Length);
                gecici = liste[talihliSayi];
                liste[talihliSayi] = liste[i];
                liste[i] = gecici;
            }


        }



    }



}









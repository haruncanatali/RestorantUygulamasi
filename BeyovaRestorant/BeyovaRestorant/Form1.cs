using BeyovaRestorant.Tables;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeyovaRestorant
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<Masa> masalar = new List<Masa>();
        private List<Urun> urunler = new List<Urun>();
        private List<UrunHareket> urunHareketleri = new List<UrunHareket>();
        private string seciliMasa;
        public Form1()
        {
            InitializeComponent();

            urunEkle();
            masaEkle();
            masaButonOlustur();
            urunButonOlustur();
            gridControl1.DataSource = urunHareketleri;
        }

        private void urunEkle()
        {
            string[] yemekler = new string[17] { "İskender", "Adana Kebap", "Urfa Kebap", "Mantı", "Et Döner", "Tavuk Döner",
                "Lahmacun", "Trabzon Yağlı", "Makarna", "Tavuk Şiş","Su", "Kola", "Fanta", "Maden Suyu", "Meyve Suyu", "IceTea", "Çay"};
            double[] fiyatlar = new double[17] { 22.5, 22, 22, 10, 12, 8, 4, 21.5, 5, 12.5, 0.75, 3.5, 3, 1.5, 3.25, 4, 0.5 };
            string[] birimler = new string[17] {"Porsiyon", "Porsiyon", "Porsiyon", "Porsiyon", "Porsiyon", "Porsiyon",
            "Adet","Porsiyon","Porsiyon","Porsiyon","Adet","Adet","Adet","Adet","Adet","Adet","Adet"};

            for(int i = 0; i < 17; i++)
            {
                Urun urun = new Urun
                {
                    id = i,
                    urunKodu = i.ToString(),
                    urunAd = yemekler[i],
                    fiyat = fiyatlar[i],
                    urunBirim = birimler[i]
                };

                urunler.Add(urun);
            }
           
        }
        private void masaEkle()
        {
            for(int i = 0; i < 12; i++)
            {
                Masa masa = new Masa
                {
                    id = i,
                    masaKodu = i.ToString(),
                    masaAdi = "Masa-" + i.ToString()
                };
                masalar.Add(masa);
            }
        }
        private void masaButonOlustur()
        {
            foreach (var masa in masalar)
            {
                SimpleButton masaBtn = new SimpleButton
                {
                    Name = masa.masaKodu,
                    Text = masa.masaAdi,
                    Height = 80,
                    Width = 80,
                    ButtonStyle = BorderStyles.Flat,
                    Appearance = { BackColor = Color.Green , ForeColor = Color.White }
                };

                flowMasalar.Controls.Add(masaBtn);
                masaBtn.Click += masaClick;
            }
        }
        private void urunButonOlustur()
        {
            foreach (var urun in urunler)
            {
                SimpleButton urunBtn = new SimpleButton
                {
                    Height = 60,
                    Width = 90,
                    Name = urun.urunKodu,
                    Text = urun.urunAd
                };
                flowUrunler.Controls.Add(urunBtn);
                urunBtn.Click += urunClick;
            }
        }

        private void urunClick(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            Urun urun = urunler.SingleOrDefault(c => c.urunKodu == btn.Name);

            masalar.SingleOrDefault(c => c.masaKodu == seciliMasa).hareketler.Add(new UrunHareket
            {
                urunKodu = urun.urunKodu,
                urunAd = urun.urunAd,
                urunBirim = urun.urunBirim,
                fiyat = urun.fiyat,
                miktar = 1
            });
            gridControl1.RefreshDataSource();

            SimpleButton bton = (SimpleButton)flowMasalar.Controls.Find(seciliMasa, true).SingleOrDefault();
            bton.Appearance.BackColor = Color.Red;

            toplamTxt.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);

        }

        private void masaClick(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            Masa masa = masalar.SingleOrDefault(c => c.masaKodu == btn.Name);

            if(masa.hareketler == null)
            {
                masa.hareketler = new List<UrunHareket>();
            }
 

            seciliMasa = masa.masaKodu;
            gridControl1.DataSource = masa.hareketler;
            toplamTxt.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);


        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SimpleButton bton = (SimpleButton)flowMasalar.Controls.Find(seciliMasa, true).SingleOrDefault();
            bton.Appearance.BackColor = Color.Green;
            var masa = masalar.SingleOrDefault(c => c.masaKodu == bton.Name);
            masa.hareketler = new List<UrunHareket>();
            gridControl1.DataSource = masa.hareketler;
            toplamTxt.Value = 0;
        }
    }
}

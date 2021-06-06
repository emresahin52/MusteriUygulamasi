using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSTERIAPPS
{
    public partial class MusteriGirisForm : Form
    {
        public MusteriAnaForm afrm;
        public YeniKullaniciForm kullanicilar;
        public MusteriGirisForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        DataTable kullaniciTablo;
        bool yokmu = false;
        Random rSayi = new Random();
        int islemSonucu = 0;
        string isaret = "+-";

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void veriDoldur()
        {
            kullaniciTablo = new DataTable();
            string musStr = "Select KullaniciAdi, KullaniciSifresi, KullaniciYetkisi  From Kullanici";
            kullaniciTablo = VtIslem.VeriGetir(musStr);
            if (kullaniciTablo.Rows.Count <= 0)
                yokmu = true;
            else
                yokmu = false;
        }

        private void guvenlikKoduUret()
        {
            int sayi1 = rSayi.Next(30, 71);
            int sayi2 = rSayi.Next(1, 31);
            int islemTipi = rSayi.Next(0, 2);
            lblSayi1.Text = sayi1.ToString();
            lblIslemTuru.Text = isaret[islemTipi].ToString();
            lblSayi2.Text = sayi2.ToString();
            if (lblIslemTuru.Text == "+")
                islemSonucu = sayi1 + sayi2;
            else
                islemSonucu = sayi1 - sayi2;

        }

        private void formIslem()
        {
            guvenlikKoduUret();
            tbAd.Select();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriGirisForm_Load(object sender, EventArgs e)
        {
            tbAd.Select();
            veriDoldur();
            if (yokmu)
            {
                MessageBox.Show("Sitemde Oturum Açmak için\nKullanıcı Tanımlamalısınız", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                kullanicilar = new YeniKullaniciForm();
                kullanicilar.grsForm = this;
                kullanicilar.ShowDialog();
                veriDoldur();
                if (yokmu)
                {
                    MusteriGirisForm_Load(sender, e);
                }
                else
                {
                    formIslem();
                }
            }
            else
            {
                formIslem();
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string ad, sifre, yetki;
            for (int k = 0; k < kullaniciTablo.Rows.Count; k++)
            {
                ad = kullaniciTablo.Rows[k].ItemArray[0].ToString();
                sifre = kullaniciTablo.Rows[k].ItemArray[1].ToString();
                yetki = kullaniciTablo.Rows[k].ItemArray[2].ToString();
                if (tbAd.Text == ad & tbSifre.Text == sifre & islemSonucu == Convert.ToInt32(tbSonuc.Text))
                {
                    Global_Degisken.Durum = true;
                    Global_Degisken.YetkiDurumu = yetki;
                    break;
                }
            }
            if (Global_Degisken.Durum)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Girilen Verileri Kontrol Ediniz", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAd.Clear();
                tbSifre.Clear();
                tbSonuc.Clear();
                formIslem();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama\nSonlandırılsın mı?", "Bilgi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Global_Degisken.Durum = true;
                Global_Degisken.Kapatma = true;
                this.Close();
            }
        }

        #endregion

    }
}

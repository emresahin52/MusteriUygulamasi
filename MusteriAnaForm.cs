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
    public partial class MusteriAnaForm : Form
    {
        public MusteriEkleForm YeniMusteri;
        public MusteriGirisForm Giris;
        public MusteriGuncelleForm MusteriGuncelle;
        public MusteriHareketForm SatisHareket;
        public MusteriSatisForm UrunSatis;
        public RaporForm Raporlar;
        public UrunTanimlaForm YeniUrun;
        public YeniKullaniciForm YeniKullanici;

        public MusteriAnaForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        MusteriDataDataContext MusteriData = new MusteriDataDataContext();
        public string MusteriNo;

        #endregion

        #region Kullanıcı Tanımlı Olaylar
        
        public void VeriDoldur()
        {
            var MusteriCek = from kimlik in MusteriData.Kimliks
                             select new
                             {
                                 kimlik.MusteriNo,
                                 kimlik.FirmaBilgisi,
                                 kimlik.YetkiliAdi,
                                 kimlik.YetkiliSoyadi,
                                 kimlik.FirmaAdresi,
                                 kimlik.TelefonNo
                             };
            dgvMusteriListe.DataSource = MusteriCek;
        }

        private void BaslikGoster()
        {
            dgvMusteriListe.Columns[0].HeaderText = "Müşteri No";
            dgvMusteriListe.Columns[0].Width = 100;
            dgvMusteriListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvMusteriListe.Columns[1].HeaderText = "Firma Bilgisi";
            dgvMusteriListe.Columns[1].Width = 320;
            dgvMusteriListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[2].HeaderText = "Yetkili Adı";
            dgvMusteriListe.Columns[2].Width = 120;
            dgvMusteriListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[3].HeaderText = "Yetkili Soyadı";
            dgvMusteriListe.Columns[3].Width = 120;
            dgvMusteriListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[4].HeaderText = "Firma Adresi";
            dgvMusteriListe.Columns[4].Width = 320;
            dgvMusteriListe.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvMusteriListe.Columns[5].HeaderText = "Telefon No";
            dgvMusteriListe.Columns[5].Width = 100;
            dgvMusteriListe.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void Baslat()
        {
            VeriDoldur();
            BaslikGoster();
        }

        private void SatisSil (string MusteriNumara)
        {
            string sorgu = "SELECT MusteriNo, FirmaBilgisi, UrunKodu, UrunTanimi, SatisMiktari, " +
                 "SatisTutari, OdemeTuru FROM Satislar WHERE MusteriNo='" + MusteriNumara + "'";
            DataTable SatislarTablo = VtIslem.VeriGetir(sorgu);
            for (int k=0; k< SatislarTablo.Rows.Count;k++)
            {
                SatislarSil SatilanUrunleriSil = new SatislarSil();
                SatilanUrunleriSil.MusteriNo = SatislarTablo.Rows[k].ItemArray[0].ToString();
                SatilanUrunleriSil.FirmaBilgisi = SatislarTablo.Rows[k].ItemArray[1].ToString();
                SatilanUrunleriSil.UrunKodu = SatislarTablo.Rows[k].ItemArray[2].ToString();
                SatilanUrunleriSil.UrunTanimi = SatislarTablo.Rows[k].ItemArray[3].ToString();
                SatilanUrunleriSil.SatisMiktari = Convert.ToInt16(SatislarTablo.Rows[k].ItemArray[4].ToString());
                SatilanUrunleriSil.SatisTutari = Convert.ToDecimal(SatislarTablo.Rows[k].ItemArray[5].ToString());
                SatilanUrunleriSil.OdemeTuru = SatislarTablo.Rows[k].ItemArray[6].ToString();
                MusteriData.SatislarSils.InsertOnSubmit(SatilanUrunleriSil);
                MusteriData.SubmitChanges();
            }
        }

        private void GirisBaslat()
        {
            Giris = new MusteriGirisForm();
            Giris.afrm = this;
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriAnaForm_Load(object sender, EventArgs e)
        {
            GirisBaslat();
            Giris.ShowDialog();
            if (Global_Degisken.Durum == false & Global_Degisken.Kapatma == false)
                MusteriAnaForm_Load(sender, e);
            else
            {
                if (Global_Degisken.Kapatma == false)
                {
                    if (Global_Degisken.YetkiDurumu == "Yönetici")
                        YonetimMenu.Visible = true;
                    else
                        YonetimMenu.Visible = false;
                    Baslat();
                }
                else
                    Application.Exit();
            }
            //Baslat();
        }

        private void btnEkleMusteri_Click(object sender, EventArgs e)
        {
            YeniMusteri = new MusteriEkleForm();
            YeniMusteri.afrm = this;
            YeniMusteri.ShowDialog();
            VeriDoldur();
        }

        private void btnEkleUrun_Click(object sender, EventArgs e)
        {
            YeniUrun = new UrunTanimlaForm();
            YeniUrun.afrm = this;
            YeniUrun.ShowDialog();
        }

        private void yeniKullaniciMenuItem_Click(object sender, EventArgs e)
        {
            YeniKullanici = new YeniKullaniciForm();
            YeniKullanici.afrm = this;
            YeniKullanici.ShowDialog();
        }

        private void tbFirmaBilgisi_TextChanged(object sender, EventArgs e)
        {
            if (tbFirmaBilgisi.Text.Trim() == "")
            {
                VeriDoldur();
            }
            else
            {
                var MusteriCek = from Musteriler in MusteriData.Kimliks
                                 where Musteriler.FirmaBilgisi.Contains(tbFirmaBilgisi.Text)
                                 select new
                                 {
                                     Musteriler.MusteriNo,
                                     Musteriler.FirmaBilgisi,
                                     Musteriler.YetkiliAdi,
                                     Musteriler.YetkiliSoyadi,
                                     Musteriler.FirmaAdresi,
                                     Musteriler.TelefonNo
                                 };
                dgvMusteriListe.DataSource = MusteriCek;
            }
        }

        private void tbYetkiliAd_TextChanged(object sender, EventArgs e)
        {
            if (tbYetkiliAd.Text.Trim() == "")
            {
                VeriDoldur();
            }
            else
            {
                var MusteriCek = from Musteriler in MusteriData.Kimliks
                                 where Musteriler.YetkiliAdi.Contains(tbYetkiliAd.Text)
                                 select new
                                 {
                                     Musteriler.MusteriNo,
                                     Musteriler.FirmaBilgisi,
                                     Musteriler.YetkiliAdi,
                                     Musteriler.YetkiliSoyadi,
                                     Musteriler.FirmaAdresi,
                                     Musteriler.TelefonNo
                                 };
                dgvMusteriListe.DataSource = MusteriCek;
            }
        }

        private void MusteriGuncelleMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelle = new MusteriGuncelleForm();
            MusteriGuncelle.afrm = this;
            MusteriGuncelle.tbMusteriNo.Enabled = false;

            MusteriNo = MusteriGuncelle.MusteriNo =
                 MusteriGuncelle.tbMusteriNo.Text =
                 dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            MusteriGuncelle.tbFirmaBilgisi.Text =
                dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            MusteriGuncelle.tbYetkiliAd.Text =
                dgvMusteriListe.CurrentRow.Cells[2].Value.ToString();
            MusteriGuncelle.tbYetkiliSoyad.Text =
                dgvMusteriListe.CurrentRow.Cells[3].Value.ToString();
            MusteriGuncelle.tbFirmaAdresi.Text =
                dgvMusteriListe.CurrentRow.Cells[4].Value.ToString();
            MusteriGuncelle.tbTelefonNo.Text =
                dgvMusteriListe.CurrentRow.Cells[5].Value.ToString();

            MusteriGuncelle.ShowDialog();
            MusteriGuncelle.tbMusteriNo.Enabled = true;
            VeriDoldur();
        }

        private void MusteriSilMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Müşteriyi \nSilmek istiyor musunuz?", "Bilgi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MusteriNo = dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();

                KimlikSil MusteriyiSil = new KimlikSil();
                MusteriyiSil.MusteriNo = dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
                MusteriyiSil.FirmaBilgisi = dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
                MusteriyiSil.YetkiliAdi = dgvMusteriListe.CurrentRow.Cells[2].Value.ToString();
                MusteriyiSil.YetkiliSoyadi = dgvMusteriListe.CurrentRow.Cells[3].Value.ToString();
                MusteriyiSil.FirmaAdresi = dgvMusteriListe.CurrentRow.Cells[4].Value.ToString();
                MusteriyiSil.TelefonNo = dgvMusteriListe.CurrentRow.Cells[5].Value.ToString();

                MusteriData.KimlikSils.InsertOnSubmit(MusteriyiSil);
                MusteriData.SubmitChanges();

                SatisSil(MusteriNo);

                Kimlik MusteriKimlikSil = MusteriData.Kimliks.First(silme => silme.MusteriNo == MusteriNo);
                MusteriData.Kimliks.DeleteOnSubmit(MusteriKimlikSil);
                //MusteriData.SubmitChanges();

                Satislar MusteriSatisSil = MusteriData.Satislars.First(silme => silme.MusteriNo == MusteriNo);
                MusteriData.Satislars.DeleteOnSubmit(MusteriSatisSil);
                MusteriData.SubmitChanges();
            }
        }

        private void MusteriUrunSatisHareketMenuItem_Click(object sender, EventArgs e)
        {
            SatisHareket = new MusteriHareketForm();
            SatisHareket.afrm = this;
            SatisHareket.tbMusteriNo.Text = dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            SatisHareket.tbSirketBilgi.Text = dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            SatisHareket.ShowDialog();
        }

        private void UrunSatisiYapMenuItem_Click(object sender, EventArgs e)
        {
            UrunSatis = new MusteriSatisForm();
            UrunSatis.afrm = this;
            UrunSatis.tbMusteriNo.Text = dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            UrunSatis.tbSirketBilgi.Text = dgvMusteriListe.CurrentRow.Cells[1].Value.ToString();
            UrunSatis.ShowDialog();
        }

        private void MusteriSatisRaporMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar = new RaporForm();
            Raporlar.afrm = this;
            Raporlar.MusteriNo = dgvMusteriListe.CurrentRow.Cells[0].Value.ToString();
            Raporlar.ShowDialog();
        }

        private void MusteriRaporMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar = new RaporForm();
            Raporlar.afrm = this;
            Raporlar.RaporTuru = "Musteriler";
            Raporlar.ShowDialog();
        }

        private void UrunlerRaporMenuItem_Click(object sender, EventArgs e)
        {
            Raporlar = new RaporForm();
            Raporlar.afrm = this;
            Raporlar.RaporTuru = "Urunler";
            Raporlar.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama\nSonlandırılsın mı?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }

        #endregion

    }
}

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
    public partial class YeniKullaniciForm : Form
    {
        public MusteriAnaForm afrm;
        public MusteriGirisForm grsForm;
        public YeniKullaniciForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        bool guncelmi = false;
        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void veriDoldur()
        {
            var KullaniciCek = from kullanici in MusteriData.Kullanicis
                               select new
                               {
                                   kullanici.KullaniciAdi,
                                   kullanici.KullaniciSifresi,
                                   kullanici.KullaniciYetkisi
                               };
            dgvKullanListe.DataSource = KullaniciCek;
        }
        private void baslikGoster()
        {
            dgvKullanListe.Columns[0].HeaderText = "Ad";
            dgvKullanListe.Columns[0].Width = 180;
            dgvKullanListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKullanListe.Columns[1].HeaderText = "Şifre";
            dgvKullanListe.Columns[1].Width = 170;
            dgvKullanListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvKullanListe.Columns[2].HeaderText = "Yetki";
            dgvKullanListe.Columns[2].Width = 110;
            dgvKullanListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
        private void baslat()
        {
            veriDoldur();
            baslikGoster();
            tbAd.Select();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void YeniKullaniciForm_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim() != "" & tbSifre.Text.Trim() != "" & cmbYetki.Text.Trim() != "")
            {
                Kullanici KullaniciBilgi = new Kullanici();
                KullaniciBilgi.KullaniciAdi = tbAd.Text;
                KullaniciBilgi.KullaniciSifresi = tbSifre.Text;
                KullaniciBilgi.KullaniciYetkisi = cmbYetki.Text;
                MusteriData.Kullanicis.InsertOnSubmit(KullaniciBilgi);
                MusteriData.SubmitChanges();
                MessageBox.Show("Kullanıcı Ekleme İşlemi \nBaşarılı Oldu", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                veriDoldur();
                tbAd.Clear();
                tbSifre.Clear();
                cmbYetki.Text = "";
                tbAd.Select();

            }
            else
            {
                MessageBox.Show("Veri girilen alanları\nkontrol ediniz!", "Kontrol Et",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guncelleMenuItem_Click(object sender, EventArgs e)
        {
            guncelmi = true;
            tbAd.Enabled = false;
            btnKaydet.Enabled = false;
            tbAd.Text = dgvKullanListe.CurrentRow.Cells[0].Value.ToString();
            tbSifre.Text = dgvKullanListe.CurrentRow.Cells[1].Value.ToString();
            cmbYetki.Text = dgvKullanListe.CurrentRow.Cells[2].Value.ToString();
            tbSifre.Select();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbAd.Text.Trim() != "" & tbSifre.Text.Trim() != "" & cmbYetki.Text.Trim() != "" & guncelmi)
            {
                Kullanici KullaniciGuncel =
                    MusteriData.Kullanicis.First(guncel => guncel.KullaniciAdi == tbAd.Text);
                KullaniciGuncel.KullaniciAdi = tbAd.Text;
                KullaniciGuncel.KullaniciSifresi = tbSifre.Text;
                KullaniciGuncel.KullaniciYetkisi = cmbYetki.Text;
                MusteriData.SubmitChanges();

                MessageBox.Show("Kullanıcı Bilgileri\nGüncellendi", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                veriDoldur();
                tbAd.Clear();
                tbSifre.Clear();
                cmbYetki.Text = "";
                tbAd.Enabled = true;
                btnKaydet.Enabled = true;
                tbAd.Select();
            }
            else
            {
                MessageBox.Show("Güncelleme\nYapamazsınız", "Kontrol Et",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void silMenuItem_Click(object sender, EventArgs e)
        {
            string ad = dgvKullanListe.CurrentRow.Cells[0].Value.ToString();

            Kullanici KullaniciSilme = MusteriData.Kullanicis.First(sil => sil.KullaniciAdi == ad);
            MusteriData.Kullanicis.DeleteOnSubmit(KullaniciSilme);
            MusteriData.SubmitChanges();

            MessageBox.Show(ad + " isimli \nKullanıcı Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            veriDoldur();
            tbAd.Select();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

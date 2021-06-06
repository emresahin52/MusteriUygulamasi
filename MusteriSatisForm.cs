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
    public partial class MusteriSatisForm : Form
    {
        public MusteriAnaForm afrm;
        public UrunStokGuncelleForm StokGuncel;
        public MusteriSatisForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        bool dolumu = true;
        int StokMiktari;
        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void OdemeDoldur()
        {
            var OdemeBilgiCek = (from OdemeBilgi in MusteriData.Odemes select OdemeBilgi).ToList();

            cmbOdeme.ValueMember = "OdemeTuru";
            cmbOdeme.DataSource = OdemeBilgiCek;
        }

        private void VeriDoldur()
        {
            var UrunCek = from UrunlerBilgi in MusteriData.Urunlers
                          select new
                          {
                              UrunlerBilgi.UrunKodu,
                              UrunlerBilgi.UrunTanimi,
                              UrunlerBilgi.UrunMiktari,
                              UrunlerBilgi.SatisFiyati
                          };
            dgvUrunListe.DataSource = UrunCek;
        }

        private void BaslikGoster()
        {
            dgvUrunListe.Columns[0].HeaderText = "Ürün Kodu";
            dgvUrunListe.Columns[0].Width = 80;
            dgvUrunListe.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[1].HeaderText = "Ürün Tanımı";
            dgvUrunListe.Columns[1].Width = 300;
            dgvUrunListe.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvUrunListe.Columns[2].HeaderText = "Miktar";
            dgvUrunListe.Columns[2].Width = 60;
            dgvUrunListe.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[3].HeaderText = "Satış Fiyatı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void temizle()
        {
            cmbOdeme.Text = "Seçiniz";
            tbSatisTutari.Clear();
            tbSatisFiyat.Clear();
            tbUrunKodu.Clear();
            tbUrunTanimi.Clear();
            tbMiktar.Clear();
            tbMiktar.Select();
        }

        private void BoslukKontrol()
        {
            dolumu = true;
            foreach (Control nesne in this.Controls)
                if (nesne is TextBox)
                {
                    if (nesne.Text.Trim() == "")
                    {
                        dolumu = false;
                        break;
                    }
                }
            if (cmbOdeme.Text == "Seçiniz")
                dolumu = false;
        }

        private void baslat()
        {
            OdemeDoldur();
            VeriDoldur();
            BaslikGoster();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriSatisForm_Load(object sender, EventArgs e)
        {
            baslat();
        }


        private void satisYapMenuItem_Click(object sender, EventArgs e)
        {
            tbUrunKodu.Text = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            tbUrunTanimi.Text = dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            tbSatisFiyat.Text = dgvUrunListe.CurrentRow.Cells[3].Value.ToString();
            StokMiktari = Convert.ToInt16(dgvUrunListe.CurrentRow.Cells[2].Value.ToString());
            tbMiktar.Select();
        }

        private void tbMiktar_Validating(object sender, CancelEventArgs e)
        {
            if (tbMiktar.Text.Trim() != "")
            {
                int SatisMiktari = Convert.ToInt16(tbMiktar.Text);
                if (SatisMiktari <= StokMiktari)
                {
                    tbSatisTutari.Text = (Convert.ToDouble(tbSatisFiyat.Text) * SatisMiktari).ToString();
                    cmbOdeme.Select();
                }
                else
                {
                    MessageBox.Show("Satış İşlemi için \nYeterli Stok Yok!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BoslukKontrol();
            if (dolumu)
            {
                Satislar MusteriUrunSatis = new Satislar();
                MusteriUrunSatis.MusteriNo = tbMusteriNo.Text;
                MusteriUrunSatis.FirmaBilgisi = tbSirketBilgi.Text;
                MusteriUrunSatis.UrunKodu = tbUrunKodu.Text;
                MusteriUrunSatis.UrunTanimi = tbUrunTanimi.Text;
                MusteriUrunSatis.SatisMiktari = Convert.ToInt16(tbMiktar.Text);
                MusteriUrunSatis.SatisTutari = decimal.Parse(tbSatisTutari.Text);
                MusteriUrunSatis.OdemeTuru = cmbOdeme.Text;
                MusteriData.Satislars.InsertOnSubmit(MusteriUrunSatis);
                MusteriData.SubmitChanges();

                Urunler GuncelleUrun = MusteriData.Urunlers.First(guncel => guncel.UrunKodu == tbUrunKodu.Text);
                GuncelleUrun.UrunMiktari -= Convert.ToInt16(tbMiktar.Text);
                MusteriData.SubmitChanges();

                MessageBox.Show("Satış İşlemi \nBaşarılı", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriDoldur();
                temizle();
            }
            else
            {
                MessageBox.Show("Alanları Kontrol Ediniz", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stokEkleMenuItem_Click(object sender, EventArgs e)
        {
            StokGuncel = new UrunStokGuncelleForm();
            StokGuncel.stsform = this;
            StokGuncel.tbUrunKodu.Text = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            StokGuncel.tbUrunTanimi.Text = dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            StokGuncel.ShowDialog();
            VeriDoldur();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

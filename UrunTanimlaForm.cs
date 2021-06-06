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
    public partial class UrunTanimlaForm : Form
    {
        public MusteriAnaForm afrm;
        public UrunStokHareketForm stkfrm;
        public RaporForm raporlar;
        public UrunTanimlaForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        bool dolumu = true;
        string UrunKodu;
        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void VeriDoldur()
        {
            var UrunCek = from urunler in MusteriData.Urunlers
                          select new
                          {
                              urunler.UrunKodu,
                              urunler.UrunTanimi,
                              urunler.UrunMiktari,
                              urunler.AlisFiyati,
                              urunler.SatisFiyati
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
            dgvUrunListe.Columns[3].HeaderText = "Alış Fiyatı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
            dgvUrunListe.Columns[4].HeaderText = "Satış Fiyatı";
            dgvUrunListe.Columns[4].Width = 120;
            dgvUrunListe.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[4].DefaultCellStyle.Format = "C2";
        }

        private void BoslukKontrol()
        {
            dolumu = true;
            foreach (Control tb in this.Controls)
                if (tb is TextBox)
                    if (tb.Text.Trim() == "")
                    {
                        dolumu = false;
                        break;
                    }
        }

        private void Temizle()
        {
            foreach (Control tb in this.Controls)
                if (tb is TextBox)
                    tb.Text = "";
            tbUrunKodu.Select();
        }


        private void StokHareketSil(string urunKod)
        {
            DataTable StokHareketTablo = new DataTable();
            string sorgu = "Select UrunKodu, IslemTarihi, AlinanMiktar, AlisFiyati, AlisTutari " +
                "From StokHareket Where UrunKodu='" + urunKod + "'";
            StokHareketTablo = VtIslem.VeriGetir(sorgu);
            for (int k = 0; k < StokHareketTablo.Rows.Count; k++)
            {
                StokHareketSil UrunStok = new StokHareketSil();
                UrunStok.UrunKodu = StokHareketTablo.Rows[k].ItemArray[0].ToString();
                UrunStok.IslemTarihi =
                    Convert.ToDateTime(StokHareketTablo.Rows[k].ItemArray[1].ToString());
                UrunStok.AlinanMiktar = Convert.ToInt32(StokHareketTablo.Rows[k].ItemArray[2].ToString());
                UrunStok.AlisFiyati = decimal.Parse(StokHareketTablo.Rows[k].ItemArray[3].ToString());
                UrunStok.AlisTutari = decimal.Parse(StokHareketTablo.Rows[k].ItemArray[4].ToString());
                MusteriData.StokHareketSils.InsertOnSubmit(UrunStok);
                MusteriData.SubmitChanges();
            }
        }

        private void baslat()
        {
            VeriDoldur();
            BaslikGoster();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void UrunTanimlaForm_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void tbAlisFiyat_Validated(object sender, EventArgs e)
        {
            if (tbAlisFiyat.Text.Trim() != "")
            {
                tbSatisFiyat.Text = (Convert.ToDouble(tbAlisFiyat.Text) * 1.20).ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BoslukKontrol();
            if (dolumu)
            {
                Urunler UrunBilgi = new Urunler();
                UrunBilgi.UrunKodu = tbUrunKodu.Text;
                UrunBilgi.UrunTanimi = tbUrunTanimi.Text;
                UrunBilgi.UrunMiktari = Convert.ToInt32(tbMiktar.Text);
                UrunBilgi.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                UrunBilgi.SatisFiyati = decimal.Parse(tbSatisFiyat.Text);
                MusteriData.Urunlers.InsertOnSubmit(UrunBilgi);
                MusteriData.SubmitChanges();

                StokHareket UrunStok = new StokHareket();
                UrunStok.UrunKodu = tbUrunKodu.Text;
                UrunStok.IslemTarihi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                UrunStok.AlinanMiktar = Convert.ToInt32(tbMiktar.Text);
                UrunStok.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                UrunStok.AlisTutari =
                    decimal.Parse((Convert.ToInt16(tbMiktar.Text) * Convert.ToDouble(tbAlisFiyat.Text)).ToString());
                MusteriData.StokHarekets.InsertOnSubmit(UrunStok);
                MusteriData.SubmitChanges();

                MessageBox.Show("Yeni Ürün \nOluşturuldu", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Veri Alanlarını \nKontrol Ediniz!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUrunKodu.Select();
            }
        }

        private void UrunuGuncelleMenuItem_Click(object sender, EventArgs e)
        {
            tbUrunKodu.Enabled = false;
            tbUrunKodu.Text = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            tbUrunTanimi.Text = dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            //tbMiktar.Text= dgvUrunListe.CurrentRow.Cells[2].Value.ToString();
            //tbAlisFiyat.Text= dgvUrunListe.CurrentRow.Cells[3].Value.ToString();
            //tbSatisFiyat.Text= dgvUrunListe.CurrentRow.Cells[4].Value.ToString();
            btnKaydet.Enabled = false;
            tbMiktar.Select();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            BoslukKontrol();
            if (dolumu)
            {
                Urunler UrunGuncel = MusteriData.Urunlers.First(guncel => guncel.UrunKodu == tbUrunKodu.Text);
                UrunGuncel.UrunKodu = tbUrunKodu.Text;
                UrunGuncel.UrunTanimi = tbUrunTanimi.Text;
                UrunGuncel.UrunMiktari += Convert.ToInt32(tbMiktar.Text);
                UrunGuncel.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                UrunGuncel.SatisFiyati = decimal.Parse(tbSatisFiyat.Text);
                MusteriData.SubmitChanges();

                StokHareket UrunStok = new StokHareket();
                UrunStok.UrunKodu = tbUrunKodu.Text;
                UrunStok.IslemTarihi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                UrunStok.AlinanMiktar = Convert.ToInt32(tbMiktar.Text);
                UrunStok.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                UrunStok.AlisTutari =
                    decimal.Parse((Convert.ToInt16(tbMiktar.Text) * Convert.ToDouble(tbAlisFiyat.Text)).ToString());
                MusteriData.StokHarekets.InsertOnSubmit(UrunStok);
                MusteriData.SubmitChanges();

                MessageBox.Show("Ürün Bilgileri \nGüncellendi", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriDoldur();
                Temizle();
            }
            else
            {
                MessageBox.Show("Veri Alanlarını \nKontrol Ediniz!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUrunTanimi.Select();
            }
        }

        private void UrunuSilMenuItem_Click(object sender, EventArgs e)
        {
            UrunKodu = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Seçili olan Ürünü \nsilmek istiyor musunuz?", "Bilgi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
            {
                UrunlerSil UrunSilme = new UrunlerSil();
                UrunSilme.UrunKodu = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
                UrunSilme.UrunTanimi = dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
                UrunSilme.UrunMiktari = Convert.ToInt32(dgvUrunListe.CurrentRow.Cells[2].Value.ToString());
                UrunSilme.AlisFiyati = decimal.Parse(dgvUrunListe.CurrentRow.Cells[3].Value.ToString());
                UrunSilme.SatisFiyati = decimal.Parse(dgvUrunListe.CurrentRow.Cells[4].Value.ToString());
                MusteriData.UrunlerSils.InsertOnSubmit(UrunSilme);
                MusteriData.SubmitChanges();

                StokHareketSil(UrunKodu);

                Urunler UrunBilgi = MusteriData.Urunlers.First(sil => sil.UrunKodu == UrunKodu);
                MusteriData.Urunlers.DeleteOnSubmit(UrunBilgi);

                StokHareket StokBilgi = MusteriData.StokHarekets.First(sil => sil.UrunKodu == UrunKodu);
                MusteriData.StokHarekets.DeleteOnSubmit(StokBilgi);
                MusteriData.SubmitChanges();
                VeriDoldur();
            }
        }

        private void UrunStokHareketMenuItem_Click(object sender, EventArgs e)
        {
            stkfrm = new UrunStokHareketForm();
            stkfrm.urnform = this;
            stkfrm.tbUrunKod.Text = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            stkfrm.tbUrunBilgisi.Text = dgvUrunListe.CurrentRow.Cells[1].Value.ToString();
            stkfrm.ShowDialog();
        }

        private void UrunStokRaporuMenuItem_Click(object sender, EventArgs e)
        {
            raporlar = new RaporForm();
            raporlar.urnform = this;
            raporlar.UrunKodu = dgvUrunListe.CurrentRow.Cells[0].Value.ToString();
            raporlar.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            raporlar = new RaporForm();
            raporlar.urnform = this;
            raporlar.RaporTuru = "Urunler";
            raporlar.ShowDialog();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

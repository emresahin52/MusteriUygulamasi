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
    public partial class UrunStokGuncelleForm : Form
    {
        public MusteriSatisForm stsform;
        public UrunStokGuncelleForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        bool dolumu = true;
        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void Temizle()
        {
            foreach (Control tb in this.Controls)
                if (tb is TextBox)
                    tb.Text = "";
        }

        private void BoslukKontrol()
        {
            foreach (Control tb in this.Controls)
                if (tb is TextBox)
                    if (tb.Text.Trim() == "")
                    {
                        dolumu = false;
                        break;
                    }
        }

        private void SayisalControl(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & e.KeyChar != 44)
            {
                MessageBox.Show("Sayısal Değer Giriniz", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void UrunStokGuncelleForm_Load(object sender, EventArgs e)
        {
            tbMiktar.Select();
        }

        private void tbAlisFiyat_Validating(object sender, CancelEventArgs e)
        {
            if (tbMiktar.Text.Trim() != "" & tbAlisFiyat.Text.Trim() != "")
            {
                tbSatisFiyat.Text = (Convert.ToDouble(tbAlisFiyat.Text) * 1.20).ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            BoslukKontrol();
            if (dolumu)
            {
                Urunler GuncelUrun = MusteriData.Urunlers.First(guncel => guncel.UrunKodu == tbUrunKodu.Text);
                GuncelUrun.UrunKodu = tbUrunKodu.Text;
                GuncelUrun.UrunTanimi = tbUrunTanimi.Text;
                GuncelUrun.UrunMiktari += Convert.ToInt16(tbMiktar.Text);
                GuncelUrun.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                GuncelUrun.SatisFiyati = decimal.Parse(tbSatisFiyat.Text);
                MusteriData.SubmitChanges();

                StokHareket UrunStokGirisi = new StokHareket();
                UrunStokGirisi.UrunKodu = tbUrunKodu.Text;
                UrunStokGirisi.IslemTarihi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                UrunStokGirisi.AlinanMiktar = Convert.ToInt16(tbMiktar.Text);
                UrunStokGirisi.AlisFiyati = decimal.Parse(tbAlisFiyat.Text);
                UrunStokGirisi.AlisTutari = decimal.Parse((Convert.ToInt16(tbMiktar.Text) * decimal.Parse(tbAlisFiyat.Text)).ToString());
                MusteriData.StokHarekets.InsertOnSubmit(UrunStokGirisi);
                MusteriData.SubmitChanges();
                MessageBox.Show("Ürün Güncellemesi Yapıldı", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ürün Güncellemesi Yapılamadı !", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMiktar.Select();
            }
        }

        #endregion

    }
}

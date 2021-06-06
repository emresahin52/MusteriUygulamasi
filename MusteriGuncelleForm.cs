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
    public partial class MusteriGuncelleForm : Form
    {
        public MusteriAnaForm afrm;
        public MusteriGuncelleForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        public string MusteriNo;
        MusteriDataDataContext MusteriData = new MusteriDataDataContext();
        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void Temizle()
        {
            foreach (Control tbox in this.Controls)
            {
                if (tbox is TextBox)
                    tbox.Text = "";
            }
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriGuncelleForm_Load(object sender, EventArgs e)
        {
            tbFirmaBilgisi.Select();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (tbMusteriNo.Text != "" & tbFirmaBilgisi.Text != "" & tbYetkiliAd.Text != "" &
               tbYetkiliSoyad.Text != "" & tbFirmaAdresi.Text != "" & tbTelefonNo.Text != "")
            {
                Kimlik GuncelKimlik = MusteriData.Kimliks.First(guncel => guncel.MusteriNo == MusteriNo);
                GuncelKimlik.MusteriNo = tbMusteriNo.Text;
                GuncelKimlik.FirmaBilgisi = tbFirmaBilgisi.Text;
                GuncelKimlik.YetkiliAdi = tbYetkiliAd.Text;
                GuncelKimlik.YetkiliSoyadi = tbYetkiliSoyad.Text;
                GuncelKimlik.FirmaAdresi = tbFirmaAdresi.Text;
                GuncelKimlik.TelefonNo = tbTelefonNo.Text;
                MusteriData.SubmitChanges();
                MessageBox.Show(MusteriNo + " numaralı \nMüşteri Bilgileri Güncellendi", "Bilgi",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                this.Close();
            }
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

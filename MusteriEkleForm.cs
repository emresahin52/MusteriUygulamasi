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
    public partial class MusteriEkleForm : Form
    {
        public MusteriAnaForm afrm;
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

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
            tbMusteriNo.Select();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriEkleForm_Load(object sender, EventArgs e)
        {
            tbMusteriNo.Select();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbMusteriNo.Text != "" & tbFirmaBilgisi.Text != "" & tbYetkiliAd.Text != "" &
               tbYetkiliSoyad.Text != "" & tbFirmaAdresi.Text != "" & tbTelefonNo.Text != "")
            {
                Kimlik MusteriKimlik = new Kimlik();
                MusteriKimlik.MusteriNo = tbMusteriNo.Text;
                MusteriKimlik.FirmaBilgisi = tbFirmaBilgisi.Text;
                MusteriKimlik.YetkiliAdi = tbYetkiliAd.Text;
                MusteriKimlik.YetkiliSoyadi = tbYetkiliSoyad.Text;
                MusteriKimlik.FirmaAdresi = tbFirmaAdresi.Text;
                MusteriKimlik.TelefonNo = tbTelefonNo.Text;
                MusteriData.Kimliks.InsertOnSubmit(MusteriKimlik);
                MusteriData.SubmitChanges();
                MessageBox.Show("Yeni Müşteri \nBaşarı ile Oluşturuldu", "Dikkat",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

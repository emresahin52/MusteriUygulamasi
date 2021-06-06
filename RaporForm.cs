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
    public partial class RaporForm : Form
    {
        public MusteriAnaForm afrm;
        public UrunTanimlaForm urnform;

        public RaporForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        public string RaporTuru;
        public string MusteriNo;
        public string UrunKodu;

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void MusteriDoldur()
        {
            string sorgu = "Select MusteriNo, FirmaBilgisi, FirmaAdresi, TelefonNo  From Kimlik";
            //MusteriListeRapor rapor = new MusteriListeRapor();
            //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
            //RaporGoster.ReportSource = rapor;
        }

        private void UrunDoldur()
        {
            string sorgu = "Select UrunKodu, UrunTanimi, UrunMiktari, SatisFiyati From Urunler";
            //UrunListeRapor rapor = new UrunListeRapor();
            //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
            //RaporGoster.ReportSource = rapor;
        }


        private void SatisDoldur()
        {
            string sorgu = "Select MusteriNo, FirmaBilgisi, UrunKodu, UrunTanimi, " +
                "SatisMiktari, SatisTutari From Satislar Where MusteriNo='" + MusteriNo + "'";
            //MusteriSatisRapor rapor = new MusteriSatisRapor();
            //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
            //RaporGoster.ReportSource = rapor; 
        }

        private void StokDoldur()
        {
            string sorgu = "Select UrunKodu, IslemTarihi, AlinanMiktar, AlisFiyati, " +
                "AlisTutari From StokHareket Where UrunKodu='" + UrunKodu + "'";
            //UrunStokRapor rapor = new UrunStokRapor();
            //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
            //RaporGoster.ReportSource = rapor;
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void RaporForm_Load(object sender, EventArgs e)
        {
            if (RaporTuru == "Musteriler")
            {
                //MusteriListeRapor rapor = new MusteriListeRapor();
                //RaporGoster.ReportSource = rapor;
                //RaporTuru = "";
            }
            else if (RaporTuru == "Urunler")
            {
                //UrunListeRapor rapor = new UrunListeRapor();
                //RaporGoster.ReportSource = rapor;
                //RaporTuru = "";
            }
            else if (MusteriNo != null)
            {
                //SatisDoldur();
                //MusteriNo = null;
            }
            else if (UrunKodu != null)
            {
                //StokDoldur();
                //UrunKodu = null;
            }
        }

        private void cmbRaporTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu;
            if (cmbRaporTuru.SelectedIndex == 0)
            {
                sorgu = "Select MusteriNo, FirmaBilgisi, FirmaAdresi, TelefonNo  From Kimlik";
                //MusteriListeRapor rapor = new MusteriListeRapor();
                //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
                //RaporGoster.ReportSource = rapor;
            }
            if (cmbRaporTuru.SelectedIndex == 1)
            {
                sorgu = "Select UrunKodu, UrunTanimi, UrunMiktari, SatisFiyati  From Urunler";
                //UrunListeRapor rapor = new UrunListeRapor();
                //rapor.SetDataSource(VtIslem.VeriGetir(sorgu));
                //RaporGoster.ReportSource = rapor;
            }
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

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
    public partial class MusteriHareketForm : Form
    {
        public MusteriAnaForm afrm;
        public MusteriHareketForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void VeriDoldur()
        {
            var MusteriSatisCek = from SatisMusteri in MusteriData.Satislars
                                  where SatisMusteri.MusteriNo == tbMusteriNo.Text
                                  select new
                                  {
                                      SatisMusteri.UrunKodu,
                                      SatisMusteri.UrunTanimi,
                                      SatisMusteri.SatisMiktari,
                                      SatisMusteri.SatisTutari,
                                      SatisMusteri.OdemeTuru                
                                  };
            dgvSatisListe.DataSource = MusteriSatisCek;
        }

        private void baslikGoster()
        {
            dgvSatisListe.Columns[0].HeaderText = "Ürün Kodu";
            dgvSatisListe.Columns[0].Width = 100;
            dgvSatisListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvSatisListe.Columns[1].HeaderText = "Ürün Tanimi";
            dgvSatisListe.Columns[1].Width = 300;
            dgvSatisListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dgvSatisListe.Columns[2].HeaderText = "Miktar";
            dgvSatisListe.Columns[2].Width = 60;
            dgvSatisListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvSatisListe.Columns[3].HeaderText = "Satış Tutarı";
            dgvSatisListe.Columns[3].Width = 120;
            dgvSatisListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvSatisListe.Columns[3].DefaultCellStyle.Format = "C2";
            dgvSatisListe.Columns[4].HeaderText = "Ödeme Türü";
            dgvSatisListe.Columns[4].Width = 120;
            dgvSatisListe.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvSatisListe.Columns[4].DefaultCellStyle.Format = "C2";
        }

        private void baslat()
        {
            VeriDoldur();
            baslikGoster();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void MusteriHareketForm_Load(object sender, EventArgs e)
        {
            baslat();
        }

        private void btnAnaForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}

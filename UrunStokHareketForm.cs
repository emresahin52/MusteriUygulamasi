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
    public partial class UrunStokHareketForm : Form
    {
        public UrunTanimlaForm urnform;
        public UrunStokHareketForm()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar

        MusteriDataDataContext MusteriData = new MusteriDataDataContext();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        private void VeriDoldur()
        {
            var StokCek = from UrunStok in MusteriData.StokHarekets
                          where UrunStok.UrunKodu == tbUrunKod.Text
                          select new
                          {
                              UrunStok.IslemTarihi,
                              UrunStok.AlinanMiktar,
                              UrunStok.AlisFiyati,
                              UrunStok.AlisTutari
                          };
            dgvUrunListe.DataSource = StokCek;
        }

        private void baslikGoster()
        {
            dgvUrunListe.Columns[0].HeaderText = "İşlem Tarihi";
            dgvUrunListe.Columns[0].Width = 120;
            dgvUrunListe.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[1].HeaderText = "Miktar";
            dgvUrunListe.Columns[1].Width = 60;
            dgvUrunListe.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvUrunListe.Columns[2].HeaderText = "Alış Fiyatı";
            dgvUrunListe.Columns[2].Width = 120;
            dgvUrunListe.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[2].DefaultCellStyle.Format = "C2";
            dgvUrunListe.Columns[3].HeaderText = "Alış Tutarı";
            dgvUrunListe.Columns[3].Width = 120;
            dgvUrunListe.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvUrunListe.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void baslat()
        {
            VeriDoldur();
            baslikGoster();
        }

        #endregion

        #region Nesne Tanımlı Olaylar

        private void UrunStokHareketForm_Load(object sender, EventArgs e)
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

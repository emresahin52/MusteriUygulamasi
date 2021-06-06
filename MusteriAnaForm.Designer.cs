namespace MUSTERIAPPS
{
    partial class MusteriAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMusteriListe = new System.Windows.Forms.DataGridView();
            this.musteriIslemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UrunSatisiYapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MusteriGuncelleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriSilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MusteriUrunSatisHareketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MusteriSatisRaporMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbYetkiliAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFirmaBilgisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.MusteriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.YeniMusteriMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunlerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriRaporMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrunlerRaporMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.YonetimMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullaniciMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMusteri = new System.Windows.Forms.ToolStrip();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.btnEkleMusteri = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEkleUrun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMusteriRapor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUrunRapor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).BeginInit();
            this.musteriIslemMenu.SuspendLayout();
            this.AnaMenu.SuspendLayout();
            this.tsMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusteriListe
            // 
            this.dgvMusteriListe.AllowUserToAddRows = false;
            this.dgvMusteriListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMusteriListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMusteriListe.ColumnHeadersHeight = 25;
            this.dgvMusteriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMusteriListe.Location = new System.Drawing.Point(12, 144);
            this.dgvMusteriListe.Name = "dgvMusteriListe";
            this.dgvMusteriListe.ReadOnly = true;
            this.dgvMusteriListe.RowHeadersWidth = 25;
            this.dgvMusteriListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvMusteriListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMusteriListe.RowTemplate.ContextMenuStrip = this.musteriIslemMenu;
            this.dgvMusteriListe.RowTemplate.Height = 30;
            this.dgvMusteriListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusteriListe.Size = new System.Drawing.Size(1126, 308);
            this.dgvMusteriListe.TabIndex = 2;
            // 
            // musteriIslemMenu
            // 
            this.musteriIslemMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.musteriIslemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunSatisiYapMenuItem,
            this.toolStripSeparator2,
            this.MusteriGuncelleMenuItem,
            this.MusteriSilMenuItem,
            this.toolStripSeparator1,
            this.MusteriUrunSatisHareketMenuItem,
            this.toolStripSeparator3,
            this.MusteriSatisRaporMenuItem});
            this.musteriIslemMenu.Name = "musteriIslemMenu";
            this.musteriIslemMenu.Size = new System.Drawing.Size(191, 132);
            // 
            // UrunSatisiYapMenuItem
            // 
            this.UrunSatisiYapMenuItem.Name = "UrunSatisiYapMenuItem";
            this.UrunSatisiYapMenuItem.Size = new System.Drawing.Size(190, 22);
            this.UrunSatisiYapMenuItem.Text = "Satış Yap";
            this.UrunSatisiYapMenuItem.Click += new System.EventHandler(this.UrunSatisiYapMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // MusteriGuncelleMenuItem
            // 
            this.MusteriGuncelleMenuItem.Name = "MusteriGuncelleMenuItem";
            this.MusteriGuncelleMenuItem.Size = new System.Drawing.Size(190, 22);
            this.MusteriGuncelleMenuItem.Text = "Müşteri Güncelle";
            this.MusteriGuncelleMenuItem.Click += new System.EventHandler(this.MusteriGuncelleMenuItem_Click);
            // 
            // MusteriSilMenuItem
            // 
            this.MusteriSilMenuItem.Name = "MusteriSilMenuItem";
            this.MusteriSilMenuItem.Size = new System.Drawing.Size(190, 22);
            this.MusteriSilMenuItem.Text = "Müşteri Sil";
            this.MusteriSilMenuItem.Click += new System.EventHandler(this.MusteriSilMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // MusteriUrunSatisHareketMenuItem
            // 
            this.MusteriUrunSatisHareketMenuItem.Name = "MusteriUrunSatisHareketMenuItem";
            this.MusteriUrunSatisHareketMenuItem.Size = new System.Drawing.Size(190, 22);
            this.MusteriUrunSatisHareketMenuItem.Text = "Satış Hareketleri";
            this.MusteriUrunSatisHareketMenuItem.Click += new System.EventHandler(this.MusteriUrunSatisHareketMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // MusteriSatisRaporMenuItem
            // 
            this.MusteriSatisRaporMenuItem.Name = "MusteriSatisRaporMenuItem";
            this.MusteriSatisRaporMenuItem.Size = new System.Drawing.Size(190, 22);
            this.MusteriSatisRaporMenuItem.Text = "Rapor";
            this.MusteriSatisRaporMenuItem.Click += new System.EventHandler(this.MusteriSatisRaporMenuItem_Click);
            // 
            // tbYetkiliAd
            // 
            this.tbYetkiliAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbYetkiliAd.Location = new System.Drawing.Point(584, 107);
            this.tbYetkiliAd.MaxLength = 20;
            this.tbYetkiliAd.Name = "tbYetkiliAd";
            this.tbYetkiliAd.Size = new System.Drawing.Size(184, 24);
            this.tbYetkiliAd.TabIndex = 1;
            this.tbYetkiliAd.TextChanged += new System.EventHandler(this.tbYetkiliAd_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(467, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yetkili Adi :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFirmaBilgisi
            // 
            this.tbFirmaBilgisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbFirmaBilgisi.Location = new System.Drawing.Point(129, 106);
            this.tbFirmaBilgisi.MaxLength = 150;
            this.tbFirmaBilgisi.Name = "tbFirmaBilgisi";
            this.tbFirmaBilgisi.Size = new System.Drawing.Size(319, 24);
            this.tbFirmaBilgisi.TabIndex = 0;
            this.tbFirmaBilgisi.TextChanged += new System.EventHandler(this.tbFirmaBilgisi_TextChanged);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şirket Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnaMenu
            // 
            this.AnaMenu.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusteriMenu,
            this.YonetimMenu,
            this.kapatMenuItem});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(1150, 25);
            this.AnaMenu.TabIndex = 18;
            this.AnaMenu.Text = "Ana Menü";
            // 
            // MusteriMenu
            // 
            this.MusteriMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.YeniMusteriMenuItem,
            this.UrunlerMenuItem,
            this.toolStripMenuItem1});
            this.MusteriMenu.Name = "MusteriMenu";
            this.MusteriMenu.Size = new System.Drawing.Size(71, 21);
            this.MusteriMenu.Text = "&Müşteri";
            // 
            // YeniMusteriMenuItem
            // 
            this.YeniMusteriMenuItem.Name = "YeniMusteriMenuItem";
            this.YeniMusteriMenuItem.Size = new System.Drawing.Size(127, 22);
            this.YeniMusteriMenuItem.Text = "Yeni";
            this.YeniMusteriMenuItem.Click += new System.EventHandler(this.btnEkleMusteri_Click);
            // 
            // UrunlerMenuItem
            // 
            this.UrunlerMenuItem.Name = "UrunlerMenuItem";
            this.UrunlerMenuItem.Size = new System.Drawing.Size(127, 22);
            this.UrunlerMenuItem.Text = "Ürünler";
            this.UrunlerMenuItem.Click += new System.EventHandler(this.btnEkleUrun_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusteriRaporMenuItem,
            this.UrunlerRaporMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItem1.Text = "Rapor";
            // 
            // MusteriRaporMenuItem
            // 
            this.MusteriRaporMenuItem.Name = "MusteriRaporMenuItem";
            this.MusteriRaporMenuItem.Size = new System.Drawing.Size(144, 22);
            this.MusteriRaporMenuItem.Text = "Müşteriler";
            this.MusteriRaporMenuItem.Click += new System.EventHandler(this.MusteriRaporMenuItem_Click);
            // 
            // UrunlerRaporMenuItem
            // 
            this.UrunlerRaporMenuItem.Name = "UrunlerRaporMenuItem";
            this.UrunlerRaporMenuItem.Size = new System.Drawing.Size(144, 22);
            this.UrunlerRaporMenuItem.Text = "Ürünler";
            this.UrunlerRaporMenuItem.Click += new System.EventHandler(this.UrunlerRaporMenuItem_Click);
            // 
            // YonetimMenu
            // 
            this.YonetimMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullaniciMenuItem});
            this.YonetimMenu.Name = "YonetimMenu";
            this.YonetimMenu.Size = new System.Drawing.Size(77, 21);
            this.YonetimMenu.Text = "Yönetim";
            // 
            // yeniKullaniciMenuItem
            // 
            this.yeniKullaniciMenuItem.Name = "yeniKullaniciMenuItem";
            this.yeniKullaniciMenuItem.Size = new System.Drawing.Size(164, 22);
            this.yeniKullaniciMenuItem.Text = "Yeni Kullanıcı";
            this.yeniKullaniciMenuItem.Click += new System.EventHandler(this.yeniKullaniciMenuItem_Click);
            // 
            // kapatMenuItem
            // 
            this.kapatMenuItem.Name = "kapatMenuItem";
            this.kapatMenuItem.Size = new System.Drawing.Size(52, 21);
            this.kapatMenuItem.Text = "Çıkış";
            this.kapatMenuItem.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // tsMusteri
            // 
            this.tsMusteri.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tsMusteri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKapat,
            this.btnEkleMusteri,
            this.toolStripSeparator4,
            this.btnEkleUrun,
            this.toolStripSeparator5,
            this.btnMusteriRapor,
            this.toolStripSeparator6,
            this.btnUrunRapor,
            this.toolStripSeparator7});
            this.tsMusteri.Location = new System.Drawing.Point(0, 25);
            this.tsMusteri.Name = "tsMusteri";
            this.tsMusteri.Size = new System.Drawing.Size(1150, 55);
            this.tsMusteri.TabIndex = 19;
            this.tsMusteri.Text = "Müşteri Toolbar";
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKapat.Image = global::MUSTERIAPPS.Properties.Resources.kapat;
            this.btnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(52, 52);
            this.btnKapat.Text = "toolStripButton1";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnEkleMusteri
            // 
            this.btnEkleMusteri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEkleMusteri.Image = global::MUSTERIAPPS.Properties.Resources.ekle_musteri;
            this.btnEkleMusteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkleMusteri.Name = "btnEkleMusteri";
            this.btnEkleMusteri.Size = new System.Drawing.Size(52, 52);
            this.btnEkleMusteri.Text = "Yeni Müşteri";
            this.btnEkleMusteri.Click += new System.EventHandler(this.btnEkleMusteri_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // btnEkleUrun
            // 
            this.btnEkleUrun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEkleUrun.Image = global::MUSTERIAPPS.Properties.Resources.ekle_urun;
            this.btnEkleUrun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEkleUrun.Name = "btnEkleUrun";
            this.btnEkleUrun.Size = new System.Drawing.Size(52, 52);
            this.btnEkleUrun.Text = "Ürün Ekleme";
            this.btnEkleUrun.Click += new System.EventHandler(this.btnEkleUrun_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // btnMusteriRapor
            // 
            this.btnMusteriRapor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMusteriRapor.Image = global::MUSTERIAPPS.Properties.Resources.rapor_musteri;
            this.btnMusteriRapor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMusteriRapor.Name = "btnMusteriRapor";
            this.btnMusteriRapor.Size = new System.Drawing.Size(52, 52);
            this.btnMusteriRapor.Text = "Müşteri Listesi";
            this.btnMusteriRapor.Click += new System.EventHandler(this.MusteriRaporMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // btnUrunRapor
            // 
            this.btnUrunRapor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUrunRapor.Image = global::MUSTERIAPPS.Properties.Resources.rapor_urun;
            this.btnUrunRapor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunRapor.Name = "btnUrunRapor";
            this.btnUrunRapor.Size = new System.Drawing.Size(52, 52);
            this.btnUrunRapor.Text = "Ürün Listesi";
            this.btnUrunRapor.Click += new System.EventHandler(this.UrunlerRaporMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 55);
            // 
            // MusteriAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 467);
            this.ControlBox = false;
            this.Controls.Add(this.tsMusteri);
            this.Controls.Add(this.AnaMenu);
            this.Controls.Add(this.tbYetkiliAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirmaBilgisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMusteriListe);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListe)).EndInit();
            this.musteriIslemMenu.ResumeLayout(false);
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.tsMusteri.ResumeLayout(false);
            this.tsMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriListe;
        private System.Windows.Forms.ContextMenuStrip musteriIslemMenu;
        private System.Windows.Forms.ToolStripMenuItem UrunSatisiYapMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MusteriSilMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriGuncelleMenuItem;
        private System.Windows.Forms.TextBox tbYetkiliAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFirmaBilgisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MusteriUrunSatisHareketMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MusteriSatisRaporMenuItem;
        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem MusteriMenu;
        private System.Windows.Forms.ToolStripMenuItem YeniMusteriMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunlerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MusteriRaporMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrunlerRaporMenuItem;
        private System.Windows.Forms.ToolStripMenuItem YonetimMenu;
        private System.Windows.Forms.ToolStripMenuItem yeniKullaniciMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatMenuItem;
        private System.Windows.Forms.ToolStrip tsMusteri;
        private System.Windows.Forms.ToolStripButton btnKapat;
        private System.Windows.Forms.ToolStripButton btnEkleMusteri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnEkleUrun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnMusteriRapor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnUrunRapor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}
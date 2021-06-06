namespace MUSTERIAPPS
{
    partial class UrunTanimlaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrunKodu = new System.Windows.Forms.TextBox();
            this.tbUrunTanimi = new System.Windows.Forms.TextBox();
            this.dgvUrunListe = new System.Windows.Forms.DataGridView();
            this.urunIslemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UrunuGuncelleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UrunuSilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UrunStokHareketMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UrunStokRaporuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).BeginInit();
            this.urunIslemMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kodu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Tanimi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUrunKodu
            // 
            this.tbUrunKodu.Location = new System.Drawing.Point(123, 21);
            this.tbUrunKodu.MaxLength = 6;
            this.tbUrunKodu.Name = "tbUrunKodu";
            this.tbUrunKodu.Size = new System.Drawing.Size(86, 24);
            this.tbUrunKodu.TabIndex = 0;
            this.tbUrunKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUrunTanimi
            // 
            this.tbUrunTanimi.Location = new System.Drawing.Point(123, 63);
            this.tbUrunTanimi.Multiline = true;
            this.tbUrunTanimi.Name = "tbUrunTanimi";
            this.tbUrunTanimi.Size = new System.Drawing.Size(180, 66);
            this.tbUrunTanimi.TabIndex = 1;
            // 
            // dgvUrunListe
            // 
            this.dgvUrunListe.AllowUserToAddRows = false;
            this.dgvUrunListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrunListe.ColumnHeadersHeight = 25;
            this.dgvUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUrunListe.Location = new System.Drawing.Point(309, 9);
            this.dgvUrunListe.Name = "dgvUrunListe";
            this.dgvUrunListe.ReadOnly = true;
            this.dgvUrunListe.RowHeadersWidth = 25;
            this.dgvUrunListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUrunListe.RowTemplate.ContextMenuStrip = this.urunIslemMenu;
            this.dgvUrunListe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunListe.RowTemplate.Height = 25;
            this.dgvUrunListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunListe.Size = new System.Drawing.Size(750, 303);
            this.dgvUrunListe.TabIndex = 7;
            // 
            // urunIslemMenu
            // 
            this.urunIslemMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.urunIslemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UrunuGuncelleMenuItem,
            this.toolStripSeparator1,
            this.UrunuSilMenuItem,
            this.toolStripSeparator2,
            this.UrunStokHareketMenuItem,
            this.toolStripSeparator3,
            this.UrunStokRaporuMenuItem});
            this.urunIslemMenu.Name = "urunIslemMenu";
            this.urunIslemMenu.Size = new System.Drawing.Size(189, 132);
            // 
            // UrunuGuncelleMenuItem
            // 
            this.UrunuGuncelleMenuItem.Name = "UrunuGuncelleMenuItem";
            this.UrunuGuncelleMenuItem.Size = new System.Drawing.Size(188, 22);
            this.UrunuGuncelleMenuItem.Text = "Güncelle";
            this.UrunuGuncelleMenuItem.Click += new System.EventHandler(this.UrunuGuncelleMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // UrunuSilMenuItem
            // 
            this.UrunuSilMenuItem.Name = "UrunuSilMenuItem";
            this.UrunuSilMenuItem.Size = new System.Drawing.Size(188, 22);
            this.UrunuSilMenuItem.Text = "Sil";
            this.UrunuSilMenuItem.Click += new System.EventHandler(this.UrunuSilMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // UrunStokHareketMenuItem
            // 
            this.UrunStokHareketMenuItem.Name = "UrunStokHareketMenuItem";
            this.UrunStokHareketMenuItem.Size = new System.Drawing.Size(188, 22);
            this.UrunStokHareketMenuItem.Text = "Stok Hareketleri";
            this.UrunStokHareketMenuItem.Click += new System.EventHandler(this.UrunStokHareketMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // UrunStokRaporuMenuItem
            // 
            this.UrunStokRaporuMenuItem.Name = "UrunStokRaporuMenuItem";
            this.UrunStokRaporuMenuItem.Size = new System.Drawing.Size(188, 22);
            this.UrunStokRaporuMenuItem.Text = "Rapor";
            this.UrunStokRaporuMenuItem.Click += new System.EventHandler(this.UrunStokRaporuMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(267, 276);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(36, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.guncel;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(196, 276);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(36, 36);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbMiktar
            // 
            this.tbMiktar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMiktar.Location = new System.Drawing.Point(123, 145);
            this.tbMiktar.MaxLength = 6;
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(60, 24);
            this.tbMiktar.TabIndex = 2;
            this.tbMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ürün Miktarı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAlisFiyat
            // 
            this.tbAlisFiyat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAlisFiyat.Location = new System.Drawing.Point(123, 189);
            this.tbAlisFiyat.MaxLength = 6;
            this.tbAlisFiyat.Name = "tbAlisFiyat";
            this.tbAlisFiyat.Size = new System.Drawing.Size(119, 24);
            this.tbAlisFiyat.TabIndex = 3;
            this.tbAlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAlisFiyat.Validated += new System.EventHandler(this.tbAlisFiyat_Validated);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alış Fiyatı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Enabled = false;
            this.tbSatisFiyat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyat.Location = new System.Drawing.Point(123, 231);
            this.tbSatisFiyat.MaxLength = 6;
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(119, 24);
            this.tbSatisFiyat.TabIndex = 4;
            this.tbSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Satış Fiyatı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(267, 9);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(36, 36);
            this.btnAnaForm.TabIndex = 8;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.rapor_urun;
            this.btnRapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRapor.Location = new System.Drawing.Point(123, 276);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(36, 36);
            this.btnRapor.TabIndex = 18;
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // UrunTanimlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.tbSatisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAlisFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.dgvUrunListe);
            this.Controls.Add(this.tbUrunTanimi);
            this.Controls.Add(this.tbUrunKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunTanimlaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Ürün Tanımlama";
            this.Load += new System.EventHandler(this.UrunTanimlaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).EndInit();
            this.urunIslemMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrunKodu;
        private System.Windows.Forms.TextBox tbUrunTanimi;
        private System.Windows.Forms.DataGridView dgvUrunListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.ContextMenuStrip urunIslemMenu;
        private System.Windows.Forms.ToolStripMenuItem UrunuGuncelleMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem UrunuSilMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAlisFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem UrunStokHareketMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem UrunStokRaporuMenuItem;
        private System.Windows.Forms.Button btnRapor;
    }
}
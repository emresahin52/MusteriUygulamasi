namespace MUSTERIAPPS
{
    partial class MusteriSatisForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSirketBilgi = new System.Windows.Forms.TextBox();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUrunTanimi = new System.Windows.Forms.TextBox();
            this.tbUrunKodu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvUrunListe = new System.Windows.Forms.DataGridView();
            this.satisMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.satisYapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.stokEkleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbSatisTutari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOdeme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAnaForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).BeginInit();
            this.satisMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSirketBilgi
            // 
            this.tbSirketBilgi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSirketBilgi.Enabled = false;
            this.tbSirketBilgi.Location = new System.Drawing.Point(129, 48);
            this.tbSirketBilgi.MaxLength = 150;
            this.tbSirketBilgi.Multiline = true;
            this.tbSirketBilgi.Name = "tbSirketBilgi";
            this.tbSirketBilgi.Size = new System.Drawing.Size(184, 69);
            this.tbSirketBilgi.TabIndex = 1;
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMusteriNo.Enabled = false;
            this.tbMusteriNo.Location = new System.Drawing.Point(129, 18);
            this.tbMusteriNo.MaxLength = 8;
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.Size = new System.Drawing.Size(100, 24);
            this.tbMusteriNo.TabIndex = 0;
            this.tbMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şirket Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Enabled = false;
            this.tbSatisFiyat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyat.Location = new System.Drawing.Point(129, 228);
            this.tbSatisFiyat.MaxLength = 6;
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(119, 24);
            this.tbSatisFiyat.TabIndex = 4;
            this.tbSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Satış Fiyatı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMiktar
            // 
            this.tbMiktar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMiktar.Location = new System.Drawing.Point(129, 262);
            this.tbMiktar.MaxLength = 6;
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(60, 24);
            this.tbMiktar.TabIndex = 5;
            this.tbMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMiktar.Validating += new System.ComponentModel.CancelEventHandler(this.tbMiktar_Validating);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ürün Miktarı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUrunTanimi
            // 
            this.tbUrunTanimi.Enabled = false;
            this.tbUrunTanimi.Location = new System.Drawing.Point(129, 153);
            this.tbUrunTanimi.Multiline = true;
            this.tbUrunTanimi.Name = "tbUrunTanimi";
            this.tbUrunTanimi.Size = new System.Drawing.Size(184, 66);
            this.tbUrunTanimi.TabIndex = 3;
            // 
            // tbUrunKodu
            // 
            this.tbUrunKodu.Enabled = false;
            this.tbUrunKodu.Location = new System.Drawing.Point(129, 123);
            this.tbUrunKodu.MaxLength = 6;
            this.tbUrunKodu.Name = "tbUrunKodu";
            this.tbUrunKodu.Size = new System.Drawing.Size(86, 24);
            this.tbUrunKodu.TabIndex = 2;
            this.tbUrunKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ürün Tanimi :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ürün Kodu :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvUrunListe
            // 
            this.dgvUrunListe.AllowUserToAddRows = false;
            this.dgvUrunListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunListe.ColumnHeadersHeight = 25;
            this.dgvUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUrunListe.Location = new System.Drawing.Point(327, 6);
            this.dgvUrunListe.Name = "dgvUrunListe";
            this.dgvUrunListe.ReadOnly = true;
            this.dgvUrunListe.RowHeadersWidth = 25;
            this.dgvUrunListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUrunListe.RowTemplate.ContextMenuStrip = this.satisMenu;
            this.dgvUrunListe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvUrunListe.RowTemplate.Height = 25;
            this.dgvUrunListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunListe.Size = new System.Drawing.Size(620, 349);
            this.dgvUrunListe.TabIndex = 28;
            // 
            // satisMenu
            // 
            this.satisMenu.Font = new System.Drawing.Font("Verdana", 10F);
            this.satisMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisYapMenuItem,
            this.toolStripSeparator1,
            this.stokEkleMenuItem});
            this.satisMenu.Name = "satisMenu";
            this.satisMenu.Size = new System.Drawing.Size(143, 54);
            // 
            // satisYapMenuItem
            // 
            this.satisYapMenuItem.Name = "satisYapMenuItem";
            this.satisYapMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satisYapMenuItem.Text = "Satış Yap";
            this.satisYapMenuItem.Click += new System.EventHandler(this.satisYapMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // stokEkleMenuItem
            // 
            this.stokEkleMenuItem.Name = "stokEkleMenuItem";
            this.stokEkleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stokEkleMenuItem.Text = "Stok Ekle";
            this.stokEkleMenuItem.Click += new System.EventHandler(this.stokEkleMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(277, 319);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(36, 36);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbSatisTutari
            // 
            this.tbSatisTutari.Enabled = false;
            this.tbSatisTutari.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisTutari.Location = new System.Drawing.Point(129, 296);
            this.tbSatisTutari.MaxLength = 6;
            this.tbSatisTutari.Name = "tbSatisTutari";
            this.tbSatisTutari.Size = new System.Drawing.Size(119, 24);
            this.tbSatisTutari.TabIndex = 6;
            this.tbSatisTutari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Satış Tutarı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(12, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ödeme Türü :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbOdeme
            // 
            this.cmbOdeme.FormattingEnabled = true;
            this.cmbOdeme.Location = new System.Drawing.Point(129, 331);
            this.cmbOdeme.Name = "cmbOdeme";
            this.cmbOdeme.Size = new System.Drawing.Size(121, 24);
            this.cmbOdeme.TabIndex = 7;
            this.cmbOdeme.Text = "Seçiniz";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(249, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "₺";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(249, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 37;
            this.label10.Text = "₺";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(277, 6);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(36, 36);
            this.btnAnaForm.TabIndex = 9;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // MusteriSatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 367);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOdeme);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSatisTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.dgvUrunListe);
            this.Controls.Add(this.tbSatisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUrunTanimi);
            this.Controls.Add(this.tbUrunKodu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSirketBilgi);
            this.Controls.Add(this.tbMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriSatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Satış İşlemleri";
            this.Load += new System.EventHandler(this.MusteriSatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).EndInit();
            this.satisMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUrunTanimi;
        private System.Windows.Forms.TextBox tbUrunKodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUrunListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.TextBox tbSatisTutari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOdeme;
        private System.Windows.Forms.ContextMenuStrip satisMenu;
        private System.Windows.Forms.ToolStripMenuItem satisYapMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem stokEkleMenuItem;
        public System.Windows.Forms.TextBox tbSirketBilgi;
        public System.Windows.Forms.TextBox tbMusteriNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
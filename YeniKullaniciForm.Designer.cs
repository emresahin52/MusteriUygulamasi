namespace MUSTERIAPPS
{
    partial class YeniKullaniciForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYetki = new System.Windows.Forms.ComboBox();
            this.dgvKullanListe = new System.Windows.Forms.DataGridView();
            this.kullanMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guncelleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.silMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanListe)).BeginInit();
            this.kullanMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.kaydet;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(154, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(36, 36);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(24, 186);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(36, 36);
            this.btnAnaForm.TabIndex = 5;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(79, 77);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(111, 24);
            this.tbSifre.TabIndex = 1;
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(79, 32);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(111, 24);
            this.tbAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(24, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yetki :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbYetki
            // 
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı"});
            this.cmbYetki.Location = new System.Drawing.Point(79, 122);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(111, 24);
            this.cmbYetki.TabIndex = 2;
            // 
            // dgvKullanListe
            // 
            this.dgvKullanListe.AllowUserToAddRows = false;
            this.dgvKullanListe.AllowUserToDeleteRows = false;
            this.dgvKullanListe.ColumnHeadersHeight = 25;
            this.dgvKullanListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKullanListe.Location = new System.Drawing.Point(208, 32);
            this.dgvKullanListe.Name = "dgvKullanListe";
            this.dgvKullanListe.ReadOnly = true;
            this.dgvKullanListe.RowHeadersWidth = 20;
            this.dgvKullanListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvKullanListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKullanListe.RowTemplate.ContextMenuStrip = this.kullanMenu;
            this.dgvKullanListe.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvKullanListe.RowTemplate.Height = 25;
            this.dgvKullanListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanListe.Size = new System.Drawing.Size(505, 190);
            this.dgvKullanListe.TabIndex = 4;
            // 
            // kullanMenu
            // 
            this.kullanMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleMenuItem,
            this.toolStripSeparator1,
            this.silMenuItem});
            this.kullanMenu.Name = "kullanMenu";
            this.kullanMenu.Size = new System.Drawing.Size(121, 54);
            // 
            // guncelleMenuItem
            // 
            this.guncelleMenuItem.Name = "guncelleMenuItem";
            this.guncelleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guncelleMenuItem.Text = "Güncelle";
            this.guncelleMenuItem.Click += new System.EventHandler(this.guncelleMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // silMenuItem
            // 
            this.silMenuItem.Name = "silMenuItem";
            this.silMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silMenuItem.Text = "Sil";
            this.silMenuItem.Click += new System.EventHandler(this.silMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.guncel;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(89, 186);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(36, 36);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(208, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Listesi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YeniKullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 240);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvKullanListe);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.tbAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniKullaniciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Kullanici İşlemleri";
            this.Load += new System.EventHandler(this.YeniKullaniciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanListe)).EndInit();
            this.kullanMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.DataGridView dgvKullanListe;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ContextMenuStrip kullanMenu;
        private System.Windows.Forms.ToolStripMenuItem guncelleMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem silMenuItem;
        private System.Windows.Forms.Label label4;
    }
}
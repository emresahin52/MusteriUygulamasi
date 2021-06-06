namespace MUSTERIAPPS
{
    partial class UrunStokGuncelleForm
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
            this.tbSatisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAlisFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMiktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbUrunTanimi = new System.Windows.Forms.TextBox();
            this.tbUrunKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSatisFiyat
            // 
            this.tbSatisFiyat.Enabled = false;
            this.tbSatisFiyat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyat.Location = new System.Drawing.Point(123, 220);
            this.tbSatisFiyat.MaxLength = 6;
            this.tbSatisFiyat.Name = "tbSatisFiyat";
            this.tbSatisFiyat.Size = new System.Drawing.Size(119, 24);
            this.tbSatisFiyat.TabIndex = 4;
            this.tbSatisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Satış Fiyatı :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAlisFiyat
            // 
            this.tbAlisFiyat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAlisFiyat.Location = new System.Drawing.Point(123, 178);
            this.tbAlisFiyat.MaxLength = 6;
            this.tbAlisFiyat.Name = "tbAlisFiyat";
            this.tbAlisFiyat.Size = new System.Drawing.Size(119, 24);
            this.tbAlisFiyat.TabIndex = 3;
            this.tbAlisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbAlisFiyat.Validating += new System.ComponentModel.CancelEventHandler(this.tbAlisFiyat_Validating);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alış Fiyatı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMiktar
            // 
            this.tbMiktar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMiktar.Location = new System.Drawing.Point(123, 134);
            this.tbMiktar.MaxLength = 6;
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(60, 24);
            this.tbMiktar.TabIndex = 2;
            this.tbMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ürün Miktarı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.guncel;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(272, 208);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(36, 36);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbUrunTanimi
            // 
            this.tbUrunTanimi.Enabled = false;
            this.tbUrunTanimi.Location = new System.Drawing.Point(123, 52);
            this.tbUrunTanimi.Multiline = true;
            this.tbUrunTanimi.Name = "tbUrunTanimi";
            this.tbUrunTanimi.Size = new System.Drawing.Size(180, 66);
            this.tbUrunTanimi.TabIndex = 1;
            // 
            // tbUrunKodu
            // 
            this.tbUrunKodu.Enabled = false;
            this.tbUrunKodu.Location = new System.Drawing.Point(123, 10);
            this.tbUrunKodu.MaxLength = 6;
            this.tbUrunKodu.Name = "tbUrunKodu";
            this.tbUrunKodu.Size = new System.Drawing.Size(86, 24);
            this.tbUrunKodu.TabIndex = 0;
            this.tbUrunKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Tanimi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Kodu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(243, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "₺";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(243, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "₺";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrunStokGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 256);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSatisFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAlisFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tbUrunTanimi);
            this.Controls.Add(this.tbUrunKodu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunStokGuncelleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Ürün Stok Güncelleme";
            this.Load += new System.EventHandler(this.UrunStokGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSatisFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAlisFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMiktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbUrunTanimi;
        public System.Windows.Forms.TextBox tbUrunKodu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
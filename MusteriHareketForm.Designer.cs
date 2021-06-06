namespace MUSTERIAPPS
{
    partial class MusteriHareketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSirketBilgi = new System.Windows.Forms.TextBox();
            this.tbMusteriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.dgvSatisListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSirketBilgi
            // 
            this.tbSirketBilgi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSirketBilgi.Enabled = false;
            this.tbSirketBilgi.Location = new System.Drawing.Point(352, 9);
            this.tbSirketBilgi.MaxLength = 150;
            this.tbSirketBilgi.Name = "tbSirketBilgi";
            this.tbSirketBilgi.Size = new System.Drawing.Size(349, 24);
            this.tbSirketBilgi.TabIndex = 1;
            // 
            // tbMusteriNo
            // 
            this.tbMusteriNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMusteriNo.Enabled = false;
            this.tbMusteriNo.Location = new System.Drawing.Point(129, 9);
            this.tbMusteriNo.MaxLength = 8;
            this.tbMusteriNo.Name = "tbMusteriNo";
            this.tbMusteriNo.Size = new System.Drawing.Size(100, 24);
            this.tbMusteriNo.TabIndex = 0;
            this.tbMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şirket Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Müşteri No :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::MUSTERIAPPS.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(734, 5);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(28, 28);
            this.btnAnaForm.TabIndex = 2;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            this.btnAnaForm.Click += new System.EventHandler(this.btnAnaForm_Click);
            // 
            // dgvSatisListe
            // 
            this.dgvSatisListe.AllowUserToAddRows = false;
            this.dgvSatisListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatisListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSatisListe.ColumnHeadersHeight = 25;
            this.dgvSatisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSatisListe.Location = new System.Drawing.Point(12, 39);
            this.dgvSatisListe.Name = "dgvSatisListe";
            this.dgvSatisListe.ReadOnly = true;
            this.dgvSatisListe.RowHeadersWidth = 25;
            this.dgvSatisListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvSatisListe.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSatisListe.RowTemplate.Height = 25;
            this.dgvSatisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatisListe.Size = new System.Drawing.Size(750, 270);
            this.dgvSatisListe.TabIndex = 17;
            // 
            // MusteriHareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 321);
            this.ControlBox = false;
            this.Controls.Add(this.dgvSatisListe);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.tbSirketBilgi);
            this.Controls.Add(this.tbMusteriNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriHareketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - Müşteri Satış Hareketleri";
            this.Load += new System.EventHandler(this.MusteriHareketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnaForm;
        private System.Windows.Forms.DataGridView dgvSatisListe;
        public System.Windows.Forms.TextBox tbSirketBilgi;
        public System.Windows.Forms.TextBox tbMusteriNo;
    }
}
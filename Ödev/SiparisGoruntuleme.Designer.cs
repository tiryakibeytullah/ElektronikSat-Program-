namespace Ödev
{
    partial class SiparisGoruntuleme
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilogram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odeme_durumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VERİLEN SİPARİŞLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urun,
            this.marka,
            this.adet,
            this.kilogram,
            this.renk,
            this.fiyat,
            this.gmail,
            this.odeme_durumu,
            this.tarih});
            this.dataGridView1.Location = new System.Drawing.Point(77, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(566, 253);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // urun
            // 
            this.urun.DataPropertyName = "urun";
            this.urun.HeaderText = "Urun";
            this.urun.Name = "urun";
            // 
            // marka
            // 
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "Marka";
            this.marka.Name = "marka";
            // 
            // adet
            // 
            this.adet.DataPropertyName = "adet";
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // kilogram
            // 
            this.kilogram.DataPropertyName = "kilogram";
            this.kilogram.HeaderText = "Kilogram";
            this.kilogram.Name = "kilogram";
            // 
            // renk
            // 
            this.renk.DataPropertyName = "renk";
            this.renk.HeaderText = "Renk";
            this.renk.Name = "renk";
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.HeaderText = "G-Mail";
            this.gmail.Name = "gmail";
            // 
            // odeme_durumu
            // 
            this.odeme_durumu.DataPropertyName = "odeme_durumu";
            this.odeme_durumu.HeaderText = "Ödeme Durumu";
            this.odeme_durumu.Name = "odeme_durumu";
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // SiparisGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "SiparisGoruntuleme";
            this.Size = new System.Drawing.Size(705, 414);
            this.Load += new System.EventHandler(this.UserControl8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn odeme_durumu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}

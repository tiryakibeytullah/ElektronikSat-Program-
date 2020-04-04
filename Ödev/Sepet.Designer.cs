namespace Ödev
{
    partial class Sepet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN SİLMEK İSTERSENİZ ÜRÜN İD\'NİZİ GİREREK SİLEBİLİRSİNİZ .";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sepeti Onayla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(596, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "→ ";
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
            this.urun.HeaderText = "Ürün";
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
            this.odeme_durumu.HeaderText = "Odeme Durumu";
            this.odeme_durumu.Name = "odeme_durumu";
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sepet";
            this.Size = new System.Drawing.Size(690, 403);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
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

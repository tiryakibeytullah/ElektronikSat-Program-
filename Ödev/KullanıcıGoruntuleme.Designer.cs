namespace Ödev
{
    partial class KullanıcıGoruntuleme
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
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(237, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICILAR\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ad,
            this.soyad,
            this.telefon,
            this.gmail,
            this.sifre,
            this.durum});
            this.dataGridView1.Location = new System.Drawing.Point(21, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // ad
            // 
            this.ad.DataPropertyName = "ad";
            this.ad.HeaderText = "Ad";
            this.ad.Name = "ad";
            // 
            // soyad
            // 
            this.soyad.DataPropertyName = "soyad";
            this.soyad.HeaderText = "Soyad";
            this.soyad.Name = "soyad";
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.HeaderText = "G-Mail";
            this.gmail.Name = "gmail";
            // 
            // sifre
            // 
            this.sifre.DataPropertyName = "sifre";
            this.sifre.HeaderText = "Şifre";
            this.sifre.Name = "sifre";
            this.sifre.Visible = false;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "Durum";
            this.durum.Name = "durum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kullanıcı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı silmek isterseniz,\r\nKullanıcı İd\'sini girerek silebilirsiniz ...";
            // 
            // KullanıcıGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KullanıcıGoruntuleme";
            this.Size = new System.Drawing.Size(628, 366);
            this.Load += new System.EventHandler(this.UserControl7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

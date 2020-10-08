namespace WindowsFormsApplication1
{
    partial class Ogrenci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciadi = new System.Windows.Forms.TextBox();
            this.ogrencisoyadi = new System.Windows.Forms.TextBox();
            this.veliadi = new System.Windows.Forms.TextBox();
            this.velisoyadi = new System.Windows.Forms.TextBox();
            this.velitel = new System.Windows.Forms.TextBox();
            this.velimail = new System.Windows.Forms.TextBox();
            this.velitc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ekle = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.txtTaksitSayisi = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ögrenci Adi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ögrenci Soyadi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Veli Adi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Veli Soyadi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Veli Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Veli E-posta :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Veli Tc :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kayit Tarihi :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1145, 256);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciadi
            // 
            this.ogrenciadi.Location = new System.Drawing.Point(147, 6);
            this.ogrenciadi.Name = "ogrenciadi";
            this.ogrenciadi.Size = new System.Drawing.Size(215, 20);
            this.ogrenciadi.TabIndex = 9;
            // 
            // ogrencisoyadi
            // 
            this.ogrencisoyadi.Location = new System.Drawing.Point(147, 39);
            this.ogrencisoyadi.Name = "ogrencisoyadi";
            this.ogrencisoyadi.Size = new System.Drawing.Size(215, 20);
            this.ogrencisoyadi.TabIndex = 10;
            // 
            // veliadi
            // 
            this.veliadi.Location = new System.Drawing.Point(147, 69);
            this.veliadi.Name = "veliadi";
            this.veliadi.Size = new System.Drawing.Size(215, 20);
            this.veliadi.TabIndex = 11;
            // 
            // velisoyadi
            // 
            this.velisoyadi.Location = new System.Drawing.Point(147, 103);
            this.velisoyadi.Name = "velisoyadi";
            this.velisoyadi.Size = new System.Drawing.Size(215, 20);
            this.velisoyadi.TabIndex = 12;
            // 
            // velitel
            // 
            this.velitel.Location = new System.Drawing.Point(147, 138);
            this.velitel.Name = "velitel";
            this.velitel.Size = new System.Drawing.Size(215, 20);
            this.velitel.TabIndex = 13;
            // 
            // velimail
            // 
            this.velimail.Location = new System.Drawing.Point(611, 5);
            this.velimail.Name = "velimail";
            this.velimail.Size = new System.Drawing.Size(215, 20);
            this.velimail.TabIndex = 14;
            // 
            // velitc
            // 
            this.velitc.Location = new System.Drawing.Point(611, 38);
            this.velitc.Name = "velitc";
            this.velitc.Size = new System.Drawing.Size(215, 20);
            this.velitc.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(611, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(147, 182);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(152, 54);
            this.ekle.TabIndex = 17;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(373, 182);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(152, 54);
            this.guncelle.TabIndex = 18;
            this.guncelle.Text = "Guncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(598, 182);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(162, 54);
            this.sil.TabIndex = 19;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // txtTaksitSayisi
            // 
            this.txtTaksitSayisi.Location = new System.Drawing.Point(611, 106);
            this.txtTaksitSayisi.Name = "txtTaksitSayisi";
            this.txtTaksitSayisi.Size = new System.Drawing.Size(215, 20);
            this.txtTaksitSayisi.TabIndex = 0;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(611, 69);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(215, 20);
            this.txtUcret.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(479, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Taksit Sayısı :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(479, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ücret :";
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 513);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtTaksitSayisi);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.velitc);
            this.Controls.Add(this.velimail);
            this.Controls.Add(this.velitel);
            this.Controls.Add(this.velisoyadi);
            this.Controls.Add(this.veliadi);
            this.Controls.Add(this.ogrencisoyadi);
            this.Controls.Add(this.ogrenciadi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci";
            this.Text = "ögrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ogrenciadi;
        private System.Windows.Forms.TextBox ogrencisoyadi;
        private System.Windows.Forms.TextBox veliadi;
        private System.Windows.Forms.TextBox velisoyadi;
        private System.Windows.Forms.TextBox velitel;
        private System.Windows.Forms.TextBox velimail;
        private System.Windows.Forms.TextBox velitc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox txtTaksitSayisi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
namespace WindowsFormsApplication1
{
    partial class OdemeGir
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
            this.dgOgrenciOdeme = new System.Windows.Forms.DataGridView();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.btnOdemeGuncelle = new System.Windows.Forms.Button();
            this.dtOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.cbTasarim = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOgrenciOdeme
            // 
            this.dgOgrenciOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOgrenciOdeme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgOgrenciOdeme.Location = new System.Drawing.Point(0, 212);
            this.dgOgrenciOdeme.Name = "dgOgrenciOdeme";
            this.dgOgrenciOdeme.Size = new System.Drawing.Size(970, 247);
            this.dgOgrenciOdeme.TabIndex = 0;
            this.dgOgrenciOdeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOgrenciOdeme_CellContentClick);
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(215, 19);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(200, 20);
            this.txtOgrenciID.TabIndex = 1;
            // 
            // btnOdemeGuncelle
            // 
            this.btnOdemeGuncelle.Location = new System.Drawing.Point(238, 163);
            this.btnOdemeGuncelle.Name = "btnOdemeGuncelle";
            this.btnOdemeGuncelle.Size = new System.Drawing.Size(134, 23);
            this.btnOdemeGuncelle.TabIndex = 2;
            this.btnOdemeGuncelle.Text = "Ödeme Yap";
            this.btnOdemeGuncelle.UseVisualStyleBackColor = true;
            this.btnOdemeGuncelle.Click += new System.EventHandler(this.btnOdemeGuncelle_Click);
            // 
            // dtOdemeTarihi
            // 
            this.dtOdemeTarihi.Location = new System.Drawing.Point(215, 88);
            this.dtOdemeTarihi.Name = "dtOdemeTarihi";
            this.dtOdemeTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtOdemeTarihi.TabIndex = 3;
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.Location = new System.Drawing.Point(215, 122);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.Size = new System.Drawing.Size(200, 20);
            this.txtOdemeTutari.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ogrenci ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ödeme Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeme Tutari :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ogrenci Adi :";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Location = new System.Drawing.Point(215, 53);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(200, 20);
            this.txtOgrenciAdi.TabIndex = 9;
            // 
            // cbTasarim
            // 
            this.cbTasarim.AutoSize = true;
            this.cbTasarim.Location = new System.Drawing.Point(38, 163);
            this.cbTasarim.Name = "cbTasarim";
            this.cbTasarim.Size = new System.Drawing.Size(93, 17);
            this.cbTasarim.TabIndex = 10;
            this.cbTasarim.Text = "Tasarım Modu";
            this.cbTasarim.UseVisualStyleBackColor = true;
            // 
            // OdemeGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 459);
            this.Controls.Add(this.cbTasarim);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.dtOdemeTarihi);
            this.Controls.Add(this.btnOdemeGuncelle);
            this.Controls.Add(this.txtOgrenciID);
            this.Controls.Add(this.dgOgrenciOdeme);
            this.Name = "OdemeGir";
            this.Text = "OdemeGir";
            this.Load += new System.EventHandler(this.OdemeGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOgrenciOdeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOgrenciOdeme;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Button btnOdemeGuncelle;
        private System.Windows.Forms.DateTimePicker dtOdemeTarihi;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
        private System.Windows.Forms.CheckBox cbTasarim;
    }
}
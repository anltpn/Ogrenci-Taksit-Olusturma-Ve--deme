namespace WindowsFormsApplication1
{
    partial class AnaForm
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
            this.ögrenci = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ögrenci
            // 
            this.ögrenci.Location = new System.Drawing.Point(22, 49);
            this.ögrenci.Name = "ögrenci";
            this.ögrenci.Size = new System.Drawing.Size(131, 54);
            this.ögrenci.TabIndex = 0;
            this.ögrenci.Text = "Ögrenci";
            this.ögrenci.UseVisualStyleBackColor = true;
            this.ögrenci.Click += new System.EventHandler(this.ögrenci_Click);
            // 
            // btnOdemeler
            // 
            this.btnOdemeler.Location = new System.Drawing.Point(181, 49);
            this.btnOdemeler.Name = "btnOdemeler";
            this.btnOdemeler.Size = new System.Drawing.Size(120, 54);
            this.btnOdemeler.TabIndex = 1;
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 192);
            this.Controls.Add(this.btnOdemeler);
            this.Controls.Add(this.ögrenci);
            this.Name = "AnaForm";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ögrenci;
        private System.Windows.Forms.Button btnOdemeler;
    }
}


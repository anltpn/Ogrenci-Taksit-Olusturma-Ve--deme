namespace WindowsFormsApplication1
{
    partial class Odemeler
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
            this.dgOdemeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOdemeler
            // 
            this.dgOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOdemeler.Location = new System.Drawing.Point(0, 0);
            this.dgOdemeler.Name = "dgOdemeler";
            this.dgOdemeler.Size = new System.Drawing.Size(730, 381);
            this.dgOdemeler.TabIndex = 0;
            this.dgOdemeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOdemeler_CellContentClick);
            // 
            // Odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 381);
            this.Controls.Add(this.dgOdemeler);
            this.Name = "Odemeler";
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.Odemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOdemeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOdemeler;
    }
}
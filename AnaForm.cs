using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ögrenci_Click(object sender, EventArgs e)
        {
            Ogrenci frm = new Ogrenci();
            frm.ShowDialog();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            Odemeler frm = new Odemeler();
            frm.ShowDialog();
        }

     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }

        private void dgOdemeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int OgrenciID = 0;


            int deger = dgOdemeler.CurrentCell.RowIndex;

            OgrenciID = int.Parse(dgOdemeler.Rows[deger].Cells["OgrenciID"].Value.ToString());
            OdemeGir OdemeGir = new OdemeGir();
            OdemeGir.a = dgOdemeler.CurrentRow.Cells[0].Value.ToString();
            OdemeGir.b = dgOdemeler.CurrentRow.Cells[1].Value.ToString();

            OdemeGir.Show();
            Odemeler_Load(sender, e);

        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"(select 
  
                                                      ob.OgrenciID,
                                                      ob.OgrenciAdi+' '+ob.OgrenciSoyadi as AdSoyad,
                                                      ob.Ucret,
                                                      ob.TaksitSayisi,

                                                       (select count(*) from Taksitler where OgrenciID = ob.OgrenciID and OdemeDurumu=1) as OdenenTaksit,
                                                      (select SUM(TaksitTutari) from Taksitler where OgrenciID = ob.OgrenciID and OdemeDurumu=1) as OdenenTutar,
                                                      ob.Ucret -(select SUM(TaksitTutari) from Taksitler where OgrenciID = ob.OgrenciID and OdemeDurumu=1) as KalanTutar,
                                                      ob.TaksitSayisi -(select count(*) from Taksitler where OgrenciID = ob.OgrenciID and OdemeDurumu=1) as KalanTaksit
                                                      from OgrenciBilgileri ob)", vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgOdemeler.DataSource = dt;
            
        }

    }
}

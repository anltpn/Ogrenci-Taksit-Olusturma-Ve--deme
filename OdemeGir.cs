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
    public partial class OdemeGir : Form
    {
        public OdemeGir()
        {
            InitializeComponent();
        }
        private void btnOdemeGuncelle_Click(object sender, EventArgs e)
        {
            
            txtOgrenciID.Text = a;
            
                if (vt.con.State != ConnectionState.Open)
                    vt.con.Open();

                SqlCommand kod = new SqlCommand(@"update Taksitler set OdemeTarihi=@OdemeTarihi, OdemeDurumu = 1 
                                                where TaksitlerID =@TaksitlerID and OgrenciID="+a.ToString(), vt.con);

                kod.Parameters.AddWithValue("OgrenciID", OgrenciID);
                kod.Parameters.AddWithValue("TaksitlerID", TaksitlerID);
                kod.Parameters.AddWithValue("OdemeTarihi", dtOdemeTarihi.Value);
                kod.Parameters.AddWithValue("TaksitTutari", txtOdemeTutari.Text);
                txtOdemeTutari.Text = "";

                kod.ExecuteNonQuery();
                OdemeGir_Load(sender, e);

                SqlDataAdapter da = new SqlDataAdapter("[spOgrenciOlustur]", vt.baglanti);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;


                da.SelectCommand.Parameters.AddWithValue("OgrenciID",txtOgrenciID.Text.ToString());

                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "Ogrenci";

                Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
                report.Load("raporlar/ogrenci.mrt");
                report.RegData(dt);

                if (cbTasarim.Checked)
                {
                    report.Design();
                }
                else
                {
                    report.Render(false);
                    report.Show();
                }
                report.ClearAllStates();
                

        }
        public string a,b;

        private void OdemeGir_Load(object sender, EventArgs e)
        {
            txtOgrenciID.Text = a;
            txtOgrenciAdi.Text = b;

            SqlDataAdapter da = new SqlDataAdapter(@"SELECT 
                                                        t.TaksitlerID,
                                                        ob.OgrenciID,	
                                                        ob.OgrenciAdi+' '+ob.OgrenciSoyadi as AdSoyad,
                                                        ob.Ucret as Ücret,
                                                        ob.TaksitSayisi as TaksitSayisi,
                                                        t.TaksitTutari,
                                                        t.OdemeTarihi,
                                                        t.OdemeDurumu,
                                                        case when t.OdemeDurumu = 1 then 'Ödeme Yapıldı' else 'Ödeme Yapılmadı' end as OdemeDurum



                                                          FROM [OdevEvProje].[dbo].[Taksitler] t
                                                          INNER JOIN OgrenciBilgileri ob on ob.OgrenciID = t.OgrenciID
                                                          where ob.OgrenciID="+a.ToString(), vt.baglanti);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgOgrenciOdeme.DataSource = dt;
        }

        int OgrenciID, TaksitlerID;
        private void dgOgrenciOdeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int deger = dgOgrenciOdeme.CurrentCell.RowIndex;
            txtOdemeTutari.Text = dgOgrenciOdeme.Rows[deger].Cells["TaksitTutari"].Value.ToString();
            OgrenciID = int.Parse(dgOgrenciOdeme.Rows[deger].Cells["OgrenciID"].Value.ToString());
            TaksitlerID = int.Parse(dgOgrenciOdeme.Rows[deger].Cells["TaksitlerID"].Value.ToString());

        }
    }
}

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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

       

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from OgrenciBilgileri", vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            guncelle.Enabled = false;
            sil.Enabled = false;
            ogrenciadi.Text = "";
            ogrencisoyadi.Text = "";
            veliadi.Text = "";
            velisoyadi.Text = "";
            velitel.Text = "";
            velimail.Text = "";
            velitc.Text = "";
            txtUcret.Text = "";
            txtTaksitSayisi.Text = "";
            dateTimePicker1.Text = "";
            
        }

        private void ekle_Click(object sender, EventArgs e)
        {
           if (vt.con.State != ConnectionState.Open)
                vt.con.Open();

           SqlCommand kod = new SqlCommand(@"insert into OgrenciBilgileri (OgrenciAdi,OgrenciSoyadi,VeliAdi,VeliSoyadi,VeliTelefon,VeliMail,VeliTc,Ucret,TaksitSayisi,KayitTarihi)
                                                values (@OgrenciAdi,@OgrenciSoyadi,@VeliAdi,@VeliSoyadi,@VeliTelefon,@VeliMail,@VeliTc,@Ucret,@TaksitSayisi,@KayitTarihi)", vt.con);

            kod.Parameters.AddWithValue("OgrenciAdi", ogrenciadi.Text);
            kod.Parameters.AddWithValue("OgrenciSoyadi", ogrencisoyadi.Text);
            kod.Parameters.AddWithValue("VeliAdi", veliadi.Text);
            kod.Parameters.AddWithValue("VeliSoyadi", velisoyadi.Text);
            kod.Parameters.AddWithValue("VeliTelefon", velitel.Text);
            kod.Parameters.AddWithValue("VeliMail", velimail.Text);
            kod.Parameters.AddWithValue("VeliTc", velitc.Text);
            kod.Parameters.AddWithValue("Ucret", txtUcret.Text);
            kod.Parameters.AddWithValue("TaksitSayisi", txtTaksitSayisi.Text);
            kod.Parameters.AddWithValue("KayitTarihi", dateTimePicker1.Value);

            kod.ExecuteNonQuery();
            vt.con.Close();

            /*Taksitler eklenir.*/

            TaksitleriEkle(OgrenciIDBul());


            Ogrenci_Load(sender, e);
        }

        /*Eklenen Öğrenci ID'sini geri Döner*/
        public int OgrenciIDBul()
        {
            int ogrenciID = 0;

            if (vt.con.State != ConnectionState.Open)
                vt.con.Open();

            SqlCommand kod = new SqlCommand(@"SELECT TOP 1 [OgrenciID] FROM [OdevEvProje].[dbo].[OgrenciBilgileri] order by OgrenciID desc", vt.con);

            SqlDataReader reader = kod.ExecuteReader();
            if (reader.Read())
            {
                ogrenciID = Convert.ToInt32(reader["OgrenciID"]);
            }



            vt.con.Close();
            return ogrenciID;
        }

        /*Taksitleri eklemek için kullanılan metot. Öğrenci ilk kayıt sırasında taksitler sisteme kaydedilir.*/
        public void TaksitleriEkle(int ogrenciID)
        {
            if (vt.con.State != ConnectionState.Open)
                vt.con.Open();
        
            int taksitSayisi = Convert.ToInt32(txtTaksitSayisi.Text);
            decimal ucret = Convert.ToDecimal(txtUcret.Text);
            decimal taksitTutari = ucret / taksitSayisi;

           
     
            for (int i = 0; i < taksitSayisi; i++)
            {
                SqlCommand kod = new SqlCommand(@"insert into Taksitler (OgrenciID,TaksitTutari,OdemeDurumu)
                                                values (@OgrenciID,@TaksitTutari,0)", vt.con);

                kod.Parameters.AddWithValue("OgrenciID", ogrenciID);
                kod.Parameters.AddWithValue("TaksitTutari", taksitTutari.ToString());
                kod.ExecuteNonQuery();
            }


      
            vt.con.Close();
        }

        
        int OgrenciID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            OgrenciID = int.Parse(dataGridView1.Rows[deger].Cells["OgrenciID"].Value.ToString());
            ogrenciadi.Text = dataGridView1.Rows[deger].Cells["OgrenciAdi"].Value.ToString();
            ogrencisoyadi.Text = dataGridView1.Rows[deger].Cells["OgrenciSoyadi"].Value.ToString();
            veliadi.Text = dataGridView1.Rows[deger].Cells["VeliAdi"].Value.ToString();
            velisoyadi.Text = dataGridView1.Rows[deger].Cells["VeliSoyadi"].Value.ToString();
            velitel.Text = dataGridView1.Rows[deger].Cells["VeliTelefon"].Value.ToString();
            velimail.Text = dataGridView1.Rows[deger].Cells["VeliMail"].Value.ToString();
            velitc.Text = dataGridView1.Rows[deger].Cells["VeliTc"].Value.ToString();
            txtUcret.Text = dataGridView1.Rows[deger].Cells["Ucret"].Value.ToString();
            txtTaksitSayisi.Text = dataGridView1.Rows[deger].Cells["TaksitSayisi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[deger].Cells["KayitTarihi"].Value.ToString();
            guncelle.Enabled = true;
            sil.Enabled = true;
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Güncellemek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (vt.con.State != ConnectionState.Open)
                    vt.con.Open();
                
                SqlCommand kod = new SqlCommand(@"update OgrenciBilgileri
                                              set OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,VeliAdi=@VeliAdi,VeliSoyadi=@VeliSoyadi,VeliTelefon=@VeliTelefon,VeliMail=@VeliMail,VeliTc=@VeliTc,KayitTarihi=@KayitTarihi
                                              where OgrenciID=@OgrenciID", vt.con);
                kod.Parameters.AddWithValue("OgrenciID", OgrenciID);
                kod.Parameters.AddWithValue("OgrenciAdi", ogrenciadi.Text);
                kod.Parameters.AddWithValue("OgrenciSoyadi", ogrencisoyadi.Text);
                kod.Parameters.AddWithValue("VeliAdi", veliadi.Text);
                kod.Parameters.AddWithValue("VeliSoyadi", velisoyadi.Text);
                kod.Parameters.AddWithValue("VeliTelefon", velitel.Text);
                kod.Parameters.AddWithValue("VeliMail", velimail.Text);
                kod.Parameters.AddWithValue("VeliTc", velitc.Text);
                //kod.Parameters.AddWithValue("Ucret", txtUcret.Text);
                //kod.Parameters.AddWithValue("TaksitSayisi", txtTaksitSayisi.Text);
                kod.Parameters.AddWithValue("KayitTarihi", dateTimePicker1.Value);

                kod.ExecuteNonQuery();
                Ogrenci_Load(sender, e);
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (vt.con.State != ConnectionState.Open)
                    vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from OgrenciBilgileri
                                              where OgrenciID=@OgrenciID
                                              delete from Taksitler
                                              where OgrenciID=@OgrenciID", vt.con);
                kod.Parameters.AddWithValue("OgrenciID", OgrenciID);
                kod.ExecuteNonQuery();
                Ogrenci_Load(sender, e);
            }
        }

             

    }
}

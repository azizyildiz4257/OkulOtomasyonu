using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DevExpress.XtraGrid.Registrator;
using System.Diagnostics;

namespace OkulOtomasyonu
{
    public partial class Frm_Ayarlar : DevExpress.XtraEditors.XtraForm
    {
        SQLBaglantim bgl = new SQLBaglantim();
        Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities();

        public Frm_Ayarlar()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            Txt_OgrtID.Text = "";
            Txt_OgrncID.Text = "";
            Txt_Brans.Text = "";
            Txt_OgrncSinif.Text = "";
            Txt_Sifre.Text = "";
            Txt_OgrncSifre.Text = "";
            Txt_OgrncTC.Text = "";
            Txt_TcKimlik.Text = "";
            pictureEdit1.Text = "";
            pictureEdit2.Text = "";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz...";
            lookUpEdit2.Properties.NullText = "Öğrenci Seçiniz...";
        }

        //ADO.NET Öğrertmen Şifre Bilgileri
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Execute AyarlarOgretmenler", bgl.Baglan());
            dataAdapter.Fill(dt);
            gridControl1.DataSource = dt;
        }

        //Entity Framework Ogrenci Listele
        void OgrListele()  //Ders 45 09:43
        {
            gridControl2.DataSource = db.AyarlarOgrenciler();
        }


        //ADO.NET LookUpEdit Aracı veri Getirme
        void OgretmenListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select OgrtID,(OgrtAd+' '+OgrtSoyad) as 'OgrtAdSoyad',OgrtBrans from Tbl_Ogretmenler", bgl.Baglan());
            dataAdapter.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "OgrtID";
            lookUpEdit1.Properties.DisplayMember = "OgrtAdSoyad";
            lookUpEdit1.Properties.NullText = "Öğretmen Seçiniz...";
            lookUpEdit1.Properties.DataSource = dt;
        }

        //Entity Framework LookUpEdit Aracı veri Getirme
        void OgrenciListesi()   //Ders 46 07:38
        {
            var model = from item in db.Tbl_Ogrenciler
                        select new
                        {
                            OgrncID = item.OgrncID,
                            OgrAdSoyad = item.OgrncAd + " " + item.OgrncSoyad,
                            OgrSinif = item.OgrncSinif,
                        };
            lookUpEdit2.Properties.ValueMember = "OgrID";
            lookUpEdit2.Properties.DisplayMember = "OgrAdSoyad";
            lookUpEdit2.Properties.NullText = "Öğrenci Seçiniz...";
            lookUpEdit2.Properties.DataSource = model.ToList();
        }

        private void Frm_Ayarlar_Load(object sender, EventArgs e)
        {
            Listele();
            OgretmenListesi();
            Temizle();
            OgrListele();
            OgrenciListesi();
        }


        //ADO.NET ile GridControl verilerini Araçlara Taşıma
        public string yeniyol;
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Txt_OgrtID.Text = dr["AyarlarID"].ToString();
                lookUpEdit1.Text = dr["OgrtAdSoyad"].ToString();
                Txt_Brans.Text = dr["OgrtBrans"].ToString();
                Txt_TcKimlik.Text = dr["OgrtTC"].ToString();
                Txt_Sifre.Text = dr["OgrtSifre"].ToString();
                //yeniyol;  Ders 41 10:55 izle foto aktarma
            }
        }

        //ADO.NET ile LookUpEdit Seçimi Sonrası Verilerin Düzeltilmesi
        private void lookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Txt_Sifre.Text = "";
            SqlCommand komut = new SqlCommand("Select * From Tbl_Ogretmenler where OgrtID=@p1", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", lookUpEdit1.ItemIndex + 1);    //İndex 0 dan başladıgı için +1 yaptık. Ders 42 4:37
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Txt_OgrtID.Text = dr["OgrtID"].ToString();
                Txt_Brans.Text = dr["OgrtBrans"].ToString();
                Txt_TcKimlik.Text = dr["OgrtTC"].ToString();
                //yeniyol;  Ders 42 07:28 izle foto aktarma
            }
            bgl.Baglan().Close();
        }

        //Ogretmenler Sifre Kaydet
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Ayarlar (AyarlarID, OgrtSifre) values (@p1,@p2)", bgl.Baglan());
            komut.Parameters.AddWithValue("@1", Txt_OgrtID.Text);
            komut.Parameters.AddWithValue("@2", Txt_Sifre.Text);
            komut.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Şifre Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        //Ogretmenler Sifre Guncelle
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Ayarlar set OgrtSifre=@p1 where AyarlarID=@p2", bgl.Baglan());
            komut.Parameters.AddWithValue("@p1", Txt_Sifre.Text);
            komut.Parameters.AddWithValue("@p2", Txt_OgrtID.Text);
            komut.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            Txt_OgrncID.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AyarlarOGRID").ToString();
            lookUpEdit2.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrAdSoyad").ToString();
            Txt_OgrncSinif.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrncSinif").ToString();
            Txt_OgrncTC.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrncTC").ToString();
            Txt_OgrncSifre.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrSifre").ToString();
            string dosyayolu = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "OgrncFoto").ToString();
            //yeniyol;  Ders 47 10:53 izle foto aktarma
        }

        //ADO.NET ile LookUpEdit Seçimi Sonrası Verilerin Txtlere Getirilemsi
        private void lookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            Txt_OgrncSifre.Text = "";
            using (Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities())
            {
                Tbl_Ogrenciler sorgu = db.Tbl_Ogrenciler.Find(lookUpEdit2.ItemIndex + 1);
                Txt_OgrncID.Text = sorgu.OgrncID.ToString();
                Txt_OgrncSinif.Text = sorgu.OgrncSinif;
                Txt_OgrncTC.Text = sorgu.OgrncTC;
                //yeniyol;  Ders 48 07:45 foto aktarma
                //pictureEdit2.Image = Image.FromFile(yeniyol);
            }
        }

        private void Btn_OgrncKaydet_Click(object sender, EventArgs e)
        {
            Tbl_OgrAyarlar komut = new Tbl_OgrAyarlar();
            komut.AyarlarOGRID = int.Parse(Txt_OgrncID.Text);
            komut.OgrSifre = Txt_OgrncSifre.Text;
            db.Tbl_OgrAyarlar.Add(komut);
            db.SaveChanges();
            MessageBox.Show("Şifre Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgrListele();
            Temizle();
        }

        private void Btn_OgrncGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "AyarlarOGRID"));
            var item = db.Tbl_OgrAyarlar.FirstOrDefault(x => x.AyarlarOGRID == id);
            item.OgrSifre = Txt_OgrncSifre.Text;
            db.SaveChanges();
            MessageBox.Show("Şifre Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OgrListele();
            Temizle();
        }

        private void Btn_OgrncTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
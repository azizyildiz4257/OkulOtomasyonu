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
using DevExpress.XtraEditors.Controls;

namespace OkulOtomasyonu
{
    public partial class Frm_Ogrenciler : Form
    {
        public Frm_Ogrenciler()
        {
            InitializeComponent();
        }
#pragma warning disable IDE0044 // Add readonly modifier
        SQLBaglantim bgl = new SQLBaglantim();
#pragma warning restore IDE0044 // Add readonly modifier

        void Listele()
        {
            //5.Sınıf
            DataTable dt1 = new DataTable();
            //SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Ogrenciler where OgrncSinif='5. Sınıf'", bgl.Baglan());
            SqlDataAdapter da1 = new SqlDataAdapter("Execute OgrenciVeli5", bgl.Baglan());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

            //6.Sınıf
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute OgrenciVeli6", bgl.Baglan());
            //SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Ogrenciler where OgrncSinif='6. Sınıf'", bgl.Baglan());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            //7.Sınıf
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute OgrenciVeli7", bgl.Baglan());
            //SqlDataAdapter da3 = new SqlDataAdapter("Select * From Tbl_Ogrenciler where OgrncSinif='7. Sınıf'", bgl.Baglan());
            da3.Fill(dt3);
            gridControl3.DataSource = dt3;

            //8.Sınıf
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Execute OgrenciVeli8", bgl.Baglan());
            //SqlDataAdapter da4 = new SqlDataAdapter("Select * From Tbl_Ogrenciler where OgrncSinif='8. Sınıf'", bgl.Baglan());
            da4.Fill(dt4);
            gridControl4.DataSource = dt4;
        }

        void VeliListesi()      /*Ders 30 8:50*/
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select VeliID,(VeliAnne+' | '+VeliBaba) as VeliAnneBaba from Tbl_Veliler", bgl.Baglan());
            da.Fill(dt1);
            LUECmb_Veli.Properties.ValueMember = "VeliID";
            LUECmb_Veli.Properties.DisplayMember = "VeliAnneBaba";
            LUECmb_Veli.Properties.DataSource = dt1;
        }

        void SehirEkle()
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Iller", bgl.Baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_İl.Properties.Items.Add(dr[1]);     /*1 sütun sayısı*/
            }
            bgl.Baglan().Close();
        }

        private void Frm_Ogrenciler_Load(object sender, EventArgs e)
        {
            Listele();
            SehirEkle();
            Temizle();
            VeliListesi();
        }

        private void Cmb_İl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_İlce.Properties.Items.Clear();
            Cmb_İlce.Text = "";

            SqlCommand cmd = new SqlCommand("Select * From Tbl_ILceler where sehir=@p1", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Cmb_İl.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_İlce.Properties.Items.Add(dr[1].ToString());
            }
            bgl.Baglan().Close();
        }

        public string cinsiyet;
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Ogrenciler(OgrncAd,OgrncSoyad,OgrncNo,OgrncSinif,OgrncDogumTarihi,OgrncCinsiyet,OgrncTC,OgrncSehir,OgrncIlce,OgrncAdres,OgrncFoto,OgrncVeliID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Txt_Adi.Text);
            cmd.Parameters.AddWithValue("@p2", Txt_Soyadi.Text);
            cmd.Parameters.AddWithValue("@p3", MskTxt_OgrNo.Text);
            cmd.Parameters.AddWithValue("@p4", Cmb_OgrSinif.Text);
            cmd.Parameters.AddWithValue("@p5", Cmb_DogTar.Text);
            if (RBtn_Erkek.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else /*if (RBtn_Bayan.Checked == true)*/
            {
                cmd.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }
            cmd.Parameters.AddWithValue("@p7", MskTxt_TCNo.Text);
            cmd.Parameters.AddWithValue("@p8", Cmb_İl.Text);
            cmd.Parameters.AddWithValue("@p9", Cmb_İlce.Text);
            cmd.Parameters.AddWithValue("@p10", RchTxt_Adres.Text);
            cmd.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            cmd.Parameters.AddWithValue("@p12", LUECmb_Veli.EditValue);

            cmd.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        void TextAktarma()      /*Sadece 5.Sınınf aktarımı yapıyro kontrol et Ders 32*/
        {
            if (dr != null)
            {
                Txt_ID.Text = dr["OgrncID"].ToString();
                Txt_Adi.Text = dr["OgrncAd"].ToString();
                Txt_Soyadi.Text = dr["OgrncSoyad"].ToString();
                MskTxt_TCNo.Text = dr["OgrncTC"].ToString();
                MskTxt_OgrNo.Text = dr["OgrncNo"].ToString();
                Cmb_OgrSinif.Text = dr["OgrncSinif"].ToString();
                if (dr["OgrncCinsiyet"].ToString() == "E")
                {
                    //RBtn_Bayan.Checked = false;
                    RBtn_Erkek.Checked = true;
                }
                else if (dr["OgrncCinsiyet"].ToString() == "B")
                {
                    //RBtn_Erkek.Checked = false;
                    RBtn_Bayan.Checked = true;
                }
                Cmb_İl.Text = dr["OgrncSehir"].ToString();
                Cmb_İlce.Text = dr["OgrncIlce"].ToString();
                Cmb_DogTar.Text = dr["OgrncDogumTarihi"].ToString();
                RchTxt_Adres.Text = dr["OgrncAdres"].ToString();
                yeniyol = "C:\\Users\\Aziz YILDIZ\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler" + dr["OgrncFoto"].ToString();
                //Pct_Resim.Image = Image.FromFile(yeniyol); 
                PctBox_Resim.ImageLocation = yeniyol;
                LUECmb_Veli.Text = dr["VeliAnneBaba"].ToString();
            }
        }

        void Temizle()
        {
            Txt_ID.Text = "";
            Txt_Adi.Text = "";
            Txt_Soyadi.Text = "";
            MskTxt_OgrNo.Text = "";
            RBtn_Erkek.Checked = false;
            RBtn_Bayan.Checked = false;
            MskTxt_TCNo.Text = "";
            RchTxt_Adres.Text = "";
            Cmb_İl.Text = "";
            Cmb_İlce.Text = "";
            Cmb_DogTar.Text = "";
            Cmb_OgrSinif.Text = "";
            Pct_Resim.Text = "";
        }

        DataRow dr;

        private void Grd_5sinif_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            dr = Grd_5sinif.GetDataRow(Grd_5sinif.FocusedRowHandle);  /*İlgili tıklanan satır*/
            TextAktarma();
        }

        private void Grd_6sinif_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            dr = Grd_6sinif.GetDataRow(Grd_6sinif.FocusedRowHandle);  /*İlgili tıklanan satır*/
            TextAktarma();
        }

        private void Grd_7sinif_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            dr = Grd_7sinif.GetDataRow(Grd_7sinif.FocusedRowHandle);  /*İlgili tıklanan satır*/
            TextAktarma();
        }

        private void Grd_8sinif_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            dr = Grd_8sinif.GetDataRow(Grd_8sinif.FocusedRowHandle);  /*İlgili tıklanan satır*/
            TextAktarma();
        }

        public string yeniyol;

        private void Btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog/*aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa*/
            {
                Filter = "REsim Dosyası |*.jpg;*.png;*.nef | Tüm Dosyalar |*.*"
            };
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            yeniyol = "C:\\Users\\Aziz YILDIZ\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler" + Guid.NewGuid().ToString() + ".jpg";
            File.Copy(dosyayolu, yeniyol);  /*Mevcut dosya yolundan yeni yola kopyalama işlemini yapıyor.*/
            Pct_Resim.Image = Image.FromFile(yeniyol);
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Ogrenciler set OgrncAd=@p1,OgrncSoyad=@p2,OgrncNo=@p3,OgrncSinif=@p4,OgrncDogumTarihi=@p5,OgrncCinsiyet=@p6,OgrncTC=@p7,OgrncSehir=@p8,OgrncIlce=@p9,OgrncAdres=@p10,OgrncFoto=@p11, OgrncVeliID=@p13 where OgrncID=@p12", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Txt_Adi.Text);
            cmd.Parameters.AddWithValue("@p2", Txt_Soyadi.Text);
            cmd.Parameters.AddWithValue("@p3", MskTxt_OgrNo.Text);
            cmd.Parameters.AddWithValue("@p4", Cmb_OgrSinif.Text);
            cmd.Parameters.AddWithValue("@p5", Cmb_DogTar.Text);
            if (RBtn_Erkek.Checked == true)
            {
                cmd.Parameters.AddWithValue("@p6", cinsiyet = "E");
            }
            else /*if (RBtn_Bayan.Checked == true)*/
            {
                cmd.Parameters.AddWithValue("@p6", cinsiyet = "B");
            }
            cmd.Parameters.AddWithValue("@p7", MskTxt_TCNo.Text);
            cmd.Parameters.AddWithValue("@p8", Cmb_İl.Text);
            cmd.Parameters.AddWithValue("@p9", Cmb_İlce.Text);
            cmd.Parameters.AddWithValue("@p10", RchTxt_Adres.Text);
            cmd.Parameters.AddWithValue("@p11", Path.GetFileName(yeniyol));
            cmd.Parameters.AddWithValue("@p12", Txt_ID.Text);
            cmd.Parameters.AddWithValue("@p13", LUECmb_Veli.EditValue);
            cmd.ExecuteNonQuery();
            bgl.Baglan().Close();
            MessageBox.Show("Öğrenci bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Ogrenciler where OgrncID=@p1", bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Txt_ID.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Öğrenci bilgileri silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

#pragma warning disable IDE0044 // Add readonly modifier
        Frm_NüfusCüzdani frm = new Frm_NüfusCüzdani();
#pragma warning restore IDE0044 // Add readonly modifier
        void LabelAktarma()
        {
            frm.TC = dr["OgrncTC"].ToString();
            frm.Adi = dr["OgrncAd"].ToString();
            frm.Soyadi = dr["OgrncSoyad"].ToString();
            frm.DogumTarihi = dr["OgrncDogumTarihi"].ToString();
            frm.Cinsiyet = dr["OgrncCinsiyet"].ToString();
        }

        private void Grd_5sinif_DoubleClick(object sender, EventArgs e)
        {
            dr = Grd_5sinif.GetDataRow(Grd_5sinif.FocusedRowHandle);
            LabelAktarma();
        }

        private void Grd_6sinif_DoubleClick(object sender, EventArgs e)
        {
            dr = Grd_6sinif.GetDataRow(Grd_6sinif.FocusedRowHandle);
            LabelAktarma();
        }

        private void Grd_7sinif_DoubleClick(object sender, EventArgs e)
        {
            dr = Grd_7sinif.GetDataRow(Grd_7sinif.FocusedRowHandle);
            LabelAktarma();
        }

        private void Grd_8sinif_DoubleClick(object sender, EventArgs e)
        {
            dr = Grd_8sinif.GetDataRow(Grd_8sinif.FocusedRowHandle);
            LabelAktarma();
        }
    }
}

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

namespace OkulOtomasyonu
{
    public partial class Frm_Ogretmenler : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Ogretmenler()
        {
            InitializeComponent();
        }
        SQLBaglantim bgl = new SQLBaglantim();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Ogretmenler", Bgl.Baglan());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void İlekle()
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Iller", Bgl.Baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_İl.Properties.Items.Add(dr[1].ToString());  //1 numaara veritabanındaki sütun değerini bildiriyor
            }
            Bgl.Baglan().Close();
        }

        void BransGetir()
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Branslar", Bgl.Baglan());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_Brans.Properties.Items.Add(dr[1].ToString());  //1 numaara veritabanındaki sütun değerini bildiriyor
            }
            Bgl.Baglan().Close();
        }

        void Temizle()
        {
            Txt_ID.Text = "";
            Txt_Adi.Text = "";
            Txt_Sayadi.Text = "";
            MskTxt_TCNo.Text = "";
            MskTxt_Telefon.Text = "";
            Cmb_İl.Text = "";
            Cmb_İlce.Text = "";
            Cmb_Brans.Text = "";
            Txt_Mail.Text = "";
            RchTxt_Adres.Text = "";
            PctBox_Resim.ImageLocation = "";
        }
        private void Frm_Ogretmenler_Load(object sender, EventArgs e)
        {
            Listele();
            İlekle();
            BransGetir();
        }

        private void Cmb_İl_SelectedIndexChanged(object sender, EventArgs e)    /*Ders 7 13:40*/
        {
            Cmb_İlce.Properties.Items.Clear();
            Cmb_İlce.Text = "";

            SqlCommand cmd = new SqlCommand("Select * From Tbl_ILceler where sehir=@p1", Bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Cmb_İl.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cmb_İlce.Properties.Items.Add(dr[1].ToString());
            }
            Bgl.Baglan().Close();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Ogretmenler (OgrtAd,OgrtSoyad,OgrtTC,OgrtTel,OgrtMail,OgrtSehir,OgrtIlce,OgrtAdres,OgrtBrans,OgrtFoto) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", Bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Txt_Adi.Text);
            cmd.Parameters.AddWithValue("@p2", Txt_Sayadi.Text);
            cmd.Parameters.AddWithValue("@p3", MskTxt_TCNo.Text);
            cmd.Parameters.AddWithValue("@p4", MskTxt_Telefon.Text);
            cmd.Parameters.AddWithValue("@p5", Txt_Mail.Text);
            cmd.Parameters.AddWithValue("@p6", Cmb_İl.Text);
            cmd.Parameters.AddWithValue("@p7", Cmb_İlce.Text);
            cmd.Parameters.AddWithValue("@p8", RchTxt_Adres.Text);
            cmd.Parameters.AddWithValue("@p9", Cmb_Brans.Text);
            cmd.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            cmd.ExecuteNonQuery();
            Bgl.Baglan().Close();
            MessageBox.Show("Kayıt işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void Grd_Ogrtmn_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = Grd_Ogrtmn.GetDataRow(Grd_Ogrtmn.FocusedRowHandle);
            if (dr != null)
            {
                Txt_ID.Text = dr["OgrtID"].ToString();
                Txt_Adi.Text = dr["OgrtAd"].ToString();
                Txt_Sayadi.Text = dr["OgrtSoyad"].ToString();
                MskTxt_TCNo.Text = dr["OgrtTC"].ToString();
                MskTxt_Telefon.Text = dr["OgrtTel"].ToString();
                Cmb_İl.Text = dr["OgrtSehir"].ToString();
                Cmb_İlce.Text = dr["OgrtIlce"].ToString();
                Cmb_Brans.Text = dr["OgrtBrans"].ToString();
                Txt_Mail.Text = dr["OgrtMail"].ToString();
                RchTxt_Adres.Text = dr["OgrtAdres"].ToString();
                yeniyol = "C:\\Users\\Aziz YILDIZ\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + dr["OgrtFoto"].ToString();
                PctBox_Resim.ImageLocation = yeniyol;
            }
        }
        public string yeniyol;

        internal SQLBaglantim Bgl { get => bgl; set => bgl = value; }

        private void Btn_ResimSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())/*aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa*/
            {
                fileDialog.Filter = "Resim Dosyası |*.jpg;*png;*nef | Tüm Dosyalar | *.*";
                fileDialog.ShowDialog();
                string dosyayolu = fileDialog.FileName;
                yeniyol = "C:\\Users\\Aziz YILDIZ\\source\\repos\\OkulOtomasyonu\\OkulOtomasyonu" + "\\resimler\\" + Guid.NewGuid().ToString() + ".jpg";
                File.Copy(dosyayolu, yeniyol);
            }

            PctBox_Resim.ImageLocation = yeniyol;
            //PctBox_Resim.Properties. = yeniyol;
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Ogretmenler set OgrtAd=@p1, OgrtSoyad=@p2, OgrtTC=@p3, OgrtTel=@p4, OgrtMail=@p5, OgrtSehir=@p6, OgrtIlce=@p7, OgrtAdres=@p8, OgrtBrans=@p9, OgrtFoto=@p10 where OgrtID=@p11", Bgl.Baglan());

            cmd.Parameters.AddWithValue("@p1", Txt_Adi.Text);
            cmd.Parameters.AddWithValue("@p2", Txt_Sayadi.Text);
            cmd.Parameters.AddWithValue("@p3", MskTxt_TCNo.Text);
            cmd.Parameters.AddWithValue("@p4", MskTxt_Telefon.Text);
            cmd.Parameters.AddWithValue("@p5", Txt_Mail.Text);
            cmd.Parameters.AddWithValue("@p6", Cmb_İl.Text);
            cmd.Parameters.AddWithValue("@p7", Cmb_İlce.Text);
            cmd.Parameters.AddWithValue("@p8", RchTxt_Adres.Text);
            cmd.Parameters.AddWithValue("@p9", Cmb_Brans.Text);
            cmd.Parameters.AddWithValue("@p10", Path.GetFileName(yeniyol));
            cmd.Parameters.AddWithValue("@p11", Txt_ID.Text);
            cmd.ExecuteNonQuery();
            Bgl.Baglan().Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Ogretmenler where OgrtID=@p1", Bgl.Baglan());
            cmd.Parameters.AddWithValue("@p1", Txt_ID.Text);
            cmd.ExecuteNonQuery();
            Bgl.Baglan().Close();
            Listele();
            MessageBox.Show("Silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
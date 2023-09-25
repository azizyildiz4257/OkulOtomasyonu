using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulOtomasyonu
{
    public partial class Frm_Veliler : DevExpress.XtraEditors.XtraForm
    {
        Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities();
        public Frm_Veliler()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var query = from item in db.Tbl_Veliler
                        select new
                        {
                            item.VeliID,
                            item.VeliAnne,
                            item.VeliBaba,
                            item.VeliTel1,
                            item.VeliTel2,
                            item.VeliMail
                        };
            gridControl1.DataSource = query.ToList();
        }

        void Temizle()
        {
            Txt_ID.Text = "";
            Txt_AnneAdi.Text = "";
            Txt_BabaAdi.Text = "";
            MskTxt_Tel1.Text = "";
            MskTxt_Tel2.Text = "";
            Txt_Mail.Text = "";
        }

        private void Frm_Veliler_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Tbl_Veliler veli = new Tbl_Veliler();
            //veli.VeliAnne = Txt_AnneAdi.Text;
            //veli.VeliBaba = Txt_BabaAdi.Text;
            //veli.VeliTel1 = MskTxt_Tel1.Text;
            //veli.VeliTel2 = MskTxt_Tel2.Text;
            //veli.VeliMail = Txt_Mail.Text;
            //db.Tbl_Veliler.Add(veli);
            //db.SaveChanges();
            //Listele();
            //Temizle();

            using (Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities())      /*Ders 33 1:43*/
            {
                Tbl_Veliler veli = new Tbl_Veliler();
                veli.VeliAnne = Txt_AnneAdi.Text;
                veli.VeliBaba = Txt_BabaAdi.Text;
                veli.VeliTel1 = MskTxt_Tel1.Text;
                veli.VeliTel2 = MskTxt_Tel2.Text;
                veli.VeliMail = Txt_Mail.Text;
                db.Tbl_Veliler.Add(veli);
                db.SaveChanges();
            }
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            Txt_ID.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliID").ToString();
            Txt_AnneAdi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliAnne").ToString();
            Txt_BabaAdi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliBaba").ToString();
            MskTxt_Tel1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliTel1").ToString();
            MskTxt_Tel2.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliTel2").ToString();
            Txt_Mail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliMail").ToString();
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliID").ToString());
            //var item = db.Tbl_Veliler.Find(id);
            //item.VeliAnne = Txt_AnneAdi.Text;
            //item.VeliBaba = Txt_BabaAdi.Text;
            //item.VeliTel1 = MskTxt_Tel1.Text;
            //item.VeliTel2 = MskTxt_Tel2.Text;
            //item.VeliMail = Txt_Mail.Text;
            //db.SaveChanges();
            //Listele();
            //Temizle();

            using (Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities())
            {
                var item = db.Tbl_Veliler.FirstOrDefault(x => x.VeliID == id);
                item.VeliAnne = Txt_AnneAdi.Text;
                item.VeliBaba = Txt_BabaAdi.Text;
                item.VeliTel1 = MskTxt_Tel1.Text;
                item.VeliTel2 = MskTxt_Tel2.Text;
                item.VeliMail = Txt_Mail.Text;
                db.SaveChanges();
                Listele();
                Temizle();
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "VeliID").ToString());
            //var item = db.Tbl_Veliler.Find(id);
            //db.Tbl_Veliler.Remove(item);
            //db.SaveChanges();
            //Listele();
            using (Db_OkulOtomasyonuEntities db = new Db_OkulOtomasyonuEntities())
            {
                var item = db.Tbl_Veliler.First(x => x.VeliID == id);
                db.Tbl_Veliler.Remove(item);
                db.SaveChanges();
                Listele();
            }
        }

        private void Btn_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
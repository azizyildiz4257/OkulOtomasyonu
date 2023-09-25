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
    public partial class Frm_Anasayfa : Form
    {
        public Frm_Anasayfa()
        {
            InitializeComponent();
        }

        Frm_Ogretmenler frm_Ogretmenler;
        private void Btn_Ogretmenler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Ogretmenler == null || frm_Ogretmenler.IsDisposed)     // yada mause tekeri ile kapandıpında açılsın Ders 6 13:46
            {
                frm_Ogretmenler = new Frm_Ogretmenler();
                frm_Ogretmenler.MdiParent = this;
                frm_Ogretmenler.Show();
            }
        }

        Frm_Ogrenciler frm_Ogrenciler;
        private void Btn_Ogrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Ogrenciler == null || frm_Ogrenciler.IsDisposed)
            {
                frm_Ogrenciler = new Frm_Ogrenciler();
                frm_Ogrenciler.MdiParent = this;
                frm_Ogrenciler.Show();
            }
        }
        Frm_Veliler frm_Veliler;
        private void Btn_Veliler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Veliler == null || frm_Veliler.IsDisposed)
            {
                frm_Veliler = new Frm_Veliler();
                frm_Veliler.MdiParent = this;
                frm_Veliler.Show();
            }
        }
        Frm_Ayarlar frm_Ayarlar;
        private void Btn_Ayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Ayarlar == null || frm_Ayarlar.IsDisposed)
            {
                frm_Ayarlar = new Frm_Ayarlar();
                frm_Ayarlar.MdiParent = this;
                frm_Ayarlar.Show();
            }
        }
    }
}

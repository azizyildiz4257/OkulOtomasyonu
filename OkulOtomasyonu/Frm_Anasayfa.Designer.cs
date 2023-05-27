namespace OkulOtomasyonu
{
    partial class Frm_Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Anasayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Btn_Anasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Ogretmenler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Ogrenciler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Veliler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_NotGirisi = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Karne = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_İstatistikler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Davranislar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Rehber = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Giderler = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Kasa = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Raporlar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Notlar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_Ayarlar = new DevExpress.XtraBars.BarButtonItem();
            this.Btn_WebSayfasi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Btn_Anasayfa,
            this.Btn_Ogretmenler,
            this.Btn_Ogrenciler,
            this.Btn_Veliler,
            this.Btn_NotGirisi,
            this.Btn_Karne,
            this.Btn_İstatistikler,
            this.Btn_Davranislar,
            this.Btn_Rehber,
            this.Btn_Giderler,
            this.Btn_Kasa,
            this.Btn_Raporlar,
            this.Btn_Notlar,
            this.Btn_Ayarlar,
            this.Btn_WebSayfasi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1184, 150);
            // 
            // Btn_Anasayfa
            // 
            this.Btn_Anasayfa.Caption = "Ana Sayfa";
            this.Btn_Anasayfa.Id = 1;
            this.Btn_Anasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Anasayfa.ImageOptions.Image")));
            this.Btn_Anasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Anasayfa.ImageOptions.LargeImage")));
            this.Btn_Anasayfa.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Anasayfa.ItemAppearance.Disabled.Options.UseFont = true;
            this.Btn_Anasayfa.LargeWidth = 75;
            this.Btn_Anasayfa.Name = "Btn_Anasayfa";
            // 
            // Btn_Ogretmenler
            // 
            this.Btn_Ogretmenler.Caption = "Öğretmenler";
            this.Btn_Ogretmenler.Id = 2;
            this.Btn_Ogretmenler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ogretmenler.ImageOptions.Image")));
            this.Btn_Ogretmenler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ogretmenler.ImageOptions.LargeImage")));
            this.Btn_Ogretmenler.LargeWidth = 75;
            this.Btn_Ogretmenler.Name = "Btn_Ogretmenler";
            this.Btn_Ogretmenler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Ogretmenler_ItemClick);
            // 
            // Btn_Ogrenciler
            // 
            this.Btn_Ogrenciler.Caption = "Öğrenciler";
            this.Btn_Ogrenciler.Id = 3;
            this.Btn_Ogrenciler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ogrenciler.ImageOptions.Image")));
            this.Btn_Ogrenciler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ogrenciler.ImageOptions.LargeImage")));
            this.Btn_Ogrenciler.LargeWidth = 65;
            this.Btn_Ogrenciler.Name = "Btn_Ogrenciler";
            this.Btn_Ogrenciler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_Ogrenciler_ItemClick);
            // 
            // Btn_Veliler
            // 
            this.Btn_Veliler.Caption = "Veliler";
            this.Btn_Veliler.Id = 4;
            this.Btn_Veliler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Veliler.ImageOptions.Image")));
            this.Btn_Veliler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Veliler.ImageOptions.LargeImage")));
            this.Btn_Veliler.LargeWidth = 60;
            this.Btn_Veliler.Name = "Btn_Veliler";
            // 
            // Btn_NotGirisi
            // 
            this.Btn_NotGirisi.Caption = "Not Girişi";
            this.Btn_NotGirisi.Id = 5;
            this.Btn_NotGirisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_NotGirisi.ImageOptions.Image")));
            this.Btn_NotGirisi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_NotGirisi.ImageOptions.LargeImage")));
            this.Btn_NotGirisi.LargeWidth = 60;
            this.Btn_NotGirisi.Name = "Btn_NotGirisi";
            // 
            // Btn_Karne
            // 
            this.Btn_Karne.Caption = "Karne";
            this.Btn_Karne.Id = 6;
            this.Btn_Karne.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Karne.ImageOptions.Image")));
            this.Btn_Karne.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Karne.ImageOptions.LargeImage")));
            this.Btn_Karne.LargeWidth = 60;
            this.Btn_Karne.Name = "Btn_Karne";
            // 
            // Btn_İstatistikler
            // 
            this.Btn_İstatistikler.Caption = "İstatistikler";
            this.Btn_İstatistikler.Id = 7;
            this.Btn_İstatistikler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_İstatistikler.ImageOptions.Image")));
            this.Btn_İstatistikler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_İstatistikler.ImageOptions.LargeImage")));
            this.Btn_İstatistikler.LargeWidth = 60;
            this.Btn_İstatistikler.Name = "Btn_İstatistikler";
            // 
            // Btn_Davranislar
            // 
            this.Btn_Davranislar.Caption = "Davranışlar";
            this.Btn_Davranislar.Id = 8;
            this.Btn_Davranislar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Davranislar.ImageOptions.Image")));
            this.Btn_Davranislar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Davranislar.ImageOptions.LargeImage")));
            this.Btn_Davranislar.LargeWidth = 75;
            this.Btn_Davranislar.Name = "Btn_Davranislar";
            // 
            // Btn_Rehber
            // 
            this.Btn_Rehber.Caption = "Rehber";
            this.Btn_Rehber.Id = 9;
            this.Btn_Rehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Rehber.ImageOptions.Image")));
            this.Btn_Rehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Rehber.ImageOptions.LargeImage")));
            this.Btn_Rehber.LargeWidth = 55;
            this.Btn_Rehber.Name = "Btn_Rehber";
            // 
            // Btn_Giderler
            // 
            this.Btn_Giderler.Caption = "Giderler";
            this.Btn_Giderler.Id = 10;
            this.Btn_Giderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Giderler.ImageOptions.Image")));
            this.Btn_Giderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Giderler.ImageOptions.LargeImage")));
            this.Btn_Giderler.LargeWidth = 60;
            this.Btn_Giderler.Name = "Btn_Giderler";
            // 
            // Btn_Kasa
            // 
            this.Btn_Kasa.Caption = "Kasa";
            this.Btn_Kasa.Id = 11;
            this.Btn_Kasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kasa.ImageOptions.Image")));
            this.Btn_Kasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Kasa.ImageOptions.LargeImage")));
            this.Btn_Kasa.LargeWidth = 55;
            this.Btn_Kasa.Name = "Btn_Kasa";
            // 
            // Btn_Raporlar
            // 
            this.Btn_Raporlar.Caption = "Raporlar";
            this.Btn_Raporlar.Id = 12;
            this.Btn_Raporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Raporlar.ImageOptions.Image")));
            this.Btn_Raporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Raporlar.ImageOptions.LargeImage")));
            this.Btn_Raporlar.LargeWidth = 60;
            this.Btn_Raporlar.Name = "Btn_Raporlar";
            // 
            // Btn_Notlar
            // 
            this.Btn_Notlar.Caption = "Notlar";
            this.Btn_Notlar.Id = 13;
            this.Btn_Notlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Notlar.ImageOptions.Image")));
            this.Btn_Notlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Notlar.ImageOptions.LargeImage")));
            this.Btn_Notlar.LargeWidth = 55;
            this.Btn_Notlar.Name = "Btn_Notlar";
            // 
            // Btn_Ayarlar
            // 
            this.Btn_Ayarlar.Caption = "Ayarlar";
            this.Btn_Ayarlar.Id = 14;
            this.Btn_Ayarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ayarlar.ImageOptions.Image")));
            this.Btn_Ayarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_Ayarlar.ImageOptions.LargeImage")));
            this.Btn_Ayarlar.LargeWidth = 55;
            this.Btn_Ayarlar.Name = "Btn_Ayarlar";
            // 
            // Btn_WebSayfasi
            // 
            this.Btn_WebSayfasi.Caption = "Web Sayfası";
            this.Btn_WebSayfasi.Id = 15;
            this.Btn_WebSayfasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_WebSayfasi.ImageOptions.Image")));
            this.Btn_WebSayfasi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Btn_WebSayfasi.ImageOptions.LargeImage")));
            this.Btn_WebSayfasi.LargeWidth = 85;
            this.Btn_WebSayfasi.Name = "Btn_WebSayfasi";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Anasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Ogretmenler);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Ogrenciler);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Veliler);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_NotGirisi);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Karne);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_İstatistikler);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Davranislar);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Rehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Giderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Kasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Raporlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Notlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_Ayarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.Btn_WebSayfasi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Frm_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Frm_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Yönetim Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem Btn_Anasayfa;
        private DevExpress.XtraBars.BarButtonItem Btn_Ogretmenler;
        private DevExpress.XtraBars.BarButtonItem Btn_Ogrenciler;
        private DevExpress.XtraBars.BarButtonItem Btn_Veliler;
        private DevExpress.XtraBars.BarButtonItem Btn_NotGirisi;
        private DevExpress.XtraBars.BarButtonItem Btn_Karne;
        private DevExpress.XtraBars.BarButtonItem Btn_İstatistikler;
        private DevExpress.XtraBars.BarButtonItem Btn_Davranislar;
        private DevExpress.XtraBars.BarButtonItem Btn_Rehber;
        private DevExpress.XtraBars.BarButtonItem Btn_Giderler;
        private DevExpress.XtraBars.BarButtonItem Btn_Kasa;
        private DevExpress.XtraBars.BarButtonItem Btn_Raporlar;
        private DevExpress.XtraBars.BarButtonItem Btn_Notlar;
        private DevExpress.XtraBars.BarButtonItem Btn_Ayarlar;
        private DevExpress.XtraBars.BarButtonItem Btn_WebSayfasi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}


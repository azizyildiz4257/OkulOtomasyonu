﻿namespace OkulOtomasyonu
{
    partial class Frm_Ogretmenler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ogretmenler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.Grd_Ogrtmn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_ResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.RchTxt_Adres = new System.Windows.Forms.RichTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.PctBox_Resim = new System.Windows.Forms.PictureBox();
            this.Cmb_Brans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmb_İlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Cmb_İl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MskTxt_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTxt_TCNo = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Sayadi = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Adi = new DevExpress.XtraEditors.TextEdit();
            this.Txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ogrtmn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mail.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Brans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_İlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_İl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sayadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.Grd_Ogrtmn;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(696, 460);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Grd_Ogrtmn});
            // 
            // Grd_Ogrtmn
            // 
            this.Grd_Ogrtmn.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Grd_Ogrtmn.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Grd_Ogrtmn.Appearance.Row.Options.UseBackColor = true;
            this.Grd_Ogrtmn.GridControl = this.gridControl1;
            this.Grd_Ogrtmn.Name = "Grd_Ogrtmn";
            this.Grd_Ogrtmn.OptionsView.ShowGroupPanel = false;
            this.Grd_Ogrtmn.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.Grd_Ogrtmn.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.Grd_Ogrtmn_FocusedRowObjectChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(714, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(254, 460);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(252, 432);
            this.xtraTabPage2.Text = "Öğretmen Bilgi-2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Btn_Temizle);
            this.groupControl2.Controls.Add(this.Btn_Guncelle);
            this.groupControl2.Controls.Add(this.Btn_Sil);
            this.groupControl2.Controls.Add(this.Btn_Kaydet);
            this.groupControl2.Controls.Add(this.Btn_ResimSec);
            this.groupControl2.Controls.Add(this.RchTxt_Adres);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.Txt_Mail);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(246, 426);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // Btn_Temizle
            // 
            this.Btn_Temizle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Temizle.Appearance.Options.UseFont = true;
            this.Btn_Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Temizle.ImageOptions.Image")));
            this.Btn_Temizle.Location = new System.Drawing.Point(127, 210);
            this.Btn_Temizle.Name = "Btn_Temizle";
            this.Btn_Temizle.Size = new System.Drawing.Size(104, 40);
            this.Btn_Temizle.TabIndex = 17;
            this.Btn_Temizle.Text = "Temizle";
            this.Btn_Temizle.Click += new System.EventHandler(this.Btn_Temizle_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Guncelle.Appearance.Options.UseFont = true;
            this.Btn_Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guncelle.ImageOptions.Image")));
            this.Btn_Guncelle.Location = new System.Drawing.Point(16, 210);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(104, 40);
            this.Btn_Guncelle.TabIndex = 16;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sil.Appearance.Options.UseFont = true;
            this.Btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.ImageOptions.Image")));
            this.Btn_Sil.Location = new System.Drawing.Point(127, 164);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(104, 40);
            this.Btn_Sil.TabIndex = 15;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Kaydet.Appearance.Options.UseFont = true;
            this.Btn_Kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.ImageOptions.Image")));
            this.Btn_Kaydet.Location = new System.Drawing.Point(16, 164);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(104, 40);
            this.Btn_Kaydet.TabIndex = 14;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Btn_ResimSec
            // 
            this.Btn_ResimSec.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ResimSec.Appearance.Options.UseFont = true;
            this.Btn_ResimSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ResimSec.ImageOptions.Image")));
            this.Btn_ResimSec.Location = new System.Drawing.Point(16, 118);
            this.Btn_ResimSec.Name = "Btn_ResimSec";
            this.Btn_ResimSec.Size = new System.Drawing.Size(215, 40);
            this.Btn_ResimSec.TabIndex = 13;
            this.Btn_ResimSec.Text = "Resim Seç";
            this.Btn_ResimSec.Click += new System.EventHandler(this.Btn_ResimSec_Click);
            // 
            // RchTxt_Adres
            // 
            this.RchTxt_Adres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RchTxt_Adres.Location = new System.Drawing.Point(75, 46);
            this.RchTxt_Adres.Name = "RchTxt_Adres";
            this.RchTxt_Adres.Size = new System.Drawing.Size(156, 66);
            this.RchTxt_Adres.TabIndex = 12;
            this.RchTxt_Adres.Text = "";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(16, 46);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 17);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = "Adres :";
            // 
            // Txt_Mail
            // 
            this.Txt_Mail.Location = new System.Drawing.Point(75, 19);
            this.Txt_Mail.Name = "Txt_Mail";
            this.Txt_Mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Mail.Properties.Appearance.Options.UseFont = true;
            this.Txt_Mail.Size = new System.Drawing.Size(156, 20);
            this.Txt_Mail.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(16, 20);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 17);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Mail :";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(252, 432);
            this.xtraTabPage1.Text = "Öğretmen Bilgi-1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.PctBox_Resim);
            this.groupControl1.Controls.Add(this.Cmb_Brans);
            this.groupControl1.Controls.Add(this.Cmb_İlce);
            this.groupControl1.Controls.Add(this.Cmb_İl);
            this.groupControl1.Controls.Add(this.MskTxt_Telefon);
            this.groupControl1.Controls.Add(this.MskTxt_TCNo);
            this.groupControl1.Controls.Add(this.Txt_Sayadi);
            this.groupControl1.Controls.Add(this.Txt_Adi);
            this.groupControl1.Controls.Add(this.Txt_ID);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(246, 426);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // PctBox_Resim
            // 
            this.PctBox_Resim.Location = new System.Drawing.Point(13, 5);
            this.PctBox_Resim.Name = "PctBox_Resim";
            this.PctBox_Resim.Size = new System.Drawing.Size(85, 85);
            this.PctBox_Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctBox_Resim.TabIndex = 17;
            this.PctBox_Resim.TabStop = false;
            // 
            // Cmb_Brans
            // 
            this.Cmb_Brans.Location = new System.Drawing.Point(82, 331);
            this.Cmb_Brans.Name = "Cmb_Brans";
            this.Cmb_Brans.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_Brans.Properties.Appearance.Options.UseFont = true;
            this.Cmb_Brans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_Brans.Size = new System.Drawing.Size(146, 20);
            this.Cmb_Brans.TabIndex = 15;
            // 
            // Cmb_İlce
            // 
            this.Cmb_İlce.Location = new System.Drawing.Point(82, 300);
            this.Cmb_İlce.Name = "Cmb_İlce";
            this.Cmb_İlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_İlce.Properties.Appearance.Options.UseFont = true;
            this.Cmb_İlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_İlce.Size = new System.Drawing.Size(146, 20);
            this.Cmb_İlce.TabIndex = 14;
            // 
            // Cmb_İl
            // 
            this.Cmb_İl.Location = new System.Drawing.Point(82, 269);
            this.Cmb_İl.Name = "Cmb_İl";
            this.Cmb_İl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cmb_İl.Properties.Appearance.Options.UseFont = true;
            this.Cmb_İl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmb_İl.Size = new System.Drawing.Size(146, 20);
            this.Cmb_İl.TabIndex = 13;
            this.Cmb_İl.SelectedIndexChanged += new System.EventHandler(this.Cmb_İl_SelectedIndexChanged);
            // 
            // MskTxt_Telefon
            // 
            this.MskTxt_Telefon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxt_Telefon.Location = new System.Drawing.Point(82, 236);
            this.MskTxt_Telefon.Mask = "(999) 000-0000";
            this.MskTxt_Telefon.Name = "MskTxt_Telefon";
            this.MskTxt_Telefon.Size = new System.Drawing.Size(146, 22);
            this.MskTxt_Telefon.TabIndex = 12;
            // 
            // MskTxt_TCNo
            // 
            this.MskTxt_TCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTxt_TCNo.Location = new System.Drawing.Point(82, 203);
            this.MskTxt_TCNo.Mask = "00000000000";
            this.MskTxt_TCNo.Name = "MskTxt_TCNo";
            this.MskTxt_TCNo.Size = new System.Drawing.Size(146, 22);
            this.MskTxt_TCNo.TabIndex = 11;
            this.MskTxt_TCNo.ValidatingType = typeof(int);
            // 
            // Txt_Sayadi
            // 
            this.Txt_Sayadi.Location = new System.Drawing.Point(82, 172);
            this.Txt_Sayadi.Name = "Txt_Sayadi";
            this.Txt_Sayadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Sayadi.Properties.Appearance.Options.UseFont = true;
            this.Txt_Sayadi.Size = new System.Drawing.Size(146, 20);
            this.Txt_Sayadi.TabIndex = 10;
            // 
            // Txt_Adi
            // 
            this.Txt_Adi.Location = new System.Drawing.Point(82, 141);
            this.Txt_Adi.Name = "Txt_Adi";
            this.Txt_Adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Adi.Properties.Appearance.Options.UseFont = true;
            this.Txt_Adi.Size = new System.Drawing.Size(146, 20);
            this.Txt_Adi.TabIndex = 9;
            // 
            // Txt_ID
            // 
            this.Txt_ID.Enabled = false;
            this.Txt_ID.Location = new System.Drawing.Point(82, 110);
            this.Txt_ID.Name = "Txt_ID";
            this.Txt_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_ID.Properties.Appearance.Options.UseFont = true;
            this.Txt_ID.Size = new System.Drawing.Size(146, 20);
            this.Txt_ID.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 332);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 17);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Branş :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(13, 301);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 17);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "İlçe :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(13, 270);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 17);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "İl :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 237);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 17);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Telefon :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "T.C. No :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Soyadı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID :";
            // 
            // Frm_Ogretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 485);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Frm_Ogretmenler.IconOptions.Image")));
            this.Name = "Frm_Ogretmenler";
            this.Text = " Öğretmenler";
            this.Load += new System.EventHandler(this.Frm_Ogretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Ogrtmn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Mail.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBox_Resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_Brans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_İlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmb_İl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Sayadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView Grd_Ogrtmn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit Cmb_Brans;
        private DevExpress.XtraEditors.ComboBoxEdit Cmb_İlce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmb_İl;
        private System.Windows.Forms.MaskedTextBox MskTxt_Telefon;
        private System.Windows.Forms.MaskedTextBox MskTxt_TCNo;
        private DevExpress.XtraEditors.TextEdit Txt_Sayadi;
        private DevExpress.XtraEditors.TextEdit Txt_Adi;
        private DevExpress.XtraEditors.TextEdit Txt_ID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox RchTxt_Adres;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit Txt_Mail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton Btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton Btn_Guncelle;
        private DevExpress.XtraEditors.SimpleButton Btn_Sil;
        private DevExpress.XtraEditors.SimpleButton Btn_Kaydet;
        private DevExpress.XtraEditors.SimpleButton Btn_ResimSec;
        private System.Windows.Forms.PictureBox PctBox_Resim;
    }
}
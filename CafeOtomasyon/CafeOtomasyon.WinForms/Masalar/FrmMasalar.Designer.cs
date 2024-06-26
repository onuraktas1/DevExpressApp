﻿namespace CafeOtomasyon.WinForms.Masalar
{
    partial class FrmMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasalar));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnDurumDegistir = new DevExpress.XtraEditors.SimpleButton();
            btnRezerveDegistir = new DevExpress.XtraEditors.SimpleButton();
            btnSilme = new DevExpress.XtraEditors.SimpleButton();
            btnCik = new DevExpress.XtraEditors.SimpleButton();
            btnYenile = new DevExpress.XtraEditors.SimpleButton();
            btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            MasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            RezerveMi = new DevExpress.XtraGrid.Columns.GridColumn();
            EklenmeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            SonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            KullaniciAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            MasaHareketi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Dock = DockStyle.Top;
            labelControl1.Location = new Point(0, 0);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(1172, 69);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Masalar";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnDurumDegistir);
            groupControl1.Controls.Add(btnRezerveDegistir);
            groupControl1.Controls.Add(btnSilme);
            groupControl1.Controls.Add(btnCik);
            groupControl1.Controls.Add(btnYenile);
            groupControl1.Controls.Add(btnDuzenle);
            groupControl1.Controls.Add(btnEkle);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 583);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1172, 100);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "İşlemler";
            // 
            // btnDurumDegistir
            // 
            btnDurumDegistir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDurumDegistir.ImageOptions.Image = (Image)resources.GetObject("btnDurumDegistir.ImageOptions.Image");
            btnDurumDegistir.Location = new Point(657, 33);
            btnDurumDegistir.Name = "btnDurumDegistir";
            btnDurumDegistir.Size = new Size(119, 55);
            btnDurumDegistir.TabIndex = 0;
            btnDurumDegistir.Text = "Durum Değiştir";
            btnDurumDegistir.Click += btnDurumDegistir_Click;
            // 
            // btnRezerveDegistir
            // 
            btnRezerveDegistir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRezerveDegistir.ImageOptions.Image = (Image)resources.GetObject("btnRezerveDegistir.ImageOptions.Image");
            btnRezerveDegistir.Location = new Point(782, 33);
            btnRezerveDegistir.Name = "btnRezerveDegistir";
            btnRezerveDegistir.Size = new Size(122, 55);
            btnRezerveDegistir.TabIndex = 0;
            btnRezerveDegistir.Text = "Rezerve Değiştir";
            btnRezerveDegistir.Click += btnRezerveDegistir_Click;
            // 
            // btnSilme
            // 
            btnSilme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSilme.ImageOptions.Image = (Image)resources.GetObject("btnSilme.ImageOptions.Image");
            btnSilme.Location = new Point(910, 33);
            btnSilme.Name = "btnSilme";
            btnSilme.Size = new Size(119, 55);
            btnSilme.TabIndex = 0;
            btnSilme.Text = "Sil";
            btnSilme.Click += btnSilme_Click;
            // 
            // btnCik
            // 
            btnCik.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCik.ImageOptions.Image = (Image)resources.GetObject("btnCik.ImageOptions.Image");
            btnCik.Location = new Point(1035, 33);
            btnCik.Name = "btnCik";
            btnCik.Size = new Size(119, 55);
            btnCik.TabIndex = 0;
            btnCik.Text = "Kapat";
            btnCik.Click += btnCik_Click;
            // 
            // btnYenile
            // 
            btnYenile.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnYenile.ImageOptions.SvgImage");
            btnYenile.Location = new Point(250, 33);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(113, 55);
            btnYenile.TabIndex = 0;
            btnYenile.Text = "Yenile";
            btnYenile.Click += btnYenile_Click;
            // 
            // btnDuzenle
            // 
            btnDuzenle.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnDuzenle.ImageOptions.SvgImage");
            btnDuzenle.Location = new Point(131, 33);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new Size(113, 55);
            btnDuzenle.TabIndex = 0;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.Click += btnDuzenle_Click;
            // 
            // btnEkle
            // 
            btnEkle.ImageOptions.Image = (Image)resources.GetObject("btnEkle.ImageOptions.Image");
            btnEkle.Location = new Point(12, 33);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(113, 55);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Ekle";
            btnEkle.Click += btnEkle_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 69);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1172, 514);
            gridControl1.TabIndex = 4;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, MasaAdi, Aciklama, Durum, RezerveMi, EklenmeTarihi, SonIslemTarihi, KullaniciAdSoyad, MasaHareketi });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // Id
            // 
            Id.Caption = "Id";
            Id.FieldName = "Id";
            Id.Name = "Id";
            Id.Visible = true;
            Id.VisibleIndex = 0;
            Id.Width = 67;
            // 
            // MasaAdi
            // 
            MasaAdi.Caption = "Masa";
            MasaAdi.FieldName = "MasaAdi";
            MasaAdi.Name = "MasaAdi";
            MasaAdi.Visible = true;
            MasaAdi.VisibleIndex = 1;
            MasaAdi.Width = 98;
            // 
            // Aciklama
            // 
            Aciklama.Caption = "Açıklama";
            Aciklama.FieldName = "Aciklama";
            Aciklama.Name = "Aciklama";
            Aciklama.Visible = true;
            Aciklama.VisibleIndex = 2;
            Aciklama.Width = 294;
            // 
            // Durum
            // 
            Durum.Caption = "Durumu";
            Durum.FieldName = "Durum";
            Durum.Name = "Durum";
            Durum.Visible = true;
            Durum.VisibleIndex = 3;
            Durum.Width = 49;
            // 
            // RezerveMi
            // 
            RezerveMi.Caption = "Rezerve Mi";
            RezerveMi.FieldName = "RezerveMi";
            RezerveMi.Name = "RezerveMi";
            RezerveMi.Visible = true;
            RezerveMi.VisibleIndex = 4;
            RezerveMi.Width = 50;
            // 
            // EklenmeTarihi
            // 
            EklenmeTarihi.Caption = "Eklenme Tarihi";
            EklenmeTarihi.FieldName = "EklenmeTarihi";
            EklenmeTarihi.Name = "EklenmeTarihi";
            EklenmeTarihi.Visible = true;
            EklenmeTarihi.VisibleIndex = 5;
            EklenmeTarihi.Width = 89;
            // 
            // SonIslemTarihi
            // 
            SonIslemTarihi.Caption = "Son İşlem Tarihi";
            SonIslemTarihi.FieldName = "SonIslemTarihi";
            SonIslemTarihi.Name = "SonIslemTarihi";
            SonIslemTarihi.Visible = true;
            SonIslemTarihi.VisibleIndex = 6;
            SonIslemTarihi.Width = 95;
            // 
            // KullaniciAdSoyad
            // 
            KullaniciAdSoyad.Caption = "Kullanıcı";
            KullaniciAdSoyad.FieldName = "Kullanici.AdSoyad";
            KullaniciAdSoyad.Name = "KullaniciAdSoyad";
            KullaniciAdSoyad.Visible = true;
            KullaniciAdSoyad.VisibleIndex = 7;
            KullaniciAdSoyad.Width = 158;
            // 
            // MasaHareketi
            // 
            MasaHareketi.Caption = "İşlem";
            MasaHareketi.FieldName = "İslem";
            MasaHareketi.Name = "MasaHareketi";
            MasaHareketi.Visible = true;
            MasaHareketi.VisibleIndex = 8;
            MasaHareketi.Width = 225;
            // 
            // FrmMasalar
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 683);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Controls.Add(labelControl1);
            Name = "FrmMasalar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Masalar";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn MasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraGrid.Columns.GridColumn RezerveMi;
        private DevExpress.XtraGrid.Columns.GridColumn EklenmeTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn SonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn KullaniciAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn MasaHareketi;
        private DevExpress.XtraEditors.SimpleButton btnDurumDegistir;
        private DevExpress.XtraEditors.SimpleButton btnRezerveDegistir;
        private DevExpress.XtraEditors.SimpleButton btnCik;
        private DevExpress.XtraEditors.SimpleButton btnSilme;
    }
}
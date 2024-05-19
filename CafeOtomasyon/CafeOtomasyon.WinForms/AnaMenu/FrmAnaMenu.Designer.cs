namespace CafeOtomasyon.WinForms.AnaMenu
{
    partial class FrmAnaMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnMasalar = new DevExpress.XtraBars.BarButtonItem();
            btnMasaHareketi = new DevExpress.XtraBars.BarButtonItem();
            btnMenuler = new DevExpress.XtraBars.BarButtonItem();
            btnMenuHareketi = new DevExpress.XtraBars.BarButtonItem();
            btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            btnUrunHareketi = new DevExpress.XtraBars.BarButtonItem();
            btnKullanicilar = new DevExpress.XtraBars.BarButtonItem();
            btnKullaniciHareketi = new DevExpress.XtraBars.BarButtonItem();
            btnRoller = new DevExpress.XtraBars.BarButtonItem();
            btnDoviz = new DevExpress.XtraBars.BarButtonItem();
            btnYardim = new DevExpress.XtraBars.BarButtonItem();
            btnHakkimizda = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.EmptyAreaImageOptions.ImagePadding = new Padding(35, 37, 35, 37);
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, btnMasalar, btnMasaHareketi, btnMenuler, btnMenuHareketi, btnUrunler, barButtonItem1, btnUrunHareketi, btnKullanicilar, btnKullaniciHareketi, btnRoller, btnDoviz, btnYardim, btnHakkimizda });
            ribbon.Location = new Point(0, 0);
            ribbon.Margin = new Padding(4);
            ribbon.MaxItemId = 14;
            ribbon.Name = "ribbon";
            ribbon.OptionsMenuMinWidth = 385;
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage2, ribbonPage1 });
            ribbon.Size = new Size(1338, 193);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // btnMasalar
            // 
            btnMasalar.Caption = "Masalar";
            btnMasalar.Id = 1;
            btnMasalar.ImageOptions.Image = (Image)resources.GetObject("btnMasalar.ImageOptions.Image");
            btnMasalar.ImageOptions.LargeImage = (Image)resources.GetObject("btnMasalar.ImageOptions.LargeImage");
            btnMasalar.Name = "btnMasalar";
            // 
            // btnMasaHareketi
            // 
            btnMasaHareketi.Caption = "Masa Hareketleri";
            btnMasaHareketi.Id = 2;
            btnMasaHareketi.ImageOptions.Image = (Image)resources.GetObject("btnMasaHareketi.ImageOptions.Image");
            btnMasaHareketi.ImageOptions.LargeImage = (Image)resources.GetObject("btnMasaHareketi.ImageOptions.LargeImage");
            btnMasaHareketi.Name = "btnMasaHareketi";
            // 
            // btnMenuler
            // 
            btnMenuler.Caption = "Menüler";
            btnMenuler.Id = 3;
            btnMenuler.ImageOptions.Image = (Image)resources.GetObject("btnMenuler.ImageOptions.Image");
            btnMenuler.ImageOptions.LargeImage = (Image)resources.GetObject("btnMenuler.ImageOptions.LargeImage");
            btnMenuler.Name = "btnMenuler";
            // 
            // btnMenuHareketi
            // 
            btnMenuHareketi.Caption = "Menu Hareketleri";
            btnMenuHareketi.Id = 4;
            btnMenuHareketi.ImageOptions.Image = (Image)resources.GetObject("btnMenuHareketi.ImageOptions.Image");
            btnMenuHareketi.ImageOptions.LargeImage = (Image)resources.GetObject("btnMenuHareketi.ImageOptions.LargeImage");
            btnMenuHareketi.Name = "btnMenuHareketi";
            // 
            // btnUrunler
            // 
            btnUrunler.Caption = "Ürünler";
            btnUrunler.Id = 5;
            btnUrunler.ImageOptions.Image = (Image)resources.GetObject("btnUrunler.ImageOptions.Image");
            btnUrunler.ImageOptions.LargeImage = (Image)resources.GetObject("btnUrunler.ImageOptions.LargeImage");
            btnUrunler.Name = "btnUrunler";
            btnUrunler.ItemClick += btnUrunler_ItemClick;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 6;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // btnUrunHareketi
            // 
            btnUrunHareketi.Caption = "Ürün Hareketleri";
            btnUrunHareketi.Id = 7;
            btnUrunHareketi.ImageOptions.Image = (Image)resources.GetObject("btnUrunHareketi.ImageOptions.Image");
            btnUrunHareketi.ImageOptions.LargeImage = (Image)resources.GetObject("btnUrunHareketi.ImageOptions.LargeImage");
            btnUrunHareketi.Name = "btnUrunHareketi";
            // 
            // btnKullanicilar
            // 
            btnKullanicilar.Caption = "Kullanıcılar";
            btnKullanicilar.Id = 8;
            btnKullanicilar.ImageOptions.Image = (Image)resources.GetObject("btnKullanicilar.ImageOptions.Image");
            btnKullanicilar.ImageOptions.LargeImage = (Image)resources.GetObject("btnKullanicilar.ImageOptions.LargeImage");
            btnKullanicilar.Name = "btnKullanicilar";
            // 
            // btnKullaniciHareketi
            // 
            btnKullaniciHareketi.Caption = "Kullanıcı Hareketleri";
            btnKullaniciHareketi.Id = 9;
            btnKullaniciHareketi.ImageOptions.Image = (Image)resources.GetObject("btnKullaniciHareketi.ImageOptions.Image");
            btnKullaniciHareketi.ImageOptions.LargeImage = (Image)resources.GetObject("btnKullaniciHareketi.ImageOptions.LargeImage");
            btnKullaniciHareketi.Name = "btnKullaniciHareketi";
            // 
            // btnRoller
            // 
            btnRoller.Caption = "Rol Tanımlama";
            btnRoller.Id = 10;
            btnRoller.ImageOptions.Image = (Image)resources.GetObject("btnRoller.ImageOptions.Image");
            btnRoller.ImageOptions.LargeImage = (Image)resources.GetObject("btnRoller.ImageOptions.LargeImage");
            btnRoller.Name = "btnRoller";
            // 
            // btnDoviz
            // 
            btnDoviz.Caption = "Döviz";
            btnDoviz.Id = 11;
            btnDoviz.ImageOptions.Image = (Image)resources.GetObject("btnDoviz.ImageOptions.Image");
            btnDoviz.ImageOptions.LargeImage = (Image)resources.GetObject("btnDoviz.ImageOptions.LargeImage");
            btnDoviz.Name = "btnDoviz";
            // 
            // btnYardim
            // 
            btnYardim.Caption = "Yardım";
            btnYardim.Id = 12;
            btnYardim.ImageOptions.Image = (Image)resources.GetObject("btnYardim.ImageOptions.Image");
            btnYardim.ImageOptions.LargeImage = (Image)resources.GetObject("btnYardim.ImageOptions.LargeImage");
            btnYardim.Name = "btnYardim";
            // 
            // btnHakkimizda
            // 
            btnHakkimizda.Caption = "Hakkımızda";
            btnHakkimizda.Id = 13;
            btnHakkimizda.ImageOptions.Image = (Image)resources.GetObject("btnHakkimizda.ImageOptions.Image");
            btnHakkimizda.ImageOptions.LargeImage = (Image)resources.GetObject("btnHakkimizda.ImageOptions.LargeImage");
            btnHakkimizda.Name = "btnHakkimizda";
            // 
            // ribbonPage2
            // 
            ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2, ribbonPageGroup3, ribbonPageGroup4, ribbonPageGroup5 });
            ribbonPage2.Name = "ribbonPage2";
            ribbonPage2.Text = "Kafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.ItemLinks.Add(btnMasalar);
            ribbonPageGroup2.ItemLinks.Add(btnMasaHareketi);
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "Masalar";
            // 
            // ribbonPageGroup3
            // 
            ribbonPageGroup3.ItemLinks.Add(btnMenuler);
            ribbonPageGroup3.ItemLinks.Add(btnMenuHareketi);
            ribbonPageGroup3.Name = "ribbonPageGroup3";
            ribbonPageGroup3.Text = "Menüler";
            // 
            // ribbonPageGroup4
            // 
            ribbonPageGroup4.ItemLinks.Add(btnUrunler);
            ribbonPageGroup4.ItemLinks.Add(btnUrunHareketi);
            ribbonPageGroup4.Name = "ribbonPageGroup4";
            ribbonPageGroup4.Text = "Ürünler";
            // 
            // ribbonPageGroup5
            // 
            ribbonPageGroup5.ItemLinks.Add(btnKullanicilar);
            ribbonPageGroup5.ItemLinks.Add(btnKullaniciHareketi);
            ribbonPageGroup5.ItemLinks.Add(btnRoller);
            ribbonPageGroup5.Name = "ribbonPageGroup5";
            ribbonPageGroup5.Text = "Kullanıcılar";
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnDoviz);
            ribbonPageGroup1.ItemLinks.Add(btnYardim);
            ribbonPageGroup1.ItemLinks.Add(btnHakkimizda);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 1071);
            ribbonStatusBar.Margin = new Padding(4);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1338, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1338, 1101);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "FrmAnaMenu";
            Ribbon = ribbon;
            StartPosition = FormStartPosition.CenterScreen;
            StatusBar = ribbonStatusBar;
            Text = "Cafe Otomasyon";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnMasalar;
        private DevExpress.XtraBars.BarButtonItem btnMasaHareketi;
        private DevExpress.XtraBars.BarButtonItem btnMenuler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnMenuHareketi;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnUrunHareketi;
        private DevExpress.XtraBars.BarButtonItem btnKullanicilar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnKullaniciHareketi;
        private DevExpress.XtraBars.BarButtonItem btnRoller;
        private DevExpress.XtraBars.BarButtonItem btnDoviz;
        private DevExpress.XtraBars.BarButtonItem btnYardim;
        private DevExpress.XtraBars.BarButtonItem btnHakkimizda;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}
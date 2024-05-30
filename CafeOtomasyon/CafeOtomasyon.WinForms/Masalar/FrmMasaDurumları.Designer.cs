namespace CafeOtomasyon.WinForms.Masalar
{
    partial class FrmMasaDurumları
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaDurumları));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupIslemler = new DevExpress.XtraEditors.GroupControl();
            btnYenile = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnRezervMasa = new DevExpress.XtraEditors.SimpleButton();
            btnBosMasa = new DevExpress.XtraEditors.SimpleButton();
            btnDoluMasa = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupHesaplamalar = new DevExpress.XtraEditors.GroupControl();
            calcIndirimliToplam = new DevExpress.XtraEditors.CalcEdit();
            calcIndirimOrani = new DevExpress.XtraEditors.CalcEdit();
            calcKalan = new DevExpress.XtraEditors.CalcEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            calcToplam = new DevExpress.XtraEditors.CalcEdit();
            calcIndirimToplami = new DevExpress.XtraEditors.CalcEdit();
            calcOdenen = new DevExpress.XtraEditors.CalcEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupIslemler).BeginInit();
            groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupHesaplamalar).BeginInit();
            groupHesaplamalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calcIndirimliToplam.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcIndirimOrani.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcKalan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcToplam.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcIndirimToplami.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcOdenen.Properties).BeginInit();
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
            labelControl1.Size = new Size(1118, 69);
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Masa Durumları";
            // 
            // groupIslemler
            // 
            groupIslemler.Controls.Add(btnYenile);
            groupIslemler.Controls.Add(btnKapat);
            groupIslemler.Controls.Add(btnSiparisEkle);
            groupIslemler.Controls.Add(btnKaydet);
            groupIslemler.Dock = DockStyle.Bottom;
            groupIslemler.Location = new Point(0, 744);
            groupIslemler.Name = "groupIslemler";
            groupIslemler.Size = new Size(1118, 100);
            groupIslemler.TabIndex = 5;
            groupIslemler.Text = "İşlemler";
            // 
            // btnYenile
            // 
            btnYenile.ImageOptions.Image = (Image)resources.GetObject("btnYenile.ImageOptions.Image");
            btnYenile.Location = new Point(131, 33);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(115, 55);
            btnYenile.TabIndex = 1;
            btnYenile.Text = "Yenile";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new Point(994, 33);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(113, 55);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.ImageOptions.Image = (Image)resources.GetObject("btnSiparisEkle.ImageOptions.Image");
            btnSiparisEkle.Location = new Point(12, 33);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(113, 55);
            btnSiparisEkle.TabIndex = 0;
            btnSiparisEkle.Text = "Sipariş Ekle";
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKaydet.ImageOptions.Image = (Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new Point(875, 33);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(113, 55);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new Point(0, 69);
            splitContainerControl1.Margin = new Padding(3, 2, 3, 2);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(flowLayoutPanel1);
            splitContainerControl1.Panel1.Controls.Add(panelControl1);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(gridControl1);
            splitContainerControl1.Panel2.Controls.Add(groupHesaplamalar);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1108, 639);
            splitContainerControl1.SplitterPosition = 343;
            splitContainerControl1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1108, 279);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panelControl1
            // 
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelControl1.Controls.Add(btnRezervMasa);
            panelControl1.Controls.Add(btnBosMasa);
            panelControl1.Controls.Add(btnDoluMasa);
            panelControl1.Location = new Point(0, 279);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1108, 64);
            panelControl1.TabIndex = 1;
            // 
            // btnRezervMasa
            // 
            btnRezervMasa.Appearance.BackColor = Color.Tan;
            btnRezervMasa.Appearance.Options.UseBackColor = true;
            btnRezervMasa.Location = new Point(219, 5);
            btnRezervMasa.Name = "btnRezervMasa";
            btnRezervMasa.Size = new Size(101, 54);
            btnRezervMasa.TabIndex = 0;
            btnRezervMasa.Text = "Rezevr Masa";
            // 
            // btnBosMasa
            // 
            btnBosMasa.Appearance.BackColor = Color.Green;
            btnBosMasa.Appearance.Options.UseBackColor = true;
            btnBosMasa.Location = new Point(112, 5);
            btnBosMasa.Name = "btnBosMasa";
            btnBosMasa.Size = new Size(101, 54);
            btnBosMasa.TabIndex = 0;
            btnBosMasa.Text = "Boş Masa";
            // 
            // btnDoluMasa
            // 
            btnDoluMasa.Appearance.BackColor = Color.Brown;
            btnDoluMasa.Appearance.Options.UseBackColor = true;
            btnDoluMasa.Location = new Point(5, 5);
            btnDoluMasa.Name = "btnDoluMasa";
            btnDoluMasa.Size = new Size(101, 54);
            btnDoluMasa.TabIndex = 0;
            btnDoluMasa.Text = "Dolu Masa";
            // 
            // gridControl1
            // 
            gridControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gridControl1.EmbeddedNavigator.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Location = new Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(3, 2, 3, 2);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(1108, 202);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 284;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 686;
            // 
            // groupHesaplamalar
            // 
            groupHesaplamalar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupHesaplamalar.Controls.Add(calcIndirimliToplam);
            groupHesaplamalar.Controls.Add(calcIndirimOrani);
            groupHesaplamalar.Controls.Add(calcKalan);
            groupHesaplamalar.Controls.Add(labelControl7);
            groupHesaplamalar.Controls.Add(labelControl5);
            groupHesaplamalar.Controls.Add(labelControl3);
            groupHesaplamalar.Controls.Add(calcToplam);
            groupHesaplamalar.Controls.Add(calcIndirimToplami);
            groupHesaplamalar.Controls.Add(calcOdenen);
            groupHesaplamalar.Controls.Add(labelControl6);
            groupHesaplamalar.Controls.Add(labelControl4);
            groupHesaplamalar.Controls.Add(labelControl2);
            groupHesaplamalar.Location = new Point(0, 202);
            groupHesaplamalar.Margin = new Padding(3, 2, 3, 2);
            groupHesaplamalar.Name = "groupHesaplamalar";
            groupHesaplamalar.Size = new Size(1108, 84);
            groupHesaplamalar.TabIndex = 0;
            groupHesaplamalar.Text = "Hesaplamalar";
            // 
            // calcIndirimliToplam
            // 
            calcIndirimliToplam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calcIndirimliToplam.Location = new Point(949, 56);
            calcIndirimliToplam.Name = "calcIndirimliToplam";
            calcIndirimliToplam.Properties.Appearance.BackColor = Color.Green;
            calcIndirimliToplam.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcIndirimliToplam.Properties.Appearance.ForeColor = Color.White;
            calcIndirimliToplam.Properties.Appearance.Options.UseBackColor = true;
            calcIndirimliToplam.Properties.Appearance.Options.UseFont = true;
            calcIndirimliToplam.Properties.Appearance.Options.UseForeColor = true;
            calcIndirimliToplam.Properties.Appearance.Options.UseTextOptions = true;
            calcIndirimliToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcIndirimliToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcIndirimliToplam.Properties.MaskSettings.Set("mask", "c");
            calcIndirimliToplam.Properties.NullText = "₺0,00";
            calcIndirimliToplam.Properties.UseMaskAsDisplayFormat = true;
            calcIndirimliToplam.Size = new Size(150, 24);
            calcIndirimliToplam.TabIndex = 1;
            // 
            // calcIndirimOrani
            // 
            calcIndirimOrani.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calcIndirimOrani.Location = new Point(547, 56);
            calcIndirimOrani.Name = "calcIndirimOrani";
            calcIndirimOrani.Properties.Appearance.BackColor = Color.Green;
            calcIndirimOrani.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcIndirimOrani.Properties.Appearance.ForeColor = Color.White;
            calcIndirimOrani.Properties.Appearance.Options.UseBackColor = true;
            calcIndirimOrani.Properties.Appearance.Options.UseFont = true;
            calcIndirimOrani.Properties.Appearance.Options.UseForeColor = true;
            calcIndirimOrani.Properties.Appearance.Options.UseTextOptions = true;
            calcIndirimOrani.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcIndirimOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcIndirimOrani.Properties.MaskSettings.Set("mask", "P");
            calcIndirimOrani.Properties.NullText = "%0,00";
            calcIndirimOrani.Properties.UseMaskAsDisplayFormat = true;
            calcIndirimOrani.Size = new Size(150, 24);
            calcIndirimOrani.TabIndex = 1;
            // 
            // calcKalan
            // 
            calcKalan.Location = new Point(131, 56);
            calcKalan.Name = "calcKalan";
            calcKalan.Properties.Appearance.BackColor = Color.Green;
            calcKalan.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcKalan.Properties.Appearance.ForeColor = Color.White;
            calcKalan.Properties.Appearance.Options.UseBackColor = true;
            calcKalan.Properties.Appearance.Options.UseFont = true;
            calcKalan.Properties.Appearance.Options.UseForeColor = true;
            calcKalan.Properties.Appearance.Options.UseTextOptions = true;
            calcKalan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcKalan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcKalan.Properties.MaskSettings.Set("mask", "c");
            calcKalan.Properties.NullText = "₺0,00";
            calcKalan.Properties.UseMaskAsDisplayFormat = true;
            calcKalan.Size = new Size(150, 24);
            calcKalan.TabIndex = 1;
            // 
            // labelControl7
            // 
            labelControl7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl7.Appearance.BorderColor = Color.Silver;
            labelControl7.Appearance.Font = new Font("Tahoma", 10F);
            labelControl7.Appearance.Options.UseBorderColor = true;
            labelControl7.Appearance.Options.UseFont = true;
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl7.Location = new Point(830, 57);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(111, 23);
            labelControl7.TabIndex = 0;
            labelControl7.Text = "İndirimli Toplam : ";
            // 
            // labelControl5
            // 
            labelControl5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl5.Appearance.BorderColor = Color.Silver;
            labelControl5.Appearance.Font = new Font("Tahoma", 10F);
            labelControl5.Appearance.Options.UseBorderColor = true;
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(419, 57);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(120, 23);
            labelControl5.TabIndex = 0;
            labelControl5.Text = "İndirim Oranı(%) : ";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BorderColor = Color.Silver;
            labelControl3.Appearance.Font = new Font("Tahoma", 10F);
            labelControl3.Appearance.Options.UseBorderColor = true;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Location = new Point(12, 57);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(111, 23);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Kalan : ";
            // 
            // calcToplam
            // 
            calcToplam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calcToplam.Location = new Point(949, 27);
            calcToplam.Name = "calcToplam";
            calcToplam.Properties.Appearance.BackColor = Color.Green;
            calcToplam.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcToplam.Properties.Appearance.ForeColor = Color.White;
            calcToplam.Properties.Appearance.Options.UseBackColor = true;
            calcToplam.Properties.Appearance.Options.UseFont = true;
            calcToplam.Properties.Appearance.Options.UseForeColor = true;
            calcToplam.Properties.Appearance.Options.UseTextOptions = true;
            calcToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcToplam.Properties.MaskSettings.Set("mask", "c");
            calcToplam.Properties.NullText = "₺0,00";
            calcToplam.Properties.UseMaskAsDisplayFormat = true;
            calcToplam.Size = new Size(150, 24);
            calcToplam.TabIndex = 1;
            // 
            // calcIndirimToplami
            // 
            calcIndirimToplami.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calcIndirimToplami.Location = new Point(547, 27);
            calcIndirimToplami.Name = "calcIndirimToplami";
            calcIndirimToplami.Properties.Appearance.BackColor = Color.Green;
            calcIndirimToplami.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcIndirimToplami.Properties.Appearance.ForeColor = Color.White;
            calcIndirimToplami.Properties.Appearance.Options.UseBackColor = true;
            calcIndirimToplami.Properties.Appearance.Options.UseFont = true;
            calcIndirimToplami.Properties.Appearance.Options.UseForeColor = true;
            calcIndirimToplami.Properties.Appearance.Options.UseTextOptions = true;
            calcIndirimToplami.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcIndirimToplami.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcIndirimToplami.Properties.MaskSettings.Set("mask", "c");
            calcIndirimToplami.Properties.NullText = "₺0,00";
            calcIndirimToplami.Properties.UseMaskAsDisplayFormat = true;
            calcIndirimToplami.Size = new Size(150, 24);
            calcIndirimToplami.TabIndex = 1;
            // 
            // calcOdenen
            // 
            calcOdenen.Location = new Point(131, 27);
            calcOdenen.Name = "calcOdenen";
            calcOdenen.Properties.Appearance.BackColor = Color.Green;
            calcOdenen.Properties.Appearance.Font = new Font("Tahoma", 11F, FontStyle.Bold);
            calcOdenen.Properties.Appearance.ForeColor = Color.White;
            calcOdenen.Properties.Appearance.Options.UseBackColor = true;
            calcOdenen.Properties.Appearance.Options.UseFont = true;
            calcOdenen.Properties.Appearance.Options.UseForeColor = true;
            calcOdenen.Properties.Appearance.Options.UseTextOptions = true;
            calcOdenen.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcOdenen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcOdenen.Properties.MaskSettings.Set("mask", "c");
            calcOdenen.Properties.NullText = "₺0,00";
            calcOdenen.Properties.UseMaskAsDisplayFormat = true;
            calcOdenen.Size = new Size(150, 24);
            calcOdenen.TabIndex = 1;
            // 
            // labelControl6
            // 
            labelControl6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl6.Appearance.BorderColor = Color.Silver;
            labelControl6.Appearance.Font = new Font("Tahoma", 10F);
            labelControl6.Appearance.Options.UseBorderColor = true;
            labelControl6.Appearance.Options.UseFont = true;
            labelControl6.Appearance.Options.UseTextOptions = true;
            labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl6.Location = new Point(830, 26);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(111, 25);
            labelControl6.TabIndex = 0;
            labelControl6.Text = "Toplam : ";
            // 
            // labelControl4
            // 
            labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelControl4.Appearance.BorderColor = Color.Silver;
            labelControl4.Appearance.Font = new Font("Tahoma", 10F);
            labelControl4.Appearance.Options.UseBorderColor = true;
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl4.Location = new Point(419, 26);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(120, 25);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "İndirim Toplamı : ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BorderColor = Color.Silver;
            labelControl2.Appearance.Font = new Font("Tahoma", 10F);
            labelControl2.Appearance.Options.UseBorderColor = true;
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl2.Location = new Point(12, 26);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(111, 25);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Ödenen : ";
            // 
            // FrmMasaDurumları
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 844);
            Controls.Add(splitContainerControl1);
            Controls.Add(groupIslemler);
            Controls.Add(labelControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMasaDurumları";
            Text = "FrmMasaDurumları";
            ((System.ComponentModel.ISupportInitialize)groupIslemler).EndInit();
            groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupHesaplamalar).EndInit();
            groupHesaplamalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)calcIndirimliToplam.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcIndirimOrani.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcKalan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcToplam.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcIndirimToplami.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcOdenen.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupHesaplamalar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSiparisEkle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRezervMasa;
        private DevExpress.XtraEditors.SimpleButton btnBosMasa;
        private DevExpress.XtraEditors.SimpleButton btnDoluMasa;
        private DevExpress.XtraEditors.CalcEdit calcOdenen;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcIndirimliToplam;
        private DevExpress.XtraEditors.CalcEdit calcIndirimOrani;
        private DevExpress.XtraEditors.CalcEdit calcKalan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CalcEdit calcToplam;
        private DevExpress.XtraEditors.CalcEdit calcIndirimToplami;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
    }
}
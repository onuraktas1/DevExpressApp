namespace CafeOtomasyon.WinForms.Urunler
{
    partial class FrmUrunKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunKaydet));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            txtUrunKodu = new DevExpress.XtraEditors.TextEdit();
            txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            calcBirimFiyati1 = new DevExpress.XtraEditors.CalcEdit();
            calcBirimFiyati2 = new DevExpress.XtraEditors.CalcEdit();
            calcBirimFiyati3 = new DevExpress.XtraEditors.CalcEdit();
            memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            dateTarih = new DevExpress.XtraEditors.DateEdit();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            lookUpMenu = new DevExpress.XtraEditors.LookUpEdit();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtUrunKodu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpMenu.Properties).BeginInit();
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
            labelControl1.Size = new Size(704, 69);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "Ürün Kayıt";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnSil);
            groupControl1.Controls.Add(btnKapat);
            groupControl1.Controls.Add(btnKaydet);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 473);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(704, 100);
            groupControl1.TabIndex = 3;
            groupControl1.Text = "İşlemler";
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSil.ImageOptions.Image = (Image)resources.GetObject("btnSil.ImageOptions.Image");
            btnSil.Location = new Point(1182, 33);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 55);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            btnKaydet.ImageOptions.Image = (Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new Point(12, 33);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(113, 55);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl2.Appearance.Options.UseBorderColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl2.Location = new Point(12, 115);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(131, 29);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Menü : ";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl3.Appearance.Options.UseBorderColor = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Location = new Point(12, 150);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(131, 29);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Ürün Kodu : ";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl4.Appearance.Options.UseBorderColor = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl4.Location = new Point(12, 185);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(131, 29);
            labelControl4.TabIndex = 4;
            labelControl4.Text = "Ürün Adı : ";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl5.Appearance.Options.UseBorderColor = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(12, 220);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(131, 29);
            labelControl5.TabIndex = 4;
            labelControl5.Text = "Birim Fiyatı 1 : ";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl6.Appearance.Options.UseBorderColor = true;
            labelControl6.Appearance.Options.UseTextOptions = true;
            labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl6.Location = new Point(12, 255);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(131, 29);
            labelControl6.TabIndex = 4;
            labelControl6.Text = "Birim Fiyatı2 : ";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl7.Appearance.Options.UseBorderColor = true;
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl7.Location = new Point(12, 290);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(131, 29);
            labelControl7.TabIndex = 4;
            labelControl7.Text = "Birim Fiyatı3 : ";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl8.Appearance.Options.UseBorderColor = true;
            labelControl8.Appearance.Options.UseTextOptions = true;
            labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl8.Location = new Point(0, 325);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(131, 29);
            labelControl8.TabIndex = 4;
            labelControl8.Text = "Menü : ";
            // 
            // labelControl9
            // 
            labelControl9.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl9.Appearance.Options.UseBorderColor = true;
            labelControl9.Appearance.Options.UseTextOptions = true;
            labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl9.Location = new Point(12, 325);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(131, 78);
            labelControl9.TabIndex = 4;
            labelControl9.Text = "Açıklama : ";
            // 
            // labelControl10
            // 
            labelControl10.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl10.Appearance.Options.UseBorderColor = true;
            labelControl10.Appearance.Options.UseTextOptions = true;
            labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl10.Location = new Point(12, 409);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(131, 29);
            labelControl10.TabIndex = 4;
            labelControl10.Text = "Tarih : ";
            // 
            // txtUrunKodu
            // 
            txtUrunKodu.Location = new Point(158, 155);
            txtUrunKodu.Name = "txtUrunKodu";
            txtUrunKodu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUrunKodu.Properties.Appearance.Options.UseFont = true;
            txtUrunKodu.Size = new Size(246, 22);
            txtUrunKodu.TabIndex = 2;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(158, 190);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUrunAdi.Properties.Appearance.Options.UseFont = true;
            txtUrunAdi.Size = new Size(246, 22);
            txtUrunAdi.TabIndex = 3;
            // 
            // calcBirimFiyati1
            // 
            calcBirimFiyati1.Location = new Point(158, 223);
            calcBirimFiyati1.Name = "calcBirimFiyati1";
            calcBirimFiyati1.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            calcBirimFiyati1.Properties.Appearance.Options.UseFont = true;
            calcBirimFiyati1.Properties.Appearance.Options.UseTextOptions = true;
            calcBirimFiyati1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcBirimFiyati1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcBirimFiyati1.Properties.DisplayFormat.FormatString = "C2";
            calcBirimFiyati1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            calcBirimFiyati1.Properties.NullText = "0,00";
            calcBirimFiyati1.Size = new Size(246, 22);
            calcBirimFiyati1.TabIndex = 4;
            // 
            // calcBirimFiyati2
            // 
            calcBirimFiyati2.Location = new Point(158, 258);
            calcBirimFiyati2.Name = "calcBirimFiyati2";
            calcBirimFiyati2.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            calcBirimFiyati2.Properties.Appearance.Options.UseFont = true;
            calcBirimFiyati2.Properties.Appearance.Options.UseTextOptions = true;
            calcBirimFiyati2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcBirimFiyati2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcBirimFiyati2.Properties.DisplayFormat.FormatString = "C2";
            calcBirimFiyati2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            calcBirimFiyati2.Properties.NullText = "0,00";
            calcBirimFiyati2.Size = new Size(246, 22);
            calcBirimFiyati2.TabIndex = 5;
            // 
            // calcBirimFiyati3
            // 
            calcBirimFiyati3.Location = new Point(158, 293);
            calcBirimFiyati3.Name = "calcBirimFiyati3";
            calcBirimFiyati3.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            calcBirimFiyati3.Properties.Appearance.Options.UseFont = true;
            calcBirimFiyati3.Properties.Appearance.Options.UseTextOptions = true;
            calcBirimFiyati3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            calcBirimFiyati3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            calcBirimFiyati3.Properties.DisplayFormat.FormatString = "C2";
            calcBirimFiyati3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            calcBirimFiyati3.Properties.NullText = "0,00";
            calcBirimFiyati3.Size = new Size(246, 22);
            calcBirimFiyati3.TabIndex = 6;
            // 
            // memoAciklama
            // 
            memoAciklama.Location = new Point(158, 326);
            memoAciklama.Name = "memoAciklama";
            memoAciklama.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            memoAciklama.Properties.Appearance.Options.UseFont = true;
            memoAciklama.Size = new Size(452, 77);
            memoAciklama.TabIndex = 7;
            // 
            // dateTarih
            // 
            dateTarih.EditValue = null;
            dateTarih.Location = new Point(158, 418);
            dateTarih.Name = "dateTarih";
            dateTarih.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            dateTarih.Properties.Appearance.Options.UseFont = true;
            dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Size = new Size(248, 22);
            dateTarih.TabIndex = 8;
            // 
            // pictureEdit1
            // 
            pictureEdit1.Location = new Point(412, 115);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.NullText = "Resim Seçilmedi";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            pictureEdit1.Size = new Size(198, 200);
            pictureEdit1.TabIndex = 12;
            // 
            // lookUpMenu
            // 
            lookUpMenu.Location = new Point(158, 120);
            lookUpMenu.Name = "lookUpMenu";
            lookUpMenu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            lookUpMenu.Properties.Appearance.Options.UseFont = true;
            lookUpMenu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpMenu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MenuAdi", "Menu Adı") });
            lookUpMenu.Properties.DisplayMember = "MenuAdi";
            lookUpMenu.Properties.NullText = "Menü Seçiniz";
            lookUpMenu.Properties.NullValuePrompt = "Menü Seçiniz";
            lookUpMenu.Properties.ValueMember = "Id";
            lookUpMenu.Size = new Size(246, 22);
            lookUpMenu.TabIndex = 1;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnYenile.ImageOptions.Image");
            btnKapat.Location = new Point(579, 33);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(113, 55);
            btnKapat.TabIndex = 11;
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;
            // 
            // FrmUrunKaydet
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 573);
            Controls.Add(lookUpMenu);
            Controls.Add(pictureEdit1);
            Controls.Add(dateTarih);
            Controls.Add(memoAciklama);
            Controls.Add(calcBirimFiyati3);
            Controls.Add(calcBirimFiyati2);
            Controls.Add(calcBirimFiyati1);
            Controls.Add(txtUrunAdi);
            Controls.Add(txtUrunKodu);
            Controls.Add(labelControl10);
            Controls.Add(labelControl9);
            Controls.Add(labelControl8);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(groupControl1);
            Controls.Add(labelControl1);
            Margin = new Padding(4);
            Name = "FrmUrunKaydet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Kaydetme";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtUrunKodu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)calcBirimFiyati3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpMenu.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtUrunKodu;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati1;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati2;
        private DevExpress.XtraEditors.CalcEdit calcBirimFiyati3;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpMenu;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}
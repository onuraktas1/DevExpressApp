namespace CafeOtomasyon.WinForms.Kullanicilar
{
    partial class FrmKullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGirisi));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnSifremiUnuttum = new DevExpress.XtraEditors.SimpleButton();
            btnGirisYap = new DevExpress.XtraEditors.SimpleButton();
            txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            txtParola = new DevExpress.XtraEditors.TextEdit();
            hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            checkBeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkBeniHatirla.Properties).BeginInit();
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
            labelControl1.Size = new Size(781, 69);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Kullanıcı Girişi";
            // 
            // pictureEdit1
            // 
            pictureEdit1.Dock = DockStyle.Left;
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(0, 69);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.Size = new Size(294, 298);
            pictureEdit1.TabIndex = 4;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnKapat);
            groupControl1.Controls.Add(btnSifremiUnuttum);
            groupControl1.Controls.Add(btnGirisYap);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(294, 267);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(487, 100);
            groupControl1.TabIndex = 5;
            groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new Point(362, 33);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(113, 55);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("btnSifremiUnuttum.ImageOptions.SvgImage");
            btnSifremiUnuttum.Location = new Point(140, 33);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(134, 55);
            btnSifremiUnuttum.TabIndex = 0;
            btnSifremiUnuttum.Text = "Şifremi unuttum";
            // 
            // btnGirisYap
            // 
            btnGirisYap.ImageOptions.Image = (Image)resources.GetObject("btnGirisYap.ImageOptions.Image");
            btnGirisYap.Location = new Point(12, 33);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(122, 55);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(325, 114);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Properties.Appearance.Font = new Font("Tahoma", 10F);
            txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            txtKullaniciAdi.Properties.ContextImageOptions.Image = (Image)resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image");
            txtKullaniciAdi.Properties.NullText = "Kullanıcı Adınızı Giriniz";
            txtKullaniciAdi.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz";
            txtKullaniciAdi.Size = new Size(438, 22);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(325, 180);
            txtParola.Name = "txtParola";
            txtParola.Properties.Appearance.Font = new Font("Tahoma", 10F);
            txtParola.Properties.Appearance.Options.UseFont = true;
            txtParola.Properties.ContextImageOptions.Image = (Image)resources.GetObject("txtParola.Properties.ContextImageOptions.Image");
            txtParola.Properties.NullText = "Parolanızı Giriniz";
            txtParola.Properties.NullValuePrompt = "Parolanızı Giriniz";
            txtParola.Properties.UseSystemPasswordChar = true;
            txtParola.Size = new Size(438, 22);
            txtParola.TabIndex = 6;
            // 
            // hyperlinkLabelControl1
            // 
            hyperlinkLabelControl1.Appearance.Font = new Font("Tahoma", 10F);
            hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            hyperlinkLabelControl1.Location = new Point(720, 245);
            hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            hyperlinkLabelControl1.Size = new Size(43, 16);
            hyperlinkLabelControl1.TabIndex = 7;
            hyperlinkLabelControl1.Text = "Kayıt Ol";
            // 
            // checkBeniHatirla
            // 
            checkBeniHatirla.Location = new Point(325, 241);
            checkBeniHatirla.Name = "checkBeniHatirla";
            checkBeniHatirla.Properties.Appearance.Font = new Font("Tahoma", 10F);
            checkBeniHatirla.Properties.Appearance.Options.UseFont = true;
            checkBeniHatirla.Properties.Caption = "Beni Hatırla";
            checkBeniHatirla.Size = new Size(133, 20);
            checkBeniHatirla.TabIndex = 8;
            // 
            // FrmKullaniciGirisi
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 367);
            Controls.Add(checkBeniHatirla);
            Controls.Add(hyperlinkLabelControl1);
            Controls.Add(txtParola);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(groupControl1);
            Controls.Add(pictureEdit1);
            Controls.Add(labelControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKullaniciGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Girişi";
            FormClosing += FrmKullaniciGirisi_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkBeniHatirla.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSifremiUnuttum;
        private DevExpress.XtraEditors.SimpleButton btnGirisYap;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.CheckEdit checkBeniHatirla;
    }
}
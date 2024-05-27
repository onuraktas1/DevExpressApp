namespace CafeOtomasyon.WinForms.Kullanicilar
{
    partial class FrmKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKayitOl));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtTelefon = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            memoAdres = new DevExpress.XtraEditors.MemoEdit();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            txtGorevi = new DevExpress.XtraEditors.TextEdit();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            txtParola = new DevExpress.XtraEditors.TextEdit();
            labelControl10 = new DevExpress.XtraEditors.LabelControl();
            txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            labelControl11 = new DevExpress.XtraEditors.LabelControl();
            txtSoru = new DevExpress.XtraEditors.TextEdit();
            labelControl12 = new DevExpress.XtraEditors.LabelControl();
            txtCevap = new DevExpress.XtraEditors.TextEdit();
            labelControl13 = new DevExpress.XtraEditors.LabelControl();
            memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoAdres.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGorevi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParolaTekrar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCevap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).BeginInit();
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
            labelControl1.Size = new Size(434, 69);
            labelControl1.TabIndex = 4;
            labelControl1.Text = "Yeni Kullanıcı";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnKapat);
            groupControl1.Controls.Add(btnKaydet);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 636);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(434, 100);
            groupControl1.TabIndex = 5;
            groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new Point(309, 33);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(113, 55);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.ImageOptions.Image = (Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new Point(12, 33);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(113, 55);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.EditValue = "";
            txtAdSoyad.Location = new Point(148, 118);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtAdSoyad.Properties.Appearance.Options.UseFont = true;
            txtAdSoyad.Size = new Size(264, 22);
            txtAdSoyad.TabIndex = 11;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl3.Appearance.Options.UseBorderColor = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Location = new Point(11, 115);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(131, 29);
            labelControl3.TabIndex = 12;
            labelControl3.Text = "Ad Soyad : ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl2.Appearance.Options.UseBorderColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl2.Location = new Point(12, 80);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(131, 29);
            labelControl2.TabIndex = 12;
            labelControl2.Text = "Durumu : ";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl4.Appearance.Options.UseBorderColor = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl4.Location = new Point(11, 143);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(131, 29);
            labelControl4.TabIndex = 12;
            labelControl4.Text = "Telefon : ";
            // 
            // txtTelefon
            // 
            txtTelefon.EditValue = "";
            txtTelefon.Location = new Point(148, 146);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtTelefon.Properties.Appearance.Options.UseFont = true;
            txtTelefon.Size = new Size(264, 22);
            txtTelefon.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl5.Appearance.Options.UseBorderColor = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(11, 171);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(131, 29);
            labelControl5.TabIndex = 12;
            labelControl5.Text = "Adres : ";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl6.Appearance.Options.UseBorderColor = true;
            labelControl6.Appearance.Options.UseTextOptions = true;
            labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl6.Location = new Point(11, 270);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(131, 29);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "Email : ";
            // 
            // txtEmail
            // 
            txtEmail.EditValue = "";
            txtEmail.Location = new Point(148, 273);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new Size(264, 22);
            txtEmail.TabIndex = 11;
            // 
            // memoAdres
            // 
            memoAdres.Location = new Point(149, 178);
            memoAdres.Name = "memoAdres";
            memoAdres.Size = new Size(263, 83);
            memoAdres.TabIndex = 13;
            // 
            // labelControl7
            // 
            labelControl7.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl7.Appearance.Options.UseBorderColor = true;
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl7.Location = new Point(11, 305);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(131, 29);
            labelControl7.TabIndex = 12;
            labelControl7.Text = "Görevi : ";
            // 
            // txtGorevi
            // 
            txtGorevi.EditValue = "";
            txtGorevi.Location = new Point(148, 308);
            txtGorevi.Name = "txtGorevi";
            txtGorevi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtGorevi.Properties.Appearance.Options.UseFont = true;
            txtGorevi.Size = new Size(264, 22);
            txtGorevi.TabIndex = 11;
            // 
            // labelControl8
            // 
            labelControl8.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl8.Appearance.Options.UseBorderColor = true;
            labelControl8.Appearance.Options.UseTextOptions = true;
            labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl8.Location = new Point(13, 340);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(131, 29);
            labelControl8.TabIndex = 12;
            labelControl8.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.EditValue = "";
            txtKullaniciAdi.Location = new Point(148, 343);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            txtKullaniciAdi.Size = new Size(264, 22);
            txtKullaniciAdi.TabIndex = 11;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl9.Appearance.Options.UseBorderColor = true;
            labelControl9.Appearance.Options.UseTextOptions = true;
            labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl9.Location = new Point(11, 375);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(131, 29);
            labelControl9.TabIndex = 12;
            labelControl9.Text = "Parola : ";
            // 
            // txtParola
            // 
            txtParola.EditValue = "";
            txtParola.Location = new Point(148, 378);
            txtParola.Name = "txtParola";
            txtParola.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtParola.Properties.Appearance.Options.UseFont = true;
            txtParola.Size = new Size(264, 22);
            txtParola.TabIndex = 11;
            // 
            // labelControl10
            // 
            labelControl10.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl10.Appearance.Options.UseBorderColor = true;
            labelControl10.Appearance.Options.UseTextOptions = true;
            labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl10.Location = new Point(12, 413);
            labelControl10.Name = "labelControl10";
            labelControl10.Size = new Size(131, 29);
            labelControl10.TabIndex = 12;
            labelControl10.Text = "Parola Tekrar : ";
            // 
            // txtParolaTekrar
            // 
            txtParolaTekrar.EditValue = "";
            txtParolaTekrar.Location = new Point(148, 416);
            txtParolaTekrar.Name = "txtParolaTekrar";
            txtParolaTekrar.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtParolaTekrar.Properties.Appearance.Options.UseFont = true;
            txtParolaTekrar.Size = new Size(264, 22);
            txtParolaTekrar.TabIndex = 11;
            // 
            // labelControl11
            // 
            labelControl11.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl11.Appearance.Options.UseBorderColor = true;
            labelControl11.Appearance.Options.UseTextOptions = true;
            labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl11.Location = new Point(13, 450);
            labelControl11.Name = "labelControl11";
            labelControl11.Size = new Size(131, 29);
            labelControl11.TabIndex = 12;
            labelControl11.Text = "Soru : ";
            // 
            // txtSoru
            // 
            txtSoru.EditValue = "";
            txtSoru.Location = new Point(149, 453);
            txtSoru.Name = "txtSoru";
            txtSoru.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtSoru.Properties.Appearance.Options.UseFont = true;
            txtSoru.Size = new Size(264, 22);
            txtSoru.TabIndex = 11;
            // 
            // labelControl12
            // 
            labelControl12.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl12.Appearance.Options.UseBorderColor = true;
            labelControl12.Appearance.Options.UseTextOptions = true;
            labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl12.Location = new Point(13, 478);
            labelControl12.Name = "labelControl12";
            labelControl12.Size = new Size(131, 29);
            labelControl12.TabIndex = 12;
            labelControl12.Text = "Cevap : ";
            // 
            // txtCevap
            // 
            txtCevap.EditValue = "";
            txtCevap.Location = new Point(149, 481);
            txtCevap.Name = "txtCevap";
            txtCevap.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCevap.Properties.Appearance.Options.UseFont = true;
            txtCevap.Size = new Size(264, 22);
            txtCevap.TabIndex = 11;
            // 
            // labelControl13
            // 
            labelControl13.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl13.Appearance.Options.UseBorderColor = true;
            labelControl13.Appearance.Options.UseTextOptions = true;
            labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl13.Location = new Point(13, 513);
            labelControl13.Name = "labelControl13";
            labelControl13.Size = new Size(131, 29);
            labelControl13.TabIndex = 12;
            labelControl13.Text = "Açıklama : ";
            // 
            // memoAciklama
            // 
            memoAciklama.Location = new Point(150, 512);
            memoAciklama.Name = "memoAciklama";
            memoAciklama.Size = new Size(263, 83);
            memoAciklama.TabIndex = 13;
            // 
            // toggleSwitch1
            // 
            toggleSwitch1.Location = new Point(150, 86);
            toggleSwitch1.Name = "toggleSwitch1";
            toggleSwitch1.Properties.OffText = "Pasif";
            toggleSwitch1.Properties.OnText = "Aktif";
            toggleSwitch1.Size = new Size(95, 18);
            toggleSwitch1.TabIndex = 14;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 736);
            Controls.Add(toggleSwitch1);
            Controls.Add(memoAciklama);
            Controls.Add(memoAdres);
            Controls.Add(txtCevap);
            Controls.Add(txtSoru);
            Controls.Add(txtParolaTekrar);
            Controls.Add(labelControl13);
            Controls.Add(labelControl12);
            Controls.Add(txtParola);
            Controls.Add(labelControl11);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(labelControl10);
            Controls.Add(txtGorevi);
            Controls.Add(labelControl9);
            Controls.Add(txtEmail);
            Controls.Add(labelControl8);
            Controls.Add(labelControl7);
            Controls.Add(labelControl6);
            Controls.Add(txtTelefon);
            Controls.Add(labelControl5);
            Controls.Add(txtAdSoyad);
            Controls.Add(labelControl4);
            Controls.Add(labelControl2);
            Controls.Add(labelControl3);
            Controls.Add(groupControl1);
            Controls.Add(labelControl1);
            Name = "FrmKayitOl";
            Text = "FrmKayitOl";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtAdSoyad.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTelefon.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoAdres.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGorevi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKullaniciAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParola.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParolaTekrar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCevap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)toggleSwitch1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.MemoEdit memoAdres;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtGorevi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtSoru;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}
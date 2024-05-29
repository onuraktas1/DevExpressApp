namespace CafeOtomasyon.WinForms.Kullanicilar
{
    partial class FrmParolamiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParolamiUnuttum));
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtKAdiEmail = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtSoru = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtCevap = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            txtYeniParola = new DevExpress.XtraEditors.TextEdit();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtKAdiEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSoru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCevap.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYeniParola.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtParolaTekrar.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnKapat);
            groupControl1.Controls.Add(btnKaydet);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 260);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(446, 100);
            groupControl1.TabIndex = 5;
            groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new Point(321, 33);
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
            labelControl1.Size = new Size(446, 69);
            labelControl1.TabIndex = 6;
            labelControl1.Text = "Parolamı Unuttum";
            // 
            // txtKAdiEmail
            // 
            txtKAdiEmail.EditValue = "";
            txtKAdiEmail.Location = new Point(159, 87);
            txtKAdiEmail.Name = "txtKAdiEmail";
            txtKAdiEmail.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtKAdiEmail.Properties.Appearance.Options.UseFont = true;
            txtKAdiEmail.Size = new Size(264, 22);
            txtKAdiEmail.TabIndex = 11;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl3.Appearance.Options.UseBorderColor = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Location = new Point(12, 84);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(131, 29);
            labelControl3.TabIndex = 12;
            labelControl3.Text = "Kullanıcı adı veya E-Mail : ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl2.Appearance.Options.UseBorderColor = true;
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl2.Location = new Point(12, 112);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(131, 29);
            labelControl2.TabIndex = 12;
            labelControl2.Text = "Soru : ";
            // 
            // txtSoru
            // 
            txtSoru.EditValue = "";
            txtSoru.Location = new Point(159, 115);
            txtSoru.Name = "txtSoru";
            txtSoru.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtSoru.Properties.Appearance.Options.UseFont = true;
            txtSoru.Size = new Size(264, 22);
            txtSoru.TabIndex = 11;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl4.Appearance.Options.UseBorderColor = true;
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl4.Location = new Point(12, 140);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(131, 29);
            labelControl4.TabIndex = 12;
            labelControl4.Text = "Cevap : ";
            // 
            // txtCevap
            // 
            txtCevap.EditValue = "";
            txtCevap.Location = new Point(159, 143);
            txtCevap.Name = "txtCevap";
            txtCevap.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtCevap.Properties.Appearance.Options.UseFont = true;
            txtCevap.Size = new Size(264, 22);
            txtCevap.TabIndex = 11;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl5.Appearance.Options.UseBorderColor = true;
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl5.Location = new Point(12, 168);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(131, 29);
            labelControl5.TabIndex = 12;
            labelControl5.Text = "Yeni Parola : ";
            // 
            // txtYeniParola
            // 
            txtYeniParola.EditValue = "";
            txtYeniParola.Location = new Point(159, 171);
            txtYeniParola.Name = "txtYeniParola";
            txtYeniParola.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtYeniParola.Properties.Appearance.Options.UseFont = true;
            txtYeniParola.Properties.UseSystemPasswordChar = true;
            txtYeniParola.Size = new Size(264, 22);
            txtYeniParola.TabIndex = 11;
            // 
            // labelControl6
            // 
            labelControl6.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl6.Appearance.Options.UseBorderColor = true;
            labelControl6.Appearance.Options.UseTextOptions = true;
            labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl6.Location = new Point(12, 196);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(131, 29);
            labelControl6.TabIndex = 12;
            labelControl6.Text = "Yeni parola tekrar : ";
            // 
            // txtParolaTekrar
            // 
            txtParolaTekrar.EditValue = "";
            txtParolaTekrar.Location = new Point(159, 199);
            txtParolaTekrar.Name = "txtParolaTekrar";
            txtParolaTekrar.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtParolaTekrar.Properties.Appearance.Options.UseFont = true;
            txtParolaTekrar.Properties.UseSystemPasswordChar = true;
            txtParolaTekrar.Size = new Size(264, 22);
            txtParolaTekrar.TabIndex = 11;
            // 
            // FrmParolamiUnuttum
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 360);
            Controls.Add(txtParolaTekrar);
            Controls.Add(labelControl6);
            Controls.Add(txtYeniParola);
            Controls.Add(labelControl5);
            Controls.Add(txtCevap);
            Controls.Add(labelControl4);
            Controls.Add(txtSoru);
            Controls.Add(labelControl2);
            Controls.Add(txtKAdiEmail);
            Controls.Add(labelControl3);
            Controls.Add(labelControl1);
            Controls.Add(groupControl1);
            Name = "FrmParolamiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parolamı Unuttum";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtKAdiEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSoru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCevap.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYeniParola.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtParolaTekrar.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKAdiEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSoru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCevap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtYeniParola;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
    }
}
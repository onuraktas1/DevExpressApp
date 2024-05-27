namespace CafeOtomasyon.WinForms.Masalar
{
    partial class FrmMasaKaydet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaKaydet));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnCikis = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            memoAciklama = new DevExpress.XtraEditors.MemoEdit();
            txtMasaAdi = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMasaAdi.Properties).BeginInit();
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
            labelControl1.Size = new Size(430, 69);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Masa Kayıt";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnCikis);
            groupControl1.Controls.Add(btnKaydet);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 270);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(430, 100);
            groupControl1.TabIndex = 4;
            groupControl1.Text = "İşlemler";
            // 
            // btnCikis
            // 
            btnCikis.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCikis.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnCikis.Location = new Point(305, 33);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(113, 55);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Kapat";
            btnCikis.Click += btnCikis_Click;
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
            // memoAciklama
            // 
            memoAciklama.Location = new Point(139, 114);
            memoAciklama.Name = "memoAciklama";
            memoAciklama.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            memoAciklama.Properties.Appearance.Options.UseFont = true;
            memoAciklama.Size = new Size(264, 114);
            memoAciklama.TabIndex = 11;
            // 
            // txtMasaAdi
            // 
            txtMasaAdi.EditValue = "";
            txtMasaAdi.Location = new Point(139, 81);
            txtMasaAdi.Name = "txtMasaAdi";
            txtMasaAdi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtMasaAdi.Properties.Appearance.Options.UseFont = true;
            txtMasaAdi.Size = new Size(264, 22);
            txtMasaAdi.TabIndex = 8;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl9.Appearance.Options.UseBorderColor = true;
            labelControl9.Appearance.Options.UseTextOptions = true;
            labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl9.Location = new Point(2, 113);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(131, 115);
            labelControl9.TabIndex = 9;
            labelControl9.Text = "Açıklama : ";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.BorderColor = Color.FromArgb(192, 192, 255);
            labelControl3.Appearance.Options.UseBorderColor = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            labelControl3.Location = new Point(2, 78);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(131, 29);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "Masa : ";
            // 
            // FrmMasaKaydet
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 370);
            Controls.Add(memoAciklama);
            Controls.Add(txtMasaAdi);
            Controls.Add(labelControl9);
            Controls.Add(labelControl3);
            Controls.Add(groupControl1);
            Controls.Add(labelControl1);
            Name = "FrmMasaKaydet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Masa Kayıt";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memoAciklama.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMasaAdi.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.MemoEdit memoAciklama;
        private DevExpress.XtraEditors.TextEdit txtMasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
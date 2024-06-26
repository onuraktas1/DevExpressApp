﻿namespace CafeOtomasyon.WinForms.Urunler
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnYenile = new DevExpress.XtraEditors.SimpleButton();
            btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            btnEkle = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Id = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            labelControl1.Size = new Size(916, 69);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnKapat);
            groupControl1.Controls.Add(btnSil);
            groupControl1.Controls.Add(btnYenile);
            groupControl1.Controls.Add(btnDuzenle);
            groupControl1.Controls.Add(btnEkle);
            groupControl1.Dock = DockStyle.Bottom;
            groupControl1.Location = new Point(0, 413);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(916, 100);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.ImageOptions.Image = (Image)resources.GetObject("btnKapat.ImageOptions.Image");
            btnKapat.Location = new Point(794, 33);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(113, 55);
            btnKapat.TabIndex = 0;
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSil.ImageOptions.Image = (Image)resources.GetObject("btnSil.ImageOptions.Image");
            btnSil.Location = new Point(672, 33);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 55);
            btnSil.TabIndex = 0;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
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
            gridControl1.Size = new Size(916, 344);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Id, gridColumn2, gridColumn8, colMenuAdi, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7 });
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
            Id.Width = 40;
            // 
            // gridColumn2
            // 
            gridColumn2.FieldName = "UrunKodu";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 45;
            // 
            // gridColumn8
            // 
            gridColumn8.FieldName = "UrunAdi";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 2;
            gridColumn8.Width = 86;
            // 
            // colMenuAdi
            // 
            colMenuAdi.Caption = "Menü";
            colMenuAdi.FieldName = "Menu.MenuAdi";
            colMenuAdi.Name = "colMenuAdi";
            colMenuAdi.Visible = true;
            colMenuAdi.VisibleIndex = 3;
            colMenuAdi.Width = 77;
            // 
            // gridColumn3
            // 
            gridColumn3.FieldName = "BirimFiyati1";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 4;
            gridColumn3.Width = 62;
            // 
            // gridColumn4
            // 
            gridColumn4.FieldName = "BirimFiyati2";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 5;
            gridColumn4.Width = 60;
            // 
            // gridColumn5
            // 
            gridColumn5.FieldName = "BirimFiyati3";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 6;
            gridColumn5.Width = 62;
            // 
            // gridColumn6
            // 
            gridColumn6.FieldName = "Aciklama";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 7;
            gridColumn6.Width = 157;
            // 
            // gridColumn7
            // 
            gridColumn7.FieldName = "Tarih";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 8;
            gridColumn7.Width = 96;
            // 
            // FrmUrunler
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 513);
            Controls.Add(gridControl1);
            Controls.Add(groupControl1);
            Controls.Add(labelControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmUrunler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
    }
}
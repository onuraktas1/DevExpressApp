﻿namespace CafeOtomasyon.WinForms.AnaMenu
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
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            Aya = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem });
            ribbon.Location = new Point(0, 0);
            ribbon.MaxItemId = 1;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1, Aya });
            ribbon.Size = new Size(1147, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Kafe İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new Point(0, 946);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new Size(1147, 24);
            // 
            // Aya
            // 
            Aya.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup2 });
            Aya.Name = "Aya";
            Aya.Text = "Ayarlar";
            // 
            // ribbonPageGroup2
            // 
            ribbonPageGroup2.Name = "ribbonPageGroup2";
            ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // FrmAnaMenu
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 970);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "FrmAnaMenu";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "FrmAnaMenu";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage Aya;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}
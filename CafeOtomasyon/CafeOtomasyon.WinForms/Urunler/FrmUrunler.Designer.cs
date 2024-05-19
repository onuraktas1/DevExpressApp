namespace CafeOtomasyon.WinForms.Urunler
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
            checkButton1 = new DevExpress.XtraEditors.CheckButton();
            SuspendLayout();
            // 
            // checkButton1
            // 
            checkButton1.Location = new Point(321, 134);
            checkButton1.Name = "checkButton1";
            checkButton1.Size = new Size(118, 36);
            checkButton1.TabIndex = 0;
            checkButton1.Text = "checkButton1";
            // 
            // FrmUrunler
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 465);
            Controls.Add(checkButton1);
            Name = "FrmUrunler";
            Text = "FrmUrunler";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}
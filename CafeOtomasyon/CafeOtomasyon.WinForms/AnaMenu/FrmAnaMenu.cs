using CafeOtomasyon.WinForms.Menuler;
using CafeOtomasyon.WinForms.Urunler;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.WinForms.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        void FormGetir(XtraForm form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmUrunler frmUrunler = new();
            FormGetir(frmUrunler);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmMenuler frmMenuler = new();
            frmMenuler.ShowDialog();
        }
    }
}
using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.WinForms.Menuler
{
    public partial class FrmMenuler : DevExpress.XtraEditors.XtraForm
    {
        MenuManager _menuManager = new(new EfMenuRepository());
        public FrmMenuler()
        {
            InitializeComponent();
            gridControl1.DataSource = _menuManager.GetAll();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _menuManager.Save();
            gridView1.RefreshData();
        }
    }
}
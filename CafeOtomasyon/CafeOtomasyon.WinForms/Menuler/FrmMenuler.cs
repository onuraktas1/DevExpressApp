using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using CafeOtomasyon.Entity.Concrete;
using DevExpress.XtraGrid.Columns;
using Microsoft.EntityFrameworkCore;
using System.Windows.Controls;
namespace CafeOtomasyon.WinForms.Menuler
{
    public partial class FrmMenuler : DevExpress.XtraEditors.XtraForm
    {
        private readonly Context _context = new Context();

        public FrmMenuler()
        {
            InitializeComponent();
            _context.Menuler.Load();
            gridControl1.DataSource = _context.Menuler.Local.ToBindingList();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            gridView1.RefreshData();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bool silinsinMi = MessageBox.Show(
                text: "Seçili olan menü silinsin mi ?",
                caption: "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;

            if (silinsinMi)
            {
                gridView1.DeleteSelectedRows();
                _context.SaveChanges();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
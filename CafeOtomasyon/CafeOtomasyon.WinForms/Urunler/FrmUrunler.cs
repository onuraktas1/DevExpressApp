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
using CafeOtomasyon.Entity.Concrete;

namespace CafeOtomasyon.WinForms.Urunler
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        //private readonly Context _context = new();
        private readonly UrunManager _urunManager = new(new EfUrunRepository());
        public FrmUrunler()
        {
            InitializeComponent();
            //_context.Urunler.Load();
            //gridControl1.DataSource = _context.Urunler.Local.ToBindingList();

            gridControl1.DataSource = _urunManager.GetAllUrunWithMenu();
            //Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUrunKaydet frm = new(new Urun());
            frm.ShowDialog();
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            Urun duzenleUrun = _urunManager.GetByFilter(x => x.Id == secilenId);
            FrmUrunKaydet frm = new(duzenleUrun);
            frm.ShowDialog();
            Listele();

        }

        public void Listele()
        {
            gridControl1.RefreshDataSource();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));

            bool silinsinMi = MessageBox.Show(
                text: "Seçili olan menü silinsin mi ?",
                caption: "Uyarı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;

            if (silinsinMi)
            {
                _urunManager.Delete(x => x.Id == id);
                Listele();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
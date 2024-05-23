using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using CafeOtomasyon.Entity.Concrete;
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

namespace CafeOtomasyon.WinForms.Masalar
{
    public partial class FrmMasalar : DevExpress.XtraEditors.XtraForm
    {
        private readonly MasaManager _masaManager = new(new EfMasaRepository());
        public FrmMasalar()
        {
            InitializeComponent();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmMasaKaydet frm = new(new Masa());
            frm.ShowDialog();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = _masaManager.GetAllMasaWithKullanici();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue(Id));
            Masa masa = _masaManager.GetByFilter(m => m.Id == id);
            FrmMasaKaydet frm = new(masa);
            frm.ShowDialog();
            Listele();
        }
    }
}
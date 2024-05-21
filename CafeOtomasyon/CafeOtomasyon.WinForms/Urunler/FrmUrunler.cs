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

namespace CafeOtomasyon.WinForms.Urunler
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        private readonly Context _context = new();
        private readonly UrunManager _urunManager = new(new EfUrunRepository());
        public FrmUrunler()
        {
            InitializeComponent();
            //_context.Urunler.Load();
            //gridControl1.DataSource = _context.Urunler.Local.ToBindingList();
            gridControl1.DataSource = _urunManager.GetAllUrunWithMenu();
        }
    }
}
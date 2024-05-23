using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
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
            gridControl1.DataSource = _masaManager.GetAllMasaWithKullanici();
        }
    }
}
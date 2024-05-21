using CafeOtomasyon.DAL.Concrete;
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

namespace CafeOtomasyon.WinForms.Urunler
{
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        private readonly Context _context = new();
        public FrmUrunler()
        {
            InitializeComponent();
        }
    }
}
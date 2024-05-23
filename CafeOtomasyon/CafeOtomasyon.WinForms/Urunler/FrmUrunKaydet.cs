using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using CafeOtomasyon.Entity.Concrete;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.WinForms.Urunler
{
    public partial class FrmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private readonly UrunManager _urunManager = new(new EfUrunRepository());
        private readonly MenuManager _MenuManager = new(new EfMenuRepository());
        private readonly Urun _urun;
        public FrmUrunKaydet(Urun urun)
        {
            InitializeComponent();
            _urun = urun;

            lookUpMenu.Properties.DataSource = _MenuManager.GetAll();
            lookUpMenu.DataBindings.Add("EditValue", _urun, "MenuId");
            txtUrunKodu.DataBindings.Add("Text", _urun, "UrunKodu");
            txtUrunAdi.DataBindings.Add("Text", _urun, "UrunAdi");
            calcBirimFiyati1.DataBindings.Add("Text", _urun, "BirimFiyati1", true);
            calcBirimFiyati2.DataBindings.Add("Text", _urun, "BirimFiyati2", true);
            calcBirimFiyati3.DataBindings.Add("Text", _urun, "BirimFiyati3", true);
            memoAciklama.DataBindings.Add("Text", _urun, "Aciklama");
            dateTarih.DataBindings.Add("Text", _urun, "Tarih", true);
            if (_urun.Id != 0)
            {
                if (!string.IsNullOrWhiteSpace(_urun.Resim))
                {
                    pictureEdit1.Image = Image.FromFile(_urun.Resim);
                }

            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UrunValidator urunValidate = new();
            bool basariliMi = ValidatorTools.Validates(urunValidate, _urun, out string errorMessage);

            if (basariliMi)
            {
                if (!string.IsNullOrEmpty(pictureEdit1.GetLoadedImageLocation()))
                {
                    string imagePath = $"{Application.StartupPath}\\Images\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                    File.Copy(pictureEdit1.GetLoadedImageLocation(), imagePath);
                    _urun.Resim = $"Images\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                }

                if (_urun.Id != 0)
                    _urunManager.Update(_urun);
                else
                    _urunManager.Add(_urun);

                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
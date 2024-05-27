using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using CafeOtomasyon.Entity.Concrete;
using DevExpress.XtraEditors;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CafeOtomasyon.WinForms.Masalar
{
    public partial class FrmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private readonly MasaManager _masaManager = new(new EfMasaRepository());
        private readonly Masa _masa;
        public FrmMasaKaydet(Masa masa)
        {
            InitializeComponent();
            _masa = masa;

            txtMasaAdi.DataBindings.Add("Text", _masa, "MasaAdi");
            memoAciklama.DataBindings.Add("Text", _masa, "Aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MasaValidator masaValidate = new();
            bool basariliMi = ValidatorTools.Validates(masaValidate, _masa, out string errorMessage);

            if (basariliMi)
            {

                if (_masa.Id != 0)
                {
                    _masa.SonIslemTarihi = DateTime.Now;
                    _masaManager.Update(_masa);
                }
                else
                {
                    _masa.EklenmeTarihi = DateTime.Now;
                    _masa.SonIslemTarihi = DateTime.Now;
                    _masa.Durum = false;
                    _masa.RezerveMi = false;
                    _masaManager.Add(_masa);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
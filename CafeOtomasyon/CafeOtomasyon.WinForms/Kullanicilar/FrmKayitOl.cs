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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyon.WinForms.Kullanicilar
{
    public partial class FrmKayitOl : DevExpress.XtraEditors.XtraForm
    {
        private readonly KullaniciManager _kullaniciManager = new(new EfKullaniciRepository());
        private Kullanici _kullanici = new();
        public FrmKayitOl()
        {
            InitializeComponent();
            toggleDurumu.DataBindings.Add("EditValue", _kullanici, "AktifMi");
            txtAdSoyad.DataBindings.Add("Text", _kullanici, "AdSoyad");
            txtTelefon.DataBindings.Add("Text", _kullanici, "Telefon");
            memoAdres.DataBindings.Add("Text", _kullanici, "Adres");
            txtEmail.DataBindings.Add("Text", _kullanici, "Email");
            txtGorevi.DataBindings.Add("Text", _kullanici, "Gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _kullanici, "KullaniciAdi");
            txtParola.DataBindings.Add("Text", _kullanici, "Parola");
            txtSoru.DataBindings.Add("Text", _kullanici, "HatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _kullanici, "Cevap");
            memoAciklama.DataBindings.Add("Text", _kullanici, "Aciklama");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _kullanici.KayitTarihi = DateTime.Now;

            bool dogrulandiMi = ValidatorTools.Validates(new KullaniciValidator(), _kullanici, out string errorMessage);

            if (dogrulandiMi)
            {
                _kullaniciManager.Add(_kullanici);
                MessageBox.Show("Yeni kullanıcı başarıyla eklendi");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

        }
    }
}
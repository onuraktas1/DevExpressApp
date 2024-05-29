using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.DAL.Concrete;
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
    public partial class FrmParolamiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        //private readonly Context _context = new();
        private readonly KullaniciManager _kullaniciManager = new(new EfKullaniciRepository());
        public FrmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanici? kullanici = _kullaniciManager.GetByFilter(x =>
            x.KullaniciAdi == txtKAdiEmail.Text ||
            x.Email == txtKAdiEmail.Text);

            if (kullanici != null)
            {
                if (kullanici.HatirlatmaSorusu.ToLower() == txtSoru.Text.ToLower() && kullanici.Cevap.ToLower() == txtCevap.Text.ToLower())
                {
                    if (txtYeniParola.Text == txtParolaTekrar.Text)
                    {
                        kullanici.Parola = txtYeniParola.Text;
                        bool dogrulandiMi = ValidatorTools.Validates(new KullaniciValidator(), kullanici, out string errorMessage);

                        if (dogrulandiMi)
                        {
                            _kullaniciManager.Update(kullanici);
                            MessageBox.Show("Şifre başarıyla değiştirildi");
                        }
                        else
                        {
                            MessageBox.Show(errorMessage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parolalar uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen soru veya cevap yanlış");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
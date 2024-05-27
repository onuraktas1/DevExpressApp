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

namespace CafeOtomasyon.WinForms.Kullanicilar
{
    public partial class FrmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private readonly KullaniciManager _kullaniciManager = new(new EfKullaniciRepository());

        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatirla.Checked = Properties.Settings.Default.BeniHatirla;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                Properties.Settings.Default.BeniHatirla = false;
            }
        }

        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.BeniHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            //if (!_giris)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            this.Close();
            //}
        }

        private void FrmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici? kullanici = _kullaniciManager.GetByFilter(x => x.KullaniciAdi == txtKullaniciAdi.Text);

            if (kullanici != null)
            {
                if (kullanici.Parola == txtParola.Text)
                {
                    BilgileriKaydet();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Şifre Hatalı");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı hatalı");
            }

        }

        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl frm = new();
            frm.ShowDialog();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmParolamiUnuttum frm = new();
            frm.ShowDialog();
        }
    }
}
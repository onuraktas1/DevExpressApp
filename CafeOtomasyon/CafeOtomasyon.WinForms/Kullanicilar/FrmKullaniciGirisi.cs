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
        private bool _giris;
        private readonly KullaniciManager _kullaniciManager = new(new EfKullaniciRepository());
        public FrmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!_giris)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void FrmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            Kullanici? kullanici = _kullaniciManager.GetByFilter(x => x.KullaniciAdi == txtKullaniciAdi.Text);

            if (kullanici != null)
            {
                if (kullanici.Parola == txtParola.Text)
                {
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
    }
}
using CafeOtomasyon.Business.Concrete;
using CafeOtomasyon.DAL.Concrete.EntityFramework;
using CafeOtomasyon.Entity.Concrete;
using DevExpress.XtraBars.Customization.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.WinForms.WinTools
{
    public class DinamikMasalar
    {
        public static void MasalariGetir(FlowLayoutPanel pnl)
        {
            MasaManager masaManager = new(new EfMasaRepository());
            List<Masa> masalar = masaManager.GetAll();

            for (int i = 0; i < masalar.Count; i++)
            {
                CheckButton btn = new();
                btn.Text = masalar[i].MasaAdi;
                btn.Name = masalar[i].Id.ToString();
                btn.Height = 100;
                btn.Width = 80;
                pnl.Controls.Add(btn);
                if (masalar[i].RezerveMi && !masalar[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Tan;
                }
                else if (masalar[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Red;
                }
                else if (!masalar[i].Durum)
                {
                    btn.Appearance.BackColor = Color.Green;
                }

                btn.Click += Btn_Click;

            }
        }

        private static void Btn_Click(object? sender, EventArgs e)
        {
            CheckButton btn = sender as CheckButton;
            MessageBox.Show("Masa Adı: " + btn.Text + "Masa Id: " + btn.Name);
        }
    }
}

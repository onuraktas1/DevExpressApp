using CafeOtomasyon.Business.Tools;
using CafeOtomasyon.Business.Validators;
using CafeOtomasyon.Entity.Abstract;
using CafeOtomasyon.Entity.Concrete;
using FluentValidation.Results;

namespace CafeOtomasyon.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new();
            m.MenuAdi = textBox1.Text;

            bool ValidationResult = ValidatorTools.Validates(new MenuValidator(), m, out string erorMessage);
            if (!ValidationResult)
            {
                MessageBox.Show(erorMessage);
            }
            else
            {

            }
        }
    }
}
